using DVLD.Global;
using DVLD.People.Controls;
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

namespace DVLD.Users
{
    public partial class frmAddUpdateUser : Form
    {

        public event Action<clsUser> UserSaved;
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;
        private int _UserID = -1;
        private bool _AllowTabChange = false;
        private void _AcceptButtons()
        {
            this.AcceptButton = btnSave;
            this.CancelButton = btnClose;
        }
        public int UserID
        {

            get { return _UserID; }


            //set
            //{

            //    _UserID = value;
            //    if (_UserID != -1)
            //    {
            //        _Mode = enMode.Update;
            //        _LoadData();
            //    }
            //}
        }
        public clsUser _User;
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _DefaultButtons();
            ctrlPersonInfoWithFilter1.OnPersonSelected += ctrlPersonInfoWithFilter1_OnPersonSelected;// subscribe

            _Mode = enMode.AddNew;
            _User = new clsUser();

        }
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _DefaultButtons();
            ctrlPersonInfoWithFilter1.OnPersonSelected += ctrlPersonInfoWithFilter1_OnPersonSelected;// subscribe

            _UserID = UserID;
            if(_UserID != -1)
            {
                _Mode = enMode.Update;
                ctrlPersonInfoWithFilter1.VisibleSearchControls(false);
                lblUserFormTitle.Text="Update User";
                _LoadData();
            }
        }

        private void _DefaultButtons() {

            btnNext.Enabled = false;
            btnSave.Enabled = false;



        }
        private bool _toEnableSaveButton()
        {
           return  ctrlPersonInfoWithFilter1.PersonID > 0 &&
        !string.IsNullOrWhiteSpace(txtUserName.Text) &&
        !string.IsNullOrWhiteSpace(txtPassword.Text) &&
        !string.IsNullOrWhiteSpace(txtConfirmPassword.Text) &&
        txtPassword.Text.Trim() == txtConfirmPassword.Text.Trim();
        
        }

        private void _RefreshBtnSave()
        {
            btnSave.Enabled = _toEnableSaveButton(); 
        }
        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);
            if (_User == null)
                return;

            lblUserID.Text = _UserID.ToString();
            txtUserName.Text=_User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            cbIsActive.Checked = _User.IsActive;
            ctrlPersonInfoWithFilter1.LoadPersonInfo(_User.PersonID);

        }
        private void _SetupUIforUnderlineEffect()
        {
            clsUICustomization.LinkUnderlineWithTextBox(txtUserName, pnlUserName);
            clsUICustomization.LinkUnderlineWithTextBox(txtPassword, pnlPassword);
            clsUICustomization.LinkUnderlineWithTextBox(txtConfirmPassword, pnlConfirmPass);
        }

        private clsUser GetUserInfo() {

            _User.PersonID = ctrlPersonInfoWithFilter1.PersonID;

            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = cbIsActive.Checked;
            return _User;

        }


        //private void setErrorProvidor() {

        //    bool isUserNameEmpty = string.IsNullOrWhiteSpace(txtUserName.Text);
        //    clsUICustomization.SetErrorProvider(txtUserName, errorProvider1, isUserNameEmpty, "UserName Reqiured");
        //    bool isPasswordEmpty = string.IsNullOrWhiteSpace(txtPassword.Text);
        //    clsUICustomization.SetErrorProvider(txtPassword, errorProvider1, isPasswordEmpty, "Password Required");
        //    // clsUICustomization.SetErrorProvider(txtConfirmPassword, errorProvider1, "Confirm Password Required");
        //}
        private bool _IsValidateInput()
        {
            bool isValid = true;
            
            isValid &= _ValidateUserName();
            isValid &= _ValidatePassword();
            isValid &= _ValidateConfirmPassword();
          //  isValid &= toEnableSaveButton;

            return isValid;
        }

        private bool _ValidateUserName()
        {
            bool isUserExist = clsUser.IsUserExist(txtUserName.Text.Trim());
            bool IsUserSameAsExisting =  txtUserName.Text.Trim() == _User.UserName;
            bool isUserNameNotEmbpty = clsUICustomization.SetErrorProviderAndReturnValidity(txtUserName, errorProvider1,
                string.IsNullOrWhiteSpace(txtUserName.Text), "UserName Required");

            if (!isUserNameNotEmbpty)
            {

                return false;
            }

            if (_Mode == enMode.Update && IsUserSameAsExisting)
            {
                return true;
            }

            bool isUserNotExists = clsUICustomization.SetErrorProviderAndReturnValidity(txtUserName, errorProvider1,
               isUserExist, "UserName Already Exists");

            return   isUserNotExists;
        }

        private bool _ValidatePassword()
        {
            return clsUICustomization.SetErrorProviderAndReturnValidity(
                txtPassword,
                errorProvider1,
                string.IsNullOrWhiteSpace(txtPassword.Text),
                "Password Required");
        }

        private bool _ValidateConfirmPassword()
        {
            if (!clsUICustomization.SetErrorProviderAndReturnValidity(
                txtConfirmPassword,
                errorProvider1,
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text),
                "Confirm Password Required"))
            {
                return false;
            }

            return clsUICustomization.SetErrorProviderAndReturnValidity(
                txtConfirmPassword,
                errorProvider1,
                txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim(),
                "Passwords do not match");
        }
        // Events //
        private void frmAddUser_Load(object sender, EventArgs e)
        {
           

            _SetupUIforUnderlineEffect();
            _AcceptButtons();
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

        }

        private void ctrlPersonInfoWithFilter1_Load(object sender, EventArgs e)
        {
            // setErrorProvidor();
            //_DefaultValues();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsValidateInput())

            {
                MessageBox.Show(
                    "Please fill in all required fields and ensure passwords match.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }
            clsUser user = GetUserInfo();


            if (user.Save())
            {

                MessageBox.Show(
                    "User saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                    UserSaved?.Invoke(user);
                if (_Mode == enMode.AddNew)
                   clsUserEvents.NotifyUserAdded(user.userID);
                else
                    clsUserEvents.NotifyUserUpdated(user.userID);
                _UserID = user.userID;
                lblUserID.Text = user.userID.ToString();
                _Mode = enMode.Update;
            }
            else
            {
                MessageBox.Show(
                    "Failed to save user.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            _ValidateConfirmPassword();
            


        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            _ValidateUserName();
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

            _ValidatePassword();
    }


    

        private void tcPersonInfo_Selecting(object sender, TabControlCancelEventArgs e)
        {

            if (!_AllowTabChange)
                e.Cancel = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if(clsUser.IsUserExistByPersonID(ctrlPersonInfoWithFilter1.PersonID))
            {
                if (!(_Mode == enMode.Update && ctrlPersonInfoWithFilter1.PersonID == _User.PersonID))
                {

                    MessageBox.Show("This person is already associated with a user account. Please select a different person.", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                return;
                }

            }

            
            _AllowTabChange = true;
            tcPersonInfo.SelectedTab = tcPersonInfo.TabPages["tpLoginInfo"];
            _AllowTabChange = false;


            
        }

        private void ctrlPersonInfoWithFilter1_OnPersonSelected(int PersonID)
        {

            if(PersonID > 0)
            {
                btnNext.Enabled = true;
            }
        }

        private void btnPervoius_Click(object sender, EventArgs e)
        {
            _AllowTabChange = true;
            tcPersonInfo.SelectedTab = tcPersonInfo.TabPages["tpPersonInfo"];
            _AllowTabChange = false;
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar=false;
                txtConfirmPassword.UseSystemPasswordChar=false;

            }else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }
        

        private void tpLoginInfo_Click(object sender, EventArgs e)
        {


        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            _RefreshBtnSave();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            _RefreshBtnSave();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            _RefreshBtnSave();
        }
    }
}



