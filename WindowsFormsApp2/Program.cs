using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Program
    {
        internal static printdata FrmMy;
        ///// <summary>
        ///// The main entry point for the application.
        ///// </summary>
        [STAThread]
        public static void Main()
        {
            FrmMy = new printdata();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FrmMy);
        }
    }
}
