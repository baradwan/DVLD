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

namespace DVLD.Users.Control
{
    public partial class ctrlUserInfoCard : UserControl
    {
        private clsUser _User;

        private int _userID = -1;

        public int UserID
        {
            get { return _userID; }
        }




        public ctrlUserInfoCard()
        {
            InitializeComponent();

        }


        public void LoadUserInfo(int UserID)
        {

            _User = clsUser.Find(UserID);
            if (_User == null)
            {

                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillUserInfo();
        }


        private void _FillUserInfo()
        {
            crlShowPersonInformation1.LoadPersonInformation(_User.PersonID);
            lblUserID.Text = _User.userID.ToString();
            lblUserName.Text = _User.UserName;
            lblIsActive.Text = _User.IsActive ? "Yes" : "No";
        }

        private void crlShowPersonInformation1_Load(object sender, EventArgs e)
        {

        }
        //private void _ResetPersonInfo()
        //{
        //    lblUserID.Text = "[???]";
        //    lblUserName.Text = "[???]";
        //    lblIsActive.Text = "[???]";
        //}
    }
}
