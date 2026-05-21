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
    public static class clsTestTypesData
    {

        public static DataTable GetAllTestTypes()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                SELECT 
                    TestTypeID,
                    TestTypeTitle,
                    TestTypeDescription,
                    TestTypeFees
                FROM TestTypes;";

            SqlCommand cmd = new SqlCommand(query, connection);

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

        public static bool GetTestTypeByID(clsTestTypesDTO testTypeDTO)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                SELECT *
                FROM TestTypes
                WHERE TestTypeID = @TestTypeID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", testTypeDTO.TestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    testTypeDTO.Title = reader["TestTypeTitle"].ToString();
                    testTypeDTO.Description = reader["TestTypeDescription"].ToString();
                    testTypeDTO.Fees = Convert.ToDecimal(reader["TestTypeFees"]);
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewTestType(clsTestTypesDTO testTypeDTO)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                INSERT INTO TestTypes
                (
                    TestTypeTitle,
                    TestTypeDescription,
                    TestTypeFees
                )
                VALUES
                (
                    @TestTypeTitle,
                    @TestTypeDescription,
                    @TestTypeFees
                );

                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeTitle", testTypeDTO.Title);
            command.Parameters.AddWithValue("@TestTypeDescription", testTypeDTO.Description);
            command.Parameters.AddWithValue("@TestTypeFees", testTypeDTO.Fees);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                return result != null && int.TryParse(result.ToString(), out int insertedID)
                    ? insertedID
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

        public static bool UpdateTestType(clsTestTypesDTO testTypeDTO)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                UPDATE TestTypes
                SET 
                    TestTypeTitle = @TestTypeTitle,
                    TestTypeDescription = @TestTypeDescription,
                    TestTypeFees = @TestTypeFees
                WHERE TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", testTypeDTO.TestTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", testTypeDTO.Title);
            command.Parameters.AddWithValue("@TestTypeDescription", testTypeDTO.Description);
            command.Parameters.AddWithValue("@TestTypeFees", testTypeDTO.Fees);

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

