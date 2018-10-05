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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Textbox_Auto_W = new System.Windows.Forms.TextBox();
            this.Textbox_Auto_Vy = new System.Windows.Forms.TextBox();
            this.Textbox_Auto_Vx = new System.Windows.Forms.TextBox();
            this.Group_Auto = new System.Windows.Forms.GroupBox();
            this.Go_Btn = new System.Windows.Forms.Button();
            this.Group_Manual = new System.Windows.Forms.GroupBox();
            this.Textbox_M_Z = new System.Windows.Forms.TextBox();
            this.Textbox_M_X = new System.Windows.Forms.TextBox();
            this.Textbox_M_Y = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Textbox_M_W = new System.Windows.Forms.TextBox();
            this.Textbox_M_Vx = new System.Windows.Forms.TextBox();
            this.Textbox_M_Vy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.replayBtn = new System.Windows.Forms.Button();
            this.fullPlayBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.pathText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Group_Auto.SuspendLayout();
            this.Group_Manual.SuspendLayout();
            this.Group_Settings.SuspendLayout();
            this.Group_Log.SuspendLayout();
            this.Group_Record.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea5.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea5.AxisX.Interval = 5D;
            chartArea5.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX.Maximum = 100D;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea5.AxisX.ScaleView.MinSize = 10D;
            chartArea5.AxisY.Interval = 5D;
            chartArea5.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisY.MajorGrid.Enabled = false;
            chartArea5.AxisY.Maximum = 100D;
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea5.AxisY.ScaleView.MinSize = 10D;
            chartArea5.BackImage = "C:\\Users\\User\\source\\repos\\Solution1\\xy_Chart\\Resources\\field.jpg";
            chartArea5.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea5.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea5.BorderWidth = 0;
            chartArea5.InnerPlotPosition.Auto = false;
            chartArea5.InnerPlotPosition.Height = 90F;
            chartArea5.InnerPlotPosition.Width = 90F;
            chartArea5.InnerPlotPosition.X = 5F;
            chartArea5.InnerPlotPosition.Y = 2F;
            chartArea5.IsSameFontSizeForAllAxes = true;
            chartArea5.Name = "auto_chart";
            chartArea5.Position.Auto = false;
            chartArea5.Position.Height = 90F;
            chartArea5.Position.Width = 90F;
            chartArea5.Position.X = 3F;
            chartArea5.Position.Y = 3F;
            chartArea6.AxisX.Interval = 10D;
            chartArea6.AxisX.LabelStyle.Enabled = false;
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisX.MajorTickMark.Enabled = false;
            chartArea6.AxisY.IsLabelAutoFit = false;
            chartArea6.AxisY.IsMarksNextToAxis = false;
            chartArea6.AxisY.LabelStyle.Enabled = false;
            chartArea6.AxisY.MajorGrid.Enabled = false;
            chartArea6.AxisY.MajorTickMark.Enabled = false;
            chartArea6.AxisY.Maximum = 124D;
            chartArea6.AxisY.Minimum = 24D;
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea6.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea6.BorderWidth = 0;
            chartArea6.InnerPlotPosition.Auto = false;
            chartArea6.InnerPlotPosition.Height = 90F;
            chartArea6.InnerPlotPosition.Width = 90F;
            chartArea6.InnerPlotPosition.X = 5F;
            chartArea6.InnerPlotPosition.Y = 2F;
            chartArea6.IsSameFontSizeForAllAxes = true;
            chartArea6.Name = "manual_chart";
            chartArea6.Position.Auto = false;
            chartArea6.Position.Height = 90F;
            chartArea6.Position.Width = 90F;
            chartArea6.Position.X = 3F;
            chartArea6.Position.Y = 3F;
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series13.ChartArea = "auto_chart";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series13.CustomProperties = "BubbleMinSize=8, BubbleMaxSize=8";
            series13.Legend = "Legend1";
            series13.MarkerSize = 3;
            series13.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series13.Name = "auto";
            series13.YValuesPerPoint = 2;
            series14.ChartArea = "manual_chart";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series14.CustomProperties = "BubbleMinSize=8, BubbleMaxSize=8";
            series14.Legend = "Legend1";
            series14.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series14.Name = "manual";
            series14.YValuesPerPoint = 6;
            series15.ChartArea = "auto_chart";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Legend = "Legend1";
            series15.Name = "history";
            series16.ChartArea = "manual_chart";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Legend = "Legend1";
            series16.Name = "manual history";
            series17.BorderWidth = 9;
            series17.ChartArea = "auto_chart";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Legend = "Legend1";
            series17.MarkerSize = 9;
            series17.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series17.Name = "auto_dir";
            series17.YValuesPerPoint = 2;
            series18.BorderWidth = 9;
            series18.ChartArea = "manual_chart";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.LabelBorderWidth = 9;
            series18.Legend = "Legend1";
            series18.MarkerSize = 9;
            series18.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series18.Name = "manual_dir";
            series18.YValuesPerPoint = 2;
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
            this.chart1.Series.Add(series17);
            this.chart1.Series.Add(series18);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ω";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Vy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Vx";
            // 
            // Textbox_Auto_W
            // 
            this.Textbox_Auto_W.Enabled = false;
            this.Textbox_Auto_W.Location = new System.Drawing.Point(38, 182);
            this.Textbox_Auto_W.Name = "Textbox_Auto_W";
            this.Textbox_Auto_W.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Auto_W.TabIndex = 21;
            // 
            // Textbox_Auto_Vy
            // 
            this.Textbox_Auto_Vy.Enabled = false;
            this.Textbox_Auto_Vy.Location = new System.Drawing.Point(38, 156);
            this.Textbox_Auto_Vy.Name = "Textbox_Auto_Vy";
            this.Textbox_Auto_Vy.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Auto_Vy.TabIndex = 20;
            // 
            // Textbox_Auto_Vx
            // 
            this.Textbox_Auto_Vx.Enabled = false;
            this.Textbox_Auto_Vx.Location = new System.Drawing.Point(38, 130);
            this.Textbox_Auto_Vx.Name = "Textbox_Auto_Vx";
            this.Textbox_Auto_Vx.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Auto_Vx.TabIndex = 19;
            // 
            // Group_Auto
            // 
            this.Group_Auto.Controls.Add(this.Textbox_Auto_Z);
            this.Group_Auto.Controls.Add(this.Textbox_Auto_X);
            this.Group_Auto.Controls.Add(this.Textbox_Auto_Y);
            this.Group_Auto.Controls.Add(this.label2);
            this.Group_Auto.Controls.Add(this.label3);
            this.Group_Auto.Controls.Add(this.label4);
            this.Group_Auto.Controls.Add(this.Textbox_Auto_W);
            this.Group_Auto.Controls.Add(this.Textbox_Auto_Vx);
            this.Group_Auto.Controls.Add(this.Textbox_Auto_Vy);
            this.Group_Auto.Controls.Add(this.label6);
            this.Group_Auto.Controls.Add(this.label5);
            this.Group_Auto.Controls.Add(this.label1);
            this.Group_Auto.Location = new System.Drawing.Point(904, 41);
            this.Group_Auto.MinimumSize = new System.Drawing.Size(175, 225);
            this.Group_Auto.Name = "Group_Auto";
            this.Group_Auto.Size = new System.Drawing.Size(175, 225);
            this.Group_Auto.TabIndex = 37;
            this.Group_Auto.TabStop = false;
            this.Group_Auto.Text = "Auto Robot";
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
            this.Group_Manual.Controls.Add(this.Textbox_M_W);
            this.Group_Manual.Controls.Add(this.Textbox_M_Vx);
            this.Group_Manual.Controls.Add(this.Textbox_M_Vy);
            this.Group_Manual.Controls.Add(this.label10);
            this.Group_Manual.Controls.Add(this.label11);
            this.Group_Manual.Controls.Add(this.label12);
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
            // Textbox_M_W
            // 
            this.Textbox_M_W.Enabled = false;
            this.Textbox_M_W.Location = new System.Drawing.Point(38, 182);
            this.Textbox_M_W.Name = "Textbox_M_W";
            this.Textbox_M_W.Size = new System.Drawing.Size(100, 20);
            this.Textbox_M_W.TabIndex = 21;
            // 
            // Textbox_M_Vx
            // 
            this.Textbox_M_Vx.Enabled = false;
            this.Textbox_M_Vx.Location = new System.Drawing.Point(38, 130);
            this.Textbox_M_Vx.Name = "Textbox_M_Vx";
            this.Textbox_M_Vx.Size = new System.Drawing.Size(100, 20);
            this.Textbox_M_Vx.TabIndex = 19;
            // 
            // Textbox_M_Vy
            // 
            this.Textbox_M_Vy.Enabled = false;
            this.Textbox_M_Vy.Location = new System.Drawing.Point(38, 156);
            this.Textbox_M_Vy.Name = "Textbox_M_Vy";
            this.Textbox_M_Vy.Size = new System.Drawing.Size(100, 20);
            this.Textbox_M_Vy.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Vx";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Vy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "ω";
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
            // replayBtn
            // 
            this.replayBtn.Location = new System.Drawing.Point(17, 64);
            this.replayBtn.Name = "replayBtn";
            this.replayBtn.Size = new System.Drawing.Size(75, 23);
            this.replayBtn.TabIndex = 0;
            this.replayBtn.Text = "Replay";
            this.replayBtn.UseVisualStyleBackColor = true;
            this.replayBtn.Click += new System.EventHandler(this.replayBtn_Click);
            // 
            // fullPlayBtn
            // 
            this.fullPlayBtn.Location = new System.Drawing.Point(17, 93);
            this.fullPlayBtn.Name = "fullPlayBtn";
            this.fullPlayBtn.Size = new System.Drawing.Size(75, 23);
            this.fullPlayBtn.TabIndex = 1;
            this.fullPlayBtn.Text = "fullPlayBtn";
            this.fullPlayBtn.UseVisualStyleBackColor = true;
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(98, 79);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(75, 23);
            this.pauseBtn.TabIndex = 2;
            this.pauseBtn.Text = "pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(25, 23);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(130, 20);
            this.pathText.TabIndex = 3;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Textbox_Auto_W;
        private System.Windows.Forms.TextBox Textbox_Auto_Vy;
        private System.Windows.Forms.TextBox Textbox_Auto_Vx;
        private System.Windows.Forms.GroupBox Group_Auto;
        private System.Windows.Forms.GroupBox Group_Manual;
        private System.Windows.Forms.TextBox Textbox_M_Z;
        private System.Windows.Forms.TextBox Textbox_M_X;
        private System.Windows.Forms.TextBox Textbox_M_Y;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Textbox_M_W;
        private System.Windows.Forms.TextBox Textbox_M_Vx;
        private System.Windows.Forms.TextBox Textbox_M_Vy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
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
    }
}

