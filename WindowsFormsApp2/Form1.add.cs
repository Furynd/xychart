using System;
using System.IO;
using GenericHid;
using System.Timers;
using System.Management;
using System.Diagnostics;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Threading;

namespace WindowsFormsApp2
{
    partial class printdata
    {
        #region "declarations"
        private Boolean _deviceDetected;
        private IntPtr _deviceNotificationHandle;
        private FileStream _deviceData;
        private FormActions _formActions;
        private SafeFileHandle _hidHandle;
        private String _hidUsage;
        private ManagementEventWatcher _deviceArrivedWatcher;
        private Boolean _deviceHandleObtained;
        private ManagementEventWatcher _deviceRemovedWatcher;
        private Int32 _myProductId = 0079;
        private Int32 _myVendorId = 0006;
        private Boolean _periodicTransfersRequested;
        private ReportReadOrWritten _readOrWritten;
        private ReportTypes _reportType;
        private SendOrGet _sendOrGet;
        private Boolean _transferInProgress;
        private TransferTypes _transferType;

        private static System.Timers.Timer _periodicTransfers;

        private readonly Debugging _myDebugging = new Debugging(); //  For viewing results of API calls via Debug.Write.
        private readonly DeviceManagement _myDeviceManagement = new DeviceManagement();
        private Hid _myHid = new Hid();

        internal static printdata FrmMy;

        private enum FormActions
        {
            AddItemToListBox,
            DisableInputReportBufferSize,
            EnableGetInputReportInterruptTransfer,
            EnableInputReportBufferSize,
            EnableSendOutputReportInterrupt,
            ScrollToBottomOfListBox,
            SetInputReportBufferSize
        }

        private enum ReportReadOrWritten
        {
            Read,
            Written
        }

        private enum ReportTypes
        {
            Input,
            Output,
            Feature
        }

        private enum SendOrGet
        {
            Send,
            Get
        }

        private enum TransferTypes
        {
            Control,
            Interrupt
        }

        private enum WmiDeviceProperties
        {
            Name,
            Caption,
            Description,
            Manufacturer,
            PNPDeviceID,
            DeviceID,
            ClassGUID
        }

        #endregion

        private delegate void MarshalDataToForm(FormActions action, String textToAdd);

        private void AddDeviceArrivedHandler()
        {
            const Int32 pollingIntervalSeconds = 3;
            var scope = new ManagementScope("root\\CIMV2");
            scope.Options.EnablePrivileges = true;

            try
            {
                var q = new WqlEventQuery();
                q.EventClassName = "__InstanceCreationEvent";
                q.WithinInterval = new TimeSpan(0, 0, pollingIntervalSeconds);
                q.Condition = @"TargetInstance ISA 'Win32_USBControllerdevice'";
                _deviceArrivedWatcher = new ManagementEventWatcher(scope, q);
                _deviceArrivedWatcher.EventArrived += DeviceAdded;

                _deviceArrivedWatcher.Start();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                if (_deviceArrivedWatcher != null)
                    _deviceArrivedWatcher.Stop();
            }
        }

        private void AddDeviceRemovedHandler()
        {
            const Int32 pollingIntervalSeconds = 3;
            var scope = new ManagementScope("root\\CIMV2");
            scope.Options.EnablePrivileges = true;

            try
            {
                var q = new WqlEventQuery();
                q.EventClassName = "__InstanceDeletionEvent";
                q.WithinInterval = new TimeSpan(0, 0, pollingIntervalSeconds);
                q.Condition = @"TargetInstance ISA 'Win32_USBControllerdevice'";
                _deviceRemovedWatcher = new ManagementEventWatcher(scope, q);
                _deviceRemovedWatcher.EventArrived += DeviceRemoved;
                _deviceRemovedWatcher.Start();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                if (_deviceRemovedWatcher != null)
                    _deviceRemovedWatcher.Stop();
            }
        }

