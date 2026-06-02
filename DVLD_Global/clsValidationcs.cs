using DVLD_Global.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVLD_Global
{
    public static class clsnValidation {

        public static bool IsPersonValid(clsPersonDTO personDTO)
        {
            
            
            if (string.IsNullOrWhiteSpace(personDTO.NationalNo)) return false;
            if (string.IsNullOrWhiteSpace(personDTO.FirstName)) return false;
            if (string.IsNullOrWhiteSpace(personDTO.SecondName)) return false;
            if (string.IsNullOrWhiteSpace(personDTO.LastName)) return false;
            if (string.IsNullOrWhiteSpace(personDTO.Address)) return false;
            if (string.IsNullOrWhiteSpace(personDTO.Phone)) return false;
            if (personDTO.Gendor < 0) return false;
            if (personDTO.NationalityCountryID <= 0) return false;
            if (DateTime.Today.AddYears(-18)<personDTO.DateOfBirth) return false;



            return true;
        }

        public static bool IsUserValid(clsUserDTO user) {

            if (user == null) return false;
            if (string.IsNullOrWhiteSpace(user.UserName)) return false;
            if (string.IsNullOrWhiteSpace(user.Password)) return false;
           if(user.PersonID<=0)return false;

            return true;

        }
        public static bool IsLocalDrivingLicenseApplicationValid(clsLocalDrivingLicenseApplicationDTO application)
        {
            if (application == null) return false;
            if(application.ApplicationID<=0)return false;
          if (application.LicenseClassID <= 0) return false;
            return true;
        }
        public static bool IsEmailValid(string Email)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var regex = new Regex(pattern);
            return regex.IsMatch(Email);


        }


        public static bool IsApplicationTypeValid(clsApplicationTypeDTO applicationType)
        {
            if (applicationType == null)
                return false;

            if (string.IsNullOrWhiteSpace(applicationType.Title))
                return false;

            if (applicationType.Fees < 0)
                return false;

            if (applicationType.ApplicationTypeID < 0)
                return false;
            return true;
        }

        public static bool IsApplicationValid(clsApplicationDTO application)
        {
            if (application == null) return false;
            
            if (application.PersonID <= 0) return false;
            if (application.ApplicationDate == DateTime.MinValue) return false;
            if (application.ApplicationTypeID <= 0) return false;
            if (application.ApplicationStatus < 0) return false;
            if(application.LastStatusDate == DateTime.MinValue) return false;
            if(application.PaidFees<0) return false;
            if(application.CreatedByUserID<=0) return false;


            if (application.PaidFees < 0) return false;
            return true;
        }

        public static bool IsLicenseClassValid(clsLicenseClassDTO licenseClass)
        {
            if (licenseClass == null) return false;
            if (string.IsNullOrWhiteSpace(licenseClass.ClassName)) return false;
            if(string.IsNullOrWhiteSpace(licenseClass.ClassDescription)) return false;

            if (licenseClass.MinAllowedAge <= 0) return false;
            if (licenseClass.DefaultValidityLength <= 0) return false;
            if (licenseClass.ClassFees < 0) return false;
            return true;
        }
        public static bool IsPositiveInteger(string text)
        {
            return int.TryParse(text, out int result) && result >= 0;
        }

        public static bool IsPositiveDecimal(string text)
        {
            return decimal.TryParse(text, out decimal result) && result >= 0;
        }

        
    }
}
