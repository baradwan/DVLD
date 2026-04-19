using DVLD_AccessLayer;
using DVLD_Global;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace DVLD_BusinessLayer
{
    /// <summary>
    /// Business Logic Layer class for managing people data / كلاس طبقة منطق العمل لإدارة بيانات الأشخاص
    /// </summary>
    public class clsPerson
    {

        public void Print()
        {
            Console.WriteLine("\n==================================================");
            Console.WriteLine("                PERSON FULL DETAILS               ");
            Console.WriteLine("==================================================");

            Console.WriteLine($"ID              : {this.PersonID}");
            Console.WriteLine($"National No     : {this.NationalNo}");

            // Handling ThirdName (it can be empty)
            string fullName = $"{this.FirstName} {this.SecondName} {this.ThirdName} {this.LastName}".Replace("  ", " ");
            Console.WriteLine($"Full Name       : {fullName}");

            // Individual Name Components
            Console.WriteLine($"First Name      : {this.FirstName}");
            Console.WriteLine($"Second Name     : {this.SecondName}");
            Console.WriteLine($"Third Name      : {(string.IsNullOrEmpty(this.ThirdName) ? "[None]" : this.ThirdName)}");
            Console.WriteLine($"Last Name       : {this.LastName}");

            // Formatting Date
            Console.WriteLine($"Date Of Birth   : {this.DateOfBirth.ToShortDateString()}");

            // Gender Logic (0: Male, 1: Female)
            Console.WriteLine($"Gender          : {(this.Gendor == 0 ? "Male" : "Female")}");

            Console.WriteLine($"Nationality ID  : {this.NationalityCountryID}");
            Console.WriteLine($"Phone           : {this.Phone}");

            // Handling Nullable/Optional Fields
            Console.WriteLine($"Email           : {(string.IsNullOrEmpty(this.Email) ? "N/A" : this.Email)}");
            Console.WriteLine($"Address         : {this.Address}");

            // Image Path
            Console.WriteLine($"Image Path      : {(string.IsNullOrEmpty(this.ImagePath) ? "No Image" : this.ImagePath)}");

            Console.WriteLine("==================================================\n");
        }
        /// <summary>
        /// Defines whether the object is for a new record or an update / يحدد ما إذا كان الكائن لسجل جديد أو لتعديل سجل موجود
        /// </summary>
        public enum enMode { AddNewPerson = 0, UpdatePerson = 1 };
        public enMode Mode = enMode.AddNewPerson;



        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

        }
        public DateTime DateOfBirth { get; set; }
        public short Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }

        /// <summary>
        /// Converts the current business object to a DTO for data transfer / يحول كائن البزنس الحالي إلى DTO لنقل البيانات بين الطبقات
        /// </summary>
        public clsPersonDTO PersonDTO
        {
            get
            {
                return new clsPersonDTO
                {
                    PersonID = this.PersonID,
                    NationalNo = this.NationalNo,
                    FirstName = this.FirstName,
                    SecondName = this.SecondName,
                    ThirdName = this.ThirdName,
                    LastName = this.LastName,
                    DateOfBirth = this.DateOfBirth,
                    Gendor = this.Gendor,
                    Address = this.Address,
                    Phone = this.Phone,
                    Email = this.Email,
                    NationalityCountryID = this.NationalityCountryID,
                    ImagePath = this.ImagePath
                };
            }
        }
        


        /// <summary>
        /// Default constructor to initialize a new person object / التهيئة كائن شخص جديد Default constructor
        /// </summary>
        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = -1;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNewPerson;
        }

        /// <summary>
        /// Constructor to initialize a person object from a DTO /   لتهيئة كائن شخص من خلال كائن نقل بيانات constructor
        /// </summary>

        public clsPerson( clsPersonDTO personDTO)
        {
            this.PersonID = personDTO.PersonID;
            this.NationalNo = personDTO.NationalNo;
            this.FirstName = personDTO.FirstName;
            this.SecondName = personDTO.SecondName;
            this.ThirdName = personDTO.ThirdName;
            this.LastName = personDTO.LastName;
            this.DateOfBirth = personDTO.DateOfBirth;
            this.Gendor = personDTO.Gendor;
            this.Address = personDTO.Address;
            this.Phone = personDTO.Phone;
            this.Email = personDTO.Email;
            this.NationalityCountryID = personDTO.NationalityCountryID;
            this.ImagePath = personDTO.ImagePath;

            this.Mode = enMode.UpdatePerson;
        }

        public static DataTable ListAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        public static clsPerson Find(int PersonID)
        {
            clsPersonDTO PersonDTO = new clsPersonDTO { PersonID = PersonID };



            if (clsPersonData.GetPersonByID(ref PersonDTO))
                return new clsPerson(PersonDTO);
            return null;

        }

        public static clsPerson Find(string NationalNO)
        {
            clsPersonDTO PersonDTO = new clsPersonDTO { NationalNo = NationalNO };



            if (clsPersonData.GetPersonByNationalNo(ref PersonDTO))
                return new clsPerson(PersonDTO);
            return null;

        }

        /// <summary>
        /// Private method to call the DAL and add a new person / دالة خاصة لاستدعاء طبقة البيانات لإضافة شخص جديد
        /// </summary>
        /// <returns>True if added successfully / صحيح إذا تمت الإضافة بنجاح</returns>
        private bool _AddNewPerson()
        {
            if (IsPersonExist(this.NationalNo))
                return false;

            this.PersonID = clsPersonData.AddNewPerson(this.PersonDTO);
            return this.PersonID != -1;
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonDTO);
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }
        public static bool  IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }
        public static bool IsPersonExist(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo.Trim().ToUpper());
        }
        private bool _IsValid()
        {

            return clsnValidation.IsPersonValid(this.PersonDTO);
        }


        /// <summary>
        /// Main method to save the record (Add or Update) / الدالة الرئيسية لحفظ السجل (إضافة أو تعديل)
        /// </summary>
        /// <returns>True if saved successfully / صحيح إذا تمت عملية الحفظ بنجاح</returns>
        public bool Save()
        {

            if (!_IsValid())
            {
                return false;
            }
            switch (Mode)
            {
                case enMode.AddNewPerson:
                    if (IsPersonExist(this.NationalNo))
                        return false;

                    if (_AddNewPerson())
                    {
                        Mode = enMode.UpdatePerson;
                        return true;
                    }
                    return false;

                case enMode.UpdatePerson:

                    return _UpdatePerson();


            }
            return false;
        }



    }
}