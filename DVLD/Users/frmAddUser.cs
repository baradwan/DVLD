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
            _User.IsActive= cbIsActive.Checked?true:false;
            return _User;
            
        }


        private void setErrorProvidor() {

            clsUICustomization.SetErrorProvider(txtUserName, errorProvider1, "UserName Reqiured");
            clsUICustomization.SetErrorProvider(txtPassword, errorProvider1, "Password Required");
            clsUICustomization.SetErrorProvider(txtConfirmPassword, errorProvider1, "Confirm Password Required");
        }

       // Events //
        private void frmAddUser_Load(object sender, EventArgs e)
        {
            _SetupUIforUnderlineEffect();
        }

        private void ctrlPersonInfoWithFilter1_Load(object sender, EventArgs e)
        {
            setErrorProvidor();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;
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
            if(txtPassword.Text!=txtConfirmPassword.Text)
            {


                clsUICustomization.SetErrorProvider(txtConfirmPassword, errorProvider1, "Confirm Password does not match."); 


            }

        }
    }
}



