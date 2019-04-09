using System;
using System.Data;
using System.Data.SqlClient;

namespace SSM_DBLIB
{
    public class DBConnector
    {
        public static SqlConnection GetDBConnection()
        {
            SqlConnection scon = new SqlConnection("Data Source=PC378075;Initial Catalog=SSM_DB;User ID=sa;Password=password-1");
            scon.Open();
            return scon;
        }
    }
}
