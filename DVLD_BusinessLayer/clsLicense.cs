using DVLD_AccessLayer;
using DVLD_Global;
using DVLD_Global.DTOs;
using System;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsLicense
    {
        private clsApplication _ApplicationInfo;
        private clsDriver _DriverInfo;
        private clsUser _CreatedByUserInfo;

        private enum enMode { AddNew = 0, Update = 1 }

        public enum enIssueReason : byte
        {
            FirstTime = 1,
            Renew = 2,
            ReplacementForDamaged = 3,
            ReplacementForLost = 4
        }

        private enMode _Mode = enMode.AddNew;

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enIssueReason IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public clsLicenseDTO LicenseDTO
        {
            get
            {
                return new clsLicenseDTO
                {
                    LicenseID = this.LicenseID,
                    ApplicationID = this.ApplicationID,
                    DriverID = this.DriverID,
                    LicenseClass = this.LicenseClass,
                    IssueDate = this.IssueDate,
                    ExpirationDate = this.ExpirationDate,
                    Notes = this.Notes,
                    PaidFees = this.PaidFees,
                    IsActive = this.IsActive,
                    IssueReason = (byte)this.IssueReason,
                    CreatedByUserID = this.CreatedByUserID
                };
            }
        }

        public clsLicense()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClass = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = null;
            PaidFees = 0;
            IsActive = true;
            IssueReason = enIssueReason.FirstTime;
            CreatedByUserID = -1;

            _Mode = enMode.AddNew;
        }

        public clsLicense(clsLicenseDTO licenseDTO)
        {
            LicenseID = licenseDTO.LicenseID;
            ApplicationID = licenseDTO.ApplicationID;
            DriverID = licenseDTO.DriverID;
            LicenseClass = licenseDTO.LicenseClass;
            IssueDate = licenseDTO.IssueDate;
            ExpirationDate = licenseDTO.ExpirationDate;
            Notes = licenseDTO.Notes;
            PaidFees = licenseDTO.PaidFees;
            IsActive = licenseDTO.IsActive;
            IssueReason = (enIssueReason)licenseDTO.IssueReason;
            CreatedByUserID = licenseDTO.CreatedByUserID;

            _Mode = enMode.Update;
        }

        public clsApplication ApplicationInfo
        {
            get
            {
                if (_ApplicationInfo == null && ApplicationID > 0)
                    _ApplicationInfo = clsApplication.Find(ApplicationID);

                return _ApplicationInfo;
            }
        }

        public clsDriver DriverInfo
        {
            get
            {
                if (_DriverInfo == null && DriverID > 0)
                    _DriverInfo = clsDriver.Find(DriverID);

                return _DriverInfo;
            }
        }

        public clsUser CreatedByUserInfo
        {
            get
            {
                if (_CreatedByUserInfo == null && CreatedByUserID > 0)
                    _CreatedByUserInfo = clsUser.Find(CreatedByUserID);

                return _CreatedByUserInfo;
            }
        }

        public string CreatedByUserName
        {
            get
            {
                return CreatedByUserInfo.UserName;
            }
        }

        public void PrepareLicense(
            int applicationID,
            int driverID,
            int licenseClass,
            DateTime expirationDate,
            decimal paidFees,
            int createdByUserID,
            enIssueReason issueReason = enIssueReason.FirstTime,
            string notes = null)
        {
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClass = licenseClass;
            IssueDate = DateTime.Now;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = true;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
        }

        public static DataTable ListAllLicenses()
        {
            return clsLicenseData.GetAllLicenses();
        }

        public static clsLicense Find(int licenseID)
        {
            clsLicenseDTO licenseDTO = clsLicenseData.GetLicenseByID(licenseID);

            if (licenseDTO == null)
                return null;

            return new clsLicense(licenseDTO);
        }

        private bool _AddNewLicense()
        {
            this.LicenseID = clsLicenseData.AddNewLicense(this.LicenseDTO);
            return this.LicenseID != -1;
        }

        private bool _UpdateLicense()
        {
            return clsLicenseData.UpdateLicense(this.LicenseDTO);
        }

        public bool DeleteLicense()
        {
            return clsLicenseData.DeleteLicense(this.LicenseID);
        }

        private bool _IsValid()
        {
            return clsnValidation.IsLicenseValid(this.LicenseDTO);
        }

        public bool Save()
        {
            if (!_IsValid())
                return false;

            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return _UpdateLicense();

                default:
                    return false;
            }
        }
    }
}