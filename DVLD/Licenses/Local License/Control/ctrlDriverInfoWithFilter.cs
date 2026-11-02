using DVLD.People.Controls;
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

namespace DVLD.Licenses.Local_License.Control
{
    public partial class ctrlDriverInfoWithFilter : UserControl
    {
        public event Action<clsLicense> OnLicenseSelected;
        public ctrlDriverInfoWithFilter()
        {
            InitializeComponent();
        }


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

                if (e.KeyChar == (char)13)
                {
                e.Handled = true;
                btnFind.PerformClick();
                return;
                }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSearch, "Please enter a valid numeric value.");
                return;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                errorProvider1.SetError(txtSearch, "Paste is disabled for this field!");
            }
        }

        private bool _FindLicense()
        {

            string value = txtSearch.Text.Trim();



             if (!int.TryParse(value, out int licenseID) || licenseID <= 0)
            {
                errorProvider1.SetError(txtSearch, "Invalid License ID.");
                return false;
            }

            else
            {
                errorProvider1.SetError(txtSearch, string.Empty);
                ctrlDeriverLicenseInfo1.LoadInfo(licenseID);

             
            }

            clsLicense License = ctrlDeriverLicenseInfo1.SelectedLicense;
                if (License == null)
                return false;
            OnLicenseSelected?.Invoke(License);
            return true;
        }
        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearch.Text))
            {
                errorProvider1.SetError(txtSearch, "Please enter a value to search."); return;
            }
            _FindLicense();
          
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSearch, string.Empty);
        }
    }
}
