using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"].ToString() == null)
            {
                string username = Request.QueryString["username"].ToString();
                this.UserName.Text = "欢迎您，管理员" + username;
            }
            else
                this.UserName.Text = "欢迎您，" + Session["username"].ToString();
        }
    }
}