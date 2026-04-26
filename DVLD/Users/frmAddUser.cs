using DVLD.Global;
using DVLD.People.Controls;
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

namespace DVLD.Users
{
    public partial class frmAddUser : Form
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;
       private int _UserID=-1;

        private void _AcceptButtons()
        {
            this.AcceptButton = btnSave;
            this.CancelButton = btnClose;
        }
        public int UserID
        {

            get { return _UserID; }


            set
            {

                _UserID = value;
                if (_UserID != -1)
                {
                    _Mode = enMode.Update;
                   // _LoadData();
                }
            }
        }
        public clsUser _User;
        public frmAddUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _User = new clsUser();

        }
        public frmAddUser( int UserID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _UserID = UserID;
        }

        private void _SetupUIforUnderlineEffect()
        {
            clsUICustomization.LinkUnderlineWithTextBox(txtUserName, pnlUserName);
            clsUICustomization.LinkUnderlineWithTextBox(txtPassword, pnlPassword);
            clsUICustomization.LinkUnderlineWithTextBox(txtConfirmPassword, pnlConfirmPass);
        }

        private clsUser GetUserInfo() {

             _User.PersonID=ctrlPersonInfoWithFilter1.PersonID;

            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive= cbIsActive.Checked;
            return _User;
            
        }


        private void setErrorProvidor() {

            bool isUserNameEmpty = string.IsNullOrWhiteSpace(txtUserName.Text);
            clsUICustomization.SetErrorProvider(txtUserName, errorProvider1, isUserNameEmpty, "UserName Reqiured");
            bool isPasswordEmpty = string.IsNullOrWhiteSpace(txtPassword.Text);
            clsUICustomization.SetErrorProvider(txtPassword, errorProvider1, isPasswordEmpty, "Password Required");
           // clsUICustomization.SetErrorProvider(txtConfirmPassword, errorProvider1, "Confirm Password Required");
        }
        private bool _IsValidateInput()
        {
            bool isValid = true;

            isValid &= _ValidateUserName();
            isValid &= _ValidatePassword();
            isValid &= _ValidateConfirmPassword();

            return isValid;
        }

        private bool _ValidateUserName()
        {
            return clsUICustomization.SetErrorProvider(
                txtUserName,
                errorProvider1,
                string.IsNullOrWhiteSpace(txtUserName.Text),
                "UserName Required");
        }

        private bool _ValidatePassword()
        {
            return clsUICustomization.SetErrorProvider(
                txtPassword,
                errorProvider1,
                string.IsNullOrWhiteSpace(txtPassword.Text),
                "Password Required");
        }

        private bool _ValidateConfirmPassword()
        {
            if (!clsUICustomization.SetErrorProvider(
                txtConfirmPassword,
                errorProvider1,
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text),
                "Confirm Password Required"))
            {
                return false;
            }

            return clsUICustomization.SetErrorProvider(
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
            txtUserName.Validating += txtUserName_Validating;
            txtPassword.Validating += txtPassword_Validating;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
        }

        private void ctrlPersonInfoWithFilter1_Load(object sender, EventArgs e)
        {
            setErrorProvidor();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsValidateInput())

            {
                MessageBox.Show("Please, fill in all required fields and ensure passwords match.");
               
                
                return;
            }
            clsUser user = GetUserInfo();

          
            if (user.Save())
            {
                MessageBox.Show("User saved successfully.");
                _UserID = user.userID;
                lblUserID.Text = user.userID.ToString();

            }
            else
            {
                MessageBox.Show("Failed to save user.");
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

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



