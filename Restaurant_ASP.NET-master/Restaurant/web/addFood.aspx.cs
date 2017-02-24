using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class addFood : System.Web.UI.Page
    {
        private DataTable dt_search_menu = new DataTable();
        private DataTable dt_search_no = new DataTable();

        BLL.MenuBLL menu = new BLL.MenuBLL();
        Model.Menu m = new Model.Menu();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
   
        protected void btnOK_Click(object sender, EventArgs e)
        {
            bool flag = false;
            dt_search_menu = menu.searchMenu(m);
            if (this.txtFoodname == null || this.txtFoodno == null || this.txtFoodprice == null)//信息不能为空
            {
                Response.Write("<script language='javascript'>alert('请把菜的信息填写完整！');</script>");
            }
            else
            {
                if (dt_search_menu.Rows.Count > 8)//即只能在菜单上显示9道菜
                {
                    Response.Write("<script language='javascript'>alert('您的菜单数量已达上限，不可添加新菜！');</script>");
                }
                else
                {
                    int foodno = int.Parse(this.txtFoodno.Text);
                    m.Foodno = foodno;
                    dt_search_no = menu.AddInfo(m);
                    if (dt_search_no.Rows.Count > 0)//编号不可以重复
                    {
                        this.Label6.Visible = true;
                    }
                    else
                    {
                        string fooname = this.txtFoodname.Text;
                        int foodprice = int.Parse(this.txtFoodprice.Text);
                        m.Foodname = fooname;
                        m.Foodprice = foodprice;
                        if (FileUpload1.HasFile)//是否上传文件
                        {
                            string savePath = Server.MapPath("~/images/");//指定上传文件在服务器上的保存路径
                            //检查服务器上是否存在这个物理路径，如果不存在则创建
                            if (!System.IO.Directory.Exists(savePath))
                            {
                                System.IO.Directory.CreateDirectory(savePath);
                            }
                            savePath = savePath + "\\" + FileUpload1.FileName;
                            FileUpload1.SaveAs(savePath);
                            m.FoodImage = "images" + "\\" + FileUpload1.FileName;
                            flag = menu.addFood(m);
                            if (flag)
                            {
                                Response.Write("<script language='javascript'>alert('" + m.Foodname + " 已加入到菜单中！');</script>");
                                Response.Write("<script language=javascript>javascript:location.href='MenuInformation.aspx'</script>");
                            }
                            else
                                Response.Write("<script language='javascript'>alert('添加失败！');</script>");
                        }
                        else
                        {
                            Response.Write("<script language='javascript'>alert('您还没有上传文件！');</script>");
                        }
                    }
                }
            }
        }
    }
}