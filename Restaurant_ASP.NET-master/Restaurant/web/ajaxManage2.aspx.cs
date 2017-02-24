using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace web
{
    public partial class ajaxManage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string json = Request.QueryString["json"].ToString();

            BLL.MenuBLL menu = new BLL.MenuBLL();
            Model.Menu m = new Model.Menu();

            if (json != null)
            {
                JArray ja = (JArray)JsonConvert.DeserializeObject(json);
                string[] datas = new string[ja.Count];
                for (int i = 0; i < ja.Count; i++)
                {
                    datas[i] = ja[i]["id"].ToString();
                    m.Foodno =int.Parse(datas[i]);
                    menu.DeleteFood(m);
                }
                Response.Write("共删除" + datas.Length + "条数据" + "|");
            }
            else
            {
                Response.Write("error");
            }
        }
    }
}