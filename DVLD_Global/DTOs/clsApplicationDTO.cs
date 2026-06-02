using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Global.DTOs
{
    public  class clsApplicationDTO
    {
        public  int ApplicationID { get; set; }
        public int PersonID { get; set; }
        public DateTime ApplicationDate { get; set; }

        public int ApplicationTypeID { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }

        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

    }
}
