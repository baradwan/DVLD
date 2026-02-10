using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
