namespace xy_Chart
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Pause_btn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Textbox_Auto_X = new System.Windows.Forms.TextBox();
            this.Textbox_Auto_Y = new System.Windows.Forms.TextBox();
            this.Textbox_Auto_Z = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.available_ports = new System.Windows.Forms.ComboBox();
            this.baud_rates = new System.Windows.Forms.ComboBox();
            this.Group_Auto = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.analogSensor = new System.Windows.Forms.TextBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Go_Btn = new System.Windows.Forms.Button();
            this.Group_Manual = new System.Windows.Forms.GroupBox();
            this.Textbox_M_Z = new System.Windows.Forms.TextBox();
            this.Textbox_M_X = new System.Windows.Forms.TextBox();
            this.Textbox_M_Y = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Group_Settings = new System.Windows.Forms.GroupBox();
            this.Sel_both = new System.Windows.Forms.RadioButton();
            this.Sel_Man = new System.Windows.Forms.RadioButton();
            this.Sel_Auto = new System.Windows.Forms.RadioButton();
            this.Refresh_Btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.history_enable = new System.Windows.Forms.CheckBox();
            this.Group_Log = new System.Windows.Forms.GroupBox();
            this.Group_Record = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.recordList = new System.Windows.Forms.ComboBox();
            this.pathText = new System.Windows.Forms.TextBox();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.fullPlayBtn = new System.Windows.Forms.Button();
            this.replayBtn = new System.Windows.Forms.Button();
            this.Data_track = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Group_Auto.SuspendLayout();
            this.Group_Manual.SuspendLayout();
            this.Group_Settings.SuspendLayout();
            this.Group_Log.SuspendLayout();
            this.Group_Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_track)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea3.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisX.Interval = 5D;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Maximum = 100D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea3.AxisX.ScaleView.MinSize = 10D;
            chartArea3.AxisY.Interval = 5D;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.Maximum = 100D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea3.AxisY.ScaleView.MinSize = 10D;
            chartArea3.BackImage = "C:\\Users\\User\\source\\repos\\Solution1\\xy_Chart\\Resources\\field.jpg";
            chartArea3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea3.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea3.BorderWidth = 0;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 90F;
            chartArea3.InnerPlotPosition.Width = 90F;
            chartArea3.InnerPlotPosition.X = 5F;
            chartArea3.InnerPlotPosition.Y = 2F;
            chartArea3.IsSameFontSizeForAllAxes = true;
            chartArea3.Name = "auto_chart";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 90F;
            chartArea3.Position.Width = 90F;
            chartArea3.Position.X = 3F;
            chartArea3.Position.Y = 3F;
            chartArea4.AxisX.Interval = 10D;
            chartArea4.AxisX.LabelStyle.Enabled = false;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.IsMarksNextToAxis = false;
            chartArea4.AxisY.LabelStyle.Enabled = false;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.AxisY.Maximum = 124D;
            chartArea4.AxisY.Minimum = 24D;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea4.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea4.BorderWidth = 0;
            chartArea4.InnerPlotPosition.Auto = false;
            chartArea4.InnerPlotPosition.Height = 90F;
            chartArea4.InnerPlotPosition.Width = 90F;
            chartArea4.InnerPlotPosition.X = 5F;
            chartArea4.InnerPlotPosition.Y = 2F;
            chartArea4.IsSameFontSizeForAllAxes = true;
            chartArea4.Name = "manual_chart";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 90F;
            chartArea4.Position.Width = 90F;
            chartArea4.Position.X = 3F;
            chartArea4.Position.Y = 3F;
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series7.ChartArea = "auto_chart";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series7.CustomProperties = "BubbleMinSize=8, BubbleMaxSize=8";
            series7.Legend = "Legend1";
            series7.MarkerSize = 3;
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series7.Name = "auto";
            series7.YValuesPerPoint = 2;
            series8.ChartArea = "manual_chart";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series8.CustomProperties = "BubbleMinSize=8, BubbleMaxSize=8";
            series8.Legend = "Legend1";
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series8.Name = "manual";
            series8.YValuesPerPoint = 6;
            series9.ChartArea = "auto_chart";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "history";
            series10.ChartArea = "manual_chart";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "manual history";
            series11.BorderWidth = 9;
            series11.ChartArea = "auto_chart";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.MarkerSize = 9;
            series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series11.Name = "auto_dir";
            series11.YValuesPerPoint = 2;
            series12.BorderWidth = 9;
            series12.ChartArea = "manual_chart";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.LabelBorderWidth = 9;
            series12.Legend = "Legend1";
            series12.MarkerSize = 9;
            series12.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series12.Name = "manual_dir";
            series12.YValuesPerPoint = 2;
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(900, 700);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 20);
            this.richTextBox1.MinimumSize = new System.Drawing.Size(175, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(300, 107);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(6, 188);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(71, 23);
            this.Start_btn.TabIndex = 7;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // Pause_btn
            // 
            this.Pause_btn.Location = new System.Drawing.Point(99, 188);
            this.Pause_btn.Name = "Pause_btn";
            this.Pause_btn.Size = new System.Drawing.Size(71, 23);
            this.Pause_btn.TabIndex = 8;
            this.Pause_btn.Text = "pause";
            this.Pause_btn.UseVisualStyleBackColor = true;
            this.Pause_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(108, 133);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(75, 23);
            this.Clear_btn.TabIndex = 10;
            this.Clear_btn.Text = "Clear History";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Textbox_Auto_X
            // 
            this.Textbox_Auto_X.Location = new System.Drawing.Point(38, 22);
            this.Textbox_Auto_X.Name = "Textbox_Auto_X";
            this.Textbox_Auto_X.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Auto_X.TabIndex = 11;
            // 
            // Textbox_Auto_Y
            // 
            this.Textbox_Auto_Y.Location = new System.Drawing.Point(38, 48);
            this.Textbox_Auto_Y.Name = "Textbox_Auto_Y";
            this.Textbox_Auto_Y.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Auto_Y.TabIndex = 12;
            // 
            // Textbox_Auto_Z
            // 
            this.Textbox_Auto_Z.Location = new System.Drawing.Point(38, 74);
            this.Textbox_Auto_Z.Name = "Textbox_Auto_Z";
            this.Textbox_Auto_Z.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Auto_Z.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "θ";
            // 
            // available_ports
            // 
            this.available_ports.FormattingEnabled = true;
            this.available_ports.Location = new System.Drawing.Point(25, 30);
            this.available_ports.Name = "available_ports";
            this.available_ports.Size = new System.Drawing.Size(121, 21);
            this.available_ports.TabIndex = 17;
            this.available_ports.SelectionChangeCommitted += new System.EventHandler(this.available_ports_SelectionChangeCommitted);
            // 
            // baud_rates
            // 
            this.baud_rates.FormattingEnabled = true;
            this.baud_rates.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "115200"});
            this.baud_rates.Location = new System.Drawing.Point(25, 65);
            this.baud_rates.Name = "baud_rates";
            this.baud_rates.Size = new System.Drawing.Size(121, 21);
            this.baud_rates.TabIndex = 18;
            this.baud_rates.SelectionChangeCommitted += new System.EventHandler(this.baud_rates_SelectionChangeCommitted);
            // 
            // Group_Auto
            // 
            this.Group_Auto.Controls.Add(this.label1);
            this.Group_Auto.Controls.Add(this.analogSensor);
            this.Group_Auto.Controls.Add(this.checkBox8);
            this.Group_Auto.Controls.Add(this.checkBox7);
            this.Group_Auto.Controls.Add(this.checkBox6);
            this.Group_Auto.Controls.Add(this.checkBox5);
            this.Group_Auto.Controls.Add(this.checkBox4);
            this.Group_Auto.Controls.Add(this.checkBox3);
            this.Group_Auto.Controls.Add(this.checkBox2);
            this.Group_Auto.Controls.Add(this.checkBox1);
            this.Group_Auto.Controls.Add(this.Textbox_Auto_Z);
            this.Group_Auto.Controls.Add(this.Textbox_Auto_X);
            this.Group_Auto.Controls.Add(this.Textbox_Auto_Y);
            this.Group_Auto.Controls.Add(this.label2);
            this.Group_Auto.Controls.Add(this.label3);
            this.Group_Auto.Controls.Add(this.label4);
            this.Group_Auto.Location = new System.Drawing.Point(904, 41);
            this.Group_Auto.MinimumSize = new System.Drawing.Size(175, 225);
            this.Group_Auto.Name = "Group_Auto";
            this.Group_Auto.Size = new System.Drawing.Size(175, 225);
            this.Group_Auto.TabIndex = 37;
            this.Group_Auto.TabStop = false;
            this.Group_Auto.Text = "Auto Robot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "9";
            // 
            // analogSensor
            // 
            this.analogSensor.Location = new System.Drawing.Point(38, 175);
            this.analogSensor.Name = "analogSensor";
            this.analogSensor.Size = new System.Drawing.Size(100, 20);
            this.analogSensor.TabIndex = 25;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(99, 152);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(32, 17);
            this.checkBox8.TabIndex = 24;
            this.checkBox8.Text = "8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(26, 152);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(32, 17);
            this.checkBox7.TabIndex = 23;
            this.checkBox7.Text = "7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(99, 136);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(32, 17);
            this.checkBox6.TabIndex = 22;
            this.checkBox6.Text = "6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(26, 136);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(32, 17);
            this.checkBox5.TabIndex = 21;
            this.checkBox5.Text = "5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(99, 120);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(32, 17);
            this.checkBox4.TabIndex = 20;
            this.checkBox4.Text = "4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(26, 120);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(32, 17);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(99, 105);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(32, 17);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 104);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Go_Btn
            // 
            this.Go_Btn.Location = new System.Drawing.Point(95, 154);
            this.Go_Btn.Name = "Go_Btn";
            this.Go_Btn.Size = new System.Drawing.Size(75, 23);
            this.Go_Btn.TabIndex = 25;
            this.Go_Btn.Text = "Go";
            this.Go_Btn.UseVisualStyleBackColor = true;
            this.Go_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Group_Manual
            // 
            this.Group_Manual.Controls.Add(this.Textbox_M_Z);
            this.Group_Manual.Controls.Add(this.Textbox_M_X);
            this.Group_Manual.Controls.Add(this.Textbox_M_Y);
            this.Group_Manual.Controls.Add(this.label7);
            this.Group_Manual.Controls.Add(this.label8);
            this.Group_Manual.Controls.Add(this.label9);
            this.Group_Manual.Location = new System.Drawing.Point(904, 293);
            this.Group_Manual.MinimumSize = new System.Drawing.Size(175, 225);
            this.Group_Manual.Name = "Group_Manual";
            this.Group_Manual.Size = new System.Drawing.Size(175, 225);
            this.Group_Manual.TabIndex = 38;
            this.Group_Manual.TabStop = false;
            this.Group_Manual.Text = "Manual Robot";
            // 
            // Textbox_M_Z
            // 
            this.Textbox_M_Z.Location = new System.Drawing.Point(38, 74);
            this.Textbox_M_Z.Name = "Textbox_M_Z";
            this.Textbox_M_Z.Size = new System.Drawing.Size(100, 20);
            this.Textbox_M_Z.TabIndex = 13;
            // 
            // Textbox_M_X
            // 
            this.Textbox_M_X.Location = new System.Drawing.Point(38, 22);
            this.Textbox_M_X.Name = "Textbox_M_X";
            this.Textbox_M_X.Size = new System.Drawing.Size(100, 20);
            this.Textbox_M_X.TabIndex = 11;
            // 
            // Textbox_M_Y
            // 
            this.Textbox_M_Y.Location = new System.Drawing.Point(38, 48);
            this.Textbox_M_Y.Name = "Textbox_M_Y";
            this.Textbox_M_Y.Size = new System.Drawing.Size(100, 20);
            this.Textbox_M_Y.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "θ";
            // 
            // Group_Settings
            // 
            this.Group_Settings.Controls.Add(this.Sel_both);
            this.Group_Settings.Controls.Add(this.Sel_Man);
            this.Group_Settings.Controls.Add(this.Sel_Auto);
            this.Group_Settings.Controls.Add(this.Go_Btn);
            this.Group_Settings.Controls.Add(this.Refresh_Btn);
            this.Group_Settings.Controls.Add(this.label14);
            this.Group_Settings.Controls.Add(this.label13);
            this.Group_Settings.Controls.Add(this.available_ports);
            this.Group_Settings.Controls.Add(this.Start_btn);
            this.Group_Settings.Controls.Add(this.Pause_btn);
            this.Group_Settings.Controls.Add(this.baud_rates);
            this.Group_Settings.Location = new System.Drawing.Point(722, 41);
            this.Group_Settings.MinimumSize = new System.Drawing.Size(175, 225);
            this.Group_Settings.Name = "Group_Settings";
            this.Group_Settings.Size = new System.Drawing.Size(176, 225);
            this.Group_Settings.TabIndex = 39;
            this.Group_Settings.TabStop = false;
            this.Group_Settings.Text = "Settings";
            // 
            // Sel_both
            // 
            this.Sel_both.AutoSize = true;
            this.Sel_both.Location = new System.Drawing.Point(31, 125);
            this.Sel_both.Name = "Sel_both";
            this.Sel_both.Size = new System.Drawing.Size(47, 17);
            this.Sel_both.TabIndex = 28;
            this.Sel_both.Text = "Both";
            this.Sel_both.UseVisualStyleBackColor = true;
            this.Sel_both.CheckedChanged += new System.EventHandler(this.Sel_both_CheckedChanged);
            // 
            // Sel_Man
            // 
            this.Sel_Man.AutoSize = true;
            this.Sel_Man.Location = new System.Drawing.Point(31, 108);
            this.Sel_Man.Name = "Sel_Man";
            this.Sel_Man.Size = new System.Drawing.Size(84, 17);
            this.Sel_Man.TabIndex = 27;
            this.Sel_Man.Text = "Manual-Only";
            this.Sel_Man.UseVisualStyleBackColor = true;
            this.Sel_Man.CheckedChanged += new System.EventHandler(this.Sel_Man_CheckedChanged);
            // 
            // Sel_Auto
            // 
            this.Sel_Auto.AutoSize = true;
            this.Sel_Auto.Checked = true;
            this.Sel_Auto.Location = new System.Drawing.Point(31, 91);
            this.Sel_Auto.Name = "Sel_Auto";
            this.Sel_Auto.Size = new System.Drawing.Size(71, 17);
            this.Sel_Auto.TabIndex = 26;
            this.Sel_Auto.TabStop = true;
            this.Sel_Auto.Text = "Auto-Only";
            this.Sel_Auto.UseVisualStyleBackColor = true;
            this.Sel_Auto.CheckedChanged += new System.EventHandler(this.Sel_Auto_CheckedChanged);
            // 
            // Refresh_Btn
            // 
            this.Refresh_Btn.Location = new System.Drawing.Point(6, 153);
            this.Refresh_Btn.Name = "Refresh_Btn";
            this.Refresh_Btn.Size = new System.Drawing.Size(75, 23);
            this.Refresh_Btn.TabIndex = 21;
            this.Refresh_Btn.Text = "Refresh";
            this.Refresh_Btn.UseVisualStyleBackColor = true;
            this.Refresh_Btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Baud Rate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Serial Port";
            // 
            // history_enable
            // 
            this.history_enable.AutoSize = true;
            this.history_enable.Location = new System.Drawing.Point(6, 135);
            this.history_enable.Name = "history_enable";
            this.history_enable.Size = new System.Drawing.Size(94, 17);
            this.history_enable.TabIndex = 40;
            this.history_enable.Text = "history_enable";
            this.history_enable.UseVisualStyleBackColor = true;
            // 
            // Group_Log
            // 
            this.Group_Log.Controls.Add(this.richTextBox1);
            this.Group_Log.Controls.Add(this.history_enable);
            this.Group_Log.Controls.Add(this.Clear_btn);
            this.Group_Log.Location = new System.Drawing.Point(725, 272);
            this.Group_Log.Name = "Group_Log";
            this.Group_Log.Size = new System.Drawing.Size(173, 275);
            this.Group_Log.TabIndex = 41;
            this.Group_Log.TabStop = false;
            this.Group_Log.Text = "Log";
            // 
            // Group_Record
            // 
            this.Group_Record.Controls.Add(this.Data_track);
            this.Group_Record.Controls.Add(this.progressBar1);
            this.Group_Record.Controls.Add(this.hScrollBar1);
            this.Group_Record.Controls.Add(this.recordList);
            this.Group_Record.Controls.Add(this.pathText);
            this.Group_Record.Controls.Add(this.pauseBtn);
            this.Group_Record.Controls.Add(this.fullPlayBtn);
            this.Group_Record.Controls.Add(this.replayBtn);
            this.Group_Record.Location = new System.Drawing.Point(445, 270);
            this.Group_Record.Name = "Group_Record";
            this.Group_Record.Size = new System.Drawing.Size(200, 248);
            this.Group_Record.TabIndex = 42;
            this.Group_Record.TabStop = false;
            this.Group_Record.Text = "Record ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(35, 166);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(138, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(35, 135);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(138, 19);
            this.hScrollBar1.TabIndex = 5;
            // 
            // recordList
            // 
            this.recordList.FormattingEnabled = true;
            this.recordList.Location = new System.Drawing.Point(25, 44);
            this.recordList.Name = "recordList";
            this.recordList.Size = new System.Drawing.Size(130, 21);
            this.recordList.TabIndex = 4;
            this.recordList.SelectedIndexChanged += new System.EventHandler(this.recordList_SelectedIndexChanged);
            this.recordList.SelectionChangeCommitted += new System.EventHandler(this.recordList_SelectionChangeCommitted);
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(25, 23);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(130, 20);
            this.pathText.TabIndex = 3;
            this.pathText.Text = "record";
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(98, 85);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(75, 23);
            this.pauseBtn.TabIndex = 2;
            this.pauseBtn.Text = "pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // fullPlayBtn
            // 
            this.fullPlayBtn.Location = new System.Drawing.Point(17, 100);
            this.fullPlayBtn.Name = "fullPlayBtn";
            this.fullPlayBtn.Size = new System.Drawing.Size(75, 23);
            this.fullPlayBtn.TabIndex = 1;
            this.fullPlayBtn.UseVisualStyleBackColor = true;
            // 
            // replayBtn
            // 
            this.replayBtn.Location = new System.Drawing.Point(17, 71);
            this.replayBtn.Name = "replayBtn";
            this.replayBtn.Size = new System.Drawing.Size(75, 23);
            this.replayBtn.TabIndex = 0;
            this.replayBtn.Text = "Replay";
            this.replayBtn.UseVisualStyleBackColor = true;
            this.replayBtn.Click += new System.EventHandler(this.replayBtn_Click);
            // 
            // Data_track
            // 
            this.Data_track.Location = new System.Drawing.Point(35, 197);
            this.Data_track.Name = "Data_track";
            this.Data_track.Size = new System.Drawing.Size(138, 45);
            this.Data_track.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 569);
            this.Controls.Add(this.Group_Record);
            this.Controls.Add(this.Group_Log);
            this.Controls.Add(this.Group_Settings);
            this.Controls.Add(this.Group_Manual);
            this.Controls.Add(this.Group_Auto);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Group_Auto.ResumeLayout(false);
            this.Group_Auto.PerformLayout();
            this.Group_Manual.ResumeLayout(false);
            this.Group_Manual.PerformLayout();
            this.Group_Settings.ResumeLayout(false);
            this.Group_Settings.PerformLayout();
            this.Group_Log.ResumeLayout(false);
            this.Group_Log.PerformLayout();
            this.Group_Record.ResumeLayout(false);
            this.Group_Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_track)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Pause_btn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.TextBox Textbox_Auto_X;
        private System.Windows.Forms.TextBox Textbox_Auto_Y;
        private System.Windows.Forms.TextBox Textbox_Auto_Z;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox available_ports;
        private System.Windows.Forms.ComboBox baud_rates;
        private System.Windows.Forms.GroupBox Group_Auto;
        private System.Windows.Forms.GroupBox Group_Manual;
        private System.Windows.Forms.TextBox Textbox_M_Z;
        private System.Windows.Forms.TextBox Textbox_M_X;
        private System.Windows.Forms.TextBox Textbox_M_Y;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox Group_Settings;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox history_enable;
        private System.Windows.Forms.Button Go_Btn;
        private System.Windows.Forms.Button Refresh_Btn;
        private System.Windows.Forms.GroupBox Group_Log;
        private System.Windows.Forms.RadioButton Sel_both;
        private System.Windows.Forms.RadioButton Sel_Man;
        private System.Windows.Forms.RadioButton Sel_Auto;
        private System.Windows.Forms.GroupBox Group_Record;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button fullPlayBtn;
        private System.Windows.Forms.Button replayBtn;
        private System.Windows.Forms.ComboBox recordList;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox analogSensor;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar Data_track;
    }
}

