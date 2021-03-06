﻿using System;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace xy_Chart
{
    public partial class Form1 : Form
    {
        private double x_pos = 0.0, y_pos = 0.0, z_pos = 5.0;
        private double manual_x, manual_y, manual_z; 
        private bool Active = false;
        private bool replay = false;
        private Thread Serial_Thread;
        private Thread Chart_Thread;
        private Thread data_Thread;
        private int Setvar = 0, stat, temp;
        private int delay= 20;
        //static int numbering = 1;
        private byte sensor_vals;
        private byte analogval;
        private byte[] buffer;
        private byte[] tembuf;
        private string dumpbuff;
        private string fileName;
        private string[] fileList;
        //private System.Text.StringBuilder Datanum = new System.Text.StringBuilder();
        private const int W_offset = 50;
        private List<byte> buffList;
        private List<float> xList;
        private List<float> yList;
        private List<float> zList;
        private List<byte> sensorList;
        //private List<byte> cutbuff = new List<byte>();
        private FileStream fS;
        private FileStream fullfS;

        //List<long> data_x = new List<long>();
        //List<long> data_y = new List<long>();
        //List<long> data_teta = new List<long>();

        //List<long> data_x_tracking = new List<long>();
        //List<long> data_y_tracking = new List<long>();
        //List<long> data_teta_tracking = new List<long>();

        //List<char> buff = new List<char>();
        //List<char> buff2 = new List<char>();

        //string data_masuk = "";
        //int kondisi = 0, tanda = 0;
        //int x_tampil = 0, y_tampil = 0, teta_tampil = 0;
        //int x_temp = 0, y_temp = 0, teta_temp = 0;
        //int penanda_data = 0;


        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Chart_setup();
            chart1.Series["auto"].Points.AddXY(0,0);
            chart1.Series["manual"].Points.AddXY(0,0);
            chart1.Series["auto_dir"].Points.AddXY(400, 0);
            chart1.Series["manual_dir"].Points.AddXY(400, 0);
            Pause_btn.Enabled = false;
            available_ports.Items.AddRange(SerialPort.GetPortNames());
            Start_btn.Enabled = true;
            baud_rates.Enabled = true;
            //available_ports.SelectedIndex = 0;
            baud_rates.SelectedIndex = 3;
            fileList = Directory.GetFiles("records");
            foreach (string filePath in fileList) recordList.Items.Add(Path.GetFileName(filePath));
            replayBtn.Enabled = false;
            fullPlayBtn.Enabled = false;
            pauseBtn.Enabled = false;
            pathText.Text = DateTime.Now.ToString("dd-MM-yy_hh-mm-ss-tt");
        }

        private void Chart_setup()
        {
            chart1.Series["auto"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            chart1.Series["auto"].MarkerColor = System.Drawing.Color.CadetBlue;
            chart1.Series["auto"].SetCustomProperty("BubbleMaxSize", "7");
            chart1.Series["auto"].SetCustomProperty("BubbleMinSize", "7");
            chart1.Series["manual"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            chart1.Series["manual"].MarkerColor = System.Drawing.Color.BlueViolet;
            chart1.Series["manual"].SetCustomProperty("BubbleMaxSize", "7");
            chart1.Series["manual"].SetCustomProperty("BubbleMinSize", "7");
            chart1.ChartAreas["auto_chart"].AxisX.Maximum = 13100-550;
            chart1.ChartAreas["auto_chart"].AxisX.Minimum = -550;
            chart1.ChartAreas["auto_chart"].AxisX.Interval = 500;
            chart1.ChartAreas["auto_chart"].AxisY.Maximum = 10100 - 550;
            chart1.ChartAreas["auto_chart"].AxisY.Minimum =  - 550;
            chart1.ChartAreas["auto_chart"].AxisY.Interval = 500;
            chart1.ChartAreas["manual_chart"].AxisX.Maximum = 13600;
            chart1.ChartAreas["manual_chart"].AxisX.Minimum = -530;
            chart1.ChartAreas["manual_chart"].AxisY.Maximum = 4770;
            chart1.ChartAreas["manual_chart"].AxisY.Minimum = -9400;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ScrollToCaret();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Start_btn.Enabled = false;
            Pause_btn.Enabled = true;
            Setvar = 1;
            Active = true;
            buffList = new List<byte>();
            xList = new List<float>();
            yList = new List<float>();
            zList = new List<float>();
            sensorList = new List<byte>();

            fileName = "records/" + pathText.Text;
            fS = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fullfS = new FileStream(fileName + ".full", FileMode.Create, FileAccess.Write);
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = available_ports.Text;
                baud_rates.Enabled = false;
                available_ports.Enabled = false;
                serialPort1.BaudRate = Convert.ToInt32(baud_rates.Text);
                serialPort1.RtsEnable = true;
            }
            serialPort1.Close();
            while (!serialPort1.IsOpen) serialPort1.Open();
            Serial_Thread = new Thread(new ThreadStart(Serial_Read));
            Serial_Thread.Start();
            data_Thread = new Thread(new ThreadStart(convert_data));
            data_Thread.Start();
            Chart_Thread = new Thread(new ThreadStart(show_data));
            Chart_Thread.Start();
        }

        private void Serial_Read()
        {
            stat = 0;
            //xarr = new double[100];
            //yarr = new double[100];
            dumpbuff = serialPort1.ReadExisting();
            //fullfS.Write(dumpbuff, 0, dumpbuff.Length);
            while (Active)
            {
                if(serialPort1.IsOpen)
                {
                    stat = get_data3(stat);
                }
                Setvar = 0;
            }
            //Thread.Sleep(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Active = false;
            Pause_btn.Enabled = false;
            available_ports.Enabled = true;
            baud_rates.Enabled = true;
            try
            {
                if (Serial_Thread.IsAlive)
                {
                    Serial_Thread.Abort();
                }
            }
            catch (Exception exc)
            {
                richTextBox1.AppendText(exc.ToString());
            }
            fS.Write(buffList.ToArray(), 0, buffList.Count);
            fullfS.Write(buffList.ToArray(), 0, buffList.Count);
            fS.Close();
            fullfS.Close();
            Start_btn.Enabled = true;
            recordList.Items.Clear();
            fileList = Directory.GetFiles("records");
            foreach (string filePath in fileList) recordList.Items.Add(Path.GetFileName(filePath));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Setvar == 1 && Serial_Thread.IsAlive)
                {
                    Serial_Thread.Abort();
                }
            }
            catch (Exception exc)
            {
                richTextBox1.AppendText(exc.ToString());
            }
            try
            {
                if (Serial_Thread.IsAlive) Serial_Thread.Abort();
                if (data_Thread.IsAlive) data_Thread.Abort();
                if (Chart_Thread.IsAlive) Chart_Thread.Abort();
                if (serialPort1.IsOpen) serialPort1.Close();
            }
            catch(Exception exc) { }
            //sW.Close();
        } 

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            chart1.Series["history"].Points.Clear();
            chart1.Series["manual history"].Points.Clear();
            richTextBox1.ResetText();
        }

        private void available_ports_SelectionChangeCommitted(object sender, EventArgs e)
        {
            baud_rates.Enabled = true;
        }

        private void baud_rates_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Start_btn.Enabled = true;
        }

        private void Sel_Auto_CheckedChanged(object sender, EventArgs e)
        {
            Group_Manual.Enabled = false;
            Group_Auto.Enabled = true;
        }

        private void Sel_Man_CheckedChanged(object sender, EventArgs e)
        {
            Group_Auto.Enabled = false;
            Group_Manual.Enabled = true;
        }

        private void Sel_both_CheckedChanged(object sender, EventArgs e)
        {
            Group_Manual.Enabled = true;
            Group_Auto.Enabled = true;
        }
        

        

        private void button1_Click(object sender, EventArgs e)//go button
        {
            if((Textbox_Auto_X.Text != "") && (Textbox_Auto_Y.Text != "") && (Textbox_Auto_Z.Text != "")
                && (Textbox_M_X.Text != "") && (Textbox_M_Y.Text != "") && (Textbox_M_Z.Text != ""))
            {
                if (!Sel_Man.Checked)
                {
                    x_pos = Convert.ToDouble(Textbox_Auto_X.Text);
                    y_pos = Convert.ToDouble(Textbox_Auto_Y.Text);
                    z_pos = Convert.ToDouble(Textbox_Auto_Z.Text);
                }
                if (!Sel_Auto.Checked)
                {
                    manual_x = Convert.ToDouble(Textbox_M_X.Text);
                    manual_y = Convert.ToDouble(Textbox_M_Y.Text);
                    manual_z = Convert.ToDouble(Textbox_M_Z.Text);
                }
                UpdateChart();
            }
            
        }

        private void replayBtn_Click(object sender, EventArgs e)
        {
            if (replayBtn.Text == "Replay")
            {
                fS = new FileStream("records/" + recordList.Text, FileMode.Open, FileAccess.Read);
                replayBtn.Text = "Stop";
                pauseBtn.Enabled = true;
                buffList = new List<byte>();
                //buffList.AddRange(fS.re)
                buffList = new List<byte>();
                xList = new List<float>();
                yList = new List<float>();
                zList = new List<float>();
                sensorList = new List<byte>();
                buffer = new byte[fS.Length];
                fS.Read(buffer, 0, (int)fS.Length);
                buffList.AddRange(buffer);
                //richTextBox1.AppendText(Encoding.UTF8.GetString(buffer).ToString());
                fS.Close();
                richTextBox1.AppendText(recordList.Text + " size: " + buffList.Count.ToString() + "bytes\n");
                if (recordList.Text.Contains(".full")) delay = 1;
                else delay = 1;
                Active = true;
                replay = true;
                int prog = buffList.Count;
                progressBar1.Maximum = prog;
                while (buffList.Count > 0)
                {
                    progressBar1.Value = prog - buffList.Count;
                    temp = buffList[0];
                    buffList.RemoveAt(0);
                    if (stat == 0 && temp == 'i') { stat = 1; }
                    else if (stat == 1 && temp == 't') { stat = 2; }
                    else if (stat == 2 && temp == 's' && buffList.Count > 24)
                    {
                        tembuf = buffList.GetRange(0, 24).ToArray();
                        buffList.RemoveRange(0, 24);
                        xList.Add(BitConverter.ToSingle(tembuf, 0));
                        yList.Add(BitConverter.ToSingle(tembuf, 4));
                        zList.Add(BitConverter.ToSingle(tembuf, 8));
                        sensorList.Add(tembuf[12]);
                        sensorList.Add(tembuf[13]);
                        stat = 0;
                    }
                }
                Data_track.Maximum = xList.Count - 1;
                Chart_Thread = new Thread(new ThreadStart(show_data));
                Chart_Thread.Start();
            }
            else
            {
                Turnoff();
                replayBtn.Text = "Replay";
                fullPlayBtn.Enabled = false;
                pauseBtn.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            available_ports.Items.Clear();
            available_ports.Items.AddRange(SerialPort.GetPortNames());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(chart1.Width + Group_Auto.Width + Group_Settings.Width + 50, chart1.Height);
        }

        private void recordList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            replayBtn.Enabled = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Group_Auto.Width = get_new_width('g');
            Group_Manual.Width = get_new_width('g');
            Group_Log.Width = get_new_width('l');
            Group_Settings.Width = get_new_width('g');
            Group_Record.Width = get_new_width('g');
            Group_Record.Height = Group_Manual.Height;
            Group_Settings.Location = new Point(chart1.Width + 15, Group_Settings.Location.Y);
            Group_Log.Location = new Point(chart1.Width + 15, Group_Manual.Location.Y + 15 + Group_Manual.Height);
            Group_Auto.Location = new Point(chart1.Width + Group_Settings.Width + 30, Group_Auto.Location.Y);
            Group_Manual.Location = new Point(chart1.Width + Group_Settings.Width + 30, Group_Manual.Location.Y);
            Group_Record.Location = new Point(chart1.Width + 15, Group_Manual.Location.Y);
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            Active = false;
            fullPlayBtn.Enabled = true;
            pauseBtn.Enabled = false;
        }
        
        private void Data_track_ValueChanged(object sender, EventArgs e)
        {
            int i = Data_track.Value;
            x_pos = xList[i];
            y_pos = yList[i];
            z_pos = zList[i];
            sensor_vals = sensorList[i * 2];
            analogval = sensorList[i * 2 + 1];
            UpdateChart();
        }

        private int get_new_width(char type)
        {
            int width = 0;
            if (type == 'g') width = (Width - chart1.Width) / 2 - W_offset;
            else if (type == 'l') width = Width - chart1.Width - W_offset;
            return width;
        }

        private void UpdateChart()
        {
            if (!Sel_Man.Checked)
            {
                Textbox_Auto_X.Text = Convert.ToString(x_pos);
                Textbox_Auto_Y.Text = Convert.ToString(y_pos);
                Textbox_Auto_Z.Text = Convert.ToString(z_pos);
                checkBox8.Checked = (((sensor_vals >> 7) & 1) != 1);
                checkBox7.Checked = (((sensor_vals >> 6) & 1) != 1);
                checkBox6.Checked = (((sensor_vals >> 5) & 1) != 1);
                checkBox5.Checked = (((sensor_vals >> 4) & 1) != 1);
                checkBox4.Checked = (((sensor_vals >> 3) & 1) != 1);
                checkBox3.Checked = (((sensor_vals >> 2) & 1) != 1);
                checkBox2.Checked = (((sensor_vals >> 1) & 1) != 1);
                checkBox1.Checked = (((sensor_vals) & 1) != 1);
                analogSensor.Text = Convert.ToString(analogval);
                chart1.Series["auto"].Points.Clear();
                chart1.Series["auto_dir"].Points.Clear();
                chart1.Series["auto"].Points.AddXY(x_pos, y_pos);
                chart1.Series["auto_dir"].Points.AddXY(x_pos, y_pos);
                chart1.Series["auto_dir"].Points.AddXY(x_pos + (400 * Math.Cos(z_pos * 0.01745329)), y_pos + (400 * Math.Sin(z_pos * 0.01745329)));
            }
            if (!Sel_Auto.Checked)
            {
                chart1.Series["manual"].Points.Clear();
                chart1.Series["manual_dir"].Points.Clear();    
                chart1.Series["manual"].Points.AddXY(manual_x, manual_y);
                chart1.Series["manual_dir"].Points.AddXY(manual_x, manual_y);
                chart1.Series["manual_dir"].Points.AddXY(manual_x + 400 * Math.Cos(manual_z * 0.01745329), manual_y + 400 * Math.Sin(manual_z * 0.01745329));
                Textbox_M_X.Text = Convert.ToString(manual_x);
                Textbox_M_Y.Text = Convert.ToString(manual_y);
                Textbox_M_Z.Text = Convert.ToString(manual_z);
            }
            if (history_enable.Checked)
            {
                chart1.Series["history"].Points.AddXY(x_pos, y_pos);
                chart1.Series["manual history"].Points.AddXY(manual_x, manual_y);
            }
            //richTextBox1.AppendText($"Moved to :({x_pos}, {y_pos})\n");
        }

        private void fullPlayBtn_Click(object sender, EventArgs e)
        {
            Active = true;
            replay = true;
            Chart_Thread = new Thread(new ThreadStart(show_data));
            Chart_Thread.Start();
            pauseBtn.Enabled = true;
            fullPlayBtn.Enabled = false;
        }

        private int get_data3(int stat)
        {
            buffer = new byte[24];
            temp = serialPort1.ReadChar();
            fullfS.WriteByte((byte)temp);
            Invoke((MethodInvoker)delegate { });

            if (stat == 0 && temp == 'i') { stat = 1; fS.WriteByte((byte)temp); }
            else if (stat == 1 && temp == 't') { stat = 2; fS.WriteByte((byte)temp); }
            else if (stat == 2 && temp == 's')
            {
                fS.WriteByte((byte)temp);
                serialPort1.Read(buffer, 0, buffer.Length);
                fS.Write(buffer, 0, 24);
                fullfS.Write(buffer, 0, 24);
                buffList.AddRange(buffer);
                dumpbuff = serialPort1.ReadExisting();
                fullfS.Write(Encoding.Unicode.GetBytes(dumpbuff), 0, dumpbuff.Length);
                stat = 0;
            }
            else stat = 0;
            return stat;
        }
        
        private void convert_data()
        {
            tembuf = new byte[24];
            stat = 0;
            while (Active)
            {
                if ( buffList.Count > 24)
                {
                    tembuf = buffList.GetRange(0, 24).ToArray();
                    buffList.RemoveRange(0, 24);
                    xList.Add(BitConverter.ToSingle(tembuf, 0));
                    yList.Add(BitConverter.ToSingle(tembuf, 4));
                    zList.Add(BitConverter.ToSingle(tembuf, 8));
                    sensorList.Add(tembuf[12]);
                    sensorList.Add(tembuf[13]);
                }
                if (buffList.Count < 24) break;
            }
        }

        private void show_data()
        {
            int i = 0;
            Invoke((MethodInvoker)delegate { i = getTrack(); });
            while (Active)
            {
                if (replay)
                {
                    Invoke((MethodInvoker)delegate { if (getTrack() != i) { i = getTrack(); Active = false; fullPlayBtn.Enabled = true; pauseBtn.Enabled = false; } });
                    if (i < Data_track.Maximum)
                    {
                       Invoke((MethodInvoker)delegate { setTrack(++i); });
                       Thread.Sleep(delay);
                    }
                    else Active = false;                    
                }
                else if (!Sel_Man.Checked && xList.Count>5 && yList.Count>5 && zList.Count>5 && sensorList.Count>6)
                {
                    x_pos = xList[0];
                    y_pos = yList[0];
                    z_pos = zList[0];
                    sensor_vals = sensorList[0];
                    analogval = sensorList[1];
                    try
                    {
                        xList.RemoveAt(0);
                        yList.RemoveAt(0);
                        zList.RemoveAt(0);
                        sensorList.RemoveRange(0,2);
                    }
                    catch(Exception exc) { MessageBox.Show("er01:"+exc.ToString()); }
                    this.Invoke((MethodInvoker)delegate { UpdateChart(); });
                }
                if (replay && (xList.Count < 0 || yList.Count < 0 || zList.Count < 0 || sensorList.Count < 0)) Turnoff();
            }
            Turnoff();
        }

        public int getTrack()
        {
            return Data_track.Value;
        }

        public void setTrack(int nval)
        {
            Data_track.Value = nval;
        }

        public void Turnoff()
        {
            Active = false;
            replay = false;
            //if (Serial_Thread.IsAlive) Serial_Thread.Abort();
            try {
                if (data_Thread.IsAlive) data_Thread.Abort();
            }
            catch (Exception) { }
                
            if (Chart_Thread.IsAlive) Chart_Thread.Abort();
        }

    }
}
