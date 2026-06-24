using DVLD_BusinessLayer;
using DVLD_Global.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class frmAddUpdateLocalDrivingLicenseApplication : Form
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;

        private clsLocalDrivingLicenseApplication _LDLApplication;

       // private int _LocalDrivingLicenseApplicationID = -1;

        private int _LDLApplicationID = -1;   ///**///

        
        private bool _AllowTabChange = false;

        


        public frmAddUpdateLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            _DefaultButtons();
            ctrlPersonInfoWithFilter1.OnPersonSelected += ctrlPersonInfoWithFilter1_OnPersonSelected;// subscribe

            _LDLApplication = new clsLocalDrivingLicenseApplication();
           
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateLocalDrivingLicenseApplication(int LDLApplicationID)
        {
            InitializeComponent();
            _DefaultButtons();
            _LDLApplicationID = LDLApplicationID;
            ctrlPersonInfoWithFilter1.OnPersonSelected += ctrlPersonInfoWithFilter1_OnPersonSelected;// subscribe
            if (LDLApplicationID != 0)
            {
                ctrlPersonInfoWithFilter1.VisibleSearchControls(false);
                lblFormTitle.Text = "Update Local Driving License Application";
                _Mode = enMode.Update;

            }
        }

        private void _LoadLicenseClassOPtions()
        {

            cmbLicenseClass.DataSource = clsLicenseClass.ListAllLicenseClass();
            cmbLicenseClass.DisplayMember = "ClassName";
            cmbLicenseClass.ValueMember = "LicenseClassID";
            if (_Mode == enMode.AddNew)
                cmbLicenseClass.SelectedValue = 3;
        }
        private void _AcceptButtons()
        {
            this.AcceptButton = btnSave;
            this.CancelButton = btnClose;
        }
        private void _DefaultButtons()
        {
            btnNext.Enabled = false;
            btnSave.Enabled = false;
        }
        private bool _toEnableSaveButton()
        {
            return tcApplicationInfo.SelectedTab == tcApplicationInfo.TabPages["tpApplicationInfo"]
            && _LDLApplication.Application != null
            && _LDLApplication.Application.PersonID > 0
            && cmbLicenseClass.SelectedValue != null;
        }
        private void _RefreshBtnSave()
        {
            btnSave.Enabled = _toEnableSaveButton();
        }

        

        private Byte _GetSelectedLicenseClassID()
        {
            return Convert.ToByte(cmbLicenseClass.SelectedValue);
        }

        private void _LoadDataToTheForm()
        {

            if (_LDLApplication.Application == null)
                return;

            lblAppDateValue.Text = _LDLApplication.Application.ApplicationDate.ToShortDateString();
            lblAppFeesValue.Text = _LDLApplication.Application.PaidFees.ToString("C");
            lblCreadtedByUserValue.Text = CurrentUser.User.UserName;
        }
        private void _LoadData()
        {
            _LDLApplication = clsLocalDrivingLicenseApplication.Find(_LDLApplicationID);

            if (_LDLApplication == null)
            {
                MessageBox.Show(
                    "No Local Driving License Application found with ID = " + _LDLApplicationID,
                    "Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close();
                return;
            }

            lblDLAppIDValue.Text =_LDLApplication.LocalDrivingLicenseApplicationID.ToString();

            ctrlPersonInfoWithFilter1.LoadPersonInfo( _LDLApplication.Application.PersonID);

           
            cmbLicenseClass.SelectedValue = _LDLApplication.LicenseClassID;
           

           

            lblAppDateValue.Text = _LDLApplication.Application.ApplicationDate.ToShortDateString();

            lblAppFeesValue.Text =  _LDLApplication.Application.PaidFees.ToString("C");

            lblCreadtedByUserValue.Text = clsUser.Find( _LDLApplication.Application.CreatedByUserID).UserName;
        }

        
        
        // //////////////////////////////////////EVENTS ///////////////////////////////////
        private void ctrlPersonInfoWithFilter1_OnPersonSelected(int PersonID)
        {

            if (PersonID > 0)
            {
                btnNext.Enabled = true;
            }


            if (_Mode == enMode.AddNew)
            {
                _LDLApplication.PrepareNewLocalDrivingLicenseApplication(PersonID, _GetSelectedLicenseClassID(), CurrentUser.User.userID);


                _LoadDataToTheForm();
            }
        }

        private void frmAddUpdateLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _LoadLicenseClassOPtions();
            if (_Mode == enMode.Update)
            {
                _LoadData();
            }
            _AcceptButtons();

        }

        private bool IsHasSameLicenseClass()
        {
           
             
            return _LDLApplication.LicenseClassID == _GetSelectedLicenseClassID();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            
          
            _LDLApplication.LicenseClassID = _GetSelectedLicenseClassID();

            if (_LDLApplication.Save())
            {

                MessageBox.Show("Local Driving License Application saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LDLApplicationID = _LDLApplication.LocalDrivingLicenseApplicationID;
              lblDLAppIDValue.Text = _LDLApplicationID.ToString();

                if (_Mode == enMode.AddNew)
                    clsLDLApplicationEvents.NotifyLocalDrivingLicenseApplicationAdded(_LDLApplication.LocalDrivingLicenseApplicationID);
                else
                    clsLDLApplicationEvents.NotifyLocalDrivingLicenseApplicationUpdated(_LDLApplication.LocalDrivingLicenseApplicationID);

                _Mode =enMode.Update;


            }
            else
            {
                MessageBox.Show("An error occurred while saving the Local Driving License Application. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

      

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _AllowTabChange = true;
            tcApplicationInfo.SelectedTab = tcApplicationInfo.TabPages["tpPersonInfo"];
            _AllowTabChange = false;

        }

        private void tcApplicationInfo_TabIndexChanged(object sender, EventArgs e)
        {
            
              

        }

        private void tcApplicationInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

            _RefreshBtnSave();
        }

        private void cmbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
           // _LDLApplication.LicenseClassID = _GetSelectedLicenseClassID();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            _AllowTabChange = true;
            tcApplicationInfo.SelectedTab = tcApplicationInfo.TabPages["tpApplicationInfo"];
            _AllowTabChange = false;
        }

        private void tcApplicationInfo_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!_AllowTabChange)
                e.Cancel = true;
        }
    }
}
 