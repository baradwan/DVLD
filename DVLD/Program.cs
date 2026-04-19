using System;
using System.Windows.Forms;
using DVLD.People;
using DVLD.Users;


// --- هذه هي الأسطر الناقصة التي ستزيل الخطوط الحمراء ---
using Syncfusion.WinForms.Controls; // لاستخدام SfSkinManager
using Syncfusion.WinForms.Themes;   // لاستخدام Office2019Theme

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
            Application.Run(new frmAddUser ());
        }
    }
}