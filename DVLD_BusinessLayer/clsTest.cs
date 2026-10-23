using DVLD_AccessLayer;
using DVLD_Global.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTest
    {

        public enum enMode { AddNew = 0, Update = 1 };

        public enMode Mode { get; private set; } = enMode.AddNew;

        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }


        public clsTestDTO TestDTO
        {
            get
            {
                return new clsTestDTO
                {
                    TestID = this.TestID,
                    TestAppointmentID = this.TestAppointmentID,
                    TestResult = this.TestResult,
                    Notes = this.Notes,
                    CreatedByUserID = this.CreatedByUserID
                };
            }
        }


        public clsTest()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = string.Empty;
            CreatedByUserID = 0;

            Mode = enMode.AddNew;
        }


        private clsTest(clsTestDTO TestDTO)
        {
            this.TestID = TestDTO.TestID;
            this.TestAppointmentID = TestDTO.TestAppointmentID;
            this.TestResult = TestDTO.TestResult;
            this.Notes = TestDTO.Notes;
            this.CreatedByUserID = TestDTO.CreatedByUserID;

            Mode = enMode.Update;
        }


        public static clsTest Find(int TestID)
        {
            clsTestDTO TestDTO = clsTestData.GetTestByID(TestID);

            if (TestDTO == null)
                return null;

            return new clsTest(TestDTO);
        }


        private bool _IsValid()
        {
            if (TestAppointmentID <= 0)
                return false;

            if (CreatedByUserID == 0)
                return false;

            if (Notes != null && Notes.Length > 500)
                return false;

            return true;
        }


        private bool _AddNewTest()
        {
            this.TestID = clsTestData.AddNewTest(this.TestDTO);

            return this.TestID > 0;
        }


        private bool _UpdateTest()
        {
            return clsTestData.UpdateTest(this.TestDTO);
        }

        public static  byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return clsTestData.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        }
    
        public static int GetTestIDByTestAppointmentID(int TestAppointmentID)
        {
            return clsTestData.GetTestID(TestAppointmentID);
        }
        public bool Save()
        {
            if (!_IsValid())
                return false;

            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewTest())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return _UpdateTest();
            }

            return false;
        }
    }

}
