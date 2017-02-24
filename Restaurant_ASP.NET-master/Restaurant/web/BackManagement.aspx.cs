using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class BackManagement : System.Web.UI.Page
    {
        //protected DataTable dt = new DataTable(); 
        protected string is_url =null;

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        //单击“基础信息”
        protected void click_BaseInformation(object sender, EventArgs e)
        {
            is_url = "UserInformation1.aspx";
        }
        //单击”菜单信息“
        protected void click_MenuInformation(object sender, EventArgs e)
        {
            is_url = "MenuInformation.aspx";
        }
        //点击“用餐信息”
        protected void click_OrderInformation(object sender, EventArgs e)
        {
            is_url = "OrderInformation.aspx";
        }
        //点击“结单信息”
        protected void click_BillInformation(object sender, EventArgs e)
        {
            is_url = "BillInformation1.aspx";
        }
        protected void click_DailyBillInformation(object sender, EventArgs e)
        {
            is_url = "Chart.aspx";
        }
        //跳转至主页
        protected void home_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?username="+Session["username"].ToString());
        }
    }
}