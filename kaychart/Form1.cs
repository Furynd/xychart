using System;
using System.Windows.Forms;
using rtChart;
using System.IO.Ports;
using System.Threading;

namespace kaychart
{
    public partial class Form1 : Form
    {
       // private Thread DataThread;
        private double[] DataArr = new double[100];
        private bool active = false;
        
        public Form1() => InitializeComponent();

        kayChart Serial_DataChart;

        private void Update_btn_Click(object sender, EventArgs e)
        {
            SerialPort serialPort = new SerialPort("COM4", 115200, Parity.None, 8, StopBits.One);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(Serial_DataReceivedEventHandler);
            if(!serialPort.IsOpen)
            {
                serialPort.Open();
            }
        }

        private void Serial_DataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort dataport = sender as SerialPort;
            string Received_data = dataport.ReadLine();
            Serial_Data.Invoke((MethodInvoker)delegate { Serial_Data.AppendText(Received_data); });

            double data;
            bool result = Double.TryParse(Received_data, out data);
            if(result)
            {
                Serial_DataChart.TriggeredUpdate(data);
            }
        }

        private void Serial_Data_TextChanged(object sender, EventArgs e)
        {
            Serial_Data.SelectionStart = Serial_Data.Text.Length;
            Serial_Data.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Serial_DataChart = new kayChart(chart1, 60);
            Serial_DataChart.serieName = "Data";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            active = false;
        }
    }
}