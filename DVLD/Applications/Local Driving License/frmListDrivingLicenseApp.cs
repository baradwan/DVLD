using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Global;
using DVLD_Global.Events;
namespace DVLD.Applications.Local_Driving_License
{
    public partial class frmListDrivingLicenseApp : Form
    {
        public frmListDrivingLicenseApp()
        {
            InitializeComponent();
        }

      

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            ctrlListLocalDriving1.CountApplicationsChanged += _UpdateCount;
            clsLDLApplicationEvents.LocalDrivingLicenseApplicationAdded += OnLocalApplicationChanged;
            clsLDLApplicationEvents.LocalDrivingLicenseApplicationUpdated += OnLocalApplicationChanged;
            clsLDLApplicationEvents.LocalDrivingLicenseApplicationDeleted += OnLocalApplicationChanged;

        }
        private void _UpdateCount(int count)
        {
            lblRecordValue.Text = count.ToString();
        }
        private void OnLocalApplicationChanged(int localDrivingLicenseApplicationID)
        {
            ctrlListLocalDriving1.RefreshList();
        }

        private void frmListDrivingLicenseApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctrlListLocalDriving1.CountApplicationsChanged -= _UpdateCount;
            clsLDLApplicationEvents.LocalDrivingLicenseApplicationAdded -= OnLocalApplicationChanged;
            clsLDLApplicationEvents.LocalDrivingLicenseApplicationUpdated -= OnLocalApplicationChanged;
            clsLDLApplicationEvents.LocalDrivingLicenseApplicationDeleted -= OnLocalApplicationChanged;
        }

        private void btnAddLDAPP_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }
    }
}
