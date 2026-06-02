using DVLD.Applications.Local_Driving_License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Main.Controls
{
    public partial class ctrlManageApplication : UserControl
    {
        public ctrlManageApplication()
        {
            InitializeComponent();
        }

        private void btnLDLApllication_Click(object sender, EventArgs e)
        {
            frmListDrivingLicenseApp frm =new frmListDrivingLicenseApp();
            frm.ShowDialog();
        }
    }
}
