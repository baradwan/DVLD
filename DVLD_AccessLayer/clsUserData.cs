using DVLD_Global;
using DVLD_Global.DTOs;
using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_AccessLayer
{
    public class clsUserData
    {

        public static DataTable GetAllUsers()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);


            string query = @"select Users.UserID,Users.PersonID,
                FullName=People.FirstName+' '+People.SecondName+' '+ISNULL(People.ThirdName,'')+' '+People.LastName,
                Users.UserName,Users.IsActive 
                from People join Users ON People.PersonID=USERS.PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dataTable.Load(reader);

                reader.Close();

            }
            finally
            {
                connection.Close();
            }

            return dataTable;

        }

        public static bool GetUserByID(ref clsUserDTO UserDTO)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select * from Users where UserID=@UserID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserDTO.UserID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    //  UserDTO.UserID = (int)reader["UserID"];
                    UserDTO.PersonID = Convert.ToInt32( reader["PersonID"]);
                    UserDTO.UserName = reader["UserName"].ToString();
                    UserDTO.Password = reader["Password"].ToString();
                    UserDTO.IsActive = Convert.ToBoolean(reader["IsActive"]);
             


                }
                else

                    isFound = false;
                reader.Close();

            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static int AddNewUser(clsUserDTO UserDTO)
        {
            if (!clsnValidation.IsUserValid(UserDTO))
                return -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"INSERT INTO [dbo].[Users]
           ([PersonID]
           ,[UserName]
           ,[Password]
           ,[IsActive])
     VALUES
           (@PersonID
           ,@UserName
           ,@Password
           ,@IsActive);
          
     SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", UserDTO.PersonID);
            command.Parameters.AddWithValue("@UserName", UserDTO.UserName);
            command.Parameters.AddWithValue("@Password", UserDTO.Password);
            command.Parameters.AddWithValue("@IsActive",UserDTO.IsActive);
            


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                connection.Close();


                return result != null && int.TryParse(result.ToString(), out int InseartedID) ? InseartedID : -1;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }



        }

        public static bool UpdateUser(clsUserDTO UserDTO)
        {
            int rowAffected = 0;

            if (!clsnValidation.IsUserValid(UserDTO))
                return false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"Update Users
                            set PersonID = @PersonID,
                                UserName = @UserName,
                                Password = @Password,
                                IsActive = @IsActive
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserDTO.UserID);
            command.Parameters.AddWithValue("@PersonID", UserDTO.PersonID);
            command.Parameters.AddWithValue("@UserName", UserDTO.UserName);
            command.Parameters.AddWithValue("@Password", UserDTO.Password);
            command.Parameters.AddWithValue("@IsActive", UserDTO.IsActive);
           
           

            try
            {

                connection.Open();
                rowAffected = command.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return false;
                throw;
            }
            finally { connection.Close(); }

            return rowAffected > 0;


        }
        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Delete Users 
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);


        }


        public static bool IsUserExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool IsUserExist(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        //  public static bool IsUserExist(string NationalNo)

        //{
        //    bool isFound = false;
        //    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
        //    {

        //        string query = "SELECT Found=1 FROM Users WHERE NationalNo = @NationalNo";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@NationalNo", NationalNo.Trim());

        //        try
        //        {
        //            connection.Open();
        //            object result = command.ExecuteScalar();
        //            isFound = (result != null);
        //        }
        //        catch
        //        {
        //            isFound = false;


        //        }
        //        finally { connection.Close(); }
        //    }
        //    return isFound;
        //}
    }
}


