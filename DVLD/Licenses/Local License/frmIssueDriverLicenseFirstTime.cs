using DVLD_BusinessLayer;
using Syncfusion.Windows.Forms.Tools;
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

    public partial class frmIssueDriverLicenseFirstTime : Form
    {
       
    private int _LocalDrivingLicenseApplicationID;
    private clsLocalDrivingLicenseApplication _LDLApp;
        
        public frmIssueDriverLicenseFirstTime(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();

            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;


        }

        private void frmIssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        {
            _LDLApp=clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenseApplicationID);


            if (_LDLApp == null)
            {
                MessageBox.Show("Local Driving License Application not found.");
                Close();
                return;
            }


            if(_LDLApp.Application.IsCanceled())
            {
                MessageBox.Show("The Applicatin ia Cancelled", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            if (!_LDLApp.PassedAllTests())
            {

                MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            int LicenseID = _LDLApp.GetActiveLicenseID();
            if (LicenseID != -1)
            {

                MessageBox.Show("Person already has License before with License ID=" + LicenseID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            }
            ctrlAppBasicInfo1.LoadApplicationInfo(_LDLApp.Application.ApplicationID);
            ctrlDrivingLicenseInfo1.LoadLocalDrivingLicenseAppInfo(_LDLApp);

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int LicenseID = -1;
            LicenseID= _LDLApp.IssuedLicenseFirstTime(txtNote.Text,clsCurrentUser.User.userID);

            if (LicenseID != -1)
            {
                MessageBox.Show("License Issued Successfully with License ID = " + LicenseID.ToString(),
                    "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            else
            {
                MessageBox.Show("License Was not Issued ! ",
                 "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
