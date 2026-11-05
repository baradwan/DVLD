using DVLD_AccessLayer.DVLD_AccessLayer;
using DVLD_Global.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsDashboard
    {
       
            public static clsDashboardStatisticsDTO GetStatistics()
            {
                return clsDashboardData.GetStatistics();
            }
        
    }
}
