<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="web.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Contacts</title>
<meta charset="utf-8">
<meta name = "format-detection" content = "telephone=no" />
<link rel="icon" href="images/favicon.ico">
<link rel="shortcut icon" href="images/favicon.ico" />
<link rel="stylesheet" href="css/form.css">
<link rel="stylesheet" href="css/stuck.css">
<link rel="stylesheet" href="css/style.css">
<script src="js/jquery.js"></script>
<script src="js/jquery-migrate-1.1.1.js"></script>
<script src="js/script.js"></script> 
<script src="js/superfish.js"></script>
<script src="js/jquery.equalheights.js"></script>
<script src="js/jquery.mobilemenu.js"></script>
<script src="js/jquery.easing.1.3.js"></script>
<script src="js/tmStickUp.js"></script>
<script src="js/jquery.ui.totop.js"></script>
<script src="js/TMForm.js"></script>
<script src="js/modal.js"></script>

<script>
    $(document).ready(function () {

        $().UItoTop({ easingType: 'easeOutQuart' });
        $('#stuck_container').tmStickUp({});

    });
</script>
<!--[if lt IE 9]>
 <div style=' clear: both; text-align:center; position: relative;'>
   <a href="http://windows.microsoft.com/en-US/internet-explorer/products/ie/home?ocid=ie6_countdown_bannercode">
     <img src="http://storage.ie6countdown.com/assets/100/images/banners/warning_bar_0000_us.jpg" border="0" height="42" width="820" alt="You are using an outdated browser. For a faster, safer browsing experience, upgrade for free today." />
   </a>
</div>
<script src="js/html5shiv.js"></script>
<link rel="stylesheet" media="screen" href="css/ie.css">


<![endif]-->
</head>
<body>
    <form id="form1" runat="server">
    <!--==============================
              header
=================================-->
<header>
<!--==============================
            Stuck menu
=================================-->
  <section id="stuck_container">
    <div class="container">
      <div class="row">
        <div class="grid_12">
        <h1>
          <a href="index.html">
            <img src="images/logo.png" alt="Logo alt">
          </a>
        </h1>  
          <div class="navigation ">
            <nav>
              <ul class="sf-menu">
               <li><a href="Home.aspx">home</a></li>
               <li><a href="Menu.aspx">menu</a></li>
               <li><a href="Blog.aspx">blog</a></li>
               <li class="current"><a href="Contact.aspx">contacts</a></li>
                  <li>
                   <asp:Label ID="UserName" runat="server" Text="Label"></asp:Label>
               </li>
                <li><a href="Login.aspx">EXIT</a></li>
             </ul>
            </nav>        
            <div class="clear"></div>
          </div>
        </div>
      </div>
    </div>
  </section> 
</header>        

<!--=====================
          Content
======================-->
<section class="content ctn__1"><div class="ic">More Website Templates @ TemplateMonster.com - July 30, 2014!</div>
  <div class="container">
    <div class="row">
      <div class="grid_12">
        <h2>Find Us</h2>
        <div class="map">
          <div class="row">
            <div class="grid_9">
              <figure class="">
                <iframe src="http://map.baidu.com/?newmap=1&ie=utf-8&s=s%26wd%3D%E5%8D%97%E4%BA%AC%E6%9E%97%E4%B8%9A%E5%A4%A7%E5%AD%A6" style="border:0"></iframe>
              </figure>
            </div>
            <div class="grid_3">
              <div class="map_block">
                <div class="map_title">Address:</div>
                9870 St Vincent Place, <br> Glasgow, DC 45 Fr 45.
              </div>
              <div class="map_block">
                <div class="map_title">Phones:</div>
                +1 800 559 6580 <br>+1 800 603 6035
              </div>
              <div class="map_block">
                <div class="map_title">Email:</div>
                <a href="#">mail@demolink.org</a>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="grid_8">
        <p>24/7 support is on for all <span class="color1 fw"><a href="#/" rel="nofollow">premium themes</a></span>. <br>
          Guys from <span class="color1 fw"><a href="http://www.templatetuning.com/" rel="nofollow">Template Tuning</a></span> are always ready to help you with customization of the chosen theme.</p>
        Kas facilisis, nulla vel viverra auctor, leo magna sodales felis, quis malesuada nibh odio ut velitoin pharetra luctus diama scelerisque eros convallis accumsan. 
      </div>
    </div>
  </div>
</section>
<div class="form_block">
  <div class="container">
    <div class="row">
      </form>
      </div>
    </div>
  </div>
</div>
<!--==============================
              footer
=================================-->
<footer id="footer">
  <div class="container">
    <div class="row">
      <div class="grid_12">  
        <div class="socials">
          <a href="#" class="fa fa-twitter"></a>
          <a href="#" class="fa fa-facebook"></a>
          <a href="#" class="fa fa-google-plus"></a>
          <a href="#" class="fa fa-pinterest"></a>
        </div>
        <div class="copyright"><span class="brand">Bliss </span> &copy; <span id="copyright-year"></span> | <a href="#">Privacy Policy</a> 
        </div>
      </div>
    </div>
  </div> 
</footer> 
    </form>
</body>
</html>
