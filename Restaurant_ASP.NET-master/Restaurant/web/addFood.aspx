<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addFood.aspx.cs" Inherits="web.addFood" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1
        {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin:0px auto; width:807px">
    
        <table style="width:100%;">
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="微软雅黑" Font-Size="Medium" Text="食物添加"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="foodno" runat="server" Text="食物编号："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFoodno" runat="server"></asp:TextBox>
                    &nbsp;<asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="微软雅黑" Font-Size="Small" ForeColor="Red" Text="*该食物编号已存在!" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label3" runat="server" Text="食物名称："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFoodname" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align:right">
                    <asp:Label ID="Label4" runat="server" Text="食物单价："></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtFoodprice" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align:right">
                    <asp:Label ID="Label7" runat="server" Text="食物图片："></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">&nbsp;</td>
                <td style="text-align:right">
                    <asp:Button ID="btnOK" runat="server" Font-Names="微软雅黑" OnClick="btnOK_Click" Text="确认添加" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
