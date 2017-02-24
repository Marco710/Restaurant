<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderInformation.aspx.cs" Inherits="web.OrderInformation" %>
<%@ Import Namespace="System.Data" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link href="css/style3.css" rel="stylesheet" type="text/css"/>
<script src="My97DatePicker/WdatePicker.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="xt-right">
    <div class="xt-bt">基础信息 > 订餐信息管理</div>
    <div class="xt-input">
        <span style="margin-left:300px">用户名称</span>
        <asp:TextBox ID="txtUserName" class="int-text" runat="server"></asp:TextBox>
&nbsp;<span>用餐日期</span>        
        <asp:TextBox ID="txtDateTime" class="int-text" runat="server" onclick="WdatePicker()"></asp:TextBox>
        &nbsp;&nbsp;
        <input id="search" type="button" value="确 定" class="green-int" runat="server" onserverclick="search_ServerClick"/>
        <input id="back" type="button" value="返 回" class="green-int" runat="server" onserverclick="back_ServerClick" />
    </div>
    <div class="xt-table">
       <table cellpadding="0" cellspacing="0" border="0" bgcolor="#dcdcdc" width="100%">
            <tr>
            <th>用户名称</th>
            <th>食物名称</th>
            <th>食物单价</th>
            <th>食物数量</th>
            <th>食物总价</th>
            <th>点餐时间</th>
            <th>是否结单</th>
            </tr>
            <% if (dt != null) 
           { 
               foreach (DataRow dt_dr in dt.Rows) 
               { 
        %> 
        <tr> 
            <td> 
                <%=dt_dr["username"]%> 
            </td> 
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
            <td> 
                <input id="<%=dt_dr["ID"]%>" type="checkbox" <%=dt_dr["IsChecked"]%> onclick="return false;"/>
            </td>    
        </tr> 
            <% 
            } 
           } 
           else 
           { 
        %> 
        <tr> 
            <td colspan="6"> 
                暂无信息 
            </td> 
        </tr> 
            <%  } 
             
        %> 

            </table>
    </div>
    <div class="xt-fenye">
        <div class="xt-fenye-left">当前第 1 / 270 页,每页10条，共 2696条记录</div>
        <div class="xt-fenye-right">
            <a href="#">首页</a>
            <a href="#">上一步</a>
            <a href="#">下一步</a>
            <a href="#">尾页</a>
            <input type="text" name="text" />
            <a href="#" class="xt-link">跳转</a>
        </div>
    </div>
</div>
    </form>
</body>
</html>
