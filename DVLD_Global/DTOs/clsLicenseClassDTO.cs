using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Global.DTOs
{
    public class clsLicenseClassDTO
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinAllowedAge { get; set; }
        public byte DefaultValidatyLength { get; set; }
        public decimal ClassFees { get; set; }
    }
}
