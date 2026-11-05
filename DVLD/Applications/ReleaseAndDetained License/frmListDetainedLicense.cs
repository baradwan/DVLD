using DVLD.Users.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.ReleaseAndDetained_License
{
    public partial class frmListDetainedLicense : Form
    {
        public frmListDetainedLicense()
        {
            InitializeComponent();

            ctrlListDetainedLIcense1.CountLicensesChanged += CtrlListDetainedLIcense1_CountLicensesChanged;
        }

        private void CtrlListDetainedLIcense1_CountLicensesChanged(int count)
        {
             lblRecordValue.Text = count.ToString();
        }

        private void OnLicenseChanged(int user)
        {
           // ctrlListUsers1.RefreshUsersList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
