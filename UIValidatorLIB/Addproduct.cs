using System;
using SSM_DBLIB;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace UIValidatorLIB
{
   public class Addproduct
    {

        public static string productDetails(string proName, byte[] image, int count, DateTime Manuf, DateTime Expiry)
        {
            string message = string.Empty;
            int r = product.AddProductDeatilsInDb(DBConnector.GetDBConnection(), proName , image ,count ,Manuf ,Expiry);
            if (r > 0)
            {
                message = "Product Details ADDED Successfully!";
            }
            else
            {
                message = "Registration Failure!";
            }
            return message;
        }
    }
}
