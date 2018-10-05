using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class printdata : Form
    {
        private int readType = 0;
        private StreamReader sR;
        public printdata()
        {
            InitializeComponent();
            Testbtn.Enabled = false;
            sR = new StreamReader("test.txt");
        }

        private void Testbtn_Click(object sender, EventArgs e)
        {
            if(readType == 1)
            {
                
            }
            else if(readType == 2)
            {

            }
        }

        private void Select_devices_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Testbtn.Enabled = true;
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                FrmMy = this;
                Startup();
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            readType = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            readType = 2;
        }

        //[STAThread]
        //internal static void Main() { Application.Run(new Form1()); }
        //private static Form1 _transDefaultFormFrmMain;
        //internal static Form1 TransDefaultFormFrmMain
        //{
        //    get
        //    {
        //        if (_transDefaultFormFrmMain == null)
        //        {
        //            _transDefaultFormFrmMain = new Form1();
        //        }
        //        return _transDefaultFormFrmMain;
        //    }
        //}

    }
}
