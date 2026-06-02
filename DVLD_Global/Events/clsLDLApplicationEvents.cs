using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Global.Events
{
    public static class clsLDLApplicationEvents
    {
        public static event Action<int> LocalDrivingLicenseApplicationAdded;
        public static event Action<int> LocalDrivingLicenseApplicationUpdated;
        public static event Action<int> LocalDrivingLicenseApplicationDeleted;

        public static void NotifyLocalDrivingLicenseApplicationAdded(int localDrivingLicenseApplicationID)
        {
            LocalDrivingLicenseApplicationAdded?.Invoke(localDrivingLicenseApplicationID);
        }

        public static void NotifyLocalDrivingLicenseApplicationUpdated(int localDrivingLicenseApplicationID)
        {
            LocalDrivingLicenseApplicationUpdated?.Invoke(localDrivingLicenseApplicationID);
        }

        public static void NotifyLocalDrivingLicenseApplicationDeleted(int localDrivingLicenseApplicationID)
        {
            LocalDrivingLicenseApplicationDeleted?.Invoke(localDrivingLicenseApplicationID);
        }
    }
}
