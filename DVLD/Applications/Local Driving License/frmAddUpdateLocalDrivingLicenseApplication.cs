using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class frmAddUpdateLocalDrivingLicenseApplication : Form
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;
        private int _UserID = -1;
        private bool _AllowTabChange = false;

        public int LocalDrivingLicenseApplicationID { get;  } 

       
        private void _AcceptButtons()
        {
            this.AcceptButton = btnSave;
            this.CancelButton = btnClose;
        }

        public frmAddUpdateLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAppDateValue_Click(object sender, EventArgs e)
        {

        }
    }
}
