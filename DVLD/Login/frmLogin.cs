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

namespace DVLD.Login
{
    public partial class frmLogin : Form
    {

        clsUser _User = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void _setupEffectUnderLine() {

            clsUICustomization.LinkUnderlineWithTextBox(txtUsername,pnlUserName, Color.Blue);
            clsUICustomization.LinkUnderlineWithTextBox(txtPassword, pnlPassword,Color.Blue);
        }

        private bool _CheckLogin() {
        
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            _User = clsUser.FindUserByUsernameAndPassword(username, password);
            return _User != null;

        }

        public bool GetLoginInfo() {
        string username="", password="";
            if (clsUtil.rememberMeWithInfo(ref username, ref password))
            {
                txtUsername.Text = username;
                txtPassword.Text = password;

                return true;
            }
            return false;
        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _setupEffectUnderLine();
            if(GetLoginInfo())
                cbRememberMe.Checked = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!_CheckLogin())
            {
                txtUsername.Focus();
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_User.IsActive)
            {
                MessageBox.Show("The user is not Active", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
             

            if(cbRememberMe.Checked)
            {
                clsUtil.RememberMe(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            }else
            {
                clsUtil.ClearRememberMe();
            }

            CurrentUser.User = _User;

            this.Hide();
            Form frm =new frmMain(this);
            frm.ShowDialog();
        }
    }
}
