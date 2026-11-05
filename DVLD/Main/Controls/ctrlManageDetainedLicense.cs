using DVLD.Applications.ReleaseAndDetained_License;
using DVLD.Licenses.Detain_License;
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
    public partial class ctrlManageDetainedLicense : UserControl
    {
        public ctrlManageDetainedLicense()
        {
            InitializeComponent();
        }

        private void btnManageDetainedLicense_Click(object sender, EventArgs e)
        {
            frmListDetainedLicense frm = new frmListDetainedLicense();
            frm.ShowDialog();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicenseApplication frm = new frmDetainLicenseApplication();
            frm.ShowDialog();
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }
    }
}
