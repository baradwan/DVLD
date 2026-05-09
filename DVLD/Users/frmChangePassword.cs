using DVLD.Global;
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
    public partial class frmChangePassword : Form
    {
        int _UserID;
        clsUser _User = null;
        public frmChangePassword()
        {
            InitializeComponent();
        }

        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        private bool _IsCurrentPasswordValid()
        {
            bool IsCurrentPasswordValid = txtCurrentPassword.Text.Trim() == _User.Password;


            clsUICustomization.SetErrorProvider(txtCurrentPassword, errorProvider1, !IsCurrentPasswordValid, "Current password is incorrect.");
            return IsCurrentPasswordValid;
        }

        private bool _IsNewPasswordValid()
        {
            bool IsNewPasswordValid = !string.IsNullOrWhiteSpace(txtNewPassword.Text) && txtNewPassword.Text.Trim() != _User.Password;
            clsUICustomization.SetErrorProvider(txtNewPassword, errorProvider1, !IsNewPasswordValid, "New password cannot be empty or the same as the current password.");
            return IsNewPasswordValid;
        }
        private bool _IsConfirmPasswordValid()
        {
            bool IsPassWordEmpty = string.IsNullOrWhiteSpace(txtConfirmPassword.Text);
            bool IsConfirmPasswordValid = txtNewPassword.Text.Trim() == txtConfirmPassword.Text.Trim();
            clsUICustomization.SetErrorProvider(txtConfirmPassword, errorProvider1, !IsConfirmPasswordValid, "Confirm password does not match the new password.");
            clsUICustomization.SetErrorProvider(txtConfirmPassword, errorProvider1, IsPassWordEmpty, "Confirm password cannot be empty.");

            return IsConfirmPasswordValid && !IsPassWordEmpty;
        }

        private bool _IsAllPasswordsValid()
        {
            return _IsCurrentPasswordValid() && _IsNewPasswordValid() && _IsConfirmPasswordValid();
        }

        private void ctrlUserInfoCard1_Load(object sender, EventArgs e)
        {
            _User = clsUser.Find(_UserID);
            ctrlUserInfoCard1.LoadUserInfo(_User);
            txtCurrentPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            _IsAllPasswordsValid();
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            _IsAllPasswordsValid();
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            _IsAllPasswordsValid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!_IsAllPasswordsValid())
            {
                MessageBox.Show(
                    "Please make sure all password fields are valid.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (MessageBox.Show(
                "Are you sure you want to change the password?",
                "Confirm Change Password",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                return;
            }

            _User.Password = txtNewPassword.Text.Trim();

            if (_User.Save())
            {
                MessageBox.Show(
                    "Password changed successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Failed to change password.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtCurrentPassword.UseSystemPasswordChar = false;
                txtNewPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;

            }
            else
            {
                txtCurrentPassword.UseSystemPasswordChar = true;
                txtNewPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }
    }
}


