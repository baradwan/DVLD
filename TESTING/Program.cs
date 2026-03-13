using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
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
            Person1.NationalNo = "N3";


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
        private static void _PrintResult(string testName, bool success)
        {
            // ضبط المسافة لجعل النتائج محاذية لبعضها البعض
            Console.Write($"{testName,-40} : ");

            if (success)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED ✅");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FAILED ❌");
            }

            // إعادة لون الكونسول للوضع الافتراضي
            Console.ResetColor();
        }
        public static void _testPeopleListPeople() {

            Console.WriteLine("Testing: Retrieve All People...");

            // 1. استدعاء الدالة من طبقة البزنس
            DataTable dtPeople = clsPerson.ListAllPeople();

            // 2. التحقق الفعال (Validation)
            // نعتبر الاختبار ناجحاً إذا كان الجدول غير نل ويحتوي على سجلات
            bool isPassed = (dtPeople != null && dtPeople.Rows.Count > 0);

            // 3. طباعة النتيجة بالألوان
            _PrintResult("Retrieve All People DataTable", isPassed);

            if (isPassed)
            {
                Console.WriteLine($"[INFO] Total Records Found: {dtPeople.Rows.Count}");

                // طباعة ترويسة بسيطة للبيانات للتأكد بصرياً
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"{"ID",-5} | {"National No",-15} | {"Full Name"}");
                Console.WriteLine("--------------------------------------------------");

                // عرض أول 3 سجلات فقط كمثال
                int rowsToShow = Math.Min(dtPeople.Rows.Count, 3);
                for (int i = 0; i < rowsToShow; i++)
                {
                    DataRow row = dtPeople.Rows[i];
                    string fullName = $"{row["FirstName"]} {row["LastName"]}";
                    Console.WriteLine($"{row["PersonID"],-5} | {row["NationalNo"],-15} | {fullName}");
                }
                Console.WriteLine("--------------------------------------------------");
            }
            else
            {
                Console.WriteLine("⚠️ Warning: No data found in People table or Connection error.");
            }
        }

        public static void Test_FindPerson_Existing(int ID)
        {
            // Assuming ID 1 exists in your database
            clsPerson person = clsPerson.Find(ID);
            _PrintResult("Find Person By ID (Existing)", person != null);
            person.Print();
        }

        // 2. Test finding a person that does NOT exist
        public static void Test_FindPerson_NotFound()
        {
            clsPerson person = clsPerson.Find(-1); // ID -1 never exists
            _PrintResult("Find Person By ID (Not Found)", person == null);
        }


        public static void Test_UpdatePerson(int ID)
        {
            clsPerson person = clsPerson.Find(ID);
            if (person == null)
            {
                _PrintResult($"Update Test (ID {ID} Not Found)", false);
                return;
            }

            // تغيير قيمة معينة للتجربة
            string newPhone = "000-000-0000";
            person.Phone = newPhone;

            // استدعاء Save (ستقوم بعمل Update داخلياً لأن المود هو Update)
            bool isSaved = person.Save();
            _PrintResult($"Update Person ID {ID}", isSaved);

            // التأكد من أن القيمة تغيرت فعلياً في قاعدة البيانات
            if (isSaved)
            {
                clsPerson updatedPerson = clsPerson.Find(ID);
                _PrintResult("Verify Update Integrity", updatedPerson.Phone == newPhone);
            }
        }

        // 2. اختبار الحذف (Delete Test)
        public static void Test_DeletePerson(int ID)
        {
            // نقوم بالحذف مباشرة
            bool isDeleted = clsPerson.DeletePerson(ID);
            _PrintResult($"Delete Person ID {ID}", isDeleted);

            // التأكد من أن البحث عنه الآن يعود بـ null
            if (isDeleted)
            {
                clsPerson person = clsPerson.Find(ID);
                _PrintResult("Verify Deletion", person == null);
            }
        }


        public static void Test_IsPersonExist(int ID)
        {
            // اختبار البحث عن شخص موجود
            bool result = clsPerson.IsPersonExist(ID);
            _PrintResult($"Check If Person ID {ID} Exists", result);
        }

        public static void Test_IsPersonNotExist()
        {
            // اختبار البحث عن رقم غير منطقي
            bool result = clsPerson.IsPersonExist(-1);
            _PrintResult("Check If Person ID -1 Exists (Should be False)", result == false);
        }

        public static void Test_IsPersonExistByNationalNo(string NationalNo)
        {
            // استدعاء البزنس للتحقق من الرقم الوطني
            bool result = clsPerson.IsPersonExist(NationalNo.Trim());

            _PrintResult($"Check Existence of National No: {NationalNo}", result);
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
            //Tester.RunTest("List All People ", clsTestPeople._testPeopleListPeople);
           // Tester.RunTest("Check Find With Existing Value", ()=>clsTestPeople.Test_FindPerson_Existing(1024));
            //Tester.RunTest("Check Find With NOT Existing Value", clsTestPeople.Test_FindPerson_NotFound);
            //Tester.RunTest("Update Person Logic",()=> clsTestPeople.Test_UpdatePerson(1024));

            //// 4. اختبار الحذف (تنبيه: سيحذف السجل نهائياً!)'

            // Tester.RunTest("Delete Person Logic", () => clsTestPeople.Test_DeletePerson(1036));
            //Tester.RunTest("Is exist person with correct data ", ()=> clsTestPeople.Test_IsPersonExist(1024));
            //Tester.RunTest("Is exist person with incorrect data ", () => clsTestPeople.Test_IsPersonExist(-1));

           //Tester.RunTest("Existence Check (By National No)", () => clsTestPeople.Test_IsPersonExistByNationalNo("N1"));

            //// اختبار رقم وطني غير موجود
            //\\Tester.RunTest("Existence Check (Not Found)", () => clsTestPeople.Test_IsPersonExistByNationalNo("XYZ-999"));
            Console.ReadKey();

        }
    }
}


