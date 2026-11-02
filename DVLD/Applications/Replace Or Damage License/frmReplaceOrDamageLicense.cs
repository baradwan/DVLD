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
using static DVLD_BusinessLayer.clsLicense;
namespace DVLD.Applications.Replace_Or_Damage_License
{
    public partial class frmReplaceOrDamageLicense : Form
    {
        clsLicense _SelectedLicense;
        public frmReplaceOrDamageLicense()
        {
            InitializeComponent();

           // ctrlDriverInfoWithFilter1.OnLicenseSelected += ctrlDriverInfoWithFilter1_OnLicenseSelected;
        }

        private int _GetApplicationTypeID()
        {
            

            if (rbDamagedLicense.Checked)

                return (int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense;
            else
                return (int)clsApplication.enApplicationType.ReplaceLostDrivingLicense;
        }
        private enIssueReason _GetIssuedReason() {
        
            if(rbDamagedLicense.Checked)
                return enIssueReason.ReplacementForDamaged;
            else
                return enIssueReason.ReplacementForLost;
        }

        private decimal AppFees() {


            return clsApplicationType.Find((int)_GetApplicationTypeID()).ApplicationFees;

        }
        private bool _LicenseValidaty()
        {



            //check the license is not Expired.
            if (_SelectedLicense.IsLicenseExpired())
            {
                MessageBox.Show("Selected License is  expiared, The Expiration was on: " + (_SelectedLicense.ExpirationDate).ToString("dd/MM/yyyy") + "Should Renew First"
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnReplacement.Enabled = false;
                pnlReplacementFor.Enabled = false;
                return false;
            }

            //check the license is not Expired.
            if (!_SelectedLicense.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnReplacement.Enabled = false;
                pnlReplacementFor.Enabled = false;
                return false;
            }
            return true;

        }
        private void frmReplaceOrDamageLicense_Load(object sender, EventArgs e)
        {
            btnReplacement.Enabled = false;
            llShowLicenseHistory.Visible = false;
            llShowLicenseInfo.Visible = false;
            rbDamagedLicense.Checked = true;
            pnlReplacementFor.Enabled = false;
        }

        private void _LoadApp() {
        
            lblAppDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblAppFees.Text = AppFees().ToString("N2");
            lblCreatedBy.Text = clsCurrentUser.User.UserName;
            lblOldLicenseID.Text = _SelectedLicense.LicenseID.ToString();

        }

        private void ctrlDriverInfoWithFilter1_OnLicenseSelected(clsLicense license)
        {
            _SelectedLicense = license;

            _LoadApp();

            if (!_LicenseValidaty())
                return;
            pnlReplacementFor.Enabled = true;
            btnReplacement.Enabled = true;
 

        }

        private void btnReplacement_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicense ReplacedLicense =   _SelectedLicense.ReplaceLicense( clsCurrentUser.User.userID,_GetIssuedReason());

            if (ReplacedLicense == null)
            {
                MessageBox.Show("Faild to Replace the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblRenewedLicenseID.Text = ReplacedLicense.LicenseID.ToString();
            lblRenewAppID.Text = ReplacedLicense.ApplicationInfo.ApplicationID.ToString();

            MessageBox.Show("Licensed Replaced Successfully with ID=" + lblRenewAppID.Text, "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnReplacement.Enabled = false;
            pnlReplacementFor.Enabled = false;
            llShowLicenseInfo.Visible = true;
            llShowLicenseHistory.Visible = true;
            llShowLicenseInfo.Enabled = true;
            llShowLicenseHistory.Enabled = true;
            _SelectedLicense = ReplacedLicense;



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_SelectedLicense);
            frm.ShowDialog();
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblAppFees.Text = AppFees().ToString("N2");

        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblAppFees.Text = AppFees().ToString("N2");

        }
    }
}
