using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UIValidatorLIB;

namespace smartshop
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnsignup_Click(object sender, EventArgs e)
        {
            string FN = txtUFname.Text;
            string LN = txtULname.Text;
            DateTime DOB;
            try
            {
                DOB = DateTime.Parse(txtudob.Text);
            }
            catch (Exception ex)
            {
                DOB = DateTime.ParseExact(txtudob.Text, "dd-MM-yyyy", null);
            }
            int age = Int32.Parse(txUge.Text.Substring(0, txUge.Text.IndexOf(" ")));

            string G = "";
            if (urb1.Checked == true)
            {
                G = urb1.Text;
            }
            if (urb2.Checked == true)
            {
                G = urb2.Text;
            }
            string contact = ucontact.Text;
            string admId = txtUId.Text;
            string admPsw = txtupw.Text;
            string confPsw = txtuconfirm.Text;
            string status = CustomerRegistration.RegisterCustomer(FN, LN, DOB, age, G, contact, admId, admPsw, confPsw);
            lbStatus.Text = status;
            if (status.Equals("Customer Details Registered Successfully!"))
            {
                Response.Redirect("firstpage.aspx");
            }
        }

        protected void txAdminDOB_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int Age = 0;
                DateTime DOB;
                try
                {
                    DOB = DateTime.Parse(txtudob.Text);
                }
                catch (Exception ex)
                {
                    DOB = DateTime.ParseExact(txtudob.Text, "dd-MM-yyyy", null);
                }
                TimeSpan ts = DateTime.Now - DOB;
                Age = (int)ts.TotalDays / 365;
                txUge.Text = Age + " years";
                txUge.ReadOnly = true;
            }
            catch (Exception ex)
            {
                txUge.Text = "0";
            }
        }

        protected void btnReset_Click1(object sender, EventArgs e)
        {
            txtUFname.Text = string.Empty; 
            txtULname.Text = string.Empty;
            txtudob.Text = string.Empty;
            ucontact.Text = string.Empty;
            txtUId.Text = string.Empty;
            txtupw.Text = string.Empty;
            txtuconfirm.Text = string.Empty;
            txtUFname.Focus();
        }

        
    }
}