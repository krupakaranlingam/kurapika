<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usersignup.aspx.cs" Inherits="smartshop.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .right {
        
        margin-top:00px;
        }
        .left {
        
            margin-top:200px;
        
        }
    </style>
    <script src="jquery-3.3.1.min.js"></script>
    <script type="text/javascript">
        var speed = 4000;
        function effectFadeIn(classname) {
            $("." + classname).fadeOut(speed).fadeIn(speed, effectFadeOut(classname))
        }
        function effectFadeOut(classname) {
            $("." + classname).fadeIn(speed).fadeOut(speed, effectFadeIn(classname))
        }
        //Calling fuction on pageload
        $(document).ready(function () {
            effectFadeIn('flashingTextcss');
        });

    </script>
</head>
<body style="background-image:url('sign2.jpg') ; height:auto; width:auto;">
    <form id="form1" runat="server">
        <div class="split left" style="width:600px;height:300px; margin-left:200px ">
        <section" class="flashingTextcss" style="text-transform: uppercase; font-size: 65px; font-style: inherit; font-family: 'Curlz MT'; font-weight: 900; font-variant: small-caps; color: #FFFFFF" aria-haspopup="False">
        
                      SMARTSHOP 
            </section>
        </div>
    <div class="split right">
    
    <table style="width:300px ; height:400px;margin-left:1300px; font-size:large ;" >
        <tr>
            <th>
                <asp:Label ID="ufname" runat="server" Text="FIRST NAME" style="width:auto"  >

                </asp:Label>
            </th>
            <th>
                <asp:TextBox ID="txtUFname" runat="server"  Text="" required="required">

                </asp:TextBox>
             </th>
        </tr>
    
        <tr>
            <th>
                <asp:Label ID="ulastname" runat="server" Text="LASTNAME"  style="width:auto" >

                </asp:Label>
            </th>
            <th>
                <asp:TextBox ID="txtULname" runat="server" required="required" Text="" >

                </asp:TextBox>
             </th>
            </tr>
    <tr>
            <th>
                <asp:Label ID="dob" runat="server"  Text="DATE OF BIRTH"  >

                </asp:Label>
            </th>
            <th>
              <asp:TextBox ID="txtudob" runat="server"   AutoPostBack="true" OnTextChanged="txAdminDOB_TextChanged" >

              </asp:TextBox>
               
             </th>
            </tr>
         <tr>
            <th>
                <asp:Label ID="UAge" runat="server"  Text="CURRENT AGE"/>

            </th>
            <th>
                <asp:TextBox ID="txUge" runat="server" ReadOnly="true"/>

              
             </th>
            </tr>
        <tr>
            <th>
                CONTACT NUMBER
            </th>
            <th>
                <asp:TextBox ID="ucontact" runat="server" >

                </asp:TextBox>
            </th>
        </tr>
         
        <tr>
            <th>
               GENDER
            </th>
            <th>
                <asp:RadioButton ID="urb1" GroupName="G" Text="MALE" runat="server" Font-Size="Small" />
                 <asp:RadioButton ID="urb2" GroupName="G" Text="FEMALE" runat="server" Font-Size="Small" />

            </th>
        </tr>

          <tr>
              <th>
                  USER NAME
              </th>
              <th>
                  <asp:TextBox ID="txtUId" runat="server" Text="">

                  </asp:TextBox>
              </th>
          </tr>

          <tr>
              <th>
                 PASSWORD
              </th>
              <th>
                  <asp:TextBox ID="txtupw" runat="server" Text="" required="required" TextMode="Password">

                  </asp:TextBox>
              </th>
          </tr>
              <tr>
            <th>
                <asp:Label ID="confirm" runat="server" Text="CONFIRM"  >

                </asp:Label>
            </th>
            <th>
                <asp:TextBox ID="txtuconfirm" runat="server"  Text="" TextMode="Password" >

                </asp:TextBox>
             </th>
            </tr>
  

         <tr>
              <th>
                <asp:Button ID="btnReset" runat="server" Text="RESET" OnClick="btnReset_Click1"  />
            </th>
           <th>

                <asp:Button ID="btnsignup" runat="server" Text="SignUp" style="text-align:center" OnClick="btnsignup_Click"  >

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
