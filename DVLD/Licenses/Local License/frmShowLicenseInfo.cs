using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.Local_License
{
    public partial class frmShowLicenseInfo : Form
    {
        clsLicense _License;
        public frmShowLicenseInfo(clsLicense License)
        {
            InitializeComponent();

            _License = License;

        }

        public frmShowLicenseInfo(int LicenseID)
        {
            InitializeComponent();

            _License = clsLicense.Find(LicenseID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDeriverLicenseInfo1.LoadInfo(_License);
        }
    }
}
