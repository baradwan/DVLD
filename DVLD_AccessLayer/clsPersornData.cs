using DVLD_Global;
using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_AccessLayer
{
    public class clsPersonData
    {
        //ahmed

        int Ahmed = 0;
        public static DataTable GetAllPeople()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select * from People;";

            SqlCommand command= new SqlCommand(query, connection);

            DataTable dataTable=new DataTable();

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dataTable .Load( reader);

                reader.Close();

            }
            finally
            {
                connection.Close();
            }

return dataTable;

        }


        public static int AddNewPerson( clsPersonDTO personDTO )
        {
            if (!clsnValidation.IsPersonValid(personDTO))
                return -1;
        
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"INSERT INTO [dbo].[People]
           ([NationalNo]
           ,[FirstName]
           ,[SecondName]
           ,[ThirdName]
           ,[LastName]
           ,[DateOfBirth]
           ,[Gendor]
           ,[Address]
           ,[Phone]
           ,[Email]
           ,[NationalityCountryID]
           ,[ImagePath])
     VALUES
           (@NationalNo
           ,@FirstName
           ,@SecondName
           ,@ThirdName
           ,@LastName
           ,@DateOfBirth
           ,@Gendor
           ,@Address
           ,@Phone
           ,@Email
           ,@NationalityCountryID
           ,@ImagePath);
     SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", personDTO.NationalNo);
            command.Parameters.AddWithValue("@FirstName", personDTO.FirstName);
            command.Parameters.AddWithValue("@SecondName", personDTO.SecondName);
            command.Parameters.AddWithValue("@ThirdName", clsSqlHelper.ToDBValue(personDTO.ThirdName));
            command.Parameters.AddWithValue("@LastName", personDTO.LastName);
            command.Parameters.AddWithValue("@DateOfBirth", personDTO.DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", personDTO.Gendor);
            command.Parameters.AddWithValue("@Address", personDTO.Address);
            command.Parameters.AddWithValue("@Phone", personDTO.Phone);
            command.Parameters.AddWithValue("@Email", clsSqlHelper.ToDBValue(personDTO.Email));
            command.Parameters.AddWithValue("@NationalityCountryID", personDTO.NationalityCountryID);
            command.Parameters.AddWithValue("@ImagePath", clsSqlHelper.ToDBValue(personDTO.ImagePath));


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



    }
}
