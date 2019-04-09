using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UIValidatorLIB;

namespace smartshop
{
    public partial class firstpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }

        }
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string userid = txuserid.Text;
            string psw = txpsw.Text;
            string utype = usertype1.SelectedValue;
            if (utype.Equals("ADMIN"))
            {
                string status= ShopManagerRegistration.GetShopManagerLoginStatus(userid, psw);
                Session.Add("USERID", userid);
                if (status.Equals("valid user"))
                {
                    Response.Redirect("managerportal.aspx");
                }
                else
                {
                    lbStatus.Text = status;
                }
            }
            if (utype.Equals("USER"))
            {
                string status = CustomerRegistration.GetCustomerLoginStatus(userid, psw);
                Session.Add("USERID", userid);
                if (status.Equals("valid user"))
                {
                    Response.Redirect("ProductHome.aspx");
                }
                else
                {
                    lbStatus.Text = status;
                }
            }
        }

        protected void btnsignup_Click(object sender, EventArgs e)
        {
            

            if (usertype1.SelectedValue.Equals("USER"))
            {
                Response.Redirect("usersignup.aspx");
            }
            else if (usertype1.SelectedValue.Equals("ADMIN"))
            {
                Response.Redirect("adminsignup.aspx");
            }
            else
            {
                lbStatus.Text = "Select User Type !";
            }
        }

        protected void usertype1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usertype1.SelectedValue.Equals("none"))
            {
                lbStatus.Text = "Select User Type !";
            }
            else
            {
                lbStatus.Text = String.Empty;
            }
        }

      

     
    }
}