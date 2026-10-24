using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Global.Events
{
    public static class clsTestEvents
    {
        public static event Action<int> TestSaved;

        public static void NotifyTestSaved(int LocalDrivingLicenseApplicationID)
        {
            TestSaved?.Invoke(LocalDrivingLicenseApplicationID);
        }
    }
}
