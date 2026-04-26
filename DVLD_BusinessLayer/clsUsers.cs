using DVLD_AccessLayer;
using DVLD_Global;
using DVLD_Global.DTOs;

using System.Data;


namespace DVLD_BusinessLayer
{
   

    public class clsUser
    {

        public enum enMode { AddNewUser = 0, UpdateUser = 1 };
        public enMode Mode = enMode.AddNewUser;

        public int userID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }


        public clsUserDTO UserDTO {

            get {

                return new clsUserDTO
                {
                    UserID = this.userID,
                    PersonID = this.PersonID,
                    UserName = this.UserName,
                    Password = this.Password,
                    IsActive = this.IsActive
                };
        }
        }


        public clsUser() { 
        
       userID = -1;
            PersonID = -1;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive=false;

            Mode = enMode.AddNewUser;

        }

        public clsUser(clsUserDTO UserDTO)
        {
            this.userID = UserDTO.UserID;
            this.PersonID = UserDTO.PersonID;
            this.UserName = UserDTO.UserName;
            this.Password = UserDTO.Password;
            this.IsActive = UserDTO.IsActive;
            Mode = enMode.UpdateUser;
        }

        ///////////////
        ///
        public static DataTable ListAllUser()
        {
            return clsUserData.GetAllUsers();
        }

        public static clsUser Find(int UserID)
        {
            clsUserDTO UserDTO = new clsUserDTO { UserID = UserID };



            if (clsUserData.GetUserByID(ref UserDTO))
                return new clsUser(UserDTO);
            return null;

        }



        /// <summary>
        /// Private method to call the DAL and add a new User / دالة خاصة لاستدعاء طبقة البيانات لإضافة شخص جديد
        /// </summary>
        /// <returns>True if added successfully / صحيح إذا تمت الإضافة بنجاح</returns>
        private bool _AddNewUser()
        {
            if (IsUserExist(this.userID))
                return false;

            this.userID = clsUserData.AddNewUser(this.UserDTO);
            return this.userID != -1;
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserDTO);
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }
        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }
        public static bool IsUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName.Trim().ToUpper());
        }
        private bool _IsValid()
        {

            return clsnValidation.IsUserValid(this.UserDTO);
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
                case enMode.AddNewUser:
                    if (IsUserExist(this.userID))
                        return false;

                    if (_AddNewUser())
                    {
                        Mode = enMode.UpdateUser;
                        return true;
                    }
                    return false;

                case enMode.UpdateUser:

                    return _UpdateUser();


            }
            return false;
        }

    }
}
