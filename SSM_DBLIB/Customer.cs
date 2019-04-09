using System;
using System.Data;
using System.Data.SqlClient;


namespace SSM_DBLIB
{
    //create procedure AddCustomerDetails @FirstName varchar(50), @LastName varchar(50), @DateOfBirth dateTime,@Age int,@Gender char(6),@ContactNo varchar(11),@AdminId varchar(15),@AdminPassword varchar(15)

    public class Customer
    {
        public static int RegisterCustomerDetails(SqlConnection scon, string FN, string LN, DateTime dob, int age, string G, string contact, string admId, string admPsw)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddCustomerDetails", scon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", FN);
                cmd.Parameters.AddWithValue("@LastName", LN);
                cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Gender", G);
                cmd.Parameters.AddWithValue("@ContactNo", contact);
                cmd.Parameters.AddWithValue("@AdminId", admId);
                cmd.Parameters.AddWithValue("@AdminPassword", admPsw);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
