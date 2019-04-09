<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="firstpage.aspx.cs" Inherits="smartshop.firstpage" %>






<!DOCTYPE html>

<html >
<head runat="server">
    <title>HOME PAGE</title>
    
</head>
<body style="background-image:url(pg1.jpg); width:auto; height:auto ">
    <form id="form1" runat="server">
    <div > 
        <section style="width:600px ; height:300px; text-align:center ; margin-left:400px ; margin-top:200px">
            <h1 style="font-family: Jokerman; font-size: 56px; font-weight: bold; font-style: italic; font-variant: normal; text-transform: uppercase; color: #0066FF">
                SmartSHop
            </h1>
        </section>
        <section>

              <table style="width:200px ; height:100px; margin-bottom:400px ; margin-top:350px; margin-left:280px; margin-top:120px">
                   <tr>
            <th>
                <asp:Label ID ="ut" runat="server" Text="USERTYPE" ></asp:Label>
                <?th>
                    <th>

                <asp:DropDownList ID="usertype1" runat="server" OnSelectedIndexChanged="usertype1_SelectedIndexChanged" AutoPostBack="true">
                  
                    <asp:ListItem Text="Select" value="none" Selected="True" >

                    </asp:ListItem>
                    <asp:ListItem Text="CUSTOMER" Value="USER" >

                    </asp:ListItem>
                      <asp:ListItem Text="SHOP_MANAGER" value="ADMIN" >

                    </asp:ListItem>

                </asp:DropDownList>
                
            </th>
           
            </tr>
        <tr>
            <th >
               USER ID
            </th>
            <th>
                <asp:TextBox ID="txuserid" runat="server"  Text="" >

                </asp:TextBox>
             </th>
        </tr>
        <tr>
            <th>
                <asp:Label ID="userpass" runat="server" Text="PASSWORD" >

                </asp:Label>
            </th>
            <th>
                <asp:TextBox ID="txpsw" runat="server"  Text="" TextMode="password" >

                </asp:TextBox>
             </th>
            </tr>


           
         <tr>
            
            

      
            <th>
                <asp:Button  ID="btnsignup" runat="server" Text="SignUp" style="text-align:center ; background-color:deepskyblue"  onclick="btnsignup_Click" ToolTip="New User? Click Sign Up To Register">

                </asp:Button>
            </th>
             <th>
                <asp:Button ID="btnlogin" runat="server" Text="Login" style="text-align:center ; background-color:deepskyblue" onclick="btnlogin_Click" ToolTip="Click Login using valid credential">

                </asp:Button>
            </th>
           
        
          <td colspan="2">
                <asp:Label ID="lbStatus" runat="server" Text="" style="border:2px inset white; border-bottom-left-radius:10px; border-bottom-right-radius:10px;"/>
            </td>
             
         </tr>
    </table>

        </section>

     
    </div>
    </form>
</body>
</html>
