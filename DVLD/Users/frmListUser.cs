using DVLD.People;
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
            ctrlListUsers1.CountUsersChanged += _UpdateCountUserss;
        }

        private void _UpdateCountUserss (int Count)
        {
            lblRecordValue.Text = Count.ToString();
        }
        private void btnPeopleAddUser_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateUser();

            frm.ShowDialog();

        }

        private void cmsUsers_Opening(object sender, CancelEventArgs e)
        {

        }

        //private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    int PersonID = ctrlListUsers1.GetCurrentPersonID();
        //                 if (PersonID != -1)
        //    {
        //        Form frm = new frmAddUpdateUser(PersonID);
        //        frm.ShowDialog();
        //     }
        //     else
        //     {
        //         MessageBox.Show("Please select a user to view details.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
           
        //}

        private void contextMenuStripEx1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
