using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rtChart;
using System.Diagnostics;

namespace kaycHarttest
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayChart kay = new kayChart(chart1, 60);
            kay.serieName = "Series1";
            Task.Factory.StartNew(() =>
            {
                kay.updateChart(updatecpu, 1000);
            });
            button1.Enabled = false;
        }

        PerformanceCounter CPUcounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        private double updatecpu()
        {
            return CPUcounter.NextValue();
        }
    }
}
