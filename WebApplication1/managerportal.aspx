<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="managerportal.aspx.cs" Inherits="smartshop.managerportal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .Initial {
            display: block;
  padding: 4px 18px 4px 18px;
  float: left;
  background-color:violet ;
  color: Black;
  font-weight: bold;
        }
        .Initial:hover
{
  color: White;
  background-color:violet ;
}
.Clicked
{
  float: left;
  display: block;
background-color:violet ;
  padding: 4px 18px 4px 18px;
  color: Black;
  font-weight: bold;
  color: White;
}
       
     
        .auto-style1 {
            height: 26px;
        }
        .right {
        
       float:right;
        
        }
       
     
    </style>
</head>
<body style="background-color:gray">
    <form id="form1" runat="server">
    <div style="height:40px">
        <menu style="text-align:center">
         
            <asp:Label ID="portalname" runat="server" Text="MANAGER PORTAL" style="text-align:justify"></asp:Label>
            <asp:Button ID="signout" runat="server" Text="Log out" OnClick="toproducthome_Click" style="float:right"> </asp:Button>
           
        </menu>
      
    
    </div>
        <div class="split right">
            <table style="width:200px; height:200px" >
               <tr>
                   <th>
                       <asp:LinkButton ID="faq" runat="server" Text="FAQ" >
                           

                       </asp:LinkButton>
                       
                      
                   </th>
               </tr>
                <tr>
                    <th>
                        <asp:LinkButton ID="contact" runat="server" Text="Contact" >

                       </asp:LinkButton>
                    </th>
                </tr>
                <tr>
                    <th>
                         <asp:LinkButton ID="gotocustomerpage" runat="server" Text="HOMEPAGE" OnClick="gotocustomerpage_Click" >

                       </asp:LinkButton>
                    </th>
                </tr>

           </table>
        </div>
        <div style="width:800px ; height:200px  " >

          
            
             <section class="split left" style="width:800px; height:200px">
                
          <table style="width:800px ; height:200px ; border:1px solid violet">
              <tr >
                  <th style=" margin-left:300px">
                      PRODUCT DETAILS
                  </th>
              </tr>
              <tr>
                  <th>
                      <asp:Button ID="addproduct" runat="server" Text="ADD PRODUCT DETAILS" OnClick="addpro_Click" CssClass="Initial" />
                     
                     
                  </th>
           
                   <th>
                     <asp:Button ID="alterpro" runat="server" CssClass="Initial"  Text="EDIT PRODUCT DETAILS" OnClick="alterpro_Click"/>
                  </th>
              
                   <th>
                       <asp:Button ID="deletepro" runat="server"  CssClass="Initial" Text="REMOVE PRODUCT DETAILS" OnClick="deletepro_Click" />
                  </th>
                  </tr>
              <tr>
                  <th>
                      <asp:Button ID="viewproduct" runat="server" CssClass="Initial" Text="VIEW PRODUCT" OnClick="viewproduct_Click"    />

                  </th>
              
                  <th>
                      <asp:Button ID="viewallapro" runat="server" CssClass="Initial" Text="ALL PRODUCT DETAILS" OnClick="viewallapro_Click" />
                  </th>
              </tr>
              </table>
                       
               
           </section>
            <section  style="height:400px ;width:800px; margin-top:60px ">
                        <asp:MultiView ID="view" runat="server">
                             <asp:View ID="none" runat="server">

                            </asp:View>
                         <asp:View ID="view1" runat="server">
                             <table style="width:800px ; border:1px solid violet">
                                 <tr>
                                   <th>
                                         <asp:Label ID="proname" runat="server" Text="PRODUCT NAME"   ></asp:Label>
                                       </th>
                                     <th>
                                         <asp:TextBox ID="proname1" runat="server" Text=""    ></asp:TextBox>
                                    </th>
                                     </tr>
                                 <tr>
                                     <th >
                                         <asp:Label ID="proimage" runat="server" Text="PRODUCT IMAGE" ></asp:Label>
                                         </th>
                                     <th>
                                         <asp:FileUpload ID="proimage1" runat="server"   />
                                     </th>
                                 </tr>
                                 <tr>
                                     <th>
                                         <asp:Label ID="prono" runat="server" Text="NO OF PRODUCTS"></asp:Label>
                                         </th>
                                     <th>
                                         <asp:TextBox ID="prono1" runat="server" Text="" TextMode="Number"  ></asp:TextBox>
                                     </th>
                                 </tr>
                                 <tr>
                                     <th>
                                         DATE OF MANUFACTURING
                                         </th>
                                     <th>
                                         <asp:TextBox ID="promanuf" runat="server" Text="" TextMode="Date" ></asp:TextBox>
                                     </th>
                                 </tr>
                                 <tr>
                                     <th>
                                         DATE OF EXPIRY
                                         </th>
                                     <th>
                                           <asp:TextBox ID="proexpiry" Runat="server" Text="" TextMode="Date"  ></asp:TextBox>
                                     </th>
                                   
                                 </tr>
                                 <tr>
                                     <th>
                                         <asp:Button ID="btnsubm" runat="server" Text="SUBMIT" OnClick="btnsubm_Click" />
                                     </th>
                                     <th>
                                         <asp:Button ID="resetadd" runat="server" Text="RESET" OnClick="resetadd_Click" />
                                     </th>
                                 </tr>
                                 <tr>
                                     <th>
                                         <asp:Label ID="lb1stspro" runat="server" Text=""  ></asp:Label>
                                     </th>
                                 </tr>
                             </table>
                         </asp:View> 
                         <asp:View ID="view2" runat="server" >
                             <table style="width:800px ;border:1px solid violet">
                                 <tr>
                                     <th class="auto-style1">
                                         PRODUCT NAME
                                         </th>
                                     <th class="auto-style1">
                                          <asp:TextBox ID="alterproname" runat="server" Text="" AutoPostBack="true" OnTextChanged="alterproname_TextChanged"></asp:TextBox>
                                     
                                     </th>       
                                 </tr>
                                 <tr>
                                     <th>
                                         NO OF PRODUCTS
                                         </th>
                                     <th>
                                         <asp:TextBox ID="alterpronum" runat="server" Text="" TextMode="Number"></asp:TextBox>
                                     </th>
                                 </tr>
                                 <tr>
                                     <th>
                                         MAUFACTURE DATE
                                         </th>
                                     <th>
                                         <asp:TextBox ID="alterpromanuf" runat="server"  ></asp:TextBox>
                                     </th>
                                 </tr>
                                 <tr><th>
                                       EXPIRY DATE
                                     </th>
                                     <th>
                                         <asp:TextBox ID="alterproexpiry" runat="server"  ></asp:TextBox>
                                     </th>
                                 </tr>
                                 <tr>
                                     <th>
                                         <asp:Button ID="submitalter" runat="server" Text="SUBMIT" OnClick="submitalter_Click" />
                                     </th>
                                     <th>
                                         <asp:Label ID="submitstatus" runat="server"  Text="" ></asp:Label>
                                     </th>
                                 </tr>
                             </table>

                         </asp:View> 
                         <asp:View ID="view3" runat="server">
                             <table style="width:800px; border:1px solid violet">
                                 <tr>
                                     <th>
                                          <asp:Label ID="Label1" runat="server" Text="PRODUCT NAME"></asp:Label>
                                     </th>
                                     <th>
                                           <asp:TextBox ID="delpro1" runat="server" Text=""    ></asp:TextBox>
                                     </th>
                                     <th>
                                         <asp:Button ID="DElete" runat="server" Text="DELETE" OnClick="DElete_Click" />
                                     </th>
                                 </tr>
                                 <tr>
                                     <th>
                                         <asp:Label ID="delstatus" runat="server" Text=""></asp:Label>
                                     </th>
                                 </tr>
                             </table>
                            

                          </asp:View>
                           







                            <asp:View ID="view4" runat="server">
                                 
                                      <table style="width:800px ; border:1px solid violet">
                                          <tr>
                                              <th>
                                                   <asp:Label ID="searchpro1" runat="server" Text="SEARCH" ></asp:Label>
                                              </th>
                                              <th>
                                                          <asp:TextBox ID="searchpro" runat="server" OnTextChanged="searchpro_TextChanged" AutoPostBack="true" ></asp:TextBox>
                                                      </th>
                                              <th>
                                                  <asp:Button ID="resetsearch" runat="server" Text="RESET" OnClick="resetsearch_Click" />
                                              </th>
                                          </tr>
                                      </table>
                                         
                                         <table style=" text-align:center;width:800px;height:600px">
                                             
                                              <tr>
                                                     <th>
                                                          <asp:Label ID="nameofproduct" Text="" runat="server"   ></asp:Label>
                                                       </th>
                                                </tr>
                                              <tr style="width:600px ; height:400px">
                                                     <th>
                                                        <asp:Image ID="imageofproduct" runat="server" style="width:600px ;height:400px" />
                                                    </th>
                                              </tr>
                                              <tr>
                                                 <th>
                                                    <asp:Label ID="countofpro" runat="server" Text=""  ></asp:Label>
                                                </th>
                                             </tr>
                                             <tr>
                                                     <th>
                                                              <asp:Label ID="manufofproduct" runat="server" Text=""   ></asp:Label>
                                                     </th>
                                             </tr>
                                             <tr>
                                                     <th>
                                                              <asp:Label ID="expiryofproduct" runat="server" Text="" ></asp:Label>
                                                      </th>
                                            </tr>
                                         </table>
                                    
     

                           
                         </asp:View>
                            <asp:View ID="view5" runat="server">
                               <asp:GridView ID="Db1" runat="server" OnSelectedIndexChanged="Db1_SelectedIndexChanged"  GridLines="Horizontal" style="width:800px; border:1px solid violet"   >

                               </asp:GridView>
                            </asp:View>
                        </asp:MultiView>
                 
             
          </section>
            
        </div>
        
 
    </form>
</body>
</html>
