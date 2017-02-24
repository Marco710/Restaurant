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
    public partial class MenuInformation : System.Web.UI.Page
    {
        protected DataTable dt = new DataTable();

        BLL.MenuBLL menu = new BLL.MenuBLL();
        Model.Menu m = new Model.Menu();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //显示表格
                dt=menu.searchMenu(m);

                //给ddlSelectFood下拉框动态赋值
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    this.ddlSelectFood.Items.Add(dt.Rows[i]["foodname"].ToString());
                }
            } 
        }
        //点击“保存”可以保存修改
        protected void save_ServerClick(object sender, EventArgs e)
        {

        }
        //点击“确定”进行相应的搜索
        protected void search_ServerClick(object sender, EventArgs e)
        {
            string point_foodname = this.ddlSelectFood.SelectedValue.ToString();
            m.Foodname = point_foodname;
            dt = menu.point_searchMenu(m);
        }

        protected void back_ServerClick(object sender, EventArgs e)
        {
            dt = menu.searchMenu(m);
        }
    }
}