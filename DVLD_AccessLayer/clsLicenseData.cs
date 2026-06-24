using DVLD_Global;
using DVLD_Global.DTOs;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_AccessLayer
{
    public static class clsLicenseData
    {
        public static DataTable GetAllLicenses()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Licenses;", connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                        dt.Load(reader);
                }
            }

            return dt;
        }

        public static clsLicenseDTO GetLicenseByID(int licenseID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(
                "SELECT * FROM Licenses WHERE LicenseID = @LicenseID;", connection))
            {
                command.Parameters.AddWithValue("@LicenseID", licenseID);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;

                    return new clsLicenseDTO
                    {
                        LicenseID = Convert.ToInt32(reader["LicenseID"]),
                        ApplicationID = Convert.ToInt32(reader["ApplicationID"]),
                        DriverID = Convert.ToInt32(reader["DriverID"]),
                        LicenseClass = Convert.ToInt32(reader["LicenseClass"]),
                        IssueDate = Convert.ToDateTime(reader["IssueDate"]),
                        ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]),
                        Notes = clsSqlHelper.FillReaderAllowNull(reader, "Notes"),
                        PaidFees = Convert.ToDecimal(reader["PaidFees"]),
                        IsActive = Convert.ToBoolean(reader["IsActive"]),
                        IssueReason = Convert.ToByte(reader["IssueReason"]),
                        CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"])
                    };
                }
            }
        }

        public static int AddNewLicense(clsLicenseDTO licenseDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(@"
                INSERT INTO Licenses
                (
                    ApplicationID,
                    DriverID,
                    LicenseClass,
                    IssueDate,
                    ExpirationDate,
                    Notes,
                    PaidFees,
                    IsActive,
                    IssueReason,
                    CreatedByUserID
                )
                VALUES
                (
                    @ApplicationID,
                    @DriverID,
                    @LicenseClass,
                    @IssueDate,
                    @ExpirationDate,
                    @Notes,
                    @PaidFees,
                    @IsActive,
                    @IssueReason,
                    @CreatedByUserID
                );

                SELECT SCOPE_IDENTITY();", connection))
            {
                command.Parameters.AddWithValue("@ApplicationID", licenseDTO.ApplicationID);
                command.Parameters.AddWithValue("@DriverID", licenseDTO.DriverID);
                command.Parameters.AddWithValue("@LicenseClass", licenseDTO.LicenseClass);
                command.Parameters.AddWithValue("@IssueDate", licenseDTO.IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", licenseDTO.ExpirationDate);
                command.Parameters.AddWithValue("@Notes", clsSqlHelper.ToDBValue(licenseDTO.Notes));
                  
                command.Parameters.AddWithValue("@PaidFees", licenseDTO.PaidFees);
                command.Parameters.AddWithValue("@IsActive", licenseDTO.IsActive);
                command.Parameters.AddWithValue("@IssueReason", licenseDTO.IssueReason);
                command.Parameters.AddWithValue("@CreatedByUserID", licenseDTO.CreatedByUserID);

                connection.Open();

                object result = command.ExecuteScalar();
                return result != null && int.TryParse(result.ToString(), out int insertedID) ? insertedID : -1;
            }
        }

        public static bool UpdateLicense(clsLicenseDTO licenseDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(@"
                UPDATE Licenses
                SET
                    ApplicationID = @ApplicationID,
                    DriverID = @DriverID,
                    LicenseClass = @LicenseClass,
                    IssueDate = @IssueDate,
                    ExpirationDate = @ExpirationDate,
                    Notes = @Notes,
                    PaidFees = @PaidFees,
                    IsActive = @IsActive,
                    IssueReason = @IssueReason,
                    CreatedByUserID = @CreatedByUserID
                WHERE LicenseID = @LicenseID;", connection))
            {
                command.Parameters.AddWithValue("@LicenseID", licenseDTO.LicenseID);
                command.Parameters.AddWithValue("@ApplicationID", licenseDTO.ApplicationID);
                command.Parameters.AddWithValue("@DriverID", licenseDTO.DriverID);
                command.Parameters.AddWithValue("@LicenseClass", licenseDTO.LicenseClass);
                command.Parameters.AddWithValue("@IssueDate", licenseDTO.IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", licenseDTO.ExpirationDate);
                command.Parameters.AddWithValue("@Notes", clsSqlHelper.ToDBValue(licenseDTO.Notes));
                command.Parameters.AddWithValue("@PaidFees", licenseDTO.PaidFees);
                command.Parameters.AddWithValue("@IsActive", licenseDTO.IsActive);
                command.Parameters.AddWithValue("@IssueReason", licenseDTO.IssueReason);
                command.Parameters.AddWithValue("@CreatedByUserID", licenseDTO.CreatedByUserID);

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool DeleteLicense(int licenseID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(
                "DELETE FROM Licenses WHERE LicenseID = @LicenseID;", connection))
            {
                command.Parameters.AddWithValue("@LicenseID", licenseID);

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}