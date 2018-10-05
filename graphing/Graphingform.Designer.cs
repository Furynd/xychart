namespace Graphing_Tutorial
{
    partial class Graphing_Tutorial
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CPUChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.Port_Name = new System.Windows.Forms.ComboBox();
            this.Baud_Rate = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CPUChart)).BeginInit();
            this.SuspendLayout();
            // 
            // CPUChart
            // 
            chartArea1.Name = "ChartArea1";
            this.CPUChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CPUChart.Legends.Add(legend1);
            this.CPUChart.Location = new System.Drawing.Point(0, 0);
            this.CPUChart.Name = "CPUChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Enabled = false;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Serial_Data";
            this.CPUChart.Series.Add(series1);
            this.CPUChart.Series.Add(series2);
            this.CPUChart.Size = new System.Drawing.Size(489, 234);
            this.CPUChart.TabIndex = 0;
            this.CPUChart.Text = "CPUChart";
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(315, 244);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(75, 23);
            this.Start_btn.TabIndex = 1;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.Location = new System.Drawing.Point(414, 244);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(75, 23);
            this.Stop_btn.TabIndex = 2;
            this.Stop_btn.Text = "Stop";
            this.Stop_btn.UseVisualStyleBackColor = true;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // Port_Name
            // 
            this.Port_Name.FormattingEnabled = true;
            this.Port_Name.Location = new System.Drawing.Point(12, 246);
            this.Port_Name.Name = "Port_Name";
            this.Port_Name.Size = new System.Drawing.Size(121, 21);
            this.Port_Name.TabIndex = 3;
            this.Port_Name.SelectionChangeCommitted += new System.EventHandler(this.Port_Name_SelectionChangeCommitted);
            // 
            // Baud_Rate
            // 
            this.Baud_Rate.FormattingEnabled = true;
            this.Baud_Rate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.Baud_Rate.Location = new System.Drawing.Point(139, 246);
            this.Baud_Rate.Name = "Baud_Rate";
            this.Baud_Rate.Size = new System.Drawing.Size(121, 21);
            this.Baud_Rate.TabIndex = 4;
            this.Baud_Rate.SelectionChangeCommitted += new System.EventHandler(this.Baud_Rate_SelectionChangeCommitted);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(359, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(117, 155);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Graphing_Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 277);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Baud_Rate);
            this.Controls.Add(this.Port_Name);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.CPUChart);
            this.Name = "Graphing_Tutorial";
            this.Text = "Graphing";
            ((System.ComponentModel.ISupportInitialize)(this.CPUChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CPUChart;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.ComboBox Port_Name;
        private System.Windows.Forms.ComboBox Baud_Rate;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

