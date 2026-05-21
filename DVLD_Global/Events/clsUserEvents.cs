using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Global
{
    public static class clsUserEvents
    {

        public static event Action<int> UserAdded;
        public static event Action<int> UserUpdated;
        public static event Action<int> UserDeleted;

        public static void NotifyUserAdded(int UserID)
        {
            UserAdded?.Invoke(UserID);
        }

        public static void NotifyUserUpdated(int UserID)
        {
            UserUpdated?.Invoke(UserID);
        }

        public static void NotifyUserDeleted(int UserID)
        {
            UserDeleted?.Invoke(UserID);
        }
    }
}
