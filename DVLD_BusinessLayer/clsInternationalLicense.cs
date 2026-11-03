using DVLD_AccessLayer;
using DVLD_Global.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_BusinessLayer.clsApplication;

namespace DVLD_BusinessLayer
{
    public class clsInternationalLicense
    {

        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int InternationalLicenseID { get; set; }
        public clsApplication Application { get; set; }
        public clsDriver DriverInfo { get; set; }
        private clsUser _CreatedByUserInfo { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsInternationalLicenseDTO InternationalLicenseDTO
        {
            get
            {
                return new clsInternationalLicenseDTO
                {
                    InternationalLicenseID =this.InternationalLicenseID,
                    ApplicationID = this.Application.ApplicationID,
                    DriverID = this.DriverInfo.DriverID,
                    IssuedUsingLocalLicenseID = this.IssuedUsingLocalLicenseID,
                    IssueDate = this.IssueDate,
                    ExpirationDate = this.ExpirationDate,
                    IsActive = this.IsActive,
                    CreatedByUserID = this.CreatedByUserID
                };
            }
           
        }

        public clsInternationalLicense()
        {
            InternationalLicenseID = -1;
            Application = null;
            DriverInfo = null;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = true;
            CreatedByUserID = -1;

            _Mode = enMode.AddNew;
        }
        public clsInternationalLicense(clsInternationalLicenseDTO DTO)
        {
            InternationalLicenseID = DTO.InternationalLicenseID;
            Application = clsApplication.Find(DTO.ApplicationID);
            DriverInfo = clsDriver.Find(DTO.DriverID);
            IssuedUsingLocalLicenseID = DTO.IssuedUsingLocalLicenseID;
            IssueDate = DTO.IssueDate;
            ExpirationDate = DTO.ExpirationDate;
            IsActive = DTO.IsActive;
            CreatedByUserID = DTO.CreatedByUserID;

            _Mode = enMode.Update;
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

        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseData.AddNewInternationalLicense(this.InternationalLicenseDTO);

            return this.InternationalLicenseID != -1;
        }

        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicenseData.UpdateInternationalLicense( this.InternationalLicenseDTO);
        }

        public static clsInternationalLicense Find(int InternationalLicenseID)
        {
            clsInternationalLicenseDTO LicenseDTO = clsInternationalLicenseData.GetInternationalLicenseByID( InternationalLicenseID);

            if (LicenseDTO == null)
                return null;

            return new clsInternationalLicense(LicenseDTO);
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseData.GetAllInternationalLicenses();
        }

        public  bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            bool IsInternationslDeleted = false;
            bool IsBaseApplicationDeleted = false;
            IsInternationslDeleted = clsInternationalLicenseData.DeleteInternationalLicense(this.InternationalLicenseID);
            if (!IsInternationslDeleted)
                return false;

            IsBaseApplicationDeleted = Application.DeleteApplication();

            return IsBaseApplicationDeleted;
        }

        public static bool IsInternationalLicenseExist(int InternationalLicenseID)
        {
            return clsInternationalLicenseData.IsInternationalLicenseExist( InternationalLicenseID);
        }




        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {

            return clsInternationalLicenseData.GetActiveInternationalLicenseIDByDriverID(DriverID);

        }

        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            return clsInternationalLicenseData.GetDriverInternationalLicenses(DriverID);
        }

        private bool _CanIssue(clsLicense LocalLicense)
        {
            if (LocalLicense == null)
                return false;

            if (!LocalLicense.IsEligibleForInternationalLicense())
                return false;

            if (GetActiveInternationalLicenseIDByDriverID(LocalLicense.DriverID) != -1)
                return false;

            return true;
        }
        private void _PrepareInternationalLicense(clsLicense LocalLicense,clsApplication Application,int CreatedByUserID)
        {
            this.Application = Application;
            this.DriverInfo = LocalLicense.DriverInfo;
            this.IssuedUsingLocalLicenseID = LocalLicense.LicenseID;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = IssueDate.AddYears(1);
            this.IsActive = true;
            this.CreatedByUserID = CreatedByUserID;
        }

        private clsApplication _PrepareApplicationForInternationalLicense(int personID, int createdByUserID)
        {
            clsApplication Application = new clsApplication();
            Application.PrepareApplication(personID, (int)clsApplicationType.enApplicationType.NewInternationalLicense, createdByUserID);
            Application.Status = enApplicationStatus.Completed;
            return Application;
        }
        public bool IssueInternationalLicense(int LocalLicenseID,int CreatedByUserID)
        {
            if (_Mode != enMode.AddNew)
                return false;

            clsLicense LocalLicense = clsLicense.Find(LocalLicenseID);

            if (!_CanIssue(LocalLicense))
                return false;

           
           
            _PrepareInternationalLicense(LocalLicense, _PrepareApplicationForInternationalLicense(LocalLicense.DriverInfo.PersonID, CreatedByUserID), CreatedByUserID);


            return this.Save();
        }

        public bool Save()
        {
            if (Application == null)
                return false;

            if (Application.PersonID <= 0)
                return false;

          

            switch (_Mode)
            {
                case enMode.AddNew:
                    if (!Application.Save())
                        return false;
                    if (_AddNewInternationalLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    
                    return _UpdateInternationalLicense();
            }

            return false;
        }

    }
}
