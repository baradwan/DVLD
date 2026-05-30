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
        enum enMode { AddNew = 0, Update = 1 }

        enMode _Mode = enMode.AddNew;
        public int ApplicationID { get; set; }
        public int PersonID { get; set; }

        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public byte Status { get; set; }
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
                    ApplicationStatus = this.Status,
                    LastStatusDate = this.LastStatusDate,
                    PaidFees = this.PaidFees,
                    CreatorID = this.CreatedByUserID
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
            this.Status = ApplicationDTO.ApplicationStatus;
            this.LastStatusDate = ApplicationDTO.LastStatusDate;
            this.PaidFees = ApplicationDTO.PaidFees;
            this.CreatedByUserID = ApplicationDTO.CreatorID;
            _Mode = enMode.Update;
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
        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationData.DeleteApplication(ApplicationID);
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
