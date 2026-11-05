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
    public partial class frmDetainLicenseApplication : Form
    {

        clsLicense _SelectedLicese;
        int _DetainID = -1;
        public frmDetainLicenseApplication()
        {
            InitializeComponent();

            ctrlDriverInfoWithFilter1.OnLicenseSelected += ctrlDriverInfoWithFilter1_OnLicenseSelected;
            btnDetain.Enabled = false;
            llShowLicenseInfo.Visible = false;
            llShowLicenseHistory.Visible = false;
        }

        private bool _LicenseValidaty()
        {



            //check the license is  Expired.
            if (_SelectedLicese.IsLicenseExpired())
            {
                MessageBox.Show("Selected license has already expired on:  " + (_SelectedLicese.ExpirationDate).ToString("dd/MM/yyyy")
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlDetainLicense.Enabled = false;
                btnDetain.Enabled = false;
                return false;
            }

            //check the license is not Expired.
            if (!_SelectedLicese.IsActive)
            {
                MessageBox.Show("Selected License is  Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlDetainLicense.Enabled = false;
                btnDetain.Enabled = false;
                return false;
            }

            if (_SelectedLicese.IsDetained())
            {
                MessageBox.Show(
                    "Selected license is already detained.",
                    "Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }
            
                return true;

        }

        private void _LoadDetainInfo()
        {
            lblLicenseID.Text = _SelectedLicese.LicenseID.ToString();

            clsDetainedLicense Detained = _SelectedLicese.Detained;

            if (Detained != null && !Detained.IsReleased)
            {
                // Existing detention
                lblDetainID.Text = Detained.DetainID.ToString();
                lblDetainDate.Text = Detained.DetainDate.ToString("dd/MM/yyyy");
                lblCreatedBy.Text = Detained.CreatedByUserInfo.UserName;
                return;
            }

            // New detention
            lblDetainID.Text = "N/A";
            lblDetainDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblCreatedBy.Text = clsCurrentUser.User.UserName;


        }
        private void ctrlDriverInfoWithFilter1_OnLicenseSelected(clsLicense License)
        {

            _SelectedLicese = License;

            btnDetain.Enabled = false;
            pnlDetainLicense.Enabled = false;

            llShowLicenseInfo.Visible = false;
            llShowLicenseHistory.Visible = false;

            txtFineFees.Clear();
            errorProvider1.SetError(txtFineFees, string.Empty);

            if (_SelectedLicese == null)
                return;
            _LoadDetainInfo();

            if (!_LicenseValidaty())
                return;
            pnlDetainLicense.Enabled = true;

            _RefreshBtnDetain();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {

            if (_SelectedLicese == null || !_LicenseValidaty())
                return;


            if (!decimal.TryParse(txtFineFees.Text.Trim(), out decimal FineFees)
    || FineFees <= 0)
            {
                errorProvider1.SetError(
                    txtFineFees,
                    "Please enter a valid fine amount greater than zero.");

                txtFineFees.Focus();
                return;
            }




            if (MessageBox.Show("Are you sure you want to Detain the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            _DetainID = _SelectedLicese.Detain(Convert.ToDecimal(txtFineFees.Text.Trim()), clsCurrentUser.User.userID);

            if (_DetainID == -1)
            {
                MessageBox.Show("Faild to Detain the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblDetainID.Text = _DetainID.ToString();
            MessageBox.Show("License Detained Successfully with ID=" + lblDetainID.Text, "License Detained", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnlDetainLicense.Enabled = false;
            btnDetain.Enabled = false;
            llShowLicenseInfo.Visible = true;
            llShowLicenseHistory.Visible = true;
            llShowLicenseInfo.Enabled = true;
            llShowLicenseHistory.Enabled = true;
           
        }

        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {

            char DecimalSeparator =
       Convert.ToChar(
           System.Globalization.CultureInfo
               .CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(txtFineFees, string.Empty);
                return;
            }

            if (e.KeyChar == DecimalSeparator &&
                !txtFineFees.Text.Contains(DecimalSeparator.ToString()))
            {
                errorProvider1.SetError(txtFineFees, string.Empty);
                return;
            }

            e.Handled = true;

            errorProvider1.SetError(
                txtFineFees,
                "Invalid input! Only numbers and one decimal separator are allowed.");
        }
        private void _RefreshBtnDetain()
        {
            bool IsValidFine =
                decimal.TryParse(txtFineFees.Text.Trim(), out decimal FineFees)
                && FineFees > 0;

            btnDetain.Enabled =
                _SelectedLicese != null
                && pnlDetainLicense.Enabled
                && _DetainID == -1
                && IsValidFine;
        }
        private void txtFineFees_TextChanged(object sender, EventArgs e)
        {
            _RefreshBtnDetain();

            if (decimal.TryParse(txtFineFees.Text.Trim(), out decimal FineFees)
                && FineFees > 0)
            {
                errorProvider1.SetError(txtFineFees, string.Empty);
            }
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (!decimal.TryParse(txtFineFees.Text.Trim(), out decimal FineFees)
        || FineFees <= 0)
            {
                errorProvider1.SetError(
                    txtFineFees,
                    "Please enter a valid fine amount greater than zero.");

                // Don't cancel focus movement.
                return;
            }

            errorProvider1.SetError(txtFineFees, string.Empty);
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(_SelectedLicese.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(_SelectedLicese.DriverInfo.PersonID);
            frm.ShowDialog();
        }
    }
    
}
