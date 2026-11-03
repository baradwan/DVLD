using DVLD.Licenses.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class frmShowPersonLicenseHistory : Form
    {

        private int _PersonID = -1;
        public frmShowPersonLicenseHistory()
        {
            InitializeComponent();
        }

        public frmShowPersonLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void ctrlPersonInfoWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
            if (_PersonID == -1)
            {
                ctrlDriverLicense1.Clear();
            }
            else
                ctrlDriverLicense1.LoadInfoByPersonID(_PersonID);
        }

        private void frmShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
                ctrlPersonInfoWithFilter1.LoadPersonInfo(_PersonID);
                ctrlPersonInfoWithFilter1.VisibleSearchControls(false);
                ctrlDriverLicense1.LoadInfoByPersonID(_PersonID);
            }
            else
            {
                ctrlPersonInfoWithFilter1.Enabled = true;
               
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
