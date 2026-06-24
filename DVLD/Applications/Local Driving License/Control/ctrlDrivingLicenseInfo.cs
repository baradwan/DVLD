using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.Local_Driving_License.Control
{

    public partial class ctrlDrivingLicenseInfo : UserControl
    {
    
        clsLocalDrivingLicenseApplication _LDLApp=null;
      

        public ctrlDrivingLicenseInfo()
        {
            InitializeComponent();
           

        }

        public void LoadLocalDrivingLicenseAppInfo(clsLocalDrivingLicenseApplication LDLApp) {
            _LDLApp = LDLApp    ;

            if (_LDLApp == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();
                MessageBox.Show("No Application with ID = " + LDLApp.LocalDrivingLicenseApplicationID, "Local Driving License Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _FillLDLApplicationInformation();
        }
        private void _FillLDLApplicationInformation()
        {
            lblLocalDrivingLicenseApplicationID.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedFor.Text =clsLicenseClass.Find(_LDLApp.LicenseClassID).ClassName;
            lblPassedTest .Text= "";


        }

        private void _ResetLocalDrivingLicenseApplicationInfo()
        {
            
            
            lblLocalDrivingLicenseApplicationID.Text = "--";
            lblAppliedFor.Text = "---";


        }
    }
}
