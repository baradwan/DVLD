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
            return clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication(this.LDLApplicationDTO);
        }
        public bool PassedAllTests()
        {
            return clsTest.PassedAllTests(this.LocalDrivingLicenseApplicationID);
        }
        public int GetActiveLicenseID()
        {//this will get the license id that belongs to this application
            return clsLicense.GetActiveLicenseIDByPersonID(Application.PersonID, this.LicenseClassID);
        }
        public  bool DeleteLocalDrivingLicenseApplication()
        {
            bool IsLocalDrivingApplicationDeleted = false;
            bool IsBaseApplicationDeleted = false;
            IsLocalDrivingApplicationDeleted =clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID);
            if (!IsLocalDrivingApplicationDeleted)
                return false;

            IsBaseApplicationDeleted = Application.DeleteApplication();

            return IsBaseApplicationDeleted;
        }

        private bool _IsValid()
        {
            return clsnValidation.IsLocalDrivingLicenseApplicationValid(this.LDLApplicationDTO);
        }

        public byte TotalTrialsPerTest(clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)

        {

            return clsLocalDrivingLicenseApplicationData.IsThereActiveTestAppointment(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public bool DoesAttendTestType(clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.DoesAttendTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.DoesAttendTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public bool DoesPassTestType(clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.DoesPassTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.DoesPassTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        private bool _SetComplete()

        {
            return clsApplicationData.UpdateStatus(Application.ApplicationID, 3);
        }


        public void PrepareNewLocalDrivingLicenseApplication(int personID,int licenseClassID,int createdByUserID)        
        {
            Application = new clsApplication();

            Application.PrepareApplication( personID, (int)clsApplicationType.enApplicationType.NewLocalDrivingLicenseService, createdByUserID);

            LicenseClassID = licenseClassID;
        }


        private clsDriver _CreateDriver(int createdByUserID) { 
        
        clsDriver Driver = clsDriver.FindByPersonID(Application.PersonID);
            
            if (Driver != null)
                          return Driver ;

            Driver = new clsDriver();

            Driver.PersonID = Application.PersonID;
            Driver.CreatedByUserID = createdByUserID;
            Driver.CreateDate = DateTime.Now;

            if (!Driver.Save())
                return null;

            _SetComplete();
            return Driver;

        }
        private clsLicense _CreateLicense(string Notes,int DriverID,int CurrentUserID)
        {

          
            clsLicense License = new clsLicense();
            License.ApplicationID = this.Application.ApplicationID;
            License.DriverID = DriverID;
            License.LicenseClass = this.LicenseClassID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.Find(this.LicenseClassID).DefaultValidityLength);
            License.Notes = Notes;
            License.PaidFees = this.Application.PaidFees;
            License.IsActive = true;
            License.IssueReason = clsLicense.enIssueReason.FirstTime;
            License.CreatedByUserID = this.Application.CreatedByUserID;
            if (!License.Save())
                return null;
            return License;
        }

        public int IssuedLicenseFirstTime(string Notes, int CurrentUserID)
        {

            clsDriver Driver = _CreateDriver(CurrentUserID);
            clsLicense License = _CreateLicense(Notes, Driver.DriverID, CurrentUserID);
            return License != null ? License.LicenseID : -1;
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
