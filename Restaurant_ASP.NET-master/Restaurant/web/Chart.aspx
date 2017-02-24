<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chart.aspx.cs" Inherits="web.Chart" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:0px auto; width:807px">
    
        <asp:Chart ID="Chart1" runat="server" Height="617px" Width="806px">
            <series>
                <asp:Series Name="Series1" XValueType="Date" YValueType="Int32">
                </asp:Series>
                <asp:Series ChartArea="ChartArea1" Name="Series2">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisY Title="金额/人数" Interval="50">
                    </AxisY>
                    <AxisX Title="日期">
                    </AxisX>
                </asp:ChartArea>
            </chartareas>
            <Legends>
                <asp:Legend Name="Legend1">
                </asp:Legend>
            </Legends>
            <Titles>
                <asp:Title Font="微软雅黑, 15.75pt" Name="Title1" Text="每日营业情况图表">
                </asp:Title>
            </Titles>
        </asp:Chart>
    
    </div>
    </form>
</body>
</html>
