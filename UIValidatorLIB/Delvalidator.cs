using System;
using SSM_DBLIB;
using System.Data;
using System.Data.SqlClient;


namespace UIValidatorLIB
{
    public class Delvalidator
    {
        public static string DeleteProduct(string PN)
        {
            string message = string.Empty;
            try
            {
                if (!PN.Equals(""))
                {
                    int r = Delrpoduct.Deletepro(DBConnector.GetDBConnection(), PN);
                    if (r > 0)
                    {
                        message = "Product Details Removed Successfully!";
                    }
                    else
                    {
                        message = "Process Failure";
                    }
                }
            }
            catch (Exception ex) { message = ex.Message; }
            return message;
        }


        public static string AlterProductDetails(string PN, int Num, DateTime MD, DateTime ED)
        {
            string message = string.Empty;
            try
            {
                if (!PN.Equals(""))
                {
                    int r = Delrpoduct.AlterProduct(DBConnector.GetDBConnection() , PN ,Num ,MD ,ED);
                    if (r > 0)
                    {
                        message = "Product Details EDITED Successfully!";
                    }
                    else
                    {
                        message = "Process Failure";
                    }
                }
            }
            catch (Exception ex) { message = ex.Message; }
            return message;
        }
    }
}
