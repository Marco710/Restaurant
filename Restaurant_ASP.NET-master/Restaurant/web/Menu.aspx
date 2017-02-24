<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="web.Menu" %>
<%@ Import Namespace="System.Data" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Menu</title>
<meta charset="utf-8">
<meta name = "format-detection" content = "telephone=no" />
<link href="css/style3.css" rel="stylesheet" type="text/css"/>
<link rel="icon" href="images/favicon.ico">
<link rel="shortcut icon" href="images/favicon.ico" />
<link rel="stylesheet" href="css/stuck.css">
<link rel="stylesheet" href="css/style.css">
<link rel="stylesheet" href="css/touchTouch.css">
<script src="js/jquery.js"></script>
<script src="js/jquery-migrate-1.1.1.js"></script>
<script src="js/script.js"></script> 
<script src="js/superfish.js"></script>
<script src="js/jquery.equalheights.js"></script>
<script src="js/jquery.mobilemenu.js"></script>
<script src="js/jquery.easing.1.3.js"></script>
<script src="js/tmStickUp.js"></script>
<script src="js/jquery.ui.totop.js"></script>
<script src="js/touchTouch.jquery.js"></script>

<script>
    $(document).ready(function () {

        $().UItoTop({ easingType: 'easeOutQuart' });
        $('#stuck_container').tmStickUp({});
        $('.gallery .gall_item').touchTouch();

    });
</script>
<script type="text/javascript">

    function show() {
        document.getElementById("div").style.display = "";
        //alert(document.getElementById("div").style.display)
    }
    function hidden() {
        document.getElementById("foodordered").style.visibility = "hidden";
        //alert(document.getElementById("div").style.display)
    }
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
               <li class="current"><a href="Menu.aspx">menu</a></li>
               <li><a href="Blog.aspx">blog</a></li>
               <li><a href="Contact.aspx">contacts</a></li>
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
<section class="content gallery pad1"><div class="ic">More Website Templates @ TemplateMonster.com - July 30, 2014!</div>
  <div class="container">
    <div class="row">
      <div class="grid_4">
        <div class="gall_block">
          <div class="maxheight">
            <a href="images/bbig1.jpg" class="gall_item"><img id="img1" alt="" runat="server"></a>
            <div class="gall_bot">
            <div class="text1"><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></div>
            Rehoncus. Aliquam nibh antegestas id ictum a, commodo. Praesenterto faucibus maleada faucibusnec laeet metus id laoreet 
            <br>
            <button id="a1" type="button" class="btn" runat="server" onserverclick="Add_FoodClick1">Add</button>
                <button id="d1" type="button" class="btn" runat="server" onserverclick="Delete_FoodClick1">Delete</button>
                <button id="price1" type="button" class="btn">
                    <asp:Label ID="lbPrice1" runat="server"></asp:Label></button></div>
          </div>
        </div>
      </div>
      <div class="grid_4">
        <div class="gall_block">
          <div class="maxheight">
            <a href="images/big3.jpg" class="gall_item"><img id="img2" alt="" runat="server"></a>
            <div class="gall_bot">
            <div class="text1"><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></div>
            Kehoncus. Aliquam nibh antegestas id ictum a, commodo. Praesenterto faucibus maleada faucibusnec laeet metus id laoreet 
            <br>
            <button id="a2" type="button" class="btn" runat="server" onserverclick="Add_FoodClick2">Add</button>
                <button id="d2" type="button" class="btn" runat="server" onserverclick="Delete_FoodClick2">Delete</button>
                <button id="price2" type="button" class="btn"><asp:Label ID="lbPrice2" runat="server"></asp:Label></button>
            </div>
          </div>
        </div>
      </div>
      <div class="grid_4">
        <div class="gall_block">
          <div class="maxheight">
            <a href="images/bbig3.jpg" class="gall_item"><img id="img3" alt="" runat="server"></a>
            <div class="gall_bot">
            <div class="text1"><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></div>
            Tehoncus. Aliquam nibh antegestas id ictum a, commodo. Praesenterto faucibus maleada faucibusnec laeet metus id laoreeto 
            <br>
            <button id="a3" type="button" class="btn" runat="server" onserverclick="Add_FoodClick3">Add</button>
                <button id="d3" type="button" class="btn" runat="server" onserverclick="Delete_FoodClick3">Delete</button>
                <button id="price3" type="button" class="btn"><asp:Label ID="lbPrice3" runat="server"></asp:Label></button>
            </div>
          </div>
        </div>
      </div>
      <div class="clear sep__1"></div>
      <div class="grid_4">
        <div class="gall_block">
          <div class="maxheight">
            <a href="images/bbig4.jpg" class="gall_item"><img id="img4" alt="" runat="server"></a>
            <div class="gall_bot">
            <div class="text1"><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></div>
            Rehoncus. Aliquam nibh antegestas id ictum a, commodo. Praesenterto faucibus maleada faucibusnec laeet metus id laoreetet 
            <br>
            <button id="a4" type="button" class="btn" runat="server" onserverclick="Add_FoodClick4">Add</button>
                <button id="d4" type="button" class="btn" runat="server" onserverclick="Delete_FoodClick4">Delete</button>
                <button id="price4" type="button" class="btn"><asp:Label ID="lbPrice4" runat="server"></asp:Label></button>
            </div>
          </div>
        </div>
      </div>
      <div class="grid_4">
        <div class="gall_block">
          <div class="maxheight">
            <a href="images/bbig5.jpg" class="gall_item"><img id="img5" alt="" runat="server"></a>
            <div class="gall_bot">
            <div class="text1"><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></div>
            Aliquam nibh antegestas id ictum a, commodo. Praesenterto faucibus maleada faucibusnec laeet metus id laoreet 
            <br>
            <button id="a5" type="button" class="btn" runat="server" onserverclick="Add_FoodClick5">Add</button>
                <button id="d5" type="button" class="btn" runat="server" onserverclick="Delete_FoodClick5">Delete</button>
                <button id="price5" type="button" class="btn"><asp:Label ID="lbPrice5" runat="server"></asp:Label></button>
            </div>
          </div>
        </div>
      </div>
      <div class="grid_4">
        <div class="gall_block">
          <div class="maxheight">
            <a href="images/bbig6.jpg" class="gall_item"><img id="img6" alt="" runat="server"></a>
            <div class="gall_bot">
            <div class="text1"><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></div>
            Rehoncus. Aliquam nibh antegestas id ictum a, commodo. Praesenterto faucibus maleada faucibusnec laeet metus id laoreet 
            <br>
            <button id="a6" type="button" class="btn" runat="server" onserverclick="Add_FoodClick6">Add</button>
                <button id="d6" type="button" class="btn" runat="server" onserverclick="Delete_FoodClick6">Delete</button>
                <button id="price6" type="button" class="btn"><asp:Label ID="lbPrice6" runat="server"></asp:Label></button>
            </div>
          </div>
        </div>
      </div>
      <div class="clear sep__1"></div>
      <div class="grid_4">
        <div class="gall_block">
          <div class="maxheight">
            <a href="images/bbig7.jpg" class="gall_item"><img id="img7" alt="" runat="server"></a>
            <div class="gall_bot">
            <div class="text1"><asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></div>
            Lehoncus. Aliquam nibh antegestas id ictum a, commodo. Praesenterto faucibus maleada faucibusnec laeet metus id laor 
            <br>
            <button id="a7" type="button" class="btn" runat="server" onserverclick="Add_FoodClick7">Add</button>
                <button id="d7" type="button" class="btn" runat="server" onserverclick="Delete_FoodClick7">Delete</button>
                <button id="price7" type="button" class="btn"><asp:Label ID="lbPrice7" runat="server"></asp:Label></button>
            </div>
          </div>
        </div>
      </div>
      <div class="grid_4">
        <div class="gall_block">
          <div class="maxheight">
            <a href="images/bbig8.jpg" class="gall_item"><img id="img8" alt="" runat="server"></a>
            <div class="gall_bot">
            <div class="text1"><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></div>
            Rehoncus. Aliquam nibh antegestas id ictum a, commodo. Praesenterto faucibus maleada faucibusnec laeet metus id laorees 
            <br>
            <button id="a8" type="button" class="btn" runat="server" onserverclick="Add_FoodClick8">Add</button>
                <button id="d8" type="button" class="btn" runat="server" onserverclick="Delete_FoodClick8">Delete</button>
                <button id="price8" type="button" class="btn"><asp:Label ID="lbPrice8" runat="server"></asp:Label></button>
            </div>
          </div>
        </div>
      </div>
      <div class="grid_4">
        <div class="gall_block">
          <div class="maxheight">
            <a href="images/bbig9.jpg" class="gall_item"><img id="img9" alt="" runat="server"></a>
            <div class="gall_bot">
            <div class="text1"><asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></div>
            Oehoncus. Gliquam nibh antegestas id ictum a, commodo. Praesenterto faucibus maleada faucibusnec laeet metus id laore 
            <br>
           <button id="a9" type="button" class="btn" runat="server" onserverclick="Add_FoodClick9">Add</button>
                <button id="d9" type="button" class="btn" runat="server" onserverclick="Delete_FoodClick9">Delete</button>
                <button id="price9" type="button" class="btn"><asp:Label ID="lbPrice9" runat="server"></asp:Label></button>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
