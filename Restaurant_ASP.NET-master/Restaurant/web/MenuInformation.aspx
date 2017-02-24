<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuInformation.aspx.cs" Inherits="web.MenuInformation" %>
<%@ Import Namespace="System.Data" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link href="css/style3.css" rel="stylesheet" type="text/css"/>
    <script src="js/jquery-1.6.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        function submit() {
            var table = document.getElementById("table");
            var deleteData = new Array();
            for (var i = 1; i < table.rows.length; i++) {
                if (table.rows[i].cells[3].getElementsByTagName("INPUT")[0].checked) {
                    var data = {};
                    data.id = table.rows[i].cells[0].innerText;
                    deleteData.push(data);
                }
            }
            $.ajax({
                type: "get",
                url: "ajaxManage2.aspx",
                data: { json: JSON.stringify(deleteData) },
                dateType: "json",
                success: function (reg) {
                    var arr = reg.split('|');
                    var returnval = arr[0].toString();
                    alert(returnval);
                    window.location.href = "MenuInformation.aspx";
                },
                error: function () {
                    alert("error");
                }
            });
        }
    </script>

</head>
<body>
    <div id="xt-right">
    <div class="xt-bt">基础信息 > 菜单信息管理</div>
    <div class="xt-input">
   <form id="form1" runat="server">
        <span style="margin-left:300px">食物名称</span>
        <asp:DropDownList ID="ddlSelectFood" class="int-text" runat="server"></asp:DropDownList>
        <input id="search" type="button" value="确 定" class="green-int" runat="server" onserverclick="search_ServerClick" />
        <input id="back" type="button" value="返 回" class="green-int" runat="server" onserverclick="back_ServerClick" />
   </form>
        <input id="save" type="button" value="保 存" class="yellow-int" style="margin-left:930px" onclick="submit();" />
        <a href="addFood.aspx"><input id="add" type="button" value="添 加" class="yellow-int" style="margin-left:30px" /></a>
    </div>
    <div class="xt-table">
       <table id="table" cellpadding="0" cellspacing="0" border="0" bgcolor="#dcdcdc" width="100%">
            <tr>
            <th>食物编号</th>
            <th>食物名称</th>
            <th>食物单价</th>
            <th>是否移除菜单</th>
            </tr>
            <% if (dt != null)
               {
                   foreach (DataRow dt_dr in dt.Rows)
                   { 
        %> 
        <tr> 
            <td> 
                <%=dt_dr["foodno"]%> 
            </td> 
            <td> 
                <%=dt_dr["foodname"]%> 
            </td> 
            <td> 
                <%=dt_dr["foodprice"]%> 
            </td> 
            <td> 
          <input id="<%=dt_dr["foodno"]%>" type="checkbox"/>   
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
</body>
</html>
