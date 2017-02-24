using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class Login : System.Web.UI.Page
    {
        BLL.UserBLL ur = new BLL.UserBLL();
        Model.User user = new Model.User();

        

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        //点击登录按钮
        protected void btn_LoginClick(object sender, EventArgs e)
        {
            string username = this.Username1.Value.ToString();
            string password=this.Password1.Value.ToString();
            user.Username = username;
            user.Pwd = password;
            bool flag = ur.Login(user);
            if (flag)
            {
                DataTable dt = new DataTable();
                dt = ur.LoginRecord(user);
                if (dt.Rows.Count > 0)
                {
                    Session["username"] = dt.Rows[0]["username"].ToString();
                    if (dt.Rows[0]["role"].ToString() == "管理员")
                    {
                        Response.Redirect("BackManagement.aspx");
                    }
                    else
                    {
                        Response.Redirect("Home.aspx");
                    }
                }
            }
            else
                Response.Write("<script>alert('用户和密码不匹配!');</script>");
        }

        //点击注册进行注册
        protected void btn_ZhuceClick(object sender, EventArgs e)
        {
            string email = this.Email.Value.ToString();
            if (Regex.IsMatch(email, "[A-Za-z0-9][@][A-Za-z0-9]+[.][A-Za-z0-9]")==true)
            {
                string username = this.Zhuce_Username.Value.ToString();
                string password = this.Zhuce_Password.Value.ToString();
                user.Email = email;
                user.Username = username;
                user.Pwd = password;
                bool flag = ur.AddUser(user);
                if (flag)
                    Response.Write("<script>alert('注册成功!');</script>");
                else
                    Response.Write("<script>alert('注册失败!');</script>");
            }
            else
            {
                Response.Write("<script>alert('您的电子邮箱格式不正确!');</script>");
            }
        }
    }
}