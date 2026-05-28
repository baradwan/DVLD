using DVLD.Login;
using DVLD.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Main.Controls
{
    public partial class ctrlAccountSetting : UserControl
    {

        public  event Action OnUserSignOut;


        public ctrlAccountSetting()
        {
            InitializeComponent();
        }

        private void btnCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo(CurrentUser.User.userID);
            frm.ShowDialog();

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(CurrentUser.User.userID);
            frm.ShowDialog();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            CurrentUser.User = null;
            OnUserSignOut?.Invoke();
        }
    }
}
