using DVLD_AccessLayer;
using DVLD_Global;
using DVLD_Global.DTOs;
using System;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsLicense
    {
        private clsLicenseClass _LicenseClassInfo;
        private clsApplication _ApplicationInfo;
        private clsDriver _DriverInfo;
        private clsDetainedLicense _DetainedInfo;
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
       public string IssueReasonText {
            get
            { 
            return _IssueReasonDescription(this.IssueReason);
            }
        }
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
        public clsDetainedLicense Detained
        {
            get
            {
                if (_DetainedInfo == null && DriverID > 0)
                    _DetainedInfo = clsDetainedLicense.FindByLicenseID(this.LicenseID);

                return _DetainedInfo;
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


        public clsLicenseClass LicenseClassInfo
        {
            get
            {
                if (_LicenseClassInfo == null && LicenseClass > 0)
                    _LicenseClassInfo = clsLicenseClass.Find(LicenseClass);

                return _LicenseClassInfo;
            }
        }
        private string _IssueReasonDescription(enIssueReason reason )
        {
           
                switch (reason)
                {
                    case enIssueReason.FirstTime:
                        return "First Time";
                    case enIssueReason.Renew:
                        return "Renew";
                    case enIssueReason.ReplacementForDamaged:
                        return "Replacement for Damaged";
                    case enIssueReason.ReplacementForLost:
                        return "Replacement for Lost";
                    default:
                        return "Unknown";
                
            }
        }
        public bool IsLicenseExpired()
        {

            return (this.ExpirationDate < DateTime.Now);

        }
        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {

            return clsLicenseData.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);

        }

        public  bool DeActivateLicense()
        {
           return clsLicenseData.DeactivateLicense(this.LicenseID);
        }

        public static DataTable ListAllLicenses()
        {
            return clsLicenseData.GetAllLicenses();
        }
        public static int GetIssuedLicenseIDByLDLApplicationID(int LDLApplicationID)
        {
            if (LDLApplicationID <= 0)
                return -1;

            return clsLicenseData.GetIssuedLicenseIDByLDLApplicationID(
                LDLApplicationID);
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

        public clsLicense ReplaceLicense( int UserID,enIssueReason issueReason)
        {
            bool isActive = !DeActivateLicense();

            clsApplication ReplaceApp = new clsApplication();
           int AppTypeID = (int)(issueReason==enIssueReason.ReplacementForDamaged?clsApplication.enApplicationType.ReplaceDamagedDrivingLicense:
                clsApplication.enApplicationType.ReplaceLostDrivingLicense);

            ReplaceApp.PrepareApplication(this.DriverInfo.PersonID, AppTypeID, UserID);

            if (!isActive)
            {
                if (!ReplaceApp.Save())
                    return null;
            }

            clsLicense ReplaceLicense = new clsLicense();

            ReplaceLicense.ApplicationID = ReplaceApp.ApplicationID;
            ReplaceLicense.DriverID = this.DriverID;
            ReplaceLicense.LicenseClass = this.LicenseClass;
            ReplaceLicense.CreatedByUserID = UserID;
            ReplaceLicense.IssueDate = DateTime.Now;
            ReplaceLicense.ExpirationDate =this.ExpirationDate;
            ReplaceLicense.Notes = this.Notes;
            ReplaceLicense.PaidFees = 0;
            ReplaceLicense.IsActive = true;
            ReplaceLicense.IssueReason = issueReason;



            if (!isActive)
            {
                if (!ReplaceLicense.Save())
                    return null;
            }




            return ReplaceLicense;
        }

        public static  DataTable GetDriverLicenses(int DriverID)
        {
            return clsLicenseData.GetDriverLicenses(DriverID);
        }
        public bool IsEligibleForInternationalLicense()
        {
            return IsActive
                && ExpirationDate.Date >= DateTime.Today
                && LicenseClass == 3;
        }
        public clsLicense RenewLIcense(string Notes,int UserID) {
        
            bool isActive = !DeActivateLicense();

            clsApplication RenewApp=new clsApplication();

            RenewApp.PrepareApplication(this.DriverInfo.PersonID, (int)clsApplication.enApplicationType.RenewDrivingLicense,  UserID);


            if (!isActive)
            {
                if (!RenewApp.Save())
                    return null;
            }

                clsLicense RenewLicense=new clsLicense();
           
            RenewLicense.ApplicationID = RenewApp.ApplicationID;
            RenewLicense.DriverID = this.DriverID;
            RenewLicense.LicenseClass = this.LicenseClass;
            RenewLicense.CreatedByUserID = UserID;
            RenewLicense.IssueDate = DateTime.Now;
            RenewLicense.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            RenewLicense.Notes = Notes;
            RenewLicense.PaidFees = this.PaidFees;
            RenewLicense.IsActive = true;
            RenewLicense.IssueReason = enIssueReason.Renew;



            if (!isActive)
            {
                if (!RenewLicense.Save())
                    return null;
            }




            return RenewLicense;


        }
        public int ReleaseLicense(int UserID) {
        
            

            clsApplication RenewApp=new clsApplication();

            RenewApp.PrepareApplication(this.DriverInfo.PersonID, (int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense,  UserID);


           
                if (!RenewApp.Save())
                    return -1;
            


            if(!this.Detained.ReleaseDetainedLicense(UserID, RenewApp.ApplicationID))
            {
                return -1;
            }

            return RenewApp.ApplicationID;


        }

        public int Detain(Decimal FineFees, int CreatedByUserID)
        {
            clsDetainedLicense detainedLicense = new clsDetainedLicense();
            detainedLicense.LicenseID = this.LicenseID;
            detainedLicense.DetainDate = DateTime.Now;
            detainedLicense.FineFees = FineFees;
            detainedLicense.CreatedByUserID = CreatedByUserID;

            if (!detainedLicense.Save())
            {

                return -1;
            }

            return detainedLicense.DetainID;

        }

        public bool IsDetained()
        {
            return clsDetainedLicense.IsLicenseDetained(this.LicenseID);
        }
        //private bool _IsValid()
        //{
        //    return clsValidation.IsLicenseValid(this.LicenseDTO);
        //}

        public bool Save()
        {
            //if (!_IsValid())
            //    return false;

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