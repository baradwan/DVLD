using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;


using Syncfusion.WinForms.Themes;
using Syncfusion.WinForms.Core;
using DVLD.Users;


namespace DVLD
{
    public partial class frmMain  :SfForm
    {
        private object tableLayoutPanel;

        public frmMain()

        {
            InitializeComponent();
            Syncfusion.WinForms.Controls.SfSkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
            Syncfusion.WinForms.Controls.SfSkinManager.SetTheme(this, "Office2019Colorful");




             }

        private void sfButton1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ahmed Baredhwan");
            
        }

       

        private object GetTableLayoutPanel()
        {
            return tableLayoutPanel;
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            Form frm= new frmPeople();
            frm.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmListUser frm = new frmListUser();
            frm.ShowDialog();

        }
    }
}
