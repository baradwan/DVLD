using System;
using System.Windows.Forms;
using DVLD.Applications.ApplicationTypes;
using DVLD.Applications.Manage_Test_Types;
using DVLD.People;
using DVLD.Users;




namespace DVLD
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
           


            // أو PerMonitorV2
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain ());
        }
    }
}