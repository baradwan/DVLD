using DVLD_Global;
using DVLD_Global.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_AccessLayer
{
    public  static class clsLicenseClassData
    {

        public static DataTable GetAllLicenseClasses()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);


            string query = @"select * from LicenseClasses;";

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

        public static clsLicenseClassDTO GetLicenseClassByID(int LicenseClassID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select * from LicenseClasses where LicenseClassID=@LicenseClassID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                   return new clsLicenseClassDTO
                    {

                        ClassName = reader["ClassName"].ToString(),
                        ClassDescription = reader["ClassDescription"].ToString(),
                        MinAllowedAge = Convert.ToByte(reader["MinimumAllowedAge"]),
                        DefaultValidityLength = Convert.ToByte(reader["DefaultValidityLength"]),
                        ClassFees = Convert.ToDecimal(reader["ClassFees"])

                    };


                }
                else

                    
                reader.Close();

            }
            finally
            {
                connection.Close();
            }
            return null;
        }
        public static int AddNewLicenseClass(clsLicenseClassDTO LicenseClassDTO)
        {
            if (!clsnValidation.IsLicenseClassValid(LicenseClassDTO))
                return -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"INSERT INTO [dbo].[LicenseClasses]
           ([ClassName]
           ,[ClassDescription]
           ,[MinimumAllowedAge]
           ,[DefaultValidityLength]
           ,[ClassFees])
     VALUES
           (@ClassName
           ,@ClassDescription
           ,@MinAllowedAge
           ,@DefaultValidatyLength
           ,@ClassFees);
          
     SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassName", LicenseClassDTO.ClassName);
            command.Parameters.AddWithValue("@ClassDescription", LicenseClassDTO.ClassDescription);
            command.Parameters.AddWithValue("@MinAllowedAge", LicenseClassDTO.MinAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidatyLength", LicenseClassDTO.DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", LicenseClassDTO.ClassFees);



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

        public static bool UpdateLicenseClass(clsLicenseClassDTO LicenseClassDTO)
        {
            int rowAffected = 0;

            if (!clsnValidation.IsLicenseClassValid(LicenseClassDTO))
                return false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"Update LicenseClasses
                            set ClassName = @ClassName,
                                ClassDescription = @ClassDescription,
                                MinimumAllowedAge = @MinimumAllowedAge,
                                DefaultValidityLength = @DefaultValidityLength,
                                ClassFees = @ClassFees
                                where LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

          
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassDTO.LicenseClassID);
            command.Parameters.AddWithValue("@ClassName", LicenseClassDTO.ClassName);
            command.Parameters.AddWithValue("@ClassDescription", LicenseClassDTO.ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", LicenseClassDTO.MinAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", LicenseClassDTO.DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", LicenseClassDTO.ClassFees);


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
        public static bool DeleteLicenseClass(int LicenseClassID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Delete LicenseClasses 
                                where LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

    }
}
