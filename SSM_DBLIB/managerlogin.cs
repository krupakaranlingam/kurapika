using System;
using System.Data;
using System.Data.SqlClient;

namespace SSM_DBLIB
{
    //ValidateShopOwner @AdminId varchar(15),@AdminPassword varchar(15), @status varchar(10) out
     public class managerlogin
    {
         public static Boolean ValidateShopManagerLogin(SqlConnection scon,string userid, string psw)
         {
             SqlCommand cmd = new SqlCommand("ValidateShopOwner", scon);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@AdminId",userid);
             cmd.Parameters.AddWithValue("@AdminPassword", psw);

             SqlParameter sp = new SqlParameter();
             sp.ParameterName = "@status";
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
