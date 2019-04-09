using System;
using SSM_DBLIB;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace UIValidatorLIB
{
    public class ShopManagerRegistration
    {
        public static string RegisterShopManager(string FN, string LN, DateTime dob, int age, string G, string contact, string admId, string admPsw, string confPsw)
        {
            string message = string.Empty;
            try
            {
                if (!admPsw.Equals(confPsw))
                {
                    message = "Confirm Password Not Matched !!";
                }
                else
                {
                    if (ValidateContactNo(contact) == true)
                    {

                        int r = ShopOwner.RegisterShopOwnerDetails(DBConnector.GetDBConnection(), FN, LN, dob, age, G, contact, admId, admPsw);
                        if (r > 0)
                        {
                            message = "ShopManager Details Registered Successfully!";
                        }
                        else
                        {
                            message = "Registration Failure!";
                        }
                    }
                    else
                    {
                        message = "Invalid Contact No";
                    }
                }
            }
            catch (Exception ex) { message = ex.Message; }
            return message;
        }

        public static Boolean ValidateContactNo(string ContactNo)
        {
            string pattern=@"[0-9]{11}";
            if (new Regex(pattern).IsMatch(ContactNo) == true && (ContactNo.Length == 11 || ContactNo.Length == 10))
            {
                return true;
            }
            else{
                return false;
            }


        }

        public static string GetShopManagerLoginStatus(string adminid ,string password)
        {
            string message = "";
            try
            {
                if (managerlogin.ValidateShopManagerLogin(DBConnector.GetDBConnection(), adminid, password) == true)
                {
                    message = "valid user";
                }
                else
                {
                    message = "credential details unauthenticated";

                }
                
            }
            catch (Exception ex) { message = ex.Message; }
            return message;

        }
    }
}
