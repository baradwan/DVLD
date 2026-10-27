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
        public ctrlDeriverLicenseInfo()
        {
            InitializeComponent();
           
           



        }

        private bool _ImageHandler()
        {
            if (_Person.ImagePath == Path.GetFileName(pbPersonPicture.ImageLocation))
            {
                return true;
            }

            string fullPathOfCurrentImage = Path.GetFullPath(Path.Combine(clsProjectFolderSetting.ProjectFolderPath, _Person.ImagePath));
            if (_Person.ImagePath != pbPersonPicture.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(fullPathOfCurrentImage);
                    }
                    catch (Exception ex)
                    {

                    }
                }

                if (pbPersonPicture.ImageLocation != null)
                {
                    string Source = pbPersonPicture.ImageLocation.ToString();
                    if (clsUtil.CopyImageToProjectFolderPathHandler(ref Source, clsProjectFolderSetting.ProjectFolderPath))
                    {
                        pbPersonPicture.ImageLocation = Source;
                        return true;
                    }

                }

            }


            return true;
        }

        private void _LoadPersonInfo() {

            lblName.Text = _License.DriverInfo.PersonInfo.FullName;
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblDateOfBirth.Text= _License.DriverInfo.PersonInfo.DateOfBirth.ToString("dd/MM/yyyy");
            lblGender.Text = _License.DriverInfo.PersonInfo.Gendor==0 ? "Male" : "Female";

        }

        private void _LoadLicenseInfo() {

           
            lblClass.Text = clsLicenseClass.Find(_License.LicenseClass).ClassName;
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
        public void LoadInfo(int LicenseID) {
            _License = clsLicense.Find(LicenseID);
            _ImageHandler();
            _LoadPersonInfo();
            _LoadLicenseInfo();

        }


    }
}
