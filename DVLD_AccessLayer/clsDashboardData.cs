using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_AccessLayer
{
    using DVLD_Global.DTOs;
    using System;
    using System.Data;
    using System.Data.SqlClient;

    namespace DVLD_AccessLayer
    {
        public static class clsDashboardData
        {
            public static clsDashboardStatisticsDTO GetStatistics()
            {
                string query = @"
                SELECT
                    (SELECT COUNT(*)
                     FROM Drivers) AS TotalDrivers,

                    (SELECT COUNT(*)
                     FROM Licenses
                     WHERE IsActive = 1
                     AND ExpirationDate >= CAST(GETDATE() AS DATE))
                     AS ActiveLicenses,

                    (SELECT COUNT(*)
                     FROM DetainedLicenses
                     WHERE IsReleased = 0) AS DetainedLicenses,

                    (SELECT COUNT(*)
                     FROM Applications) AS TotalApplications;
            ";

                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            throw new DataException(
                                "Dashboard statistics were not returned.");

                        return new clsDashboardStatisticsDTO
                        {
                            TotalDrivers =
                                Convert.ToInt32(reader["TotalDrivers"]),

                            ActiveLicenses =
                                Convert.ToInt32(reader["ActiveLicenses"]),

                            DetainedLicenses =
                                Convert.ToInt32(reader["DetainedLicenses"]),

                            TotalApplications =
                                Convert.ToInt32(reader["TotalApplications"])
                        };
                    }
                }
            }
        }
    }
}
