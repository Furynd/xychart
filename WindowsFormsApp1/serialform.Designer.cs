namespace Serial_tutorial
{
    partial class Serial_Comm
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
            this.Transmit = new System.Windows.Forms.Button();
            this.Select_Baudrate = new System.Windows.Forms.ComboBox();
            this.Available_Ports = new System.Windows.Forms.ComboBox();
            this.Setup = new System.Windows.Forms.GroupBox();
            this.Serial_Transmit = new System.Windows.Forms.GroupBox();
            this.Transmit_data = new System.Windows.Forms.TextBox();
            this.Serial_Receive = new System.Windows.Forms.GroupBox();
            this.Received_data = new System.Windows.Forms.TextBox();
            this.Receive = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Setup.SuspendLayout();
            this.Serial_Transmit.SuspendLayout();
            this.Serial_Receive.SuspendLayout();
            this.SuspendLayout();
            // 
            // Transmit
            // 
            this.Transmit.Location = new System.Drawing.Point(24, 63);
            this.Transmit.Name = "Transmit";
            this.Transmit.Size = new System.Drawing.Size(161, 23);
            this.Transmit.TabIndex = 0;
            this.Transmit.Text = "Transmit";
            this.Transmit.UseVisualStyleBackColor = true;
            this.Transmit.Click += new System.EventHandler(this.Transmit_Click);
            // 
            // Select_Baudrate
            // 
            this.Select_Baudrate.FormattingEnabled = true;
            this.Select_Baudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.Select_Baudrate.Location = new System.Drawing.Point(296, 41);
            this.Select_Baudrate.Name = "Select_Baudrate";
            this.Select_Baudrate.Size = new System.Drawing.Size(121, 21);
            this.Select_Baudrate.TabIndex = 1;
            this.Select_Baudrate.SelectionChangeCommitted += new System.EventHandler(this.Select_Baudrate_SelectionChangeCommitted);
            // 
            // Available_Ports
            // 
            this.Available_Ports.FormattingEnabled = true;
            this.Available_Ports.Location = new System.Drawing.Point(24, 41);
            this.Available_Ports.Name = "Available_Ports";
            this.Available_Ports.Size = new System.Drawing.Size(121, 21);
            this.Available_Ports.TabIndex = 2;
            this.Available_Ports.SelectionChangeCommitted += new System.EventHandler(this.Available_Ports_SelectionChangeCommitted);
            // 
            // Setup
            // 
            this.Setup.Controls.Add(this.Select_Baudrate);
            this.Setup.Controls.Add(this.Available_Ports);
            this.Setup.Location = new System.Drawing.Point(20, 20);
            this.Setup.Name = "Setup";
            this.Setup.Size = new System.Drawing.Size(440, 90);
            this.Setup.TabIndex = 3;
            this.Setup.TabStop = false;
            this.Setup.Text = "Setup";
            // 
            // Serial_Transmit
            // 
            this.Serial_Transmit.Controls.Add(this.Transmit_data);
            this.Serial_Transmit.Controls.Add(this.Transmit);
            this.Serial_Transmit.Location = new System.Drawing.Point(21, 122);
            this.Serial_Transmit.Name = "Serial_Transmit";
            this.Serial_Transmit.Size = new System.Drawing.Size(200, 100);
            this.Serial_Transmit.TabIndex = 4;
            this.Serial_Transmit.TabStop = false;
            this.Serial_Transmit.Text = "Serial Transmit";
            // 
            // Transmit_data
            // 
            this.Transmit_data.Location = new System.Drawing.Point(24, 37);
            this.Transmit_data.Name = "Transmit_data";
            this.Transmit_data.Size = new System.Drawing.Size(161, 20);
            this.Transmit_data.TabIndex = 0;
            // 
            // Serial_Receive
            // 
            this.Serial_Receive.Controls.Add(this.Received_data);
            this.Serial_Receive.Controls.Add(this.Receive);
            this.Serial_Receive.Location = new System.Drawing.Point(258, 123);
            this.Serial_Receive.Name = "Serial_Receive";
            this.Serial_Receive.Size = new System.Drawing.Size(200, 100);
            this.Serial_Receive.TabIndex = 5;
            this.Serial_Receive.TabStop = false;
            this.Serial_Receive.Text = "Serial Receive";
            // 
            // Received_data
            // 
            this.Received_data.Location = new System.Drawing.Point(21, 51);
            this.Received_data.Multiline = true;
            this.Received_data.Name = "Received_data";
            this.Received_data.Size = new System.Drawing.Size(158, 35);
            this.Received_data.TabIndex = 1;
            // 
            // Receive
            // 
            this.Receive.Location = new System.Drawing.Point(18, 22);
            this.Receive.Name = "Receive";
            this.Receive.Size = new System.Drawing.Size(161, 23);
            this.Receive.TabIndex = 0;
            this.Receive.Text = "Receive";
            this.Receive.UseVisualStyleBackColor = true;
            this.Receive.Click += new System.EventHandler(this.Receive_Click);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(21, 241);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(200, 88);
            this.Log.TabIndex = 6;
            // 
            // Serial_Comm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Serial_Receive);
            this.Controls.Add(this.Serial_Transmit);
            this.Controls.Add(this.Setup);
            this.Name = "Serial_Comm";
            this.Text = "Serial_test";
            this.Setup.ResumeLayout(false);
            this.Serial_Transmit.ResumeLayout(false);
            this.Serial_Transmit.PerformLayout();
            this.Serial_Receive.ResumeLayout(false);
            this.Serial_Receive.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Select_Baudrate_SelectionChangeCommitted1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button Transmit;
        private System.Windows.Forms.ComboBox Select_Baudrate;
        private System.Windows.Forms.ComboBox Available_Ports;
        private System.Windows.Forms.GroupBox Setup;
        private System.Windows.Forms.GroupBox Serial_Transmit;
        private System.Windows.Forms.TextBox Transmit_data;
        private System.Windows.Forms.GroupBox Serial_Receive;
        private System.Windows.Forms.TextBox Received_data;
        private System.Windows.Forms.Button Receive;
        private System.Windows.Forms.TextBox Log;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

