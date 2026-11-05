using DVLD.Licenses;
using DVLD.Licenses.Local_License;
using DVLD.Licenses.Local_License.Control;
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

namespace DVLD.Applications.Renew_Local_License
{
    public partial class frmRenewLocalLicense : Form
    {
      
        clsLicense _SelectedLicese;
        public frmRenewLocalLicense()
        {

            InitializeComponent();
           
            ctrlDriverInfoWithFilter1.OnLicenseSelected += ctrlDriverInfoWithFilter1_OnLicenseSelected;
            btnRenew.Enabled = false;
            llShowLicenseInfo.Visible = false;
            llShowLicenseHistory.Visible = false;
        }

        private void _LoadNewAPPLicense() { 
        
            decimal AppFees = clsApplicationType.Find((int)clsApplicationType.enApplicationType.RenewDrivingLicenseService).ApplicationFees;
            decimal LicenseFees = _SelectedLicese.LicenseClassInfo.ClassFees;
            lblAppDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblAppFees.Text=AppFees.ToString("N2");
            lblLicenseFees.Text = LicenseFees.ToString("N2");
            lblIssueDate.Text = lblAppDate.Text;
            lblOldLicenseID.Text = _SelectedLicese.LicenseID.ToString();
            lblCreatedBy.Text = clsCurrentUser.User.UserName;
            lblTotalFees.Text= (AppFees + LicenseFees).ToString("N2");
            lblExpirationDate.Text=DateTime.Now.AddYears(_SelectedLicese.LicenseClassInfo.DefaultValidityLength).ToString("dd/MM/yyyy");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _LicenseValidaty() {



            //check the license is not Expired.
            if (!_SelectedLicese.IsLicenseExpired())
            {
                MessageBox.Show("Selected License is not yet expiared, it will expire on: " + (_SelectedLicese.ExpirationDate).ToString("dd/MM/yyyy")
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlRenewApp.Enabled = false;
                btnRenew.Enabled = false;
                return false;
            }

            //check the license is not Expired.
            if (!_SelectedLicese.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlRenewApp.Enabled = false;
                btnRenew.Enabled = false;
                return false;
            }
            return true;

        }
        private void ctrlDriverInfoWithFilter1_OnLicenseSelected(clsLicense License)
        {

            _SelectedLicese = License;
            if (_SelectedLicese == null)
                return;
            _LoadNewAPPLicense();

            if (!_LicenseValidaty())
                return;

            btnRenew.Enabled = true;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicense RenewLicense = _SelectedLicese.RenewLIcense(txtNote.Text.Trim(), clsCurrentUser.User.userID);

            if (RenewLicense == null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblRenewedLicenseID.Text = RenewLicense.LicenseID.ToString();
            lblRenewAppID.Text = RenewLicense.ApplicationInfo.ApplicationID.ToString();

            MessageBox.Show("Licensed Renewed Successfully with ID=" + lblRenewAppID.Text, "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnlRenewApp.Enabled = false;
            btnRenew.Enabled = false;
            llShowLicenseInfo.Visible = true;
            llShowLicenseHistory.Visible = true;
            llShowLicenseInfo.Enabled = true;
            llShowLicenseHistory.Enabled = true;
            _SelectedLicese = RenewLicense;
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm=new frmShowLicenseInfo(_SelectedLicese);
            frm.ShowDialog();
        }

        private void ctrlDriverInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(_SelectedLicese.DriverInfo.PersonID);
            frm.ShowDialog();
        }
    }
}
