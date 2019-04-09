<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="smartshop.Header" %>

<header style="background-image:url(header.jpg);width:auto; height: 200px; text-align:center; color: #CC00FF;">
    <section" class="flashingTextcss" style="margin-bottom:50px; text-transform: uppercase; font-size: 65px; font-style: inherit; font-family: 'Curlz MT'; font-weight: 900; font-variant: small-caps; color: #CC00FF" aria-haspopup="False">
        
                      SMARTSHOP 
            </section>
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

</header>
