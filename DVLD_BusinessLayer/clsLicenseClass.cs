using DVLD_AccessLayer;
using DVLD_Global;
using DVLD_Global.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsLicenseClass
    {
        enum enMode { AddNew = 0, Update = 1 }

        enMode _Mode = enMode.AddNew;

        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        public clsLicenseClassDTO LicenseClassDTO
        {
            get
            {
                return new clsLicenseClassDTO
                {
                    LicenseClassID = this.LicenseClassID,
                    ClassName = this.ClassName,
                    ClassDescription = this.ClassDescription,
                    MinAllowedAge = this.MinimumAllowedAge,
                    DefaultValidityLength = this.DefaultValidityLength,
                    ClassFees = this.ClassFees
                };
            }
        }


        public clsLicenseClass()
        {
            LicenseClassID = -1;
            ClassName = string.Empty;
            ClassDescription = string.Empty;
            MinimumAllowedAge = 0;
            DefaultValidityLength = 0;
            ClassFees = 0;
            _Mode = enMode.AddNew;
        }


        public clsLicenseClass(clsLicenseClassDTO licenseClassDTO)
        {
            this.LicenseClassID = licenseClassDTO.LicenseClassID;
            this.ClassName = licenseClassDTO.ClassName;
            this.ClassDescription = licenseClassDTO.ClassDescription;
            this.MinimumAllowedAge = licenseClassDTO.MinAllowedAge;
            this.DefaultValidityLength = licenseClassDTO.DefaultValidityLength;
            this.ClassFees = licenseClassDTO.ClassFees;
            _Mode = enMode.Update;
        }
       


        public static DataTable ListAllLicenseClass() {
        
            return clsLicenseClassData.GetAllLicenseClasses();
        }

        public static clsLicenseClass Find(int ID)
        {
            clsLicenseClassDTO licenseClassDTO = clsLicenseClassData.GetLicenseClassByID(ID);
            if (licenseClassDTO == null)
                return null;

     return new clsLicenseClass(licenseClassDTO);
        }

        private bool _AddNewLicenseClass()
        {

            this.LicenseClassID = clsLicenseClassData.AddNewLicenseClass(this.LicenseClassDTO);
            return this.LicenseClassID != -1;
        }

        private bool _UpdateLicenseClass()
        {
            return clsLicenseClassData.UpdateLicenseClass(this.LicenseClassDTO);
        }

        private bool _IsValid()
        {
            return clsnValidation.IsLicenseClassValid(this.LicenseClassDTO);
        }
        public bool Save()
        {
            if (!_IsValid())
                return false;

            switch (_Mode)
            {
                case enMode.AddNew:
                   if(_AddNewLicenseClass())
                    {
                        _Mode = enMode.Update;
                        return true;

                    }
                    return false;

                case enMode.Update:
                    return _UpdateLicenseClass();

                default:
                    return false;
            }

        }
    }
}
