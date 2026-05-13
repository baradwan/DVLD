using DVLD_Global;
using DVLD_Global.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_AccessLayer
{
    public class clsApplicationTypeData
    {
        public static DataTable GetAllApplicationType() { 
        
            DataTable dataTable=new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select ApplicationTypeID,ApplicationTypeTitle,ApplicationFees  from ApplicationTypes;";

            SqlCommand cmd=new SqlCommand(query, connection);



            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

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

        public static bool GetApplicationTypeByID(clsApplicationTypeDTO AppTypeDTO)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query ="select * from ApplicationTypes where ApplicationTypeID=@ApplicationTypeID;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationTypeID", AppTypeDTO.ApplicationTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    
                   AppTypeDTO.Title = reader["ApplicationTypeTitle"].ToString();
                    AppTypeDTO.Fees = Convert.ToDecimal(reader["ApplicationFees"]);
                  
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
        public static int AddNewApplicationType(clsApplicationTypeDTO ApplicationTypeDTO)
        {
            if (!clsnValidation.IsApplicationTypeValid(ApplicationTypeDTO))
                return -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO ApplicationTypes
                    (
                        ApplicationTypeTitle,
                        ApplicationFees
                    )
                    VALUES
                    (
                        @ApplicationTypeTitle,
                        @ApplicationFees
                    );

                    SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeDTO.Title);

            command.Parameters.AddWithValue("@ApplicationFees",
                ApplicationTypeDTO.Fees);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                return (result != null &&
                        int.TryParse(result.ToString(), out int InsertedID))
                        ? InsertedID
                        : -1;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }

            finally
            {
                connection.Close();
            }
        }

        public static bool UpdateApplicationType( clsApplicationTypeDTO ApplicationTypeDTO)
        {
            if (!clsnValidation.IsApplicationTypeValid(ApplicationTypeDTO))
                return false;
            int rowsAffected = 0;

            SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE ApplicationTypes
                    SET
                        ApplicationTypeTitle = @ApplicationTypeTitle,
                        ApplicationFees = @ApplicationFees
                    WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID",
                ApplicationTypeDTO.ApplicationTypeID);

            command.Parameters.AddWithValue("@ApplicationTypeTitle",
                ApplicationTypeDTO.Title);

            command.Parameters.AddWithValue("@ApplicationFees",
                ApplicationTypeDTO.Fees);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }
    }
}