<!--==============================
              now-menu
=================================-->
        <div id="xt-right" style="position: fixed; bottom:<%=value%>px; text-align:center;width:100%;">
    <div id="foodordered" class="xt-table" style="visibility:<%=vsb%>">
       <table cellpadding="0" cellspacing="0" border="0" bgcolor="#dcdcdc" width="100%">
            <tr>
            <th>食物名称</th>
            <th>食物单价</th>
            <th>食物数量</th>
            <th>食物总价</th>
            <th>点餐时间</th>
            </tr>
            <% if (dt != null)
               {
                   foreach (DataRow dt_dr in dt.Rows)
                   {
        %> 
        <tr> 
            <td> 
                <%=dt_dr["foodname"]%> 
            </td> 
            <td> 
                <%=dt_dr["foodprice"]%> 
            </td> 
            <td> 
                <%=dt_dr["foodnum"]%> 
            </td>
            <td> 
                <%=dt_dr["sumprice"]%> 
            </td>    
            <td> 
                <%=dt_dr["datetime"]%> 
            </td>  
        </tr> 
        <% 
                   }
               }
               else
               { 
        %> 
        <tr> 
            <td colspan="5"> 
                暂无信息 
            </td> 
        </tr> 
        <%  } 
             
        %> 

            </table>
    </div>
    <div class="xt-fenye">
        <div class="xt-fenye-right">
            <asp:Label ID="sumprice" runat="server" Text="Label"></asp:Label>
            <a href="#" id="downOrder" class="xt-link" runat="server" onserverclick="downOrder_ServerClick">收起订餐表</a>
            <a href="#" id="upOrder" class="xt-link" runat="server" onserverclick="upOrder_ServerClick">展开订餐表</a>
            <a href="#" id="saveOrder" class="xt-link" runat="server" onserverclick="saveOrder_ServerClick">提交订餐</a>
        </div>
    </div>
</div>
    </section>
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
