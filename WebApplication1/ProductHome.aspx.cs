using System;
using System.Data;
using System.Data.SqlClient;
using System.Timers;
using System.Threading;


using UIValidatorLIB;

namespace smartshop
{
    public partial class ProductHome : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string userid = (string)Session["USERID"];
                prostatus.Text = "Welcome " + userid;
                displaymultiview.ActiveViewIndex = 1;
                imageofproduct1.Visible = false;

                int i, n=11;
                for( i = 2; i <=n; i=i+10 )
                {

                    

                        byte[] slide = Validatesearch.ValidateSearchslide(i);
                        string IMAGE = Convert.ToBase64String(slide);
                        img1.ImageUrl = String.Format("data:image/jpg;base64,{0}", IMAGE);

                        byte[] slide1 = Validatesearch.ValidateSearchslide(i + 1);
                        string IMAGE1 = Convert.ToBase64String(slide1);
                        img2.ImageUrl = String.Format("data:image/jpg;base64,{0}", IMAGE1);
                        
                        byte[] slide2 = Validatesearch.ValidateSearchslide(i + 2);
                        string IMAGE2 = Convert.ToBase64String(slide2);
                        img3.ImageUrl = String.Format("data:image/jpg;base64,{0}", IMAGE2);

                         byte[] slide3 = Validatesearch.ValidateSearchslide(i + 3);
                       string IMAGE3 = Convert.ToBase64String(slide3);
                        Image1.ImageUrl = String.Format("data:image/jpg;base64,{0}", IMAGE3);

                       byte[] slide4 = Validatesearch.ValidateSearchslide(i + 4);
                        string  IMAGE4 = Convert.ToBase64String(slide4);
                        Image2.ImageUrl = String.Format("data:image/jpg;base64,{0}", IMAGE4);

                     byte[]   slide5 = Validatesearch.ValidateSearchslide(i + 5);
                     string   IMAGE5 = Convert.ToBase64String(slide5);
                        Image3.ImageUrl = String.Format("data:image/jpg;base64,{0}", IMAGE5);

                       byte[] slide6 = Validatesearch.ValidateSearchslide(i + 6);
                      string  IMAGE6 = Convert.ToBase64String(slide6);
                        Image4.ImageUrl = String.Format("data:image/jpg;base64,{0}", IMAGE6);

                      byte[] slide7 = Validatesearch.ValidateSearchslide(i + 7);
                      string  IMAGE7 = Convert.ToBase64String(slide7);
                       Image5.ImageUrl = String.Format("data:image/jpg;base64,{0}", IMAGE7);

                       byte[] slide8 = Validatesearch.ValidateSearchslide(i + 8);
                       string IMAGE8 = Convert.ToBase64String(slide8);
                        Image6.ImageUrl = String.Format("data:image/jpg;base64,{0}", IMAGE8);

                        byte[] slide9 = Validatesearch.ValidateSearchslide(i + 9);
                       string IMAGE9 = Convert.ToBase64String(slide9);
                        Image7.ImageUrl = String.Format("data:image/jpg;base64,{0}", IMAGE9);


                    }
                    
                }
            }
        

        
               
          /*      imageofproduct.Visible = false;
                slideimage.Visible = false;
                int r = RandomNumber(1, 5);
            byte[] slide = Validatesearch.ValidateSearchslide(r);
            string IMAGE = Convert.ToBase64String(slide);
            slideimage.ImageUrl = String.Format("data:image/jpg;base64,{0}", IMAGE);
      */
           protected void promenu_Click1(object sender, EventArgs e)
        {

        }

        protected void prologout_Click(object sender, EventArgs e)
        {
          

                
                Session.Remove("USERID");
                Session.Clear();
                Session.Abandon();
                Response.Cookies["USERID"].Value = string.Empty;
                Response.Redirect("firstpage.aspx");

               
        }

       

        protected void prosearch1_TextChanged(object sender, EventArgs e)
        {


            displaymultiview.ActiveViewIndex = 0;
            
            string message = string.Empty;
            string searchproduct = prosearch1.Text;
           
                if (searchproduct != "")
                {
                    try
                    {

                        //string status1 = Validatesearch.ValidateSearch(searchproduct);
                        SqlDataReader sdr = Validatesearch.ValidateSearchProduct(searchproduct);
                        if (sdr.HasRows)
                        {
                            int i = 0;
                            while (sdr.Read())
                            {
                                ++i;
                                if (i == 1)
                                {
                                   
                                    nameofproduct1.Text = sdr[1].ToString();
                                    imageofproduct1.Visible = true;
                                    byte[] status2 = (byte[])sdr[2];
                                    string IMAGE = Convert.ToBase64String(status2);
                                    imageofproduct1.ImageUrl = String.Format("data:image/jpg;base64,{0}", IMAGE);


                                    int count = (int)sdr[3];
                                    countofpro1.Text = "AVAILABLE COUNT " + count.ToString();
                                    DateTime datemanuf = (DateTime)sdr[4];
                                    manufofproduct1.Text = "DATE OF MANUFACTURE" + datemanuf.ToString();

                                    DateTime expiredate = (DateTime)sdr[5];
                                    expiryofproduct1.Text = "DATE OF EXPIRE" + expiredate.ToString();
                                }
                                if (i == 2)
                                {
                                    
                                    nameofproduct2.Text = sdr[1].ToString();
                                    imageofproduct2.Visible = true;
                                    byte[] status2 = (byte[])sdr[2];
                                    string IMAGE = Convert.ToBase64String(status2);
                                    imageofproduct2.ImageUrl = String.Format("data:image/jpg;base64,{0}", IMAGE);


                                    int count = (int)sdr[3];
                                    countofpro2.Text = "AVAILABLE COUNT " + count.ToString();
                                    DateTime datemanuf = (DateTime)sdr[4];
                                    manufofproduct2.Text = "DATE OF MANUFACTURE" + datemanuf.ToString();

                                    DateTime expiredate = (DateTime)sdr[5];
                                    expiryofproduct2.Text = "DATE OF EXPIRE" + expiredate.ToString();
                                }
                            }
                        }
                        sdr.Close();
                    }
                    catch (Exception ex)
                    {
                        imageofproduct1.Visible = false;
                        message = ex.Message;
                        nameofproduct1.Text = string.Empty;
                        countofpro1.Text = string.Empty;
                        manufofproduct1.Text = string.Empty;
                        expiryofproduct1.Text = string.Empty;
                    }
                }
                else if (searchproduct == "")
                {
                    displaymultiview.ActiveViewIndex = 1;
                }
            
        }

        protected void prologout_Click1(object sender, EventArgs e)
        {
            Response.Redirect("firstpage.aspx");
        }

      
    }
}