using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Motor
{
    public partial class Form1 : Form
    {
        private double setPoint, kP, kI, kD;
        private double motorData;
        private bool active = false;
        private Thread serialThread;
        private Thread charThread;
        private string stringBuff;
        private short headerStat;
        private byte[] buffer;

        private List<float> vList;
        private List<float> splist;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateChart()
        {
            if (chart1.Series["Set_point"].Points.Count > 100)
            {
                chart1.Series["Set_point"].Points.RemoveAt(0);
                chart1.Series["Motor_data"].Points.RemoveAt(0);
            }
            if (vList.Count > 10)
            {
                chart1.Series["Set_point"].Points.Add(setPoint);
                chart1.Series["Motor_data"].Points.Add(vList[0]);
                vList.RemoveAt(0);
            }
        }

        private void Show_data()
        {
            while (active)
            {
                this.Invoke((MethodInvoker)delegate { UpdateChart(); });
                Thread.Sleep(10);
            }
        }

        private short get_data(short a)
        {
            buffer = new byte[4];
            int temp = serialPort1.ReadChar();

            //Invoke((MethodInvoker)delegate { });

            if (headerStat == 0 && temp == 'i') return 1;
            else if (headerStat == 1 && temp == 't') return 2;
            else if (headerStat == 2 && temp == 's')
            {
                serialPort1.Read(buffer, 0, buffer.Length);
                vList.Add(Convert.ToSingle(buffer));
            }
            return 0;
        }

        private void Serial_read()
        {
            double a = 0;
            headerStat = 0;
            //stringBuff = serialPort1.ReadExisting();
            while (active)
            {
                vList.Add((float)a);
                a += 0.1;
                if (a > 100) a = 0;
                Thread.Sleep(10);
                //if (serialPort1.IsOpen)
                //{
                //    headerStat = get_data(headerStat);
                //}
            }
        }

        private void Receive_btn_Click(object sender, EventArgs e)
        {
            if (!active)
            {
                active = true;
                Receive_btn.Text = "Stop";
                vList = new List<float>();
                setPoint = Convert.ToDouble(setPoint_txt.Text);
                //serialPort1.Close();
                //while (!serialPort1.IsOpen)serialPort1.Open();
                serialThread = new Thread(new ThreadStart(Serial_read));
                serialThread.Start();
                charThread = new Thread(new ThreadStart(Show_data));
                charThread.Start();
            }
            else
            {
                active = false;
                Receive_btn.Text = "Receive";
            }
        }

    }
}
