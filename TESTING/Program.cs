using DVLD_BusinessLayer;
using DVLD_Global.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTING;

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
           // person.Print();
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

    class clsTestUser
    {
        // 1. الحصول على بيانات مستخدم افتراضية للتجربة
        private static clsUser _GetDefaultUser()
        {
            return new clsUser()
            {
                // يجب التأكد من وجود PersonID رقم 1 في قاعدة البيانات قبل الإضافة
                PersonID = 2084,
                UserName = "TestUser1",
                Password = "Password123",
                IsActive = true
            };
        }

        // دالة مساعدة لطباعة النتيجة بنفس تنسيقك
        private static void _PrintResult(string testName, bool success)
        {
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
            Console.ResetColor();
        }

        // 2. اختبار إضافة مستخدم جديد (Add New)
        public static void Test_AddNewUser()
        {
            clsUser User1 = _GetDefaultUser();

            // يمكنك تغيير اسم المستخدم هنا لتجنب تكرار البيانات (Unique Constraint)
            User1.UserName = "Omar_DVLD_" + Guid.NewGuid().ToString().Substring(0, 5);

            Console.WriteLine("Saving User to Database...");

            if (User1.Save())
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("✅ Success: User Added Successfully!");
                Console.WriteLine($"Generated UserID: {User1.userID}");
                Console.WriteLine($"Associated PersonID: {User1.PersonID}");
                Console.WriteLine($"Current Mode: {User1.Mode}");
                Console.WriteLine("--------------------------------------------");
            }
            else
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("❌ Error: Failed to Add User.");
                Console.WriteLine("Check your Database Connection or Constraints (e.g., PersonID exists, UserName is unique).");
                Console.WriteLine("--------------------------------------------");
            }
        }

        // 3. اختبار جلب جميع المستخدمين (List All)
        public static void Test_ListAllUsers()
        {
            Console.WriteLine("Testing: Retrieve All Users...");

            DataTable dtUsers = clsUser.ListAllUser(); // أو ListAllUsers() حسب المسمى في مشروعك

            bool isPassed = (dtUsers != null && dtUsers.Rows.Count > 0);
            _PrintResult("Retrieve All Users DataTable", isPassed);

            if (isPassed)
            {
                Console.WriteLine($"[INFO] Total Users Found: {dtUsers.Rows.Count}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"{"UserID",-8} | {"PersonID",-10} | {"UserName"}");
                Console.WriteLine("--------------------------------------------------");

               // int rowsToShow = Math.Min(dtUsers.Rows.Count);
                for (int i = 0; i < dtUsers.Rows.Count; i++)
                {
                    DataRow row = dtUsers.Rows[i];
                    Console.WriteLine($"{row["UserID"],-8} | {row["PersonID"],-10} | {row["UserName"]}");
                }
                Console.WriteLine("--------------------------------------------------");
            }
        }

        // 4. اختبار البحث عن مستخدم موجود (Find)
        public static void Test_FindUser_Existing(int UserID)
        {
            clsUser user = clsUser.Find(UserID); // أو Find(UserID)
            _PrintResult($"Find User By ID ({UserID})", user != null);

            if (user != null)
            {
                Console.WriteLine($"Found User: {user.UserName}, Active: {user.IsActive}");
            }
        }

        // 5. اختبار تحديث بيانات المستخدم (Update)
        public static void Test_UpdateUser(int UserID)
        {
            clsUser user = clsUser.Find(UserID);
            if (user == null)
            {
                _PrintResult($"Update Test (UserID {UserID} Not Found)", false);
                return;
            }

            // تغيير حالة التفعيل أو كلمة المرور للتجربة
            user.IsActive = !user.IsActive;
            user.Password = "NewPass789";
            Console.WriteLine($"DEBUG: Attempting to update User {user.userID} linked to Person {user.PersonID}");
            
            bool isSaved = user.Save();
            _PrintResult($"Update User ID {UserID}", isSaved);
        }

        // 6. اختبار حذف المستخدم (Delete)
        public static void Test_DeleteUser(int UserID)
        {
            bool isDeleted = clsUser.DeleteUser(UserID);
            _PrintResult($"Delete User ID {UserID}", isDeleted);

            if (isDeleted)
            {
                clsUser user = clsUser.Find(UserID);
                _PrintResult("Verify Deletion (User should be null)", user == null);
            }
        }

        // 7. اختبار التحقق من وجود المستخدم (Is Exist)
        public static void Test_IsUserExist(int UserID)
        {
            bool result = clsUser.IsUserExist(UserID);
            _PrintResult($"Check If User ID {UserID} Exists", result);
        }

        //public static void Test_IsUserExistByUserName(string UserName)
        //{
        //    bool result = clsUser.IsUserExist(UserName);
        //    _PrintResult($"Check Existence of UserName: {UserName}", result);
        //}
    }
}
internal class Program
    {
        static void Main(string[] args)
        {

        //  Tester.RunTest("Add New Person ", clsTestPeople._testPeopleAddNewPerson);
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



        ///////////                                                                 /////////////////////////
        ///                        USERS TESTS                                   ///////////////////////////////////
        ////
        ////




        // اختبار إضافة مستخدم جديد
       // Tester.RunTest("Add New User", clsTestUser.Test_AddNewUser);

        // اختبار عرض المستخدمين
        // Tester.RunTest("List All Users", clsTestUser.Test_ListAllUsers);

        // اختبار البحث (ضع رقم مستخدم موجود في قاعدة بياناتك)
        // Tester.RunTest("Find Existing User", () => clsTestUser.Test_FindUser_Existing(21));

        // اختبار التحديث
        // Tester.RunTest("Update User Logic", () => clsTestUser.Test_UpdateUser(21));

        // اختبار التحقق من اسم المستخدم
        // Tester.RunTest("Check UserName Exist", () => clsTestUser.Test_IsUserExistByUserName("Admin"));

        // اختبار الحذف (تحذير: سيحذف السجل من قاعدة البيانات)
        // Tester.RunTest("Delete User Logic", () => clsTestUser.Test_DeleteUser(21));
       // Console.ReadKey();


        //clsUserDTO user22 = new clsUserDTO();
        //user22.UserName = "Ahmed210";
        //user22.Password = "A1234";
        //clsUser user01 = clsUser.FindUserByUsernameAndPassword(user22.UserName, user22.Password);

        //Console.WriteLine("UserName: " + user01.UserName);
        //Console.WriteLine("Password : "+user01.Password);
        //Console.WriteLine("UserID: " + user01.userID);
        //Console.WriteLine("Person ID: " + user01.PersonID);
        //Console.WriteLine("IS Active: " + user01.IsActive);

        decimal Amount=312.78m;

        Console.WriteLine(Amount.ToString("C"));

        }
    
}


