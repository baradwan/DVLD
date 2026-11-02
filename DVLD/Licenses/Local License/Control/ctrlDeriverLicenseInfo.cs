using DVLD.Properties;
using DVLD_BusinessLayer;
using DVLD_Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.Local_License.Control
{
    public partial class ctrlDeriverLicenseInfo : UserControl
    {
  
        clsLicense _License;
        clsPerson _Person;
        public ctrlDeriverLicenseInfo()
        {
            InitializeComponent();
           
           



        }
        public clsLicense SelectedLicense { get { return _License; } }
        private void _LoadPersonImage()
        {

            if (_Person.ImagePath == null)
                return;
            if (_Person.Gendor == 0)
                pbPersonalProfile.Image = Resources.Male;
            else
                pbPersonalProfile.Image = Resources.Female;

            string ImagePath = Path.Combine(clsProjectFolderSetting.ProjectFolderPath, _Person.ImagePath);
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonalProfile.ImageLocation = ImagePath;


        }

        private void _LoadPersonInfo() {

            lblName.Text = _Person.FullName;
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblDateOfBirth.Text= _License.DriverInfo.PersonInfo.DateOfBirth.ToString("dd/MM/yyyy");
            lblGender.Text = _License.DriverInfo.PersonInfo.Gendor==0 ? "Male" : "Female";

        }

        private void _LoadLicenseInfo() {

           
            lblClass.Text =_License.LicenseClassInfo.ClassName;
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblIssueDate.Text=_License.IssueDate.ToString("dd/MM/yyyy");
            lblIssueReason.Text=_License.IssueReasonText;
            lblIsActive.Text = _License.IsActive ? "Yes" : "No";
           // lblIsDetained.Text = _License.is ? "Yes" : "No";
           lblExpirationDate.Text = _License.ExpirationDate.ToString("dd/MM/yyyy");
            lblDriverID.Text = _License.DriverID.ToString();
            lblNotes.Text= _License.Notes;
            lblCreatedUser.Text = _License.CreatedByUserName;

        }
        public void LoadInfo(clsLicense License) {
            _License = License;
            if (_License == null)
            {             
                MessageBox.Show("No license was found with the specified License ID. Please verify the ID and try again.","License Not Found",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);

                return;
            }
            _Person = _License.DriverInfo.PersonInfo;
            _LoadPersonImage();
            _LoadPersonInfo();
            _LoadLicenseInfo();

        }

        public void LoadInfo(int LicenseID)
        {
            _License = clsLicense.Find(LicenseID);
            if (_License == null)
            {
                MessageBox.Show("No license was found with the specified License ID. Please verify the ID and try again.", "License Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            _Person = _License.DriverInfo.PersonInfo;
            _LoadPersonImage();
            _LoadPersonInfo();
            _LoadLicenseInfo();

        }

        private void lblDateOfBirth_Click(object sender, EventArgs e)
        {

        }
    }
}
