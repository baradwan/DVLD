using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    }
}
