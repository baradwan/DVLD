using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.International_License
{
    public partial class frmListInternationalApp : Form
    {
        public frmListInternationalApp()
        {
            InitializeComponent();
            ctrlListInternationalLicense1.CountLicensesChanged += CtrlListInternationalLicense1_CountLicensesChanged;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void CtrlListInternationalLicense1_CountLicensesChanged(int count)
        {
            lblRecordValue.Text = count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
