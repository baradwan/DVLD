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
    public  class clsTestAppointment

    {
        private int _TestID = -1;
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID { set; get; }
        public clsTestType.enTestType TestTypeID { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsLocked { set; get; }
        public int RetakeTestApplicationID { set; get; }
        public clsApplication RetakeTestAppInfo { set; get; }

        
        public clsTestAppointmentDTO testAppointmentDTO
        {
            get
            {
                return new clsTestAppointmentDTO
                {
                    TestAppointmentID = this.TestAppointmentID,
                    TestTypeID = (int)this.TestTypeID,
                    LocalDrivingLicenseApplicationID = this.LocalDrivingLicenseApplicationID,
                    AppointmentDate = this.AppointmentDate,
                    PaidFees = this.PaidFees,
                    CreatedByUserID = this.CreatedByUserID,
                    IsLocked = this.IsLocked,
                    RetakeTestApplicationID = this.RetakeTestApplicationID
                };
            }
        }
        public clsTestAppointment()

        {
            this.TestAppointmentID = -1;
            this.TestTypeID = clsTestType.enTestType.VisionTest;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.RetakeTestApplicationID = -1;
            Mode = enMode.AddNew;

        }

        public clsTestAppointment(clsTestAppointmentDTO testAppointmentDTO)
        {
            this.TestAppointmentID = testAppointmentDTO.TestAppointmentID;
            this.TestTypeID = (clsTestType.enTestType)testAppointmentDTO.TestTypeID;
            this.LocalDrivingLicenseApplicationID = testAppointmentDTO.LocalDrivingLicenseApplicationID;
            this.AppointmentDate = testAppointmentDTO.AppointmentDate;
            this.PaidFees = testAppointmentDTO.PaidFees;
            this.CreatedByUserID = testAppointmentDTO.CreatedByUserID;
            this.IsLocked = testAppointmentDTO.IsLocked;
            this.RetakeTestApplicationID = testAppointmentDTO.RetakeTestApplicationID;
            Mode = enMode.Update;
        }

        public int TestID
        {
            get { return this._GetTestID(); }
        }
        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID=clsTestAppointmentData.AddNewTestAppointment(this.testAppointmentDTO);
            return this.TestAppointmentID!=-1;
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentData.UpdateTestAppointment(this.testAppointmentDTO);
        }

        public static clsTestAppointment Find(int TestAppointmentID) {

            clsTestAppointmentDTO testAppointmentDTO = clsTestAppointmentData.GetTestAppointmentByID(TestAppointmentID);

            if(testAppointmentDTO==null)
                return null;

            return new clsTestAppointment(testAppointmentDTO);
        }

        public static clsTestAppointment GetLastTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID) {

            clsTestAppointmentDTO testAppointmentDTO = clsTestAppointmentData.GetLastTestAppointment(TestTypeID, LocalDrivingLicenseApplicationID);

            if(testAppointmentDTO == null)
                return null;
            return new clsTestAppointment(testAppointmentDTO);

        }
        public static DataTable GetAllTestAppointments()
        {
            return clsTestAppointmentData.GetAllTestAppointments();

        }

        public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            return clsTestAppointmentData.GetApplicationTestAppointmentsPerTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);

        }


        private bool _IsValid()
        {
            return clsnValidation.IsTestAppointmentValid(this.testAppointmentDTO);
        }

        private int _GetTestID()
        {
            if (_TestID == -1)
            {
                _TestID = clsTest.GetTestIDByTestAppointmentID(this.TestAppointmentID);
            }
            return _TestID;
        }
        public bool Save()
        {
           if (!_IsValid())
            {
                return false;
            }   
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestAppointment();

            }

            return false;
        }
    }
}
