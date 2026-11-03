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

namespace DVLD.Licenses.International_License.Control
{
    public partial class ctrlInternationalLicenseInfo : UserControl
    {
        int _InternationalLicenseID;
        clsPerson _Person;
        clsInternationalLicense _License;
        public ctrlInternationalLicenseInfo()
        {
            InitializeComponent();

           
        }
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

        private void _LoadPersonInfo()
        {

            lblName.Text = _Person.FullName;
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToString("dd/MM/yyyy");
            lblGender.Text = _License.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";

        }

        private void _LoadLicenseInfo()
        {
            lblAppID.Text = _License.Application.ApplicationID.ToString();
            lblInternationalLicenseID.Text = _License.InternationalLicenseID.ToString();
            lblLicenseID.Text = _License.IssuedUsingLocalLicenseID.ToString();
            lblIssueDate.Text = _License.IssueDate.ToString("dd/MM/yyyy");
            lblExpirationDate.Text = _License.ExpirationDate.ToString("dd/MM/yyyy");
            lblDriverID.Text = _License.DriverInfo.DriverID.ToString();
            lblCreatedUser.Text = _License.CreatedByUserName;

        }
        public void LoadInfo(clsInternationalLicense License)
        {
            _License = License;
            if (_License == null)
            {
                MessageBox.Show("No license was found with the specified international  License ID. Please verify the ID and try again.", "License Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            _Person = _License.DriverInfo.PersonInfo;
            _LoadPersonImage();
            _LoadPersonInfo();
            _LoadLicenseInfo();

        }

        public void LoadInfo(int LicenseID)
        {
            _License = clsInternationalLicense.Find(LicenseID);
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


    }
}
