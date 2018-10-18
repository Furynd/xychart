namespace Motor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.setPoint_txt = new System.Windows.Forms.TextBox();
            this.kI_txt = new System.Windows.Forms.TextBox();
            this.kD_txt = new System.Windows.Forms.TextBox();
            this.kP_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Receive_btn = new System.Windows.Forms.Button();
            this.Send_btn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Set_point";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Motor_data";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(485, 316);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // setPoint_txt
            // 
            this.setPoint_txt.Location = new System.Drawing.Point(550, 62);
            this.setPoint_txt.Name = "setPoint_txt";
            this.setPoint_txt.Size = new System.Drawing.Size(100, 20);
            this.setPoint_txt.TabIndex = 1;
            this.setPoint_txt.Text = "70";
            // 
            // kI_txt
            // 
            this.kI_txt.Location = new System.Drawing.Point(550, 158);
            this.kI_txt.Name = "kI_txt";
            this.kI_txt.Size = new System.Drawing.Size(100, 20);
            this.kI_txt.TabIndex = 2;
            // 
            // kD_txt
            // 
            this.kD_txt.Location = new System.Drawing.Point(550, 209);
            this.kD_txt.Name = "kD_txt";
            this.kD_txt.Size = new System.Drawing.Size(100, 20);
            this.kD_txt.TabIndex = 4;
            // 
            // kP_txt
            // 
            this.kP_txt.Location = new System.Drawing.Point(550, 107);
            this.kP_txt.Name = "kP_txt";
            this.kP_txt.Size = new System.Drawing.Size(100, 20);
            this.kP_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Set_Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "kP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "kI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "kD";
            // 
            // Receive_btn
            // 
            this.Receive_btn.Location = new System.Drawing.Point(550, 247);
            this.Receive_btn.Name = "Receive_btn";
            this.Receive_btn.Size = new System.Drawing.Size(75, 23);
            this.Receive_btn.TabIndex = 9;
            this.Receive_btn.Text = "Receive";
            this.Receive_btn.UseVisualStyleBackColor = true;
            this.Receive_btn.Click += new System.EventHandler(this.Receive_btn_Click);
            // 
            // Send_btn
            // 
            this.Send_btn.Location = new System.Drawing.Point(550, 286);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(75, 23);
            this.Send_btn.TabIndex = 11;
            this.Send_btn.Text = "Send";
            this.Send_btn.UseVisualStyleBackColor = true;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 345);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.Receive_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kD_txt);
            this.Controls.Add(this.kP_txt);
            this.Controls.Add(this.kI_txt);
            this.Controls.Add(this.setPoint_txt);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox setPoint_txt;
        private System.Windows.Forms.TextBox kI_txt;
        private System.Windows.Forms.TextBox kD_txt;
        private System.Windows.Forms.TextBox kP_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Receive_btn;
        private System.Windows.Forms.Button Send_btn;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

