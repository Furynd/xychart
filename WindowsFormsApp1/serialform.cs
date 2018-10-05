using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial_tutorial
{
    public partial class Serial_Comm : Form
    {
        public Serial_Comm()
        {
            InitializeComponent();
            Available_Ports.Items.AddRange(SerialPort.GetPortNames());
            Select_Baudrate.Enabled = false;
            Serial_Receive.Enabled = false;
            Serial_Transmit.Enabled = false;
            Log.Enabled = false;
            string SystemInformation;//Used for Storing System Information 

            SystemInformation = " Machine Name = " + System.Environment.MachineName;                                         // Get the Machine Name 
            SystemInformation = SystemInformation + Environment.NewLine + " OS Version = " + System.Environment.OSVersion;    // Get the OS version
            SystemInformation = SystemInformation + Environment.NewLine + " Processor Cores = " + Environment.ProcessorCount; // Get the Number of Processors on the System

            Log.Text = SystemInformation; //Display into the Log Text Box
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Available_Ports_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Select_Baudrate.Enabled = true;
            Log.Text = Available_Ports.SelectedItem.ToString() + "selected";
        }

        private void Select_Baudrate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Log.Text += Select_Baudrate.SelectedItem.ToString() + "bps";
            Serial_Receive.Enabled = true;
            Serial_Transmit.Enabled = true;
        }

        private void Transmit_Click(object sender, EventArgs e)
        {
            string Port_Name = Available_Ports.SelectedItem.ToString();
            int    Baud_Rate = Convert.ToInt32(Select_Baudrate.SelectedItem);
            string sent_data = Transmit_data.Text;

            SerialPort COMport = new SerialPort(Port_Name, Baud_Rate);

            try
            {
                COMport.Open();
            }
            #region  
            catch (UnauthorizedAccessException SerialException) //exception that is thrown when the operating system denies access 
            {
                MessageBox.Show(SerialException.ToString());
                Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                Log.Text += Environment.NewLine + SerialException.ToString();
                COMport.Close();
            }

            catch (System.IO.IOException SerialException)     // An attempt to set the state of the underlying port failed
            {
                MessageBox.Show(SerialException.ToString());
                Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                Log.Text += Environment.NewLine + SerialException.ToString();
                COMport.Close();
            }

            catch (InvalidOperationException SerialException) // The specified port on the current instance of the SerialPort is already open
            {
                MessageBox.Show(SerialException.ToString());
                Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                Log.Text += Environment.NewLine + SerialException.ToString();
                COMport.Close();
            }

            catch //Any other ERROR
            {
                MessageBox.Show("ERROR in Opening Serial PORT -- UnKnown ERROR");
                COMport.Close();
            }
            #endregion

            //If we are able to open the port 
            if (COMport.IsOpen == true)
            {
                //MessageBox.Show("Port Opened");
                COMport.WriteLine(sent_data);                // Send Data
                COMport.Close();                        // Close the Port
           
                Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                Log.Text += Environment.NewLine + sent_data + "  Written to Port";
            }
            else
            {
                MessageBox.Show("Unable to Write to COM port ");
                COMport.Close();
            }
        }

        private void Receive_Click(object sender, EventArgs e)
        {
            string Port_Name = Available_Ports.SelectedItem.ToString();
            int    Baud_Rate = Convert.ToInt32(Select_Baudrate.SelectedItem);
            string ReceivedData = "";

            SerialPort COMport = new SerialPort(Port_Name, Baud_Rate);

            try
            {
                COMport.Open();
            }
            catch (UnauthorizedAccessException SerialException) //exception that is thrown when the operating system denies access 
            {
                MessageBox.Show(SerialException.ToString());
                Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                Log.Text = Log.Text + Environment.NewLine + SerialException.ToString();
                COMport.Close();                                  // Close the Port
            }

            catch (System.IO.IOException SerialException)     // An attempt to set the state of the underlying port failed
            {
                MessageBox.Show(SerialException.ToString());
                Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                Log.Text = Log.Text + Environment.NewLine + SerialException.ToString();
                COMport.Close();                                  // Close the Port
            }

            catch (InvalidOperationException SerialException) // The specified port on the current instance of the SerialPort is already open
            {
                MessageBox.Show(SerialException.ToString());
                Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                Log.Text = Log.Text + Environment.NewLine + SerialException.ToString();
                COMport.Close();                                  // Close the Port
            }


            catch //Any other ERROR
            {
                MessageBox.Show("ERROR in Opening Serial PORT -- UnKnown ERROR");
                COMport.Close();                                  // Close the Port
            }

            try
            {
                //If we are able to open the port 
                if (COMport.IsOpen == true)
                {
                    //MessageBox.Show("Port Opened");
                    Log.Text = Port_Name + Environment.NewLine + Baud_Rate;

                    #region
                    ReceivedData = COMport.ReadLine();

                    Log.Text = Log.Text + Environment.NewLine + Environment.NewLine + "Waiting for Data";

                    Received_data.Text = ReceivedData;

                    COMport.Close();                                  // Close the Port

                    Log.Text = Log.Text + Environment.NewLine + ReceivedData + "  Received from Port";
                    #endregion
                }
                else
                {
                    MessageBox.Show("Unable to Write to COM port ");
                    COMport.Close();                                  // Close the Port
                }
            }

            // Only catch timeout exceptions.
            catch (TimeoutException SerialTimeOutException)
            {
                #region
                // Show in a Message Box 
                MessageBox.Show(COMport.ReadTimeout.ToString() + " milliSeconds Passed" + Environment.NewLine + "Operation Timed Out");
                MessageBox.Show(SerialTimeOutException.ToString());

                //Show in Log TextBox
                Log.Text = COMport.ReadTimeout.ToString() + " milliSeconds Passed" + Environment.NewLine + "Operation Timed Out";
                Log.Text = Log.Text + Environment.NewLine + SerialTimeOutException.ToString();
                #endregion
                COMport.Close();                                  // Close the Port
            }
        }
    }
}
