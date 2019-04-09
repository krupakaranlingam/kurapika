using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UIValidatorLIB;


namespace smartshop
{
    public partial class adminsignup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        

       
        protected void txAdminDOB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Age = 0;
                DateTime DOB;
                try
                {
                     DOB= DateTime.Parse(txAdminDOB.Text);
                }
                catch (Exception ex)
                {
                    DOB = DateTime.ParseExact(txAdminDOB.Text,"dd-MM-yyyy",null);
                }
                TimeSpan ts = DateTime.Now - DOB;
                Age = (int)ts.TotalDays / 365;
                txAge.Text = Age + " years";
                txAge.ReadOnly = true;
            }
            catch (Exception ex)
            {
                txAge.Text = "0";
            }
        }

        protected void abtnsignup_Click(object sender, EventArgs e)
        {
            
                string FN = txAFname.Text;
                string LN = txALname.Text;
                DateTime DOB;
                try
                {
                    DOB = DateTime.Parse(txAdminDOB.Text);
                }
                catch (Exception ex)
                {
                    DOB = DateTime.ParseExact(txAdminDOB.Text, "dd-MM-yyyy", null);
                }
                int age = Int32.Parse(txAge.Text.Substring(0, txAge.Text.IndexOf(" ")));

                string G = "";
                if (arb1.Checked == true)
                {
                    G = arb1.Text;
                }
                if (arb2.Checked == true)
                {
                    G = arb2.Text;
                }
                string contact = txAcontact.Text;
                string admId = txAUserId.Text;
                string admPsw = txApw.Text;
                string confPsw = txAConfirm.Text;
                string status = ShopManagerRegistration.RegisterShopManager(FN, LN, DOB, age, G, contact, admId, admPsw, confPsw);
                lbStatus.Text = status;
                if (status.Equals("ShopManager Details Registered Successfully!"))
                {
                    Response.Redirect("firstpage.aspx");
                }
            
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txAFname.Text= string.Empty;
            txALname.Text =string.Empty;
            txAdminDOB.Text = string.Empty; 
            txAcontact.Text = string.Empty; 
            txAUserId.Text = string.Empty;
            txApw.Text = string.Empty;
            txAConfirm.Text = string.Empty; 
            txAFname.Focus();
            
        }
    }
}