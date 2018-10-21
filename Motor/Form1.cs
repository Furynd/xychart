using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Text;
using System.IO;

namespace Motor
{
    public partial class Form1 : Form
    {
        private double setPoint;//, kP, kI, kD;
        private bool active = false;
        private Thread serialThread;
        //private Thread dataThread;
        private Thread charThread;
        private string stringBuff;
        private short headerStat;
        private byte[] buffer;
        private int chartlen=100;

        private List<short> v0List;
        private List<short> v1List;
        private List<short> v2List;
        //private List<float> splist;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Send_btn.Enabled = Check_input();
            //testing
            setPoint = Convert.ToDouble(setPoint_txt.Text);
            chart1.Series["Set_point"].Points.Add(setPoint);
            chart1.Series["Set_point"].Points.Add(setPoint);
            chart1.Series["Motor_0"].Points.Add(10);
            chart1.Series["Motor_1"].Points.Add(11);
            chart1.Series["Motor_2"].Points.Add(12);
            chart1.Series["Motor_0"].Points.Add(11);
            chart1.Series["Motor_1"].Points.Add(12);
            chart1.Series["Motor_2"].Points.Add(13);
            //testing
        }

        private void UpdateChart()
        {
            while (chart1.Series["Set_point"].Points.Count > chartlen)
            {
                chart1.Series["Set_point"].Points.RemoveAt(0);
                chart1.Series["Motor_0"].Points.RemoveAt(0);
                chart1.Series["Motor_1"].Points.RemoveAt(0);
                chart1.Series["Motor_2"].Points.RemoveAt(0);
            }
            if (v0List.Count > 10)
            {
                chart1.Series["Set_point"].Points.Add(setPoint);
                chart1.Series["Motor_0"].Points.Add(v0List[0]);
                chart1.Series["Motor_1"].Points.Add(v1List[0]);
                chart1.Series["Motor_2"].Points.Add(v2List[0]);
                try
                {
                    v0List.RemoveAt(0);
                    v1List.RemoveAt(0);
                    v2List.RemoveAt(0);
                }
                catch(Exception) {

                }
                
            }
        }

        private void Show_data()
        {
            while (active)
            {
                Invoke((MethodInvoker)delegate { UpdateChart(); });
                //Thread.Sleep(10);
            }
        }

        private void Send_btn_Click(object sender, EventArgs e)
        {
            buffer = new byte[19];
            buffer[0] = (byte)'i';
            buffer[1] = (byte)'t';
            buffer[2] = (byte)'s';
            float[] tempBuf = new float[3];

            tempBuf[0] = Convert.ToSingle(kP_txt.Text);
            tempBuf[1] = Convert.ToSingle(kI_txt.Text);
            tempBuf[2] = Convert.ToSingle(kD_txt.Text);
            Buffer.BlockCopy(tempBuf, 0, buffer, 3, sizeof(float) * tempBuf.Length);
            //serialPort1.Close();
            while (!serialPort1.IsOpen) serialPort1.Open();
            serialPort1.Write(buffer.ToString());
        }

        private short get_data(short a)
        {
            buffer = new byte[24];
            int temp = serialPort1.ReadChar();

            //Invoke((MethodInvoker)delegate { });

            if (headerStat == 0 && temp == 'i') return 1;
            else if (headerStat == 1 && temp == 't') return 2;
            else if (headerStat == 2 && temp == 's')
            {
                serialPort1.Read(buffer, 0, buffer.Length);
                v0List.Add(BitConverter.ToInt16(buffer, 0));
                v1List.Add(BitConverter.ToInt16(buffer, 2));
                v2List.Add(BitConverter.ToInt16(buffer, 4));
            }
            return 0;
        }

        private void kP_txt_TextChanged(object sender, EventArgs e)
        {
            Send_btn.Enabled = Check_input();
        }

        private void Serial_read()
        {
            headerStat = 0;
            stringBuff = serialPort1.ReadExisting();
            while (active)
            {
                if (serialPort1.IsOpen) headerStat = get_data(headerStat);
            }
            //serialThread.Abort();
        }

        private void Receive_btn_Click(object sender, EventArgs e)
        {
            if (!active)
            {
                active = true;
                Receive_btn.Text = "Stop";
                Send_btn.Enabled = false;
                v0List = new List<short>();
                v1List = new List<short>();
                v2List = new List<short>();
                setPoint = Convert.ToDouble(setPoint_txt.Text);
                serialPort1.Close();
                while (!serialPort1.IsOpen) serialPort1.Open();
                serialThread = new Thread(new ThreadStart(Serial_read));
                serialThread.Start();
                charThread = new Thread(new ThreadStart(Show_data));
                charThread.Start();
            }
            else
            {
                active = false;
                Send_btn.Enabled = Check_input();
                Receive_btn.Text = "Receive";
            }
        }

        private bool Check_input()
        {
            return setPoint_txt.Text != "" && kI_txt.Text != "" && kP_txt.Text != "" && kD_txt.Text != "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Motor_0"].Enabled = true;
            chart1.Series["Motor_1"].Enabled = false;
            chart1.Series["Motor_2"].Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Motor_0"].Enabled = false;
            chart1.Series["Motor_1"].Enabled = true;
            chart1.Series["Motor_2"].Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Motor_0"].Enabled = false;
            chart1.Series["Motor_1"].Enabled = false;
            chart1.Series["Motor_2"].Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Motor_0"].Enabled = true;
            chart1.Series["Motor_1"].Enabled = true;
            chart1.Series["Motor_2"].Enabled = true;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                chartlen = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception) { }
        }
    }
}
