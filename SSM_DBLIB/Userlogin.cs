using System;
using System.Data;
using System.Data.SqlClient;



namespace SSM_DBLIB
{
   public  class Userlogin
    {
        public static Boolean ValidateCustomerLogin(SqlConnection scon,string userid, string psw)
         {
             SqlCommand cmd = new SqlCommand("ValidateCustomer", scon);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@UserId",userid);
             cmd.Parameters.AddWithValue("@UserPassword", psw);

             SqlParameter sp = new SqlParameter();
             sp.ParameterName = "@ustatus";
             sp.SqlDbType = SqlDbType.VarChar;
             sp.Size = 10;
             sp.Direction = ParameterDirection.Output;
             cmd.Parameters.Add(sp);
             cmd.ExecuteReader();

             string status =(string)sp.Value;
             if (status.Equals("valid"))
             {
                 return true;
             }
             else
                 return false;
         }
    }
}
