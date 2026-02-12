using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_AccessLayer
{
    internal class clsSqlHelper
    {
        public static object ToDBValue(object Value)
        { 
        return Value==null|| Value is string str && string.IsNullOrWhiteSpace(str)? DBNull.Value:Value;
        }

      

        public  static string FillReaderAllowNull(SqlDataReader reader, string ColumnName)
        {
                      object value = reader[ColumnName];
            return value != DBNull.Value ? value.ToString() :string.Empty;
    
        }
    }
}
