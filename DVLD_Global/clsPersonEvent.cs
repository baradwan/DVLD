using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Global
{
    /*
    Why are the events separated instead of using one generic event?

    Arabic:
    تم فصل الأحداث إلى:
    - PersonAdded
    - PersonUpdated
    - PersonDeleted

    بدلاً من استخدام حدث عام واحد مثل:
    PersonChanged

    والسبب هو:

    1- إعطاء معنى واضح لكل حدث (Semantic Events).
       بحيث تعرف مباشرة ماذا حدث داخل النظام.

    2- السماح لكل شاشة بالتعامل مع كل حالة بشكل مختلف.
       مثال:
       - عند الإضافة → إضافة صف جديد.
       - عند التعديل → تحديث صف موجود.
       - عند الحذف → إزالة صف من الـ Grid.

    3- تحسين التتبع والصيانة (Debugging & Maintenance).
       فعند قراءة:
       NotifyPersonDeleted(personID)

       يصبح واضح مباشرة أن الشخص تم حذفه.

    4- تقليل المعالجة غير الضرورية.
       لأن بعض الشاشات قد تهتم بالحذف فقط
       أو بالإضافة فقط.

    ------------------------------------------------------

    English:
    Events are separated into:
    - PersonAdded
    - PersonUpdated
    - PersonDeleted

    instead of using a single generic event like:
    PersonChanged

    Reasons:

    1- Provide semantic and meaningful system events.
       Each event clearly describes what happened.

    2- Allow each screen to react differently.
       Example:
       - Add → Insert new row.
       - Update → Refresh existing row.
       - Delete → Remove row from grid.

    3- Improve debugging and maintenance.
       Reading:
       NotifyPersonDeleted(personID)

       immediately explains the system action.

    4- Reduce unnecessary processing.
       Some screens may only care about deletion
       or insertion events.
*/


    public static class clsPersonEvents
    {
        public static event Action<int> PersonAdded;
        public static event Action<int> PersonUpdated;
        public static event Action<int> PersonDeleted;

        public static void NotifyPersonAdded(int personID)
        {
            PersonAdded?.Invoke(personID);
        }

        public static void NotifyPersonUpdated(int personID)
        {
            PersonUpdated?.Invoke(personID);
        }

        public static void NotifyPersonDeleted(int personID)
        {
            PersonDeleted?.Invoke(personID);
        }
    }
}


