using DVLD_Global;
using DVLD_Global.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_AccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsApplicationType
    {


        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;
        public enum enApplicationType
        {
            NewLocalDrivingLicenseService = 1,
            RenewDrivingLicenseService = 2,
            ReplacementForLostDrivingLicense = 3,
            ReplacementForDamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicense = 5,
            NewInternationalLicense = 6,
            RetakeTest = 7
        }

        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }

        public clsApplicationTypeDTO ApplicationTypeDTO
        {
            get
            {
                return new clsApplicationTypeDTO
                {
                    ApplicationTypeID = this.ApplicationTypeID,
                    Title = this.ApplicationTypeTitle,
                    Fees = this.ApplicationFees
                };
            }
        }

        public clsApplicationType()
        {
            ApplicationTypeID = -1;
            ApplicationTypeTitle = string.Empty;
            ApplicationFees = 0;

            Mode = enMode.AddNew;
        }

        public clsApplicationType(clsApplicationTypeDTO applicationTypeDTO)
        {
            this.ApplicationTypeID = applicationTypeDTO.ApplicationTypeID;
            this.ApplicationTypeTitle = applicationTypeDTO.Title;
            this.ApplicationFees = applicationTypeDTO.Fees;

            Mode = enMode.Update;
        }

        public static DataTable ListAllApplicationTypes()
        {
            return clsApplicationTypeData.GetAllApplicationType();
        }

        public static clsApplicationType Find(int applicationTypeID)
        {
            clsApplicationTypeDTO applicationTypeDTO =
            new clsApplicationTypeDTO
            {
                ApplicationTypeID = applicationTypeID
            };


            if (clsApplicationTypeData.GetApplicationTypeByID(applicationTypeDTO))
                return new clsApplicationType(applicationTypeDTO);

            return null;
        }

        private bool _AddNewApplicationType()
        {
            this.ApplicationTypeID = clsApplicationTypeData.AddNewApplicationType(this.ApplicationTypeDTO);

            return this.ApplicationTypeID != -1;
        }

        private bool _UpdateApplicationType()
        {
            return clsApplicationTypeData.UpdateApplicationType(this.ApplicationTypeDTO);
        }




        private bool _IsValid()
        {
            return clsnValidation.IsApplicationTypeValid(this.ApplicationTypeDTO);
        }

        public bool Save()
        {
            if (!_IsValid())
                return false;

            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewApplicationType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return _UpdateApplicationType();
            }

            return false;
        }

    }
}


