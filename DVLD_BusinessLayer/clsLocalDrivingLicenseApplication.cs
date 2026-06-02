using DVLD_AccessLayer;
using DVLD_Global;
using DVLD_Global.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace DVLD_BusinessLayer
{
    public class clsLocalDrivingLicenseApplication

    {
        enum enMode { AddNew = 0, Update = 1 }

        enMode _Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public clsApplication Application { get; set; }
        public int LicenseClassID { get; set; }

        public clsLocalDrivingLicenseApplicationDTO LDLApplicationDTO
        {
            get
            {
                return new clsLocalDrivingLicenseApplicationDTO
                {
                    LocalDrivingLicenseApplicationID = this.LocalDrivingLicenseApplicationID,
                    ApplicationID = this.Application.ApplicationID,
                    LicenseClassID = this.LicenseClassID
                };
            }
        }

        public clsLocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            Application = null;
            LicenseClassID = -1;
            _Mode = enMode.AddNew;
        }

        public clsLocalDrivingLicenseApplication(clsLocalDrivingLicenseApplicationDTO DTO)
        {
            LocalDrivingLicenseApplicationID = DTO.LocalDrivingLicenseApplicationID;
            Application = clsApplication.Find(DTO.ApplicationID);
            LicenseClassID = DTO.LicenseClassID;
            _Mode = enMode.Update;
        }



        public static DataTable ListAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplications();
        }

        public static clsLocalDrivingLicenseApplication Find(int LocalDrivingLicenseApplicationID)
        {
            clsLocalDrivingLicenseApplicationDTO LDLApplicationDTO =  clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationByID(LocalDrivingLicenseApplicationID);

            if (LDLApplicationDTO == null)
                return null;

            return new clsLocalDrivingLicenseApplication(LDLApplicationDTO);
        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID =clsLocalDrivingLicenseApplicationData.AddLocalDrivingLicenseApplication(this.LDLApplicationDTO);

            return this.LocalDrivingLicenseApplicationID != -1;
        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication(
                this.LDLApplicationDTO);
        }

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication( LocalDrivingLicenseApplicationID);
        }

        private bool _IsValid()
        {
            return clsnValidation.IsLocalDrivingLicenseApplicationValid(this.LDLApplicationDTO);
        }


        public void PrepareNewLocalDrivingLicenseApplication(int personID,int licenseClassID,int createdByUserID)        
        {
            Application = new clsApplication();

            Application.PrepareApplication( personID, (int)clsApplicationType.enApplicationType.NewLocalDrivingLicenseService, createdByUserID);

            LicenseClassID = licenseClassID;
        }

        public bool Save()
        {

                    if (!Application.Save())
                        return false;

            if (!_IsValid())
                return false;


            switch (_Mode)
            {
                case enMode.AddNew:



                    if (!_AddNewLocalDrivingLicenseApplication())
                        return false;

                    _Mode = enMode.Update;
                        return true;
                 

                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();

                default:
                    return false;
            }
        }

    }
}
