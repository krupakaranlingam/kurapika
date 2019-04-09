using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using UIValidatorLIB;

namespace smartshop
{
    public partial class managerportal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                addproduct.CssClass = "Initial";
                view.ActiveViewIndex = 0;
                string userid = (string)Session["USERID"];
                portalname.Text = "MANAGER PORTAL, Welcome " + userid;
               
            }
        
        }

        protected void toproducthome_Click(object sender, EventArgs e)
        {
            Response.Redirect("firstpage.aspx");
            
        }

        protected void addpro_Click(object sender, EventArgs e)
        {
            addproduct.CssClass = "Clicked";
            alterpro.CssClass = "Initial";
            deletepro.CssClass = "Initial";
            viewproduct.CssClass = "Initial";
            viewallapro.CssClass = "Initial";
            view.ActiveViewIndex = 1;
        }

        protected void alterpro_Click(object sender, EventArgs e)
        {
            
                addproduct.CssClass = "Initial";
                alterpro.CssClass = "Clicked";
                deletepro.CssClass = "Initial";
                viewproduct.CssClass = "Initial";
                viewallapro.CssClass = "Initial";
                view.ActiveViewIndex = 2;
            


           




        }

        protected void deletepro_Click(object sender, EventArgs e)
        {
            addproduct.CssClass = "Initial";
            alterpro.CssClass = "Initial";
            deletepro.CssClass = "Clicked";
            viewproduct.CssClass = "Initial";
            viewallapro.CssClass = "Initial";
            view.ActiveViewIndex = 3;




        }

        protected void proproperty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void proname1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnsubm_Click(object sender, EventArgs e)
        {

            //  proName , image ,count ,Manuf ,Expiry
            try
            {
                string proName = proname1.Text;
                if (proName != "")
                {
                    byte[] image = proimage1.FileBytes;
                    int count = Int32.Parse(prono1.Text);
                    DateTime Manuf, Expiry;
                    try
                    {
                        Manuf = DateTime.Parse(promanuf.Text);
                    }
                    catch (Exception ex)
                    {
                        Manuf = DateTime.ParseExact(promanuf.Text, "dd-MM-yyyy", null);
                    }
                    try
                    {
                        Expiry = DateTime.Parse(proexpiry.Text);
                    }
                    catch (Exception ex)
                    {
                        Expiry = DateTime.ParseExact(proexpiry.Text, "dd-MM-yyyy", null);
                    }

                    string lbsts = Addproduct.productDetails(proName, image, count, Manuf, Expiry);


                    lb1stspro.Text = lbsts;
                }
                else
                {
                    lb1stspro.Text = "Enter PROCUT DETAILS";
                }
            }
            catch (Exception ex)
            {

            }
                



        }

        protected void viewproduct_Click(object sender, EventArgs e)
        {
            addproduct.CssClass = "Initial";
            alterpro.CssClass = "Initial";
            deletepro.CssClass = "Initial";
            viewproduct.CssClass = "Clicked";
            viewallapro.CssClass = "Initial";
            view.ActiveViewIndex = 4;

        }

        protected void searchpro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                addproduct.CssClass = "Initial";
                alterpro.CssClass = "Initial";
                deletepro.CssClass = "Initial";
                viewproduct.CssClass = "Clicked";
                viewallapro.CssClass = "Initial";
                view.ActiveViewIndex = 4;
                string searchproduct = searchpro.Text;

                SqlDataReader sdr = Validatesearch.ValidateSearchProduct(searchproduct);

               if(sdr.Read())
                            {
                                
                                 nameofproduct.Text = sdr[1].ToString();
                                   
                                    byte[] status2 = (byte[])sdr[2];
                                    string IMAGE = Convert.ToBase64String(status2);
                                    imageofproduct.ImageUrl = String.Format("data:image/jpg;base64,{0}", IMAGE);


                                    int count = (int)sdr[3];
                                    countofpro.Text = "AVAILABLE COUNT " + count.ToString();
                                    DateTime datemanuf = (DateTime)sdr[4];
                                    manufofproduct.Text = "DATE OF MANUFACTURE" + datemanuf.ToString();

                                    DateTime expiredate = (DateTime)sdr[5];
                                    expiryofproduct.Text = "DATE OF EXPIRE" + expiredate.ToString();
                                }
            }
            catch (Exception ex) { }
        }

    

        protected void DElete_Click(object sender, EventArgs e)
        {
            try
            {
                string searchdel = delpro1.Text;
                if (searchdel != "")
                {
                    string status = Delvalidator.DeleteProduct(searchdel);
                    delstatus.Text = status;
                }
                else
                {
                    delstatus.Text = " !!!!!!!!   ENTER PRODUCT NAME   !!!!!!!!";
                }
            }
            catch (Exception ex)
            {
                delstatus.Text = ex.Message;
            }
        }

        protected void resetsearch_Click(object sender, EventArgs e)
        {
            searchpro.Text = string.Empty;
            nameofproduct.Text = "";
            imageofproduct.ImageUrl = string.Empty;
            countofpro.Text = string.Empty;
            manufofproduct.Text = string.Empty;
            expiryofproduct.Text = string.Empty;

        }

        protected void submitalter_Click(object sender, EventArgs e)
        {
            try
            {

                string altname = alterproname.Text;

                int altnum = Int32.Parse(alterpronum.Text);

                DateTime altmanuf;
                DateTime altexpire;
                try
                {
                    altmanuf = DateTime.Parse(alterpromanuf.Text);
                }
                catch (Exception ex)
                {
                    altmanuf = DateTime.ParseExact(alterpromanuf.Text, "dd-MM-yyyy", null);
                }

                try
                {
                    altexpire = DateTime.Parse(alterproexpiry.Text);
                }
                catch (Exception ex)
                {
                    altexpire = DateTime.ParseExact(alterproexpiry.Text, "dd-MM-yyyy", null);
                }

                string sts = Delvalidator.AlterProductDetails(altname, altnum, altmanuf, altexpire);

                submitstatus.Text = sts;
            }
            catch(Exception ex)
            {
                submitstatus.Text = "ENTER DETAILS";
            }
        }

        protected void resetadd_Click(object sender, EventArgs e)
        {
            proname1.Text = string.Empty;
           
            prono1.Text = string.Empty ;
            promanuf.Text = string.Empty;
            proexpiry.Text = string.Empty; 
        }

        protected void viewallapro_Click(object sender, EventArgs e)
        {
            addproduct.CssClass = "Initial";
            alterpro.CssClass = "Initial";
            deletepro.CssClass = "Initial";
            viewproduct.CssClass = "Initial";
            viewallapro.CssClass = "Clicked";
            view.ActiveViewIndex = 5;
            DataSet ds = Validatesearch.GetProductsDetails();

            Db1.Visible = true;
            Db1.DataSource = ds;
            Db1.DataMember = ds.Tables[0].TableName;
            Db1.DataBind();

        }

        protected void Db1_SelectedIndexChanged(object sender, EventArgs e)
        {
            addproduct.CssClass = "Initial";
            alterpro.CssClass = "Initial";
            deletepro.CssClass = "Initial";
            viewproduct.CssClass = "Initial";
            viewallapro.CssClass = "Clicked";
            view.ActiveViewIndex = 5;
            
           
           


        }

        protected void alterproname_TextChanged(object sender, EventArgs e)
        {
            

                addproduct.CssClass = "Initial";
                alterpro.CssClass = "Clicked";
                deletepro.CssClass = "Initial";
                viewproduct.CssClass = "Initial";
                viewallapro.CssClass = "Initial";
                view.ActiveViewIndex = 2;

                string altname = alterproname.Text;

                SqlDataReader sdr = Validatesearch.ValidateSearchProduct(altname);

                if (sdr.Read())
                {

                    alterproname.Text = sdr[1].ToString();

                  


                    int count = (int)sdr[3];
                    alterpronum.Text = "AVAILABLE COUNT " + count.ToString();
                    DateTime datemanuf = (DateTime)sdr[4];
                    alterpromanuf.Text = "DATE OF MANUFACTURE" + datemanuf.ToString();

                    DateTime expiredate = (DateTime)sdr[5];
                    alterproexpiry.Text = "DATE OF EXPIRE" + expiredate.ToString();
                }


                
               
            
        }

        protected void gotocustomerpage_Click(object sender, EventArgs e)
        {
            Server.Transfer("ProductHome.aspx");
        }

        

      

      
     

       

      
    }
}