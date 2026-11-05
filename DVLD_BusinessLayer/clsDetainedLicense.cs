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
    public class clsDetainedLicense
    {

        private clsLicense _LicenseInfo;
        private clsUser _CreatedByUserInfo;
        private clsUser _ReleasedByUserInfo;

        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }

        public clsDetainedLicenseDTO DetainedLicenseDTO
        {
            get
            {
                return new clsDetainedLicenseDTO
                {
                    DetainID = this.DetainID,
                    LicenseID = this.LicenseID,
                    DetainDate = this.DetainDate,
                    FineFees = this.FineFees,
                    CreatedByUserID = this.CreatedByUserID,
                    IsReleased = this.IsReleased,
                    ReleaseDate = this.ReleaseDate,
                    ReleasedByUserID = this.ReleasedByUserID,
                    ReleaseApplicationID = this.ReleaseApplicationID
                };
            }
        }

        public clsDetainedLicense()
        {
            this.DetainID = -1;
          this.  LicenseID = -1;
          this.  DetainDate = DateTime.Now;
          this.  FineFees = 0;
          this.  CreatedByUserID = -1;
          this.  IsReleased = false;
          this.  ReleaseDate = null;
          this.  ReleasedByUserID = null;
          this.  ReleaseApplicationID = null;

            _Mode = enMode.AddNew;
        }

        public clsDetainedLicense(clsDetainedLicenseDTO DTO)
        {
            this.DetainID = DTO.DetainID;
           this. LicenseID = DTO.LicenseID;
           this. DetainDate = DTO.DetainDate;
           this. FineFees = DTO.FineFees;
           this. CreatedByUserID = DTO.CreatedByUserID;
           this. IsReleased = DTO.IsReleased;
           this. ReleaseDate = DTO.ReleaseDate;
           this. ReleasedByUserID = DTO.ReleasedByUserID;
           this. ReleaseApplicationID = DTO.ReleaseApplicationID;

            _Mode = enMode.Update;
        }

        public clsLicense LicenseInfo
        {
            get
            {
                if (_LicenseInfo == null && LicenseID > 0)
                    _LicenseInfo = clsLicense.Find(LicenseID);

                return _LicenseInfo;
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

        public clsUser ReleasedByUserInfo
        {
            get
            {
                if (_ReleasedByUserInfo == null &&
                    ReleasedByUserID.HasValue &&
                    ReleasedByUserID.Value > 0)
                {
                    _ReleasedByUserInfo =
                        clsUser.Find(ReleasedByUserID.Value);
                }

                return _ReleasedByUserInfo;
            }
        }

        private bool _AddNewDetainedLicense()
        {
            this.DetainID =clsDetainedLicenseData.AddNewDetainedLicense( this.DetainedLicenseDTO);

            return this.DetainID != -1;
        }

        private bool _UpdateDetainedLicense()
        {
            return clsDetainedLicenseData.UpdateDetainedLicense(this.DetainedLicenseDTO);
        }

        public static clsDetainedLicense Find(int DetainID)
        {
            clsDetainedLicenseDTO DTO =clsDetainedLicenseData.GetDetainedLicenseByID(DetainID);

            if (DTO == null)
                return null;

            return new clsDetainedLicense(DTO);
        }
        public static clsDetainedLicense FindByLicenseID(int LicenseID)
        {
            clsDetainedLicenseDTO DTO =clsDetainedLicenseData.GetDetainedLicenseByLicenseID(LicenseID);

            if (DTO == null)
                return null;

            return new clsDetainedLicense(DTO);
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicenseData.GetAllDetainedLicenses();
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicenseData.IsLicenseDetained(LicenseID);
        }

        public bool DeleteDetainedLicense()
        {
            return clsDetainedLicenseData.DeleteDetainedLicense(
                this.DetainID);
        }

        private bool _CanDetain()
        {
            if (LicenseID <= 0 ||
                CreatedByUserID <= 0 ||
                FineFees < 0)
                return false;

            if (LicenseInfo == null || !LicenseInfo.IsActive)
                return false;

            if (IsLicenseDetained(LicenseID))
                return false;

            return true;
        }

        public bool ReleaseDetainedLicense( int ReleasedByUserID, int ReleaseApplicationID)
        {
            return clsDetainedLicenseData.ReleaseDetainedLicense(this.DetainID, ReleasedByUserID, ReleaseApplicationID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
              
                case enMode.AddNew:

                    if (!_CanDetain())
                        return false;

                    DetainDate = DateTime.Now;

                    if (_AddNewDetainedLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:

                    return _UpdateDetainedLicense();

                default:
                    return false;
          
            
            }
        }

    }
}
