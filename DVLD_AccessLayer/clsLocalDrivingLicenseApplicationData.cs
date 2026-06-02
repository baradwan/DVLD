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
    public static class clsLocalDrivingLicenseApplicationData
    {

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);


            string query = @"select * from LocalDrivingLicenseApplications_View 
                                    order by ApplicationDate; ";

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


        public static int AddLocalDrivingLicenseApplication(clsLocalDrivingLicenseApplicationDTO ApplicationDTO)
        {
            if (!clsnValidation.IsLocalDrivingLicenseApplicationValid(ApplicationDTO))
                return -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"INSERT INTO [dbo].[LocalDrivingLicenseApplications]
           ([ApplicationID]
           ,[LicenseClassID])
     VALUES
           (@ApplicationID
           ,@LicenseClassID);
          
     SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationDTO.ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", ApplicationDTO.LicenseClassID);



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

        public static bool UpdateLocalDrivingLicenseApplication(clsLocalDrivingLicenseApplicationDTO LDLApplication)
        {
            int rowAffected = 0;

            if (!clsnValidation.IsLocalDrivingLicenseApplicationValid(LDLApplication))
                return false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"Update LocalDrivingLicenseApplications
                            set LicenseClassID = @LicenseClassID
                            where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLApplication.LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@ApplicationID", LDLApplication.ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LDLApplication.LicenseClassID);



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
        public static clsLocalDrivingLicenseApplicationDTO GetLocalDrivingLicenseApplicationByID( int LocalDrivingLicenseApplicationID)
        {
            SqlConnection connection =new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
        SELECT * 
        FROM LocalDrivingLicenseApplications
        WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new clsLocalDrivingLicenseApplicationDTO
                    {
                        LocalDrivingLicenseApplicationID =Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]),

                        ApplicationID =  Convert.ToInt32(reader["ApplicationID"]),

                        LicenseClassID = Convert.ToInt32(reader["LicenseClassID"])
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

           // return null;
        }

        public static bool DeleteLocalDrivingLicenseApplication(
    int LocalDrivingLicenseApplicationID)
        {
            int RowsAffected = 0;

            SqlConnection connection =new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
        DELETE FROM LocalDrivingLicenseApplications
        WHERE LocalDrivingLicenseApplicationID =
        @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue( "@LocalDrivingLicenseApplicationID",LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                RowsAffected = command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }

            return RowsAffected > 0;
        }

    }
}
