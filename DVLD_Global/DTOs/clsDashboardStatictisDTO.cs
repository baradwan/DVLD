using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Global.DTOs
{
    public class clsDashboardStatisticsDTO
    {

        
            public int TotalDrivers { get; set; }
            public int ActiveLicenses { get; set; }
            public int DetainedLicenses { get; set; }
            public int TotalApplications { get; set; }
        
    }
}
