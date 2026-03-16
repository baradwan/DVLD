using DVLD.Users.Control;
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
    public partial class frmListUser : Form
    {
        public frmListUser()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListUser_Load(object sender, EventArgs e)
        {
            lblRecordValue.Text = crtlListUsers1.CountUsers.ToString();
            crtlListUsers1.CountUsersChanged += count =>
            lblRecordValue.Text = count.ToString();

        }
    }
}
