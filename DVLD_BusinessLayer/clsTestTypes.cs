using DVLD_AccessLayer;
using DVLD_Global.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTestTypes
    {
        public class clsTestType
        {
            public enum enMode { AddNew = 0, Update = 1 }

            public enMode Mode = enMode.AddNew;

            public int TestTypeID { get; set; }
            public string TestTypeTitle { get; set; }
            public string TestTypeDescription { get; set; }
            public decimal TestTypeFees { get; set; }

            public clsTestTypesDTO TestTypeDTO
            {
                get
                {
                    return new clsTestTypesDTO
                    {
                        TestTypeID = this.TestTypeID,
                        Title = this.TestTypeTitle,
                        Description = this.TestTypeDescription,
                        Fees = this.TestTypeFees
                    };
                }
            }

            public clsTestType()
            {
                TestTypeID = -1;
                TestTypeTitle = string.Empty;
                TestTypeDescription = string.Empty;
                TestTypeFees = 0;
                Mode = enMode.AddNew;
            }

            public clsTestType(clsTestTypesDTO testTypeDTO)
            {
                this.TestTypeID = testTypeDTO.TestTypeID;
                this.TestTypeTitle = testTypeDTO.Title;
                this.TestTypeDescription = testTypeDTO.Description;
                this.TestTypeFees = testTypeDTO.Fees;

                Mode = enMode.Update;
            }

            public static DataTable ListAllTestTypes()
            {
                return clsTestTypesData.GetAllTestTypes();
            }

            public static clsTestType Find(int testTypeID)
            {
                clsTestTypesDTO testTypeDTO = new clsTestTypesDTO
                {
                    TestTypeID = testTypeID
                };

                if (clsTestTypesData.GetTestTypeByID(testTypeDTO))
                    return new clsTestType(testTypeDTO);

                return null;
            }

            private bool _AddNewTestType()
            {
                this.TestTypeID = clsTestTypesData.AddNewTestType(this.TestTypeDTO);

                return this.TestTypeID != -1;
            }

            private bool _UpdateTestType()
            {
                return clsTestTypesData.UpdateTestType(this.TestTypeDTO);
            }

            private bool _IsValid()
            {
                return !string.IsNullOrWhiteSpace(TestTypeTitle)
                    && !string.IsNullOrWhiteSpace(TestTypeDescription)
                    && TestTypeFees > 0;
            }

            public bool Save()
            {
                if (!_IsValid())
                    return false;

                switch (Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewTestType())
                        {
                            Mode = enMode.Update;
                            return true;
                        }

                        return false;

                    case enMode.Update:
                        return _UpdateTestType();
                }

                return false;
            }
        }
    }
}
