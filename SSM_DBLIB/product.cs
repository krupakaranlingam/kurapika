using System;
using System.Data;
using System.Data.SqlClient;

namespace SSM_DBLIB
{
    public class product
    {
        //@product_Name varchar(50), @product_Image varbinary(8000),@No_Of_Items int ,@DateOfManuf dateTime,@DateOfExpiry dateTime


        public static int AddProductDeatilsInDb(SqlConnection scon, string proName, byte[] image, int count ,DateTime Manuf , DateTime Expiry)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddProductDetails", scon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@product_Name", proName);
                cmd.Parameters.AddWithValue("@product_Image",image);
                cmd.Parameters.AddWithValue("@No_Of_Items", count);
                cmd.Parameters.AddWithValue("@DateOfManuf",Manuf);
                cmd.Parameters.AddWithValue("@DateOfExpiry", Expiry);
              
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
