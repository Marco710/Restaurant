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
    public partial class OrderInformation : System.Web.UI.Page
    {
        protected DataTable dt = new DataTable();

        BLL.OrderBLL order = new BLL.OrderBLL();
        Model.Order o = new Model.Order();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dt = order.searchOrderInformation(o);
            } 
        }

        protected void search_ServerClick(object sender, EventArgs e)
        {           
            if (this.txtUserName.Text != "" && this.txtDateTime.Text != "")
            {
                string d = this.txtDateTime.Text;
                string date = Convert.ToDateTime(d).ToString("yyyy/MM/dd");
                o.Username = this.txtUserName.Text;
                dt = order.searchPointedOrderInformation(o, date);
            }
            else if (this.txtUserName.Text == "" && this.txtDateTime.Text != "")
            {
                string d = this.txtDateTime.Text;
                string date = Convert.ToDateTime(d).ToString("yyyy/MM/dd");
                dt = order.search_Date_OrderInformation(date);
            }
            else if (this.txtUserName.Text != "" && this.txtDateTime.Text == "")
            {
                o.Username = this.txtUserName.Text;
                dt = order.search_User_OrderInformation(o);
            }
            else
            {
                Response.Write("<script>alert('您未输入搜索条件!');</script>");
            }
        }

        protected void back_ServerClick(object sender, EventArgs e)
        {
            dt = order.searchOrderInformation(o);
        }
    }
}