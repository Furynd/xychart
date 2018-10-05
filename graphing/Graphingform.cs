using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace Graphing_Tutorial
{
    public partial class Graphing_Tutorial : Form
    {
        private Thread CPUThread;
        //private double[] CPUArray = new double[100];
        private double[] DataArray = new double[60];
        private bool active = false;
        private SerialPort serialPort;

        public Graphing_Tutorial()
        {
            InitializeComponent();
            Port_Name.Items.AddRange(SerialPort.GetPortNames());
            Start_btn.Enabled = false;
            Baud_Rate.Enabled = false;
        }

        /*private string getData()
        {
            string dataRead = serialPort.ReadLine();
            richTextBox1.AppendText(dataRead);
            return dataRead;
        }*/
        private void getPerformance()
        {
            string dataRead;
            double test;
            //var CPUPerfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            while(active)
            {
                while(!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
                if (serialPort.IsOpen)
                {
                    dataRead = serialPort.ReadLine();
                    richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.AppendText("Received:" + dataRead); });
                    bool result = Double.TryParse(dataRead, out test);
                    if (result)
                    {
                        DataArray[DataArray.Length - 1] = test;
                    }
                }                
                Array.Copy(DataArray, 1, DataArray, 0, DataArray.Length - 1);
                if(CPUChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate {UpdateCPUChart();});
                }

                Thread.Sleep(1000);
            }
        }

        private void UpdateCPUChart()
        {
            //CPUChart.Series["CPU"].Points.Clear();
            CPUChart.Series["Serial_Data"].Points.Clear();

            for (int i = 0; i < DataArray.Length - 1; i++)
            {
            //    CPUChart.Series["CPU"].Points.AddY(CPUArray[i]);
                CPUChart.Series["Serial_Data"].Points.AddY(DataArray[i]);
            }
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            if(!active)
            {
                active = true;
                string Portname = Port_Name.SelectedItem.ToString();
                int Baudrate = Convert.ToInt32(Baud_Rate.SelectedItem);

                serialPort = new SerialPort(Portname, Baudrate, Parity.None, 8, StopBits.One);
                serialPort.Open();
                CPUThread = new Thread(new ThreadStart(getPerformance));
                CPUThread.IsBackground = true;
                CPUThread.Start();
            }
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            active = false;
            serialPort.Close();
        }

        private void Port_Name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Baud_Rate.Enabled = true;
        }

        private void Baud_Rate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Start_btn.Enabled = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
    }
}
