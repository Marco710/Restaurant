using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class UserInformation1 : System.Web.UI.Page
    {
        protected DataTable dt = new DataTable();

        BLL.UserBLL user = new BLL.UserBLL();
        Model.User u = new Model.User();

        protected void Page_Load(object sender, EventArgs e)
        {
            dt = user.searchUser();
        }
        protected void save_ServerClick(object sender, EventArgs e)
        {

        }

        protected void search_ServerClick(object sender, EventArgs e)
        {
            string username = this.TextBox1.Text.ToString();
            u.Username = username;
            dt = user.point_searchUser(u);
        }

        protected void back_ServerClick(object sender, EventArgs e)
        {
            dt = user.searchUser();
        }
    }
}