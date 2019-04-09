using System;
using System.Data;
using System.Data.SqlClient;

namespace SSM_DBLIB
{
   public class Delrpoduct
    {
       public static int Deletepro(SqlConnection scon, string proName)
       {
           try
           {


               SqlCommand cmd = new SqlCommand("DelProducts",scon);
               cmd.Connection = scon;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@Productname", proName);
              

               return cmd.ExecuteNonQuery();
               
           }
           catch (Exception ex)
           {
               throw ex;
           }



       }
       public static int AlterProduct(SqlConnection scon, string proName, int proNum, DateTime proManuf, DateTime proExpire)
       {

           try
           {
               SqlCommand cmd = new SqlCommand("EditProductDetails", scon);
               cmd.Connection = scon;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@Productname", proName);
               cmd.Parameters.AddWithValue("@No_Of_Items", proNum);
               cmd.Parameters.AddWithValue("@DateOfManuf", proManuf);
               cmd.Parameters.AddWithValue("@DateOfExpiry", proExpire);



               return cmd.ExecuteNonQuery();
               

           }
           catch (Exception ex)
           {
               throw ex;
           }


       }
   



    }
}
