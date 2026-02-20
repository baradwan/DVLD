using DVLD_Global;
using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_AccessLayer
{
    public class clsPersonData
    {
        
        public static DataTable GetAllPeople()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);


            string query =
              @"SELECT People.PersonID, People.NationalNo,
              People.FirstName, People.SecondName, People.ThirdName, People.LastName,
			  People.DateOfBirth, People.Gendor,  
				  CASE
                  WHEN People.Gendor = 0 THEN 'Male'

                  ELSE 'Female'

                  END as GendorCaption ,
			  People.Address, People.Phone, People.Email, 
              People.NationalityCountryID, Countries.CountryName, People.ImagePath
              FROM            People INNER JOIN
                         Countries ON People.NationalityCountryID = Countries.CountryID
                ORDER BY People.FirstName";

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

        public static bool GetPersonByID(ref clsPersonDTO personDTO)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select * from People where PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", personDTO. PersonID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                   
                      //  personDTO.PersonID = (int)reader["PersonID"];
                    personDTO.NationalNo = reader["NationalNo"].ToString();
                    personDTO.FirstName = reader["FirstName"].ToString();
                    personDTO.SecondName = reader["SecondName"].ToString();
                    personDTO.ThirdName = clsSqlHelper.FillReaderAllowNull(reader, "ThirdName");
                    personDTO.LastName = reader["LastName"].ToString();
                    personDTO.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    personDTO.Gendor = Convert.ToInt16(reader["Gendor"]);
                    personDTO.Address = reader["Address"].ToString();
                    personDTO.Phone = reader["Phone"].ToString();
                    personDTO.Email = clsSqlHelper.FillReaderAllowNull(reader, "Email");
                    personDTO.NationalityCountryID = Convert.ToInt16(reader["NationalityCountryID"]);
                    personDTO.ImagePath = clsSqlHelper.FillReaderAllowNull(reader, "ImagePath");





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

        public static bool UpdatePerson(clsPersonDTO personDTO)
        {
            int rowAffected = 0;

            if (!clsnValidation.IsPersonValid(personDTO))
                return false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"UPDATE People 
                 SET NationalNo = @NationalNo, 
                     FirstName = @FirstName, 
                     SecondName = @SecondName, 
                     ThirdName = @ThirdName, 
                     LastName = @LastName, 
                     DateOfBirth = @DateOfBirth, 
                     Gendor = @Gendor, 
                     Address = @Address, 
                     Phone = @Phone, 
                     Email = @Email, 
                     NationalityCountryID = @NationalityCountryID, 
                     ImagePath = @ImagePath
                 WHERE PersonID = @PersonID";

            SqlCommand command =new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personDTO.PersonID);
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
        public static bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Delete People 
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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


        public static bool IsPersonExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

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

        public static bool IsPersonExist(string NationalNo)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
            
                string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NationalNo", NationalNo.Trim());

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    isFound = (result != null);
                }
                catch { isFound = false;
                
                    
                }finally { connection.Close(); }
            }
            return isFound;
        }
    }
}


