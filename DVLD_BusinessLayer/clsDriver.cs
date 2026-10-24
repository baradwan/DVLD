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
    public class clsDriver
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsPerson PersonInfo { get; }
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreateDate { get; set; }

        public clsDriverDTO DriverDTO
        {
            get
            {
                return new clsDriverDTO
                {
                    DriverID = this.DriverID,
                    PersonID = this.PersonID,
                    CreatedByUserID = this.CreatedByUserID,
                    CreateDate = this.CreateDate
                };
            }
        }

        public clsDriver()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreateDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        private clsDriver(clsDriverDTO DriverDTO)
        {
            this.DriverID = DriverDTO.DriverID;
            this.PersonID = DriverDTO.PersonID;
            this.CreatedByUserID = DriverDTO.CreatedByUserID;
            this.CreateDate = DriverDTO.CreateDate;
            this.PersonInfo = clsPerson.Find(this.PersonID);
            Mode = enMode.Update;
        }

        private bool _AddNewDriver()
        {
            this.DriverID = clsDriverData.AddNewDriver(this.DriverDTO);

            return this.DriverID != -1;
        }

        private bool _UpdateDriver()
        {
            return clsDriverData.UpdateDriver(this.DriverDTO);
        }


        public static clsDriver Find(int DriverID)
        {
            clsDriverDTO DriverDTO =  clsDriverData.GetDriverInfoByID(DriverID);

            if (DriverDTO == null)
                return null;

            return new clsDriver(DriverDTO);
        }

        public static clsDriver FindByPersonID(int PersonID)
        {
            clsDriverDTO DriverDTO = clsDriverData.GetDriverInfoByPersonID(PersonID);

            if (DriverDTO == null)
                return null;

            return new clsDriver(DriverDTO);
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriverData.GetAllDrivers();
        }

        public bool Delete()
        {
            return clsDriverData.DeleteDriver(this.DriverID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return _UpdateDriver();
            }

            return false;
        }
    }
}
