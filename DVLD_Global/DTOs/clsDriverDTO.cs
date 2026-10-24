using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Global.DTOs
{
    public class clsDriverDTO
    {
        public int DriverID { get; set; } = -1;
        public int PersonID { get; set; } = -1;
        public int CreatedByUserID { get; set; } = -1;
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
