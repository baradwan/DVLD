using DVLD_BusinessLayer;
using DVLD_Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class frmLocalDrivingLicenseApplicationInfo : Form
    {
        private clsLocalDrivingLicenseApplication _LDLApp ;
        public frmLocalDrivingLicenseApplicationInfo(int LDLAppID)
        {
            InitializeComponent();
            clsPersonEvents.PersonUpdated += OnPersonUpdated;
            _LDLApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);


        }
        private void OnPersonUpdated(int personID)
        {
            if (_LDLApp == null || _LDLApp.Application == null)
                return;

            if (_LDLApp.Application.PersonID == personID)
            {
                ctrlAppBasicInfo1.LoadApplicationInfo(_LDLApp.Application.ApplicationID);
            }
        }
        private void ctrlDrivingLicenseInfo1_Load(object sender, EventArgs e)
        {

        }

        private void frmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            if (_LDLApp == null)
            {
                MessageBox.Show("Local Driving License Application not found.");
                Close();
                return;
            }
            ctrlAppBasicInfo1.LoadApplicationInfo(_LDLApp.Application.ApplicationID);
            ctrlDrivingLicenseInfo1.LoadLocalDrivingLicenseAppInfo(_LDLApp);
         

        }

        private void frmLocalDrivingLicenseApplicationInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsPersonEvents.PersonUpdated -= OnPersonUpdated;
        }
    }
    
}
