<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductHome.aspx.cs" Inherits="smartshop.ProductHome" %>

<%@ Register Src="~/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/FOOTER.ascx" TagPrefix="uc1" TagName="FOOTER" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
 
    <style>
body {
  font-family: Arial;
  color: black;
}

.split {
  height: 100%;
  width: 50%;
  position: fixed;
  z-index: 1;
  top: 0;
  overflow-x: hidden;
  padding-top: 20px;
}



.mySlides {display:none;}

      

* {box-sizing: border-box;}
body {font-family: Verdana, sans-serif;}
.mySlides {display: none;}
img {vertical-align: middle;}

/* Slideshow container */
.slideshow-container {
  max-width: 600px;
  height:400px;
  position: relative;
  margin-left: 1100px;
  margin-top: 50px;

           margin-right: 50px;
        }

/* Caption text */
.text {
  color: #f2f2f2;
  font-size: 15px;
  padding: 8px 12px;
  position: absolute;
  bottom: 8px;
  width: 100%;
  text-align: center;
}

/* Number text (1/3 etc) */
.numbertext {
  color: #f2f2f2;
  font-size: 12px;
  padding: 8px 12px;
  position: absolute;
  top: 0;
}

/* The dots/bullets/indicators */
.dot {
  height: 15px;
  width: 15px;
  margin: 0 2px;
  
  background-color: #bbb;
  border-radius: 50%;
  display: inline-block;
  transition: background-color 0.6s ease;
}

.active {
  background-color: #717171;
}

/* Fading animation */
.fade {
  -webkit-animation-name: fade;
  -webkit-animation-duration: 1.5s;
  animation-name: fade;
  animation-duration: 1.5s;
}

@-webkit-keyframes fade {
  from {opacity: .4} 
  to {opacity: 1}
}

@keyframes fade {
  from {opacity: .4} 
  to {opacity: 1}
}

/* On smaller screens, decrease text size */
@media only screen and (max-width: 300px) {
  .text {font-size: 11px}
}
    </style>
 

  
   
</head>
<body style="background-image:url(prohome.jpg)">
    <form id="form1" runat="server">
        <div style="color:white">
            <header>
                <uc1:Header runat="server" id="Header" />
            </header>
         <menu style="color:white">
             
             <asp:Label ID="prostatus" runat="server" Text="" BackColor="PaleVioletRed" ></asp:Label>
                <asp:Label  ID="prosearch" runat="server" Text="SEARCH" ></asp:Label>
             <asp:TextBox ID="prosearch1" runat="server" Text="" TextMode="Search" OnTextChanged="prosearch1_TextChanged"   AutoPostBack="true"></asp:TextBox>
             <asp:LinkButton ID="prologout" runat="server" Text="Logout" style="margin-right:0px" OnClick="prologout_Click1" ></asp:LinkButton>
         </menu>

      </div>    
  


     <div  style="margin-left:1300px">
  <span class="dot"></span> 
  <span class="dot"></span> 
  <span class="dot"></span> 
    <span class="dot"></span> 
    <span class="dot"></span> 
    <span class="dot"></span> 
    <span class="dot"></span> 
    <span class="dot"></span> 
<span class="dot"></span> 
    <span class="dot"></span> 
</div> 
        <div class="slideshow-container"" >
  <div class="mySlides fade">
      <asp:Image ID="img1" runat="server" style="width:100%" />
</div>
<div class="mySlides fade">
    <asp:Image ID="img2" runat="server" style="width:100%"/>
</div> 
<div class="mySlides fade">
   <asp:Image ID="img3" runat="server" style="width:100%" />
</div>
            <div class="mySlides fade">
   <asp:Image ID="Image1" runat="server" style="width:100%" />
</div>
            <div class="mySlides fade">
   <asp:Image ID="Image2" runat="server" style="width:100%" />
</div>
            <div class="mySlides fade">
   <asp:Image ID="Image3" runat="server" style="width:100%" />
</div>
            <div class="mySlides fade">
   <asp:Image ID="Image4" runat="server" style="width:100%" />
</div>
            <div class="mySlides fade">
   <asp:Image ID="Image5" runat="server" style="width:100%" />
</div>
            <div class="mySlides fade">
   <asp:Image ID="Image6" runat="server" style="width:100%" />
</div>
            <div class="mySlides fade">
   <asp:Image ID="Image7" runat="server" style="width:100%" />
</div>
  

</div>

<br/>


          
         
 
<script>
    var slideIndex = 0;
    showSlides();

    function showSlides() {
        var i;
        var slides = document.getElementsByClassName("mySlides");
        var dots = document.getElementsByClassName("dot");
        for (i = 0; i < slides.length; i++) {
            slides[i].style.display = "none";
        }
        slideIndex++;
        if (slideIndex > slides.length) { slideIndex = 1 }
        for (i = 0; i < dots.length; i++) {
            dots[i].className = dots[i].className.replace(" active", "");
        }
        slides[slideIndex - 1].style.display = "block";
        dots[slideIndex - 1].className += " active";
        setTimeout(showSlides, 2000); // Change image every 2 seconds
    }

</script>
      



       
           <div   style="width:600px; height:1500px;margin-left:50px;font:900;margin-top:-400px">
            <section>
                
                <asp:MultiView ID="displaymultiview" runat="server">
                   
                    <asp:View ID="productview1" runat="server" >
                       
                         <table style="color:white;width:600px;height:500px ; ">
                    <tr style="width:600px ; height:400px ">
               <th>
                   <asp:Image ID="imageofproduct1" runat="server" style="width:600px ;height:400px " />

               </th>
           </tr>
           <tr>
               <th>
                   <asp:Label ID="nameofproduct1" Text="" runat="server"    ></asp:Label>
               </th>
           </tr>
           
           
      
                    <tr>
               <th>
                   <asp:Label ID="countofpro1" runat="server" Text=""  ></asp:Label>
               </th>
           </tr>
           <tr>
               <th>
                   <asp:Label ID="manufofproduct1" runat="server" Text=""   ></asp:Label>
               </th>
           </tr>
           <tr>
               <th>
                <asp:Label ID="expiryofproduct1" runat="server" Text="" ></asp:Label>
                   </th>
           </tr>
                    </table>

                        <table style="color:white; text-align:center;width:600px;height:500px ; ">

                            <tr style="width:600px ; height:400px ">
                                <th>
                                    <asp:Image ID="imageofproduct2" runat="server" style="width:600px ;height:400px " />
                                </th>

                            </tr>
                            <tr>
               <th>
                   <asp:Label ID="nameofproduct2" Text="" runat="server"    ></asp:Label>
               </th>
           </tr>
           
           
      
                    <tr>
               <th>
                   <asp:Label ID="countofpro2" runat="server" Text=""  ></asp:Label>
               </th>
           </tr>
           <tr>
               <th>
                   <asp:Label ID="manufofproduct2" runat="server" Text=""   ></asp:Label>
               </th>
           </tr>
           <tr>
               <th>
                <asp:Label ID="expiryofproduct2" runat="server" Text="" ></asp:Label>
                   </th>
           </tr>
                        </table>

                    </asp:View>

                <asp:View ID="none" runat="server">

                    </asp:View>
                    </asp:MultiView>
            </section>
       
     
 </div>  



   
     
        <div style="margin-bottom:0px">
            <footer>
         <uc1:FOOTER runat="server" id="FOOTER" />
     </footer>
        </div>
      
    </form>
        
    </body>
</html>
