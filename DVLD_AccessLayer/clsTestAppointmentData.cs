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
    public class clsTestAppointmentData
    {
        public static clsTestAppointmentDTO GetTestAppointmentID(int TestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
  SELECT * 
  FROM TestAppointments
  WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new clsTestAppointmentDTO
                    {
                        TestAppointmentID =
        Convert.ToInt32(reader["TestAppointmentID"]),

                        TestTypeID =
        Convert.ToInt32(reader["TestTypeID"]),

                        LocalDrivingLicenseApplicationID =
        Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]),

                        AppointmentDate =
        Convert.ToDateTime(reader["AppointmentDate"]),

                        PaidFees =
        Convert.ToDecimal(reader["PaidFees"]),

                        CreatedByUserID =
        Convert.ToInt32(reader["CreatedByUser"]),

                        IsLocked =
        Convert.ToBoolean(reader["IsLocked"]),

                        RetakeTestApplicationID =
        reader["RetakeTestApplicationID"] == DBNull.Value
            ? -1
            : Convert.ToInt32(reader["RetakeTestApplicationID"])
                    };

                }



                else
                {
                    reader.Close();
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }

        }


        public static DataTable GetAllTestAppointments()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);



            string query = @"select * from TestAppointments_View
                                  order by AppointmentDate Desc";


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

        public static clsTestAppointmentDTO GetLastTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELECT       top 1 *
                FROM            TestAppointments
                WHERE        (TestTypeID = @TestTypeID) 
                AND (LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                order by TestAppointmentID Desc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    return new clsTestAppointmentDTO
                    {
                        TestAppointmentID = Convert.ToInt32(reader["TestAppointmentID"]),

                        AppointmentDate = Convert.ToDateTime(reader["AppointmentDate"]),

                        PaidFees = Convert.ToDecimal(reader["PaidFees"]),

                        CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),

                        IsLocked = Convert.ToBoolean(reader["IsLocked"]),

                        RetakeTestApplicationID =
                            reader["RetakeTestApplicationID"] == DBNull.Value
                                ? -1
                                : Convert.ToInt32(reader["RetakeTestApplicationID"])
                                
                    };


                }
                

                reader.Close();


            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            
            }
            return null;

        }
        public static int AddNewTestAppointment(clsTestAppointmentDTO TestAppointmentDTO)
        {
            if (!clsnValidation.IsTestAppointmentValid(TestAppointmentDTO))
                return -1;

            SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
        INSERT INTO [dbo].[TestAppointments]
        (
            [TestTypeID],
            [LocalDrivingLicenseApplicationID],
            [AppointmentDate],
            [PaidFees],
            [CreatedByUserID],
            [IsLocked],
            [RetakeTestApplicationID]
        )
        VALUES
        (
            @TestTypeID,
            @LocalDrivingLicenseApplicationID,
            @AppointmentDate,
            @PaidFees,
            @CreatedByUserID,
            @IsLocked,
            @RetakeTestApplicationID
        );

        SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@TestTypeID",
                TestAppointmentDTO.TestTypeID);

            command.Parameters.AddWithValue(
                "@LocalDrivingLicenseApplicationID",
                TestAppointmentDTO.LocalDrivingLicenseApplicationID);

            command.Parameters.AddWithValue(
                "@AppointmentDate",
                TestAppointmentDTO.AppointmentDate);

            command.Parameters.AddWithValue(
                "@PaidFees",
                TestAppointmentDTO.PaidFees);

            command.Parameters.AddWithValue(
                "@CreatedByUserID",
                TestAppointmentDTO.CreatedByUserID);

            command.Parameters.AddWithValue(
                "@IsLocked",
                TestAppointmentDTO.IsLocked);

            command.Parameters.AddWithValue(
                "@RetakeTestApplicationID",
                TestAppointmentDTO.RetakeTestApplicationID == -1
                    ? (object)DBNull.Value
                    : TestAppointmentDTO.RetakeTestApplicationID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                connection.Close();

                return result != null &&
                       int.TryParse(result.ToString(), out int InsertedID)
                       ? InsertedID
                       : -1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public static bool UpdateTestAppointment(clsTestAppointmentDTO TestAppointmentDTO)
        {
            int rowAffected = 0;

            if (!clsnValidation.IsTestAppointmentValid(TestAppointmentDTO))
                return false;

            SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
        UPDATE TestAppointments
        SET
            TestTypeID = @TestTypeID,
            LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
            AppointmentDate = @AppointmentDate,
            PaidFees = @PaidFees,
            CreatedByUserID = @CreatedByUserID,
            IsLocked = @IsLocked,
            RetakeTestApplicationID = @RetakeTestApplicationID
        WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@TestAppointmentID",
                TestAppointmentDTO.TestAppointmentID);

            command.Parameters.AddWithValue(
                "@TestTypeID",
                TestAppointmentDTO.TestTypeID);

            command.Parameters.AddWithValue(
                "@LocalDrivingLicenseApplicationID",
                TestAppointmentDTO.LocalDrivingLicenseApplicationID);

            command.Parameters.AddWithValue(
                "@AppointmentDate",
                TestAppointmentDTO.AppointmentDate);

            command.Parameters.AddWithValue(
                "@PaidFees",
                TestAppointmentDTO.PaidFees);

            command.Parameters.AddWithValue(
                "@CreatedByUserID",
                TestAppointmentDTO.CreatedByUserID);

            command.Parameters.AddWithValue(
                "@IsLocked",
                TestAppointmentDTO.IsLocked);

            command.Parameters.AddWithValue(
                "@RetakeTestApplicationID",
                TestAppointmentDTO.RetakeTestApplicationID == -1
                    ? (object)DBNull.Value
                    : TestAppointmentDTO.RetakeTestApplicationID);

            try
            {
                connection.Open();

                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return rowAffected > 0;
        }
    }
    
}
