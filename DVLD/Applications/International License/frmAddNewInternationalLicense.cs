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

namespace DVLD.Applications.International_License
{
    public partial class frmAddNewInternationalLicense : Form
    {
        clsLicense _SelectedLicese;
        clsInternationalLicense _InternationalLicense;
        public frmAddNewInternationalLicense()
        {
            InitializeComponent();
            ctrlDriverInfoWithFilter1.OnLicenseSelected += ctrlDriverInfoWithFilter1_OnLicenseSelected;
            btnIssue.Enabled = false;
            llShowLicenseInfo.Visible = false;
            llShowLicenseHistory.Visible = false;
        }

        private bool CheckActiveInterNationalLicense() { 
        
        int InternationalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(_SelectedLicese.DriverID);
            if (InternationalLicenseID != -1)
            {
                
                _InternationalLicense = clsInternationalLicense.Find(InternationalLicenseID);
                lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
                lblInternationalAppID.Text = _InternationalLicense.Application.ApplicationID.ToString();
                return true;
            }
            return false;


        }
        private bool _LicenseValidaty()
        {


            if (CheckActiveInterNationalLicense())
            {
                MessageBox.Show("Driver already has an active international license.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LoadNewAPPLicense();
                   

                return false;
            }

            if (_SelectedLicese.IsLicenseExpired())
            {
                MessageBox.Show("Selected License is  expiared, You should renew it before issuing an international license: " + (_SelectedLicese.ExpirationDate).ToString("dd/MM/yyyy")
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlInternationalApp.Enabled = false;
                btnIssue.Enabled = false;
                return false;
            }

           
            if (!_SelectedLicese.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlInternationalApp.Enabled = false;
                btnIssue.Enabled = false;
                return false;
            }

            if (_SelectedLicese.LicenseClass!=3)
            {
                MessageBox.Show("\"International licenses can only be issued for Ordinary Driving Licenses (Class 3).\"."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlInternationalApp.Enabled = false;
                btnIssue.Enabled = false;
                return false;
            }

            if (!_SelectedLicese.IsEligibleForInternationalLicense())
            {
                MessageBox.Show(
                    "The selected local license is not eligible for an international license.",
                    "Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }
            return true;

        }

        private void _LoadNewAPPLicense()
        {

            decimal AppFees = clsApplicationType.Find((int)clsApplicationType.enApplicationType.NewInternationalLicense).ApplicationFees;
            lblAppDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblIssueDate.Text = lblAppDate.Text;
            lblLocalLicenseID.Text = _SelectedLicese.LicenseID.ToString();
            lblCreatedBy.Text = clsCurrentUser.User.UserName;
            lblTotalFees.Text = AppFees.ToString("N2");
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToString("dd/MM/yyyy"); ;

        }
        private void ctrlDriverInfoWithFilter1_OnLicenseSelected(clsLicense License)
        {

            _SelectedLicese = License;

            if (_SelectedLicese == null)
                return ;

            if (!_LicenseValidaty())
                return;
            _LoadNewAPPLicense();

            btnIssue.Enabled = true;
            pnlInternationalApp .Enabled= true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _saveInternationalLicense()
        {
            _InternationalLicense = new clsInternationalLicense();
            if (_InternationalLicense.IssueInternationalLicense(_SelectedLicese.LicenseID, clsCurrentUser.User.userID))
            {
                MessageBox.Show("International License Issued Successfully with License ID = " + _InternationalLicense.InternationalLicenseID.ToString(),
                    "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("International License Was not Issued ! ",
                 "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (_SelectedLicese == null)
                return;

            if (MessageBox.Show("\"Are you sure you want to issue an international license?\"", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (!_saveInternationalLicense())
                return;



            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblInternationalAppID.Text = _InternationalLicense.Application.ApplicationID.ToString();

            pnlInternationalApp.Enabled = false;
            btnIssue.Enabled = false;
            llShowLicenseInfo.Visible = true;
            llShowLicenseHistory.Visible = true;
            llShowLicenseInfo.Enabled = true;
            llShowLicenseHistory.Enabled = true;
           
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frm frm =  new frmShowInternationalLicenseInfo(_InternationalLicenseID);
            //frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
