<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminsignup.aspx.cs" Inherits="smartshop.adminsignup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
</head>
<body style="background-image:url(pgadmin.jpg)">
    <form id="form1" runat="server">
    <div>
    
         <table style="width:600px ; height:300px; margin-bottom:400px ; margin-top:350px ; margin-left:600px; font-size:x-large" >
        <tr>
            <th>
                <asp:Label ID="afname" runat="server" Text="FIRST NAME" style="width:auto"  >

                </asp:Label>
            </th>
            <th>
                <asp:TextBox ID="txAFname" runat="server"  Text="" required="required">

                </asp:TextBox>
             </th>
        </tr>
    
        <tr>
            <th>
                <asp:Label ID="alastname" runat="server" Text="LASTNAME"  style="width:auto" >

                </asp:Label>
            </th>
            <th>
                <asp:TextBox ID="txALname" runat="server" required="required" Text="" >

                </asp:TextBox>
             </th>
            </tr>
    <tr>
            <th>
                <asp:Label ID="adob" runat="server"  Text="DATE OF BIRTH [MM-DD-YYYY]"  >

                </asp:Label>
            </th>
            <th>
              <asp:TextBox ID="txAdminDOB" runat="server" AutoPostBack="true" OnTextChanged="txAdminDOB_TextChanged"/>
             </th>
            </tr>
              <tr>
            <th>
                <asp:Label ID="lbAge" runat="server"  Text="CURRENT AGE"/>

            </th>
            <th>
                <asp:TextBox ID="txAge" runat="server" ReadOnly="true"/>

              
             </th>
            </tr>
<tr>
            <th>
                CONTACT NUMBER
            </th>
            <th>
                <asp:TextBox ID="txAcontact" runat="server" TextMode="Phone">

                </asp:TextBox>
            </th>
        </tr>
         
        <tr>
            <th>
               GENDER
            </th>
            <th>
                <asp:RadioButton ID="arb1" GroupName="G" Text="MALE" runat="server" Font-Size="Small" />
                 <asp:RadioButton ID="arb2" GroupName="G" Text="FEMALE" runat="server"  Font-Size="Small" />

            </th>
        </tr>

          <tr>
              <th>
                  USER NAME
              </th>
              <th>
                  <asp:TextBox ID="txAUserId" runat="server" Text="">

                  </asp:TextBox>
              </th>
          </tr>

          <tr>
              <th>
                 PASSWORD
              </th>
              <th>
                  <asp:TextBox ID="txApw" runat="server" Text="" required="required" TextMode="Password">

                  </asp:TextBox>
              </th>
          </tr>
              <tr>
            <th>
                <asp:Label ID="lbAconfirm" runat="server" Text="CONFIRM PASSWORD">

                </asp:Label>
            </th>
            <th>
                <asp:TextBox ID="txAConfirm" runat="server"  Text="" TextMode="Password">

                </asp:TextBox>
             </th>
            </tr>
  

         <tr>
              <th>
                <asp:Button ID="btnReset" runat="server" Text="RESET" OnClick="btnReset_Click" />
            </th>
           <th>
                <asp:Button ID="abtnsignup" runat="server" Text="SignUp" style="text-align:center" OnClick="abtnsignup_Click"  >

                </asp:Button>
            </th>
         </tr>
<tr>
            <th colspan="2">
                <asp:Label ID="lbStatus" runat="server" BackColor="#FFFF66" />
            </th>
    </tr>
    </table>


    </div>
    </form>
</body>
</html>
