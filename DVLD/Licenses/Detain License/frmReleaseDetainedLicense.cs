using DVLD.Licenses.Local_License;
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

namespace DVLD.Licenses.Detain_License
{
    public partial class frmReleaseDetainedLicense : Form
    {
        public event Action LicenseReleased;
        clsLicense _SelectedLicese;

        clsDetainedLicense _SelectedDetainedLicense;
        int _AppID = -1;
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();

            ctrlDriverInfoWithFilter1.OnLicenseSelected += ctrlDriverInfoWithFilter1_OnLicenseSelected;
            btnRelease.Enabled = false;
            llShowLicenseInfo.Visible = false;
            llShowLicenseHistory.Visible = false;
        }
        public frmReleaseDetainedLicense(int LicenseID) : this()
        {

           

            if (LicenseID > 0)
                ctrlDriverInfoWithFilter1.LoadInfo(LicenseID);
           
        }



        private bool _LicenseValidaty()
        {

            if (_SelectedLicese == null)
                return false;

            if (!_SelectedLicese.IsDetained())
            {
                MessageBox.Show("Selected license is not detained.  " 
                    , "Release Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlReleaseLicense.Enabled = false;
                btnRelease.Enabled = false;
                _ClearDetainedInfo();
                return false;
            }

            if ((_SelectedDetainedLicense == null || _SelectedDetainedLicense.IsReleased))
            {
                MessageBox.Show("No active detention record was found for this license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlReleaseLicense.Enabled = false;
                btnRelease.Enabled = false;
                return false;
            }


            return true;

        }

        private void _ClearDetainedInfo()
        {

            lblDetainID.Text = "N/A";
            lblCreatedBy.Text= "N/A";
            lblLicenseID.Text= "N/A";
            lblDetainDate.Text="N/A";
            lblAppFees.Text = "N/A";
            lblFineFees.Text = "N/A";
            lblTotalFees.Text = "N/A";
        }
        private void _LoadDetainInfo()
        {
            decimal AppFees = clsApplicationType.Find((short)clsApplicationType.enApplicationType.ReleaseDetainedDrivingLicense).ApplicationFees;
            decimal FineFees = _SelectedDetainedLicense.FineFees;
            decimal Total = AppFees + FineFees;
            lblDetainID.Text = _SelectedDetainedLicense.DetainID.ToString();
            lblCreatedBy.Text = _SelectedDetainedLicense.CreatedByUserInfo.UserName;
            lblLicenseID.Text = _SelectedLicese.LicenseID.ToString();
            lblDetainDate.Text = _SelectedDetainedLicense.DetainDate.ToString("dd/MM/yyyy");
            lblAppFees.Text = AppFees.ToString("N2");
            lblFineFees.Text = FineFees.ToString("N2");
            lblTotalFees.Text=Total.ToString("N2");
          

        }
        private void ctrlDriverInfoWithFilter1_OnLicenseSelected(clsLicense License)
        {
            _IntinateSelectedLicense(License);
        }

        private void _IntinateSelectedLicense(clsLicense License)
        {
            btnRelease.Enabled = false;
            pnlReleaseLicense.Enabled = false;

            llShowLicenseInfo.Visible = false;
            llShowLicenseHistory.Visible = false;


            _SelectedLicese = License;
            if (_SelectedLicese == null)
                return;

            _SelectedDetainedLicense = clsDetainedLicense.FindByLicenseID(_SelectedLicese.LicenseID);




            if (!_LicenseValidaty())
                return;

            _LoadDetainInfo();
            pnlReleaseLicense.Enabled = true;
            _RefreshBtnRelease();
        }
        private void _RefreshBtnRelease()
        {
            btnRelease.Enabled =
                _SelectedLicese != null
                && _SelectedDetainedLicense != null
                && pnlReleaseLicense.Enabled
                && _AppID == -1;
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {

            if (_SelectedLicese == null || !_LicenseValidaty())
                return;






            if (MessageBox.Show("Are you sure you want to Release the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            _AppID = _SelectedLicese.ReleaseLicense(clsCurrentUser.User.userID);

            if (_AppID == -1)
            {
                MessageBox.Show("Failed to Release the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            LicenseReleased?.Invoke();
            lblAppID.Text = _AppID.ToString();
            MessageBox.Show($"License released successfully.\nRelease Application ID: {_AppID}",
         "License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnlReleaseLicense.Enabled = false;
            btnRelease.Enabled = false;
            llShowLicenseInfo.Visible = true;
            llShowLicenseHistory.Visible = true;
            llShowLicenseInfo.Enabled = true;
            llShowLicenseHistory.Enabled = true;
        }

        private void ctrlDriverInfoWithFilter1_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_SelectedLicese);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(_SelectedLicese.DriverInfo.PersonID);
            frm.ShowDialog();
        }
    }


}
