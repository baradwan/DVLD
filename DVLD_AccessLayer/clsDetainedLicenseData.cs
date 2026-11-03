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
    public class clsDetainedLicenseData
    {
        public static int AddNewDetainedLicense(clsDetainedLicenseDTO dto)
        {
            int DetainID = -1;

            SqlConnection connection = new SqlConnection(
                clsDataAccessSettings.connectionString);

            string query = @"
                INSERT INTO DetainedLicenses
                (
                    LicenseID,
                    DetainDate,
                    FineFees,
                    CreatedByUserID,
                    IsReleased,
                    ReleaseDate,
                    ReleasedByUserID,
                    ReleaseApplicationID
                )
                VALUES
                (
                    @LicenseID,
                    @DetainDate,
                    @FineFees,
                    @CreatedByUserID,
                    @IsReleased,
                    @ReleaseDate,
                    @ReleasedByUserID,
                    @ReleaseApplicationID
                );

                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", dto.LicenseID);
            command.Parameters.AddWithValue("@DetainDate", dto.DetainDate);
            command.Parameters.AddWithValue("@FineFees", dto.FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", dto.CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", dto.IsReleased);

            command.Parameters.AddWithValue("@ReleaseDate", clsSqlHelper.ToDBValue(dto.ReleaseDate));

            command.Parameters.AddWithValue("@ReleasedByUserID",clsSqlHelper.ToDBValue(dto.ReleasedByUserID));

            command.Parameters.AddWithValue("@ReleaseApplicationID", clsSqlHelper.ToDBValue(dto.ReleaseApplicationID));

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


        public static clsDetainedLicenseDTO GetDetainedLicenseByID(int DetainID)
        {
            clsDetainedLicenseDTO dto = null;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    dto = new clsDetainedLicenseDTO();

                    dto.DetainID = (int)reader["DetainID"];
                    dto.LicenseID = (int)reader["LicenseID"];
                    dto.DetainDate = Convert.ToDateTime(reader["DetainDate"]);
                    dto.FineFees = Convert.ToDecimal(reader["FineFees"]);
                    dto.CreatedByUserID = (int)reader["CreatedByUserID"];
                    dto.IsReleased = (bool)reader["IsReleased"];

                    dto.ReleaseDate =
                        clsSqlHelper.FillReaderAllowNull<DateTime>(reader, "ReleaseDate");

                    dto.ReleasedByUserID =
                        clsSqlHelper.FillReaderAllowNull<int>(reader, "ReleasedByUserID");

                    dto.ReleaseApplicationID =
                        clsSqlHelper.FillReaderAllowNull<int>(reader, "ReleaseApplicationID");

                }

                reader.Close();
            }
            finally
            {
                connection.Close();
            }

            return dto;
        }

        public static bool UpdateDetainedLicense(clsDetainedLicenseDTO dto)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(
                clsDataAccessSettings.connectionString);

            string query = @"
                UPDATE DetainedLicenses
                SET
                    LicenseID = @LicenseID,
                    DetainDate = @DetainDate,
                    FineFees = @FineFees,
                    CreatedByUserID = @CreatedByUserID,
                    IsReleased = @IsReleased,
                    ReleaseDate = @ReleaseDate,
                    ReleasedByUserID = @ReleasedByUserID,
                    ReleaseApplicationID = @ReleaseApplicationID
                WHERE DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", dto.DetainID);
            command.Parameters.AddWithValue("@LicenseID", dto.LicenseID);
            command.Parameters.AddWithValue("@DetainDate", dto.DetainDate);
            command.Parameters.AddWithValue("@FineFees", dto.FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", dto.CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", dto.IsReleased);

            command.Parameters.AddWithValue("@ReleaseDate", clsSqlHelper.ToDBValue(dto.ReleaseDate));

            command.Parameters.AddWithValue("@ReleasedByUserID",  clsSqlHelper.ToDBValue(dto.ReleasedByUserID));

            command.Parameters.AddWithValue("@ReleaseApplicationID", clsSqlHelper.ToDBValue(dto.ReleaseApplicationID));

            try
            {

                connection.Open();
                RowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return false;
                throw;
            }
            finally { connection.Close(); }

            return RowsAffected > 0;

        }

        public static bool DeleteDetainedLicense(int DetainID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(
                clsDataAccessSettings.connectionString);

            string query = @"
                DELETE FROM DetainedLicenses
                WHERE DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connection.Open();

                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                RowsAffected = 0;
            }
            finally
            {
                connection.Close();
            }

            return RowsAffected > 0;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(
                clsDataAccessSettings.connectionString);

            string query = @"
                SELECT *
                FROM DetainedLicenses_View
                ORDER BY DetainID DESC;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                dt.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {
                // Return an empty DataTable.
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool IsDetained = false;

            SqlConnection connection = new SqlConnection(
                clsDataAccessSettings.connectionString);

            string query = @"
                SELECT 1
                FROM DetainedLicenses
                WHERE LicenseID = @LicenseID
                  AND IsReleased = 0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                IsDetained = result != null;
            }
            catch (Exception)
            {
                IsDetained = false;
            }
            finally
            {
                connection.Close();
            }

            return IsDetained;
        }

    }
}
