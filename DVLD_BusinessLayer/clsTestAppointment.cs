using DVLD_Global.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DVLD_BusinessLayer
{
    public  class clsTestAppointment

    {
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


    }
}
