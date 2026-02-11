using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTING
{
    class clsTestPeople
    {

        private static clsPerson _GetDefaultPerson()
        {
            // استخدام GUID لضمان رقم وطني فريد تماماً في كل عملية اختبار
            

            return new clsPerson()
            {
                NationalNo = "A1" ,
                FirstName = "Omar",
                SecondName = "Khalid",
                ThirdName = "",
                LastName = "Mansour",
                DateOfBirth = new DateTime(1998, 10, 20),
                Gendor = 0, // 0 للمذكر، 1 للمؤنث
                Address = "Saudi Arabia - Riyadh - King Fahd Rd",
                Phone = "0501234567",
                Email = "omar.k@outlook.com",
                NationalityCountryID = 1, // تأكد من وجود الدولة رقم 1 في جدول Countries
                ImagePath = ""
            };
        }
        public static void _testPeopleAddNewPerson()
        {
            // 1. إنشاء كائن جديد (سيكون المود تلقائياً AddNew)
            clsPerson Person1 = new clsPerson();

            Person1 = _GetDefaultPerson();
            Person1.FirstName = "dfg";
            Person1.SecondName = "    ";


            // 3. محاولة الحفظ
            Console.WriteLine("Saving Person to Database...");

            if (Person1.Save())
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("✅ Success: Person Added Successfully!");
                Console.WriteLine($"Generated PersonID: {Person1.PersonID}");
                Console.WriteLine($"Current Mode: {Person1.Mode}"); // يجب أن يكون Update الآن
                Console.WriteLine("--------------------------------------------");
            }
            else
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("❌ Error: Failed to Add Person.");
                Console.WriteLine("Check your Database Connection or Constraints.");
                Console.WriteLine("--------------------------------------------");
            }
        }
    }


    class Tester
    {



        public static void RunTest(string testName,Action ActionTest)
        {
            Console.WriteLine($"\n>>> Running: {testName} <<<");
            Console.WriteLine("--------------------------------------------");

            try
            {
                ActionTest.Invoke(); // هنا يتم استدعاء ميثود الاختبار التي أرسلتها
            }
            catch (Exception ex)
            {
                Console.WriteLine($"💥 Exception: {ex.Message}");
            }

            Console.WriteLine("--------------------------------------------");
        
    }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Tester.RunTest("Add New Person ", clsTestPeople._testPeopleAddNewPerson);
           
          
          
            Console.ReadKey();
        }
    }
}
