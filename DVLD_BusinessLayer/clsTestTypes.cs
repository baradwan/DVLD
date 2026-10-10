using DVLD_AccessLayer;
using DVLD_Global.DTOs;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
  
        public class clsTestType
        {
            private enum enMode { AddNew = 0, Update = 1 }
            public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };

            private enMode Mode = enMode.AddNew;

            public clsTestType.enTestType ID { set; get; }
            public string TestTypeTitle { get; set; }
            public string TestTypeDescription { get; set; }
            public decimal TestTypeFees { get; set; }

            public clsTestTypesDTO TestTypeDTO
            {
                get
                {
                    return new clsTestTypesDTO
                    {
                        TestTypeID = (int)this.ID,
                        Title = this.TestTypeTitle,
                        Description = this.TestTypeDescription,
                        Fees = this.TestTypeFees
                    };
                }
            }

            public clsTestType()
            {
                ID = clsTestType.enTestType.VisionTest;
                TestTypeTitle = string.Empty;
                TestTypeDescription = string.Empty;
                TestTypeFees = 0;
                Mode = enMode.AddNew;
            }

            public clsTestType(clsTestTypesDTO testTypeDTO)
            {
                this.ID = (clsTestType.enTestType)testTypeDTO.TestTypeID;
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

            //private bool _AddNewTestType()
            //{
            //    this.ID = (clsTestType.enTestType)clsTestTypesData.AddNewTestType(this.TestTypeDTO);

            //    return this.TestTypeTitle != string.Empty;
            //}

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

                //switch (Mode)
                //{
                //    case enMode.AddNew:
                //        if (_AddNewTestType())
                //        {
                //            Mode = enMode.Update;
                //            return true;
                //        }

                //        return false;

                //    case enMode.Update:
                //        return _UpdateTestType();
                //}

                if (Mode==enMode.Update)
                return _UpdateTestType();
            return false;
            }
        }
    }
