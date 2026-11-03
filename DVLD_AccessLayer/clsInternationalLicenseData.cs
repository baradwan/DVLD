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
    public class clsInternationalLicenseData
    {

        public static int AddNewInternationalLicense(clsInternationalLicenseDTO LicenseDTO)
        {
            int InternationalLicenseID = -1;

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"
Update InternationalLicenses 
                               set IsActive=0
                               where DriverID=@DriverID;

                    INSERT INTO InternationalLicenses
                    (
                        ApplicationID,
                        DriverID,
                        IssuedUsingLocalLicenseID,
                        IssueDate,
                        ExpirationDate,
                        IsActive,
                        CreatedByUserID
                    )
                    VALUES
                    (
                        @ApplicationID,
                        @DriverID,
                        @IssuedUsingLocalLicenseID,
                        @IssueDate,
                        @ExpirationDate,
                        @IsActive,
                        @CreatedByUserID
                    );

                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", LicenseDTO.ApplicationID);
                    command.Parameters.AddWithValue("@DriverID", LicenseDTO.DriverID);
                    command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", LicenseDTO.IssuedUsingLocalLicenseID);
                    command.Parameters.AddWithValue("@IssueDate", LicenseDTO.IssueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", LicenseDTO.ExpirationDate);
                    command.Parameters.AddWithValue("@IsActive", LicenseDTO.IsActive);
                    command.Parameters.AddWithValue("@CreatedByUserID", LicenseDTO.CreatedByUserID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                            InternationalLicenseID = Convert.ToInt32(result);
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }

            return InternationalLicenseID;
        }

        public static bool UpdateInternationalLicense(clsInternationalLicenseDTO LicenseDTO)
        {
            int RowsAffected = 0;

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"
                    UPDATE InternationalLicenses
                    SET
                        ApplicationID = @ApplicationID,
                        DriverID = @DriverID,
                        IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
                        IssueDate = @IssueDate,
                        ExpirationDate = @ExpirationDate,
                        IsActive = @IsActive,
                        CreatedByUserID = @CreatedByUserID
                    WHERE InternationalLicenseID = @InternationalLicenseID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InternationalLicenseID", LicenseDTO.InternationalLicenseID);
                    command.Parameters.AddWithValue("@ApplicationID", LicenseDTO.ApplicationID);
                    command.Parameters.AddWithValue("@DriverID", LicenseDTO.DriverID);
                    command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", LicenseDTO.IssuedUsingLocalLicenseID);
                    command.Parameters.AddWithValue("@IssueDate", LicenseDTO.IssueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", LicenseDTO.ExpirationDate);
                    command.Parameters.AddWithValue("@IsActive", LicenseDTO.IsActive);
                    command.Parameters.AddWithValue("@CreatedByUserID", LicenseDTO.CreatedByUserID);

                    try
                    {
                        connection.Open();
                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }

            return RowsAffected > 0;
        }

        public static clsInternationalLicenseDTO GetInternationalLicenseByID(int InternationalLicenseID)
        {
            clsInternationalLicenseDTO LicenseDTO = null;

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"
                    SELECT *
                    FROM InternationalLicenses
                    WHERE InternationalLicenseID = @InternationalLicenseID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                LicenseDTO = new clsInternationalLicenseDTO
                                {
                                    InternationalLicenseID = (int)reader["InternationalLicenseID"],
                                    ApplicationID = (int)reader["ApplicationID"],
                                    DriverID = (int)reader["DriverID"],
                                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"],
                                    IssueDate = (DateTime)reader["IssueDate"],
                                    ExpirationDate = (DateTime)reader["ExpirationDate"],
                                    IsActive = (bool)reader["IsActive"],
                                    CreatedByUserID = (int)reader["CreatedByUserID"]
                                };
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }

            return LicenseDTO;
        }

        public static DataTable GetAllInternationalLicenses()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"SELECT * FROM InternationalLicenses;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch (Exception)
                    {
                        return dt;
                    }
                }
            }

            return dt;
        }

        public static bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            int RowsAffected = 0;

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"
                    DELETE FROM InternationalLicenses
                    WHERE InternationalLicenseID = @InternationalLicenseID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

                    try
                    {
                        connection.Open();
                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }

            return RowsAffected > 0;
        }

        public static bool IsInternationalLicenseExist(int InternationalLicenseID)
        {
            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"
                    SELECT 1
                    FROM InternationalLicenses
                    WHERE InternationalLicenseID = @InternationalLicenseID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

                    try
                    {
                        connection.Open();
                        return command.ExecuteScalar() != null;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }


        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
            SELECT    InternationalLicenseID, ApplicationID,
		                IssuedUsingLocalLicenseID , IssueDate, 
                        ExpirationDate, IsActive
		    from InternationalLicenses where DriverID=@DriverID
                order by ExpirationDate desc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

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



        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            int InternationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"  
                            SELECT Top 1 InternationalLicenseID
                            FROM InternationalLicenses 
                            where DriverID=@DriverID and GetDate() between IssueDate and ExpirationDate 
                            order by ExpirationDate Desc;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    InternationalLicenseID = insertedID;
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


            return InternationalLicenseID;
        }



    }
}
