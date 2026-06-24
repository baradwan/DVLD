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
    public static class clsApplicationData
    {
        public static DataTable GetAllApplications()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);


            string query = @"     select * from Applications;";

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

        public static clsApplicationDTO GetApplicationByID(int ApplicationID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select * from Applications where ApplicationID=@ApplicationID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    //  ApplicationDTO.ApplicationID = (int)reader["ApplicationID"];
                    return new clsApplicationDTO
                    {
                        ApplicationID = Convert.ToInt32(reader["ApplicationID"]),
                        PersonID = Convert.ToInt32(reader["ApplicantPersonID"]),
                        ApplicationDate = Convert.ToDateTime(reader["ApplicationDate"]),
                        ApplicationTypeID = Convert.ToInt32(reader["ApplicationTypeID"]),
                        ApplicationStatus = Convert.ToByte(reader["ApplicationStatus"]),
                        LastStatusDate = Convert.ToDateTime(reader["LastStatusDate"]),
                        PaidFees = Convert.ToDecimal(reader["PaidFees"]),
                        CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"])
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
            return null;
        }
        public static int AddNewApplication(clsApplicationDTO ApplicationDTO)
        {
            if (!clsnValidation.IsApplicationValid(ApplicationDTO))
                return -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"INSERT INTO [dbo].[Applications]
           ([ApplicantPersonID]
           ,[ApplicationDate]
           ,[ApplicationTypeID]
           ,[ApplicationStatus]
           ,[LastStatusDate]
           ,[PaidFees]
           ,[CreatedByUserID])
     VALUES
           (@ApplicantPersonID
           ,@ApplicationDate
           ,@ApplicationTypeID
           ,@ApplicationStatus
           ,@LastStatusDate
           ,@PaidFees
           ,@CreatedByUserID);
          
     SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicationDTO.PersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDTO.ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationDTO.ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationDTO.ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", ApplicationDTO.LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", ApplicationDTO.PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", ApplicationDTO.CreatedByUserID);



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

        public static bool UpdateApplication(clsApplicationDTO ApplicationDTO)
        {
            int rowAffected = 0;

            if (!clsnValidation.IsApplicationValid(ApplicationDTO))
                return false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"Update Applications
                            set ApplicantPersonID = @ApplicantPersonID,
                                ApplicationDate = @ApplicationDate,
                                ApplicationTypeID = @ApplicationTypeID,
                                ApplicationStatus = @ApplicationStatus,
                                LastStatusDate = @LastStatusDate,
                                PaidFees = @PaidFees,
                                CreatedByUserID = @CreatedByUserID
                                where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationDTO.ApplicationID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicationDTO.PersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDTO.ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationDTO.ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationDTO.ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", ApplicationDTO.LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", ApplicationDTO.PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", ApplicationDTO.CreatedByUserID);



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
        public static bool DeleteApplication(int ApplicationID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Delete Applications 
                                where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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


        public static int GetActiveApplicationIDForLicenseClass(int PersonID, int ApplicationTypeID, int LicenseClassID)
        {
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT ActiveApplicationID=Applications.ApplicationID  
                            From
                            Applications INNER JOIN
                            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE ApplicantPersonID = @ApplicantPersonID 
                            and ApplicationTypeID=@ApplicationTypeID 
							and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                            and ApplicationStatus=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return ActiveApplicationID;
            }
            finally
            {
                connection.Close();
            }

            return ActiveApplicationID;
        }

    }
}
