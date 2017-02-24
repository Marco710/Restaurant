<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BackManagement.aspx.cs" Inherits="web.BackManagement" %>
<%@ Import Namespace="System.Data" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link href="css/style2.css" rel="stylesheet" type="text/css"/>
</head>

<script>
    function windowHeight() {
        var de = document.documentElement;
        return self.innerHeight || (de && de.clientHeight) || document.body.clientHeight;
    }
    window.onload = window.onresize = function () {
        var wh = windowHeight();
        document.getElementById("xt-left").style.height = document.getElementById("xt-right").style.height = (wh - document.getElementById("xt-top").offsetHeight) + "px";
    }
</script>
<body>

    <!-- top -->
<div id="xt-top">
    <div class="xt-logo"><a href="#" id="home" runat="server" onserverclick="home_ServerClick"><img src="images/logo2.png" /></a></div>
    <div class="xt-geren">
        <div class="xt-exit"><span class="xt-span">您好! 管理员，欢迎您登录管理中心</span><a href="#" class="help">帮助</a>
            <a href="Login.aspx" class="exit">退出</a></div>
    </div>
</div>
<!-- left -->
<div class="xt-center">
<div id="xt-left">
    <div class="xt-logo"></div>
    <div class="xt-menu">
        <form id="form1" runat="server">
        <ul>
            <li><a href="#" class="hover" runat="server" onserverclick="click_BaseInformation"><em class="one"></em>基础信息</a></li>
            <li><a href="#" class="hover" runat="server" onserverclick="click_MenuInformation"><em class="one"></em>菜单信息</a></li>
            <li><a href="#" class="hover" runat="server" onserverclick="click_OrderInformation"><em class="one"></em>用餐信息</a></li>
            <li><a href="#" class="hover" runat="server" onserverclick="click_BillInformation"><em class="one"></em>结单信息</a></li>
            <li><a href="#" class="hover" runat="server" onserverclick="click_DailyBillInformation"><em class="one"></em>每日营业情况信息</a></li>
              </ul>
        </form>
        <div class="xt-menu-list"></div>
        <ul>
            <li><a href="#"><em class="two"></em>系统设置</a></li>
        </ul>
        <ul>
            <li><a href="#"><em class="three"></em>报表数据</a></li>
        </ul>
    </div>
</div>
<!-- right -->
    <div id="xt-right">
<iframe src="<%=is_url %>" width="1332" height="689">

</iframe>
        </div>
</div>

</body>
</html>
