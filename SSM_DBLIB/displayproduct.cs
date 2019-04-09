using System;
using System.Data;
using System.Data.SqlClient;

namespace SSM_DBLIB
{
  public  class displayproduct
    {
      public static SqlDataReader DisplayPro_src(SqlConnection scon, string proName)
      {
          

              SqlCommand cmd = new SqlCommand();
              cmd.Connection = scon;
              cmd.CommandType = CommandType.Text;
              cmd.CommandText = "select Top 2 * from Product_details where Product_Name like '%" + proName + "%'";
              return cmd.ExecuteReader();
          
      }
      

      public static DataSet GetAllProductDetails(SqlConnection scon)
      {
          DataSet ds = new DataSet();
          SqlDataAdapter sda = new SqlDataAdapter("select  * from Product_details", scon);
          sda.Fill(ds, "Product_details");
          return ds;
      }



      public static byte[] slideImagesOfProduct(SqlConnection scon, int count)
  {
      try
          {
              byte[] pn;

              SqlCommand cmd = new SqlCommand("DisplayRandomImgae", scon);
              cmd.Connection = scon;
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@count",count);
              pn = (byte[])cmd.ExecuteScalar();
              return pn;
          }
          catch (Exception ex)
          {
              throw ex;
          }


     

  }


    }
}





 