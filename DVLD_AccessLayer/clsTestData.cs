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
    public class clsTestData
    {
        public static int AddNewTest(clsTestDTO TestDTO)
        {
            int TestID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Insert Into Tests (TestAppointmentID,TestResult,
                                                Notes,   CreatedByUserID)
                            Values (@TestAppointmentID,@TestResult,
                                                @Notes,   @CreatedByUserID);
                            
                                UPDATE TestAppointments 
                                SET IsLocked=1 where TestAppointmentID = @TestAppointmentID;

                                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue( "@TestAppointmentID", TestDTO.TestAppointmentID);

            command.Parameters.AddWithValue( "@TestResult", TestDTO.TestResult);

            command.Parameters.AddWithValue("@Notes", clsSqlHelper.ToDBValue(TestDTO.Notes));

            command.Parameters.AddWithValue( "@CreatedByUserID", TestDTO.CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    TestID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return TestID;
        }

        public static int GetTestID(int TestAppointmentID) {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"  select t.TestID
                  from tests t
                  join TestAppointments ts
                  on ts.TestAppointmentID=t.TestAppointmentID
                   where ts.TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return TestID;


        }
        public static clsTestDTO GetTestByID(int TestID)
        {
            clsTestDTO TestDTO = null;

            SqlConnection connection = new SqlConnection(
                clsDataAccessSettings.connectionString);

            string query = @"SELECT *
                             FROM Tests
                             WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestDTO = new clsTestDTO
                    {
                        TestID = Convert.ToInt32(reader["TestID"]),

                        TestAppointmentID = Convert.ToInt32(
                            reader["TestAppointmentID"]),

                        TestResult = Convert.ToBoolean(
                            reader["TestResult"]),

                        Notes =clsSqlHelper.FillReaderAllowNull(reader, "Notes"),

                        CreatedByUserID = Convert.ToInt32(
                            reader["CreatedByUserID"])
                    };
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return TestDTO;
        }


        public static bool UpdateTest(clsTestDTO TestDTO)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(
                clsDataAccessSettings.connectionString);

            string query = @"UPDATE Tests
                             SET TestAppointmentID = @TestAppointmentID,
                                 TestResult = @TestResult,
                                 Notes = @Notes,
                                 CreatedByUserID = @CreatedByUserID
                             WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@TestID", TestDTO.TestID);

            command.Parameters.AddWithValue(
                "@TestAppointmentID", TestDTO.TestAppointmentID);

            command.Parameters.AddWithValue(
                "@TestResult", TestDTO.TestResult);

            command.Parameters.Add("@Notes", SqlDbType.NVarChar, 500)
                   .Value = (object)TestDTO.Notes ?? DBNull.Value;

            command.Parameters.AddWithValue(
                "@CreatedByUserID", TestDTO.CreatedByUserID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }
        public static DataTable GetAllTests()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Tests order by TestID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID) {


            byte PassedTestCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT PassedTestCount = count(TestTypeID)
                         FROM Tests INNER JOIN
                         TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
						 where LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID and TestResult=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte ptCount))
                {
                    PassedTestCount = ptCount;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return PassedTestCount;
        }
    }
}

