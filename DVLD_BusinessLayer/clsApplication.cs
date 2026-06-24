using DVLD_Global.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DVLD_AccessLayer;
using System.Security.Cryptography.X509Certificates;
using DVLD_Global;

namespace DVLD_BusinessLayer
{
    public class clsApplication
    {
        private clsPerson _PersonInfo;
        private clsUser _CreatedByUserInfo;
        private clsApplicationType _ApplicationTypeInfo;
        enum enMode { AddNew = 0, Update = 1 }
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };
        public enum enApplicationStatus : byte
        {
            New = 1,
            Cancelled = 2,
            Completed = 3
        }

        enMode _Mode = enMode.AddNew;


        public int ApplicationID { get; set; }
        public int PersonID { get; set; }

        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public enApplicationStatus Status { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }



        public clsApplicationDTO ApplicationDTO
        {
            get
            {
                return new clsApplicationDTO
                {
                    ApplicationID = this.ApplicationID,
                    PersonID = this.PersonID,
                    ApplicationDate = this.ApplicationDate,
                    ApplicationTypeID = this.ApplicationTypeID,
                    ApplicationStatus = (byte)this.Status,
                    LastStatusDate = this.LastStatusDate,
                    PaidFees = this.PaidFees,
                    CreatedByUserID = this.CreatedByUserID
                };
            }
        }


        public clsApplication()
        {
            ApplicationID = -1;
            PersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            Status = 0;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
            _Mode = enMode.AddNew;

        }

        public clsApplication(clsApplicationDTO ApplicationDTO)
        {
            this.ApplicationID = ApplicationDTO.ApplicationID;
            this.PersonID = ApplicationDTO.PersonID;
            this.ApplicationDate = ApplicationDTO.ApplicationDate;
            this.ApplicationTypeID = ApplicationDTO.ApplicationTypeID;
            this.Status = (enApplicationStatus)ApplicationDTO.ApplicationStatus;
            this.LastStatusDate = ApplicationDTO.LastStatusDate;
            this.PaidFees = ApplicationDTO.PaidFees;
            this.CreatedByUserID = ApplicationDTO.CreatedByUserID;
            _Mode = enMode.Update;
        }

      
        public clsPerson PersonInfo
        {
            get
            {
                if (_PersonInfo == null && PersonID > 0)
                    _PersonInfo = clsPerson.Find(PersonID);

                return _PersonInfo;
            }
        }

        public string PersonName
        {
            get
            {
                return PersonInfo.FullName ;
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

        
        public clsApplicationType ApplicationTypeInfo
        {
            get
            {
                if (_ApplicationTypeInfo == null && ApplicationTypeID > 0)
                    _ApplicationTypeInfo = clsApplicationType.Find(ApplicationTypeID);

                return _ApplicationTypeInfo;
            }
        }

        public string ApplicationTypeTitle
        {
            get
            {
                return ApplicationTypeInfo.ApplicationTypeTitle;
            }
        }
        public void PrepareApplication(  int personID, int applicationTypeID, int createdByUserID)
        {
            PersonID = personID;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = applicationTypeID;

            Status = enApplicationStatus.New;

            LastStatusDate = DateTime.Now;

            PaidFees =clsApplicationType.Find(ApplicationTypeID).ApplicationFees;

            CreatedByUserID = createdByUserID;
        }
        public static DataTable ListAllAppliations()
        {

            return clsApplicationData.GetAllApplications();

        }

        public static clsApplication Find(int ApplicationID)
        {
            clsApplicationDTO ApplicationDTO = clsApplicationData.GetApplicationByID(ApplicationID);
            if (ApplicationDTO == null)
                return null;

            return new clsApplication(ApplicationDTO);
        }

        private bool _AddNewApplication()
        {

            this.ApplicationID = clsApplicationData.AddNewApplication(this.ApplicationDTO);
            return this.ApplicationID != -1;
        }

        private bool _UpdateApplication()
        {
            return clsApplicationData.UpdateApplication(this.ApplicationDTO);
        }
        public  bool DeleteApplication()
        {
            return clsApplicationData.DeleteApplication(this.ApplicationID);
        }


        public static int GetActiveAppAppID(int PersonID, clsApplication.enApplicationType ApplicationTypeID) {
            return clsApplicationData.GET(PersonID, (int)ApplicationTypeID);

        }
        private bool _IsValid()
        {

            return clsnValidation.IsApplicationValid(this.ApplicationDTO);
        }

        public bool Save()

        {
            if (!_IsValid())
                return false;

            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewApplication())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateApplication();
                default:
                    return false;
            }

        }


    }
}