        private void DeviceAdded(object sender, EventArrivedEventArgs e)
        {
            try
            {
                Debug.WriteLine("A USB device has been inserted");

                _deviceDetected = FindDeviceUsingWmi();
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        private Boolean FindDeviceUsingWmi()
        {
            try
            {
                // Prepend "@" to string below to treat backslash as a normal character (not escape character):

                String deviceIdString = @"USB\VID_" + _myVendorId.ToString("X4") + "&PID_" + _myProductId.ToString("X4");

                _deviceDetected = false;
                var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if (queryObj["PNPDeviceID"].ToString().Contains(deviceIdString))
                    {
                        _deviceDetected = true;
                        MyMarshalDataToForm(FormActions.AddItemToListBox, "--------");
                        MyMarshalDataToForm(FormActions.AddItemToListBox, "My device found (WMI):");

                        // Display device properties.

                        foreach (WmiDeviceProperties wmiDeviceProperty in Enum.GetValues(typeof(WmiDeviceProperties)))
                        {
                            MyMarshalDataToForm(FormActions.AddItemToListBox, (wmiDeviceProperty.ToString() + ": " + queryObj[wmiDeviceProperty.ToString()]));
                            Debug.WriteLine(wmiDeviceProperty.ToString() + ": {0}", queryObj[wmiDeviceProperty.ToString()]);
                        }
                        MyMarshalDataToForm(FormActions.AddItemToListBox, "--------");
                        MyMarshalDataToForm(FormActions.ScrollToBottomOfListBox, "");
                    }
                }
                if (!_deviceDetected)
                {
                    MyMarshalDataToForm(FormActions.AddItemToListBox, "My device not found (WMI)");
                    MyMarshalDataToForm(FormActions.ScrollToBottomOfListBox, "");
                }
                return _deviceDetected;
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        internal static void DisplayException(String moduleName, Exception e)
        {
            //  Create an error message.

            String message = "Exception: " + e.Message + Environment.NewLine + "Module: " + moduleName + Environment.NewLine + "Method: " + e.TargetSite.Name;

            const String caption = "Unexpected Exception";

            MessageBox.Show(message, caption, MessageBoxButtons.OK);
            Debug.Write(message);

            // Get the last error and display it. 

            Int32 error = Marshal.GetLastWin32Error();

            Debug.WriteLine("The last Win32 Error was: " + error);
        }

        private Boolean FindTheHid()
        {
            var devicePathName = new String[128];
            String myDevicePathName = "";

            try
            {
                _deviceHandleObtained = false;
                CloseCommunications();

                //  Get the device's Vendor ID and Product ID from the form's text boxes.

                GetVendorAndProductIDsFromTextBoxes(ref _myVendorId, ref _myProductId);

                // Get the HID-class GUID.

                Guid hidGuid = _myHid.GetHidGuid();

                String functionName = "GetHidGuid";
                Debug.WriteLine(_myDebugging.ResultOfApiCall(functionName));
                Debug.WriteLine("  GUID for system HIDs: " + hidGuid.ToString());

                //  Fill an array with the device path names of all attached HIDs.

                Boolean availableHids = _myDeviceManagement.FindDeviceFromGuid(hidGuid, ref devicePathName);

                //  If there is at least one HID, attempt to read the Vendor ID and Product ID
                //  of each device until there is a match or all devices have been examined.

                if (availableHids)
                {
                    Int32 memberIndex = 0;

                    do
                    {
                        // Open the handle without read/write access to enable getting information about any HID, even system keyboards and mice.

                        _hidHandle = _myHid.OpenHandle(devicePathName[memberIndex], false);

                        functionName = "CreateFile";
                        Debug.WriteLine(_myDebugging.ResultOfApiCall(functionName));
                        Debug.WriteLine("  Returned handle: " + _hidHandle);

                        if (!_hidHandle.IsInvalid)
                        {
                            // The returned handle is valid, 
                            // so find out if this is the device we're looking for.

                            _myHid.DeviceAttributes.Size = Marshal.SizeOf(_myHid.DeviceAttributes);

                            Boolean success = _myHid.GetAttributes(_hidHandle, ref _myHid.DeviceAttributes);

                            if (success)
                            {
                                Debug.WriteLine("  HIDD_ATTRIBUTES structure filled without error.");
                                Debug.WriteLine("  Structure size: " + _myHid.DeviceAttributes.Size);
                                Debug.WriteLine("  Vendor ID: " + Convert.ToString(_myHid.DeviceAttributes.VendorID, 16));
                                Debug.WriteLine("  Product ID: " + Convert.ToString(_myHid.DeviceAttributes.ProductID, 16));
                                Debug.WriteLine("  Version Number: " + Convert.ToString(_myHid.DeviceAttributes.VersionNumber, 16));

                                if ((_myHid.DeviceAttributes.VendorID == _myVendorId) && (_myHid.DeviceAttributes.ProductID == _myProductId))
                                {
                                    Debug.WriteLine("  Handle obtained to my device");

                                    //  Display the information in form's list box.

                                    MyMarshalDataToForm(FormActions.AddItemToListBox, "Handle obtained to my device:");
                                    MyMarshalDataToForm(FormActions.AddItemToListBox, "  Vendor ID= " + Convert.ToString(_myHid.DeviceAttributes.VendorID, 16));
                                    MyMarshalDataToForm(FormActions.AddItemToListBox, "  Product ID = " + Convert.ToString(_myHid.DeviceAttributes.ProductID, 16));
                                    MyMarshalDataToForm(FormActions.ScrollToBottomOfListBox, "");

                                    _deviceHandleObtained = true;

                                    myDevicePathName = devicePathName[memberIndex];
                                }
                                else
                                {
                                    //  It's not a match, so close the handle.

                                    _deviceHandleObtained = false;
                                    _hidHandle.Close();
                                }
                            }
                            else
                            {
                                //  There was a problem retrieving the information.

                                Debug.WriteLine("  Error in filling HIDD_ATTRIBUTES structure.");
                                _deviceHandleObtained = false;
                                _hidHandle.Close();
                            }
                        }

                        //  Keep looking until we find the device or there are no devices left to examine.

                        memberIndex = memberIndex + 1;
                    }
                    while (!((_deviceHandleObtained || (memberIndex == devicePathName.Length))));
                }

                if (_deviceHandleObtained)
                {
                    //  The device was detected.
                    //  Learn the capabilities of the device.

                    _myHid.Capabilities = _myHid.GetDeviceCapabilities(_hidHandle);

                    //  Find out if the device is a system mouse or keyboard.

                    _hidUsage = _myHid.GetHidUsage(_myHid.Capabilities);

                    //  Get the Input report buffer size.

                    GetInputReportBufferSize();
                    MyMarshalDataToForm(FormActions.EnableInputReportBufferSize, "");

                    //Close the handle and reopen it with read/write access.

                    _hidHandle.Close();

                    _hidHandle = _myHid.OpenHandle(myDevicePathName, true);

                    if (_hidHandle.IsInvalid)
                    {
                        MyMarshalDataToForm(FormActions.AddItemToListBox, "The device is a system " + _hidUsage + ".");
                        MyMarshalDataToForm(FormActions.AddItemToListBox, "Windows 2000 and later obtain exclusive access to Input and Output reports for this devices.");
                        MyMarshalDataToForm(FormActions.AddItemToListBox, "Windows 8 also obtains exclusive access to Feature reports.");
                        MyMarshalDataToForm(FormActions.ScrollToBottomOfListBox, "");
                    }
                    else
                    {
                        if (_myHid.Capabilities.InputReportByteLength > 0)
                        {
                            //  Set the size of the Input report buffer. 

                            var inputReportBuffer = new Byte[_myHid.Capabilities.InputReportByteLength];

                            _deviceData = new FileStream(_hidHandle, FileAccess.Read | FileAccess.Write, inputReportBuffer.Length, false);
                        }

                        if (_myHid.Capabilities.OutputReportByteLength > 0)
                        {
                            Byte[] outputReportBuffer = null;
                        }
                        //  Flush any waiting reports in the input buffer. (optional)

                        _myHid.FlushQueue(_hidHandle);
                    }
                }
                else
                {
                    MyMarshalDataToForm(FormActions.AddItemToListBox, "Device not found.");
                    MyMarshalDataToForm(FormActions.DisableInputReportBufferSize, "");
                    EnableFormControls();
                    MyMarshalDataToForm(FormActions.ScrollToBottomOfListBox, "");
                }
                return _deviceHandleObtained;
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        private void CloseCommunications()
        {
            if (_deviceData != null)
            {
                _deviceData.Close();
            }

            if ((_hidHandle != null) && (!(_hidHandle.IsInvalid)))
            {
                _hidHandle.Close();
            }

            // The next attempt to communicate will get a new handle and FileStreams.

            _deviceHandleObtained = false;
        }

        private void GetVendorAndProductIDsFromTextBoxes(ref Int32 myVendorId, ref Int32 myProductId)
        {
            try
            {
                myVendorId = Int32.Parse(VID_txtbox.Text, NumberStyles.AllowHexSpecifier);
                myProductId = Int32.Parse(PID_txtbox.Text, NumberStyles.AllowHexSpecifier);
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        private void MyMarshalDataToForm(FormActions action, String textToDisplay)
        {
            try
            {
                object[] args = { action, textToDisplay };

                //  The AccessForm routine contains the code that accesses the form.

                MarshalDataToForm marshalDataToFormDelegate = AccessForm;

                //  Execute AccessForm, passing the parameters in args.

                Invoke(marshalDataToFormDelegate, args);
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        private void AccessForm(FormActions action, String formText)
        {
            try
            {
                //  Select an action to perform on the form:

                switch (action)
                {
                    case FormActions.AddItemToListBox:

                        LstResults.Items.Add(formText);
                        break;

                    case FormActions.ScrollToBottomOfListBox:

                        LstResults.SelectedIndex = LstResults.Items.Count - 1;
                        break;

                    case FormActions.SetInputReportBufferSize:

                        BufferSize.Text = formText;
                        break;
                }
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        private void GetInputReportBufferSize()
        {
            Int32 numberOfInputBuffers = 0;
            Boolean success;

            try
            {
                //  Get the number of input buffers.

                _myHid.GetNumberOfInputBuffers(_hidHandle, ref numberOfInputBuffers);

                //  Display the result in the text box.

                MyMarshalDataToForm(FormActions.SetInputReportBufferSize, Convert.ToString(numberOfInputBuffers));
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        private void EnableFormControls()
        {
            GetInput_btn.Enabled = true;
        }

        private void Startup()
        {
            const Int32 periodicTransferInterval = 1000;
            try
            {
                _myHid = new Hid();
                //InitializeDisplay();

                _periodicTransfers = new System.Timers.Timer(periodicTransferInterval);
                _periodicTransfers.Elapsed += DoPeriodicTransfers;
                _periodicTransfers.Stop();
                _periodicTransfers.SynchronizingObject = this;

                //  Default USB Vendor ID and Product ID:

                VID_txtbox.Text = "0079";
                PID_txtbox.Text = "0006";

                GetVendorAndProductIDsFromTextBoxes(ref _myVendorId, ref _myProductId);

                DeviceNotificationsStart();
                FindDeviceUsingWmi();
                FindTheHid();
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        private void DoPeriodicTransfers(object source, ElapsedEventArgs e)
        {
            try
            {
                PeriodicTransfers();
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        private void PeriodicTransfers()
        {
            try
            {
                if (!_transferInProgress)
                {
                    if (_reportType == ReportTypes.Feature)
                    {
                       // SendOrGetFeatureReport();
                    }
                    else
                    {
                        // Output and Input reports

                        SendOutputReportOrGetInputReport();
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        private void DeviceNotificationsStart()
        {
            AddDeviceArrivedHandler();
            AddDeviceRemovedHandler();
        }

        private void DeviceRemoved(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine("A USB device has been removed");

                _deviceDetected = FindDeviceUsingWmi();

                if (!_deviceDetected)
                {
                    _deviceHandleObtained = false;
                    CloseCommunications();
                }
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        private void DisplayTransferInProgressMessage()
        {
            AccessForm(FormActions.AddItemToListBox, "Command not executed because a transfer is in progress.");
            ScrollToBottomOfListBox();
        }

        private void ScrollToBottomOfListBox()
        {
            try
            {
                LstResults.SelectedIndex = LstResults.Items.Count - 1;

                //  If the list box is getting too large, trim its contents by removing the earliest data.

                if (LstResults.Items.Count > 1000)
                {
                    Int32 count;
                    for (count = 1; count <= 500; count++)
                    {
                        LstResults.Items.RemoveAt(4);
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        private void PeriodicTransfersStart()
        {
            //  Change the command button's text.

            GetInput_btn.Text = "Stop";

            //  Enable the timer event to trigger a set of transfers.

            _periodicTransfers.Start();

            GetInput_btn.Enabled = true;

            _transferType = TransferTypes.Interrupt;
            _reportType = ReportTypes.Output;

            _periodicTransfersRequested = true;
            PeriodicTransfers();
        }

        private void PeriodicTransfersStop()
        {
            //  Stop doing continuous transfers.

            _periodicTransfersRequested = false;

            // Disable the timer that triggers the transfers.	

            _periodicTransfers.Stop();
            GetInput_btn.Enabled = true;

            //  Change the command button's text.

            GetInput_btn.Text = "Start";
        }

        private void SendOutputReportOrGetInputReport()
        {
            try
            {
                //  If the device hasn't been detected, was removed, or timed out on a previous attempt
                //  to access it, look for the device.

                if (!_deviceHandleObtained)
                {
                    _deviceHandleObtained = FindTheHid();
                }

                if (_deviceHandleObtained)
                {
                    if (_sendOrGet == SendOrGet.Send)
                    {
                        //RequestToSendOutputReport();
                        _sendOrGet = SendOrGet.Get;
                    }
                    else
                    {
                        RequestToGetInputReport();
                        //_sendOrGet = SendOrGet.Send;
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        private async void RequestToGetInputReport()
        {
            const Int32 readTimeout = 5000;

            String byteValue = null;
            Byte[] inputReportBuffer = null;

            try
            {
                Boolean success = false;

                //  If the device hasn't been detected, was removed, or timed out on a previous attempt
                //  to access it, look for the device.

                if (!_deviceHandleObtained)
                {
                    _deviceHandleObtained = FindTheHid();
                }

                if (_deviceHandleObtained)
                {
                    //  Don't attempt to exchange reports if valid handles aren't available
                    //  (as for a mouse or keyboard under Windows 2000 and later.)

                    if (!_hidHandle.IsInvalid)
                    {
                        //  Read an Input report.

                        //  Don't attempt to send an Input report if the HID has no Input report.
                        //  (The HID spec requires all HIDs to have an interrupt IN endpoint,
                        //  which suggests that all HIDs must support Input reports.)

                        if (_myHid.Capabilities.InputReportByteLength > 0)
                        {
                            //  Set the size of the Input report buffer. 

                            inputReportBuffer = new Byte[_myHid.Capabilities.InputReportByteLength];

                            if (_transferType.Equals(TransferTypes.Control))
                            {
                                {
                                    _transferInProgress = true;

                                    //  Read a report using a control transfer.

                                    success = _myHid.GetInputReportViaControlTransfer(_hidHandle, ref inputReportBuffer);
                                    GetInput_btn.Enabled = true;
                                    _transferInProgress = false;
                                }
                            }
                            else
                            {
                                {
                                    _transferInProgress = true;

                                    //  Read a report using interrupt transfers. 
                                    //  Timeout if no report available.
                                    //  To enable reading a report without blocking the calling thread, uses Filestream's ReadAsync method.                                               

                                    // Create a delegate to execute on a timeout.

                                    Action onReadTimeoutAction = OnReadTimeout;

                                    // The CancellationTokenSource specifies the timeout value and the action to take on a timeout.

                                    var cts = new CancellationTokenSource();

                                    // Cancel the read if it hasn't completed after a timeout.

                                    cts.CancelAfter(readTimeout);

                                    // Specify the function to call on a timeout.

                                    cts.Token.Register(onReadTimeoutAction);

                                    // Stops waiting when data is available or on timeout:

                                    Int32 bytesRead = await _myHid.GetInputReportViaInterruptTransfer(_deviceData, inputReportBuffer, cts);

                                    // Arrive here only if the operation completed.

                                    // Dispose to stop the timeout timer. 

                                    cts.Dispose();

                                    _transferInProgress = false;
                                    GetInput_btn.Enabled = true;

                                    if (bytesRead > 0)
                                    {
                                        success = true;
                                        Debug.Print("bytes read (includes report ID) = " + Convert.ToString(bytesRead));
                                    }
                                }
                            }
                        }
                        else
                        {
                            MyMarshalDataToForm(FormActions.AddItemToListBox, "No attempt to read an Input report was made.");
                            MyMarshalDataToForm(FormActions.AddItemToListBox, "The HID doesn't have an Input report.");
                        }
                    }
                    else
                    {
                        MyMarshalDataToForm(FormActions.AddItemToListBox, "Invalid handle.");
                        MyMarshalDataToForm(FormActions.AddItemToListBox,
                                            "No attempt to write an Output report or read an Input report was made.");
                    }

                    if (success)
                    {
                        DisplayReportData(inputReportBuffer, ReportTypes.Input, ReportReadOrWritten.Read);
                    }
                    else
                    {
                        CloseCommunications();
                        MyMarshalDataToForm(FormActions.AddItemToListBox, "The attempt to read an Input report has failed.");
                        ScrollToBottomOfListBox();
                    }
                }
            }

            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        //private async void RequestToSendOutputReport()
        //{
        //    const Int32 writeTimeout = 5000;
        //    String byteValue = null;

        //    try
        //    {
        //        //  If the device hasn't been detected, was removed, or timed out on a previous attempt
        //        //  to access it, look for the device.

        //        if (!_deviceHandleObtained)
        //        {
        //            _deviceHandleObtained = FindTheHid();
        //        }

        //        if (_deviceHandleObtained)
        //        {
        //            GetBytesToSend();
        //        }
        //        //  Don't attempt to exchange reports if valid handles aren't available
        //        //  (as for a mouse or keyboard.)

        //        if (!_hidHandle.IsInvalid)
        //        {
        //            //  Don't attempt to send an Output report if the HID has no Output report.

        //            if (_myHid.Capabilities.OutputReportByteLength > 0)
        //            {
        //                //  Set the size of the Output report buffer.   

        //                var outputReportBuffer = new Byte[_myHid.Capabilities.OutputReportByteLength];

        //                //  Store the report ID in the first byte of the buffer:

        //                outputReportBuffer[0] = 0;

        //                //  Store the report data following the report ID.
        //                //  Use the data in the combo boxes on the form.

        //                outputReportBuffer[1] = Convert.ToByte(CboByte0.SelectedIndex);

        //                if (outputReportBuffer.GetUpperBound(0) > 1)
        //                {
        //                    outputReportBuffer[2] = Convert.ToByte(CboByte1.SelectedIndex);
        //                }

        //                //  Write a report.

        //                Boolean success;

        //                if (_transferType.Equals(TransferTypes.Control))
        //                {
        //                    {
        //                        _transferInProgress = true;

        //                        //  Use a control transfer to send the report,
        //                        //  even if the HID has an interrupt OUT endpoint.

        //                        success = _myHid.SendOutputReportViaControlTransfer(_hidHandle, outputReportBuffer);

        //                        _transferInProgress = false;
        //                        cmdSendOutputReportControl.Enabled = true;
        //                    }
        //                }
        //                else
        //                {
        //                    Debug.Print("interrupt");
        //                    _transferInProgress = true;

        //                    // The CancellationTokenSource specifies the timeout value and the action to take on a timeout.

        //                    var cts = new CancellationTokenSource();

        //                    // Create a delegate to execute on a timeout.

        //                    Action onWriteTimeoutAction = OnWriteTimeout;

        //                    // Cancel the read if it hasn't completed after a timeout.

        //                    cts.CancelAfter(writeTimeout);

        //                    // Specify the function to call on a timeout.

        //                    cts.Token.Register(onWriteTimeoutAction);

        //                    // Send an Output report and wait for completion or timeout.

        //                    success = await _myHid.SendOutputReportViaInterruptTransfer(_deviceData, _hidHandle, outputReportBuffer, cts);

        //                    // Get here only if the operation completes without a timeout.

        //                    _transferInProgress = false;
        //                    cmdSendOutputReportInterrupt.Enabled = true;

        //                    // Dispose to stop the timeout timer.

        //                    cts.Dispose();
        //                }
        //                if (success)
        //                {
        //                    DisplayReportData(outputReportBuffer, ReportTypes.Output, ReportReadOrWritten.Written);
        //                }
        //                else
        //                {
        //                    CloseCommunications();
        //                    AccessForm(FormActions.AddItemToListBox, "The attempt to write an Output report failed.");
        //                    ScrollToBottomOfListBox();
        //                }
        //            }
        //        }
        //        else
        //        {
        //            AccessForm(FormActions.AddItemToListBox, "The HID doesn't have an Output report.");
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        DisplayException(Name, ex);
        //        throw;
        //    }
        //}

        private void OnReadTimeout()
        {
            try
            {
                MyMarshalDataToForm(FormActions.AddItemToListBox, "The attempt to read a report timed out.");
                MyMarshalDataToForm(FormActions.ScrollToBottomOfListBox, "");
                CloseCommunications();
                MyMarshalDataToForm(FormActions.EnableGetInputReportInterruptTransfer, "");
                _transferInProgress = false;
                _sendOrGet = SendOrGet.Send;
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        private void DisplayReportData(Byte[] buffer, ReportTypes currentReportType, ReportReadOrWritten currentReadOrWritten)
        {
            try
            {
                Int32 count;

                LstResults.Items.Add(currentReportType.ToString() + " report has been " + currentReadOrWritten.ToString().ToLower() + ".");

                //  Display the report data received in the form's list box.

                LstResults.Items.Add(" Report ID: " + String.Format("{0:X2} ", buffer[0]));
                LstResults.Items.Add(" Report Data:");

                //TxtBytesReceived.Text = "";

                for (count = 1; count <= buffer.Length - 1; count++)
                {
                    //  Display bytes as 2-character Hex strings.

                    String byteValue = String.Format("{0:X2} ", buffer[count]);

                    LstResults.Items.Add(" " + byteValue);

                    //  Display the received bytes in the text box.

                    //TxtBytesReceived.SelectionStart = TxtBytesReceived.Text.Length;
                    //TxtBytesReceived.SelectedText = byteValue + Environment.NewLine;
                }
                ScrollToBottomOfListBox();
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }


    }
}
