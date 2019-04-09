using System;
using SSM_DBLIB;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace UIValidatorLIB
{
   public  class Validatesearch
   {

       public static SqlDataReader ValidateSearchProduct(string PN)
       {
                  return displayproduct.DisplayPro_src(DBConnector.GetDBConnection(), PN);

       }


     


      public static DataSet GetProductsDetails()
      {
          SqlConnection scon = DBConnector.GetDBConnection();
          DataSet ds= displayproduct.GetAllProductDetails(scon);
          return ds;
      }


      public static byte[] ValidateSearchslide(int count)
      {
          byte[] message;


          message = displayproduct.slideImagesOfProduct(DBConnector.GetDBConnection(), count);


          return message;
      }




    }
}
    
