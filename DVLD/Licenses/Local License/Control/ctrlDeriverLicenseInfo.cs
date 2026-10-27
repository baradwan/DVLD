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
        private int _personID = -1;
        private clsPerson _Person;
        clsLocalDrivingLicenseApplication _LDLApp;
        public ctrlDeriverLicenseInfo(clsLocalDrivingLicenseApplication LDLApplication)
        {
            InitializeComponent();
            _LDLApp = LDLApplication;
            _personID = _LDLApp.Application.PersonID;
            _Person = clsPerson.Find(_personID);



        }

        public bool ImageHandler()
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


    }
}
