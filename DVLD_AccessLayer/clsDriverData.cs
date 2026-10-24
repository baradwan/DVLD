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
    public  class clsDriverData
    {

        public static int AddNewDriver(clsDriverDTO DriverDTO)
        {
            int DriverID = -1;

            SqlConnection connection = new SqlConnection( clsDataAccessSettings.connectionString);


            string query = @"Insert Into Drivers (PersonID,CreatedByUserID,CreatedDate)
                            Values (@PersonID,@CreatedByUserID,@CreatedDate);
                          
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", DriverDTO.PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", DriverDTO.CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null &&
                    int.TryParse(result.ToString(), out int InsertedID))
                {
                    DriverID = InsertedID;
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

            return DriverID;
        }

        public static clsDriverDTO GetDriverInfoByID(int DriverID)
        {
            clsDriverDTO DriverDTO = null;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                SELECT DriverID, PersonID, CreatedByUserID, CreateDate
                FROM Drivers
                WHERE DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DriverDTO = new clsDriverDTO
                    {
                        DriverID = (int)reader["DriverID"],
                        PersonID = (int)reader["PersonID"],
                        CreatedByUserID = (int)reader["CreatedByUserID"],
                        CreateDate = (DateTime)reader["CreateDate"]
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

            return DriverDTO;
        }

        public static clsDriverDTO GetDriverInfoByPersonID(int PersonID)
        {
            clsDriverDTO DriverDTO = null;

            SqlConnection connection = new SqlConnection(
                clsDataAccessSettings.connectionString);

            string query = @"
                SELECT DriverID, PersonID, CreatedByUserID, CreateDate
                FROM Drivers
                WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DriverDTO = new clsDriverDTO
                    {
                        DriverID = (int)reader["DriverID"],
                        PersonID = (int)reader["PersonID"],
                        CreatedByUserID = (int)reader["CreatedByUserID"],
                        CreateDate = (DateTime)reader["CreateDate"]
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

            return DriverDTO;
        }

        public static bool UpdateDriver(clsDriverDTO DriverDTO)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(
                clsDataAccessSettings.connectionString);

            string query = @"
                UPDATE Drivers
                SET PersonID = @PersonID,
                    CreatedByUserID = @CreatedByUserID,
                    CreateDate = @CreateDate
                WHERE DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverDTO.DriverID);
            command.Parameters.AddWithValue("@PersonID", DriverDTO.PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", DriverDTO.CreatedByUserID);
            command.Parameters.AddWithValue("@CreateDate", DriverDTO.CreateDate);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return RowsAffected > 0;
        }

        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(
                clsDataAccessSettings.connectionString);

            string query = @"
                SELECT DriverID, PersonID, CreatedByUserID, CreateDate
                from Drivers_View
                ORDER BY DriverID DESC;"; 

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                dt.Load(reader);

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

            return dt;
        }

        public static bool DeleteDriver(int DriverID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(
                clsDataAccessSettings.connectionString);

            string query = @"
                DELETE FROM Drivers
                WHERE DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return RowsAffected > 0;
        }
    }
}

