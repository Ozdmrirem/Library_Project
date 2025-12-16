using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Project
{
    public static class SqlCon
    {
        readonly static string connectionString = ("Data source = DESKTOP-HJ161GJ\\SQLEXPRESS ; Initial Catalog=DbLibrary ; Integrated Security=True");
        public static SqlConnection Connect()
        {
            return new SqlConnection(connectionString);
        }
    }
}
