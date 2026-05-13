using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DVLD_Global.DTOs;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_AccessLayer
{
    public class clsApplicationType
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

        }

    }
}
