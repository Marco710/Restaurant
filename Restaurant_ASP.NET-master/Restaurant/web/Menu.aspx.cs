using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class Menu : System.Web.UI.Page
    {
        protected DataTable dt = new DataTable();
        private DataTable dt_menu = new DataTable();
        private int no = 0;

        protected int value = -600;
        protected string vsb = "visible";
        protected string text = "收起订餐表";

        BLL.MenuBLL menu = new BLL.MenuBLL();
        Model.Menu m = new Model.Menu();
        BLL.OrderBLL order = new BLL.OrderBLL();
        Model.Order o = new Model.Order();
        BLL.BillBLL bill = new BLL.BillBLL();
        Model.Bill b = new Model.Bill();

        protected void Page_Load(object sender, EventArgs e)
        {
            //this.UserName.Text = "欢迎您，" + Session["username"].ToString();
            //showFoodname();
            //o.Username = Session["username"].ToString();
            //dt = order.searchOrder(o);
            //value += (dt.Rows.Count) * 50;
        }

        //显示菜单名
        public void showFoodname()
        {
            dt_menu=menu.searchMenu(m);
            //食物1
            this.Label1.Text = dt_menu.Rows[0]["foodname"].ToString();
            this.img1.Src=dt_menu.Rows[0]["foodimage"].ToString();
            this.lbPrice1.Text = dt_menu.Rows[0]["foodprice"].ToString()+"￥";
            //食物2
            this.Label2.Text = dt_menu.Rows[1]["foodname"].ToString();
            this.img2.Src = dt_menu.Rows[1]["foodimage"].ToString();
            this.lbPrice2.Text = dt_menu.Rows[1]["foodprice"].ToString() + "￥"; 
            //食物3
            this.Label3.Text = dt_menu.Rows[2]["foodname"].ToString();
            this.img3.Src = dt_menu.Rows[2]["foodimage"].ToString();
            this.lbPrice3.Text = dt_menu.Rows[2]["foodprice"].ToString() + "￥";
            //食物4
            this.Label4.Text = dt_menu.Rows[3]["foodname"].ToString();
            this.img4.Src = dt_menu.Rows[3]["foodimage"].ToString();
            this.lbPrice4.Text = dt_menu.Rows[3]["foodprice"].ToString() + "￥";
            //食物5
            this.Label5.Text = dt_menu.Rows[4]["foodname"].ToString();
            this.img5.Src = dt_menu.Rows[4]["foodimage"].ToString();
            this.lbPrice5.Text = dt_menu.Rows[4]["foodprice"].ToString() + "￥";
            //食物6
            this.Label6.Text = dt_menu.Rows[5]["foodname"].ToString();
            this.img6.Src = dt_menu.Rows[5]["foodimage"].ToString();
            this.lbPrice6.Text = dt_menu.Rows[5]["foodprice"].ToString() + "￥";
            //食物7
            this.Label7.Text = dt_menu.Rows[6]["foodname"].ToString();
            this.img7.Src = dt_menu.Rows[6]["foodimage"].ToString();
            this.lbPrice7.Text = dt_menu.Rows[6]["foodprice"].ToString() + "￥";
            //食物8
            this.Label8.Text = dt_menu.Rows[7]["foodname"].ToString();
            this.img8.Src = dt_menu.Rows[7]["foodimage"].ToString();
            this.lbPrice8.Text = dt_menu.Rows[7]["foodprice"].ToString() + "￥";
            //食物9
            this.Label9.Text = dt_menu.Rows[8]["foodname"].ToString();
            this.img9.Src = dt_menu.Rows[8]["foodimage"].ToString();
            this.lbPrice9.Text = dt_menu.Rows[8]["foodprice"].ToString() + "￥";
        }

        //增加食物（总）
        public void add(int id)
        {
            DataTable dt = new DataTable();
            m.Foodno = id;
            dt = menu.AddInfo(m);
            o.Username = Session["username"].ToString();
            o.Foodname=dt.Rows[0]["foodname"].ToString();
            o.Foodprice = int.Parse(dt.Rows[0]["foodprice"].ToString());
            
            bool flag = order.AddFood(o);
            if (flag)
            {
                Response.Write("<script language='javascript'>alert('" + o.Foodname + " 已成功加入到您的菜单中！');</script>");
                Response.Write("<script language=javascript>javascript:location.href='Menu.aspx'</script>");
            }
        }
        //删除食物（总）
        public void delete(int id)
        {
            DataTable dt = new DataTable();
            m.Foodno = id;
            dt = menu.AddInfo(m);
            o.Username = Session["username"].ToString();
            o.Foodname = dt.Rows[0]["foodname"].ToString();
            bool flag = order.DeleteFood(o);
            if (flag)
            {
                Response.Write("<script language='javascript'>alert('" + o.Foodname + " 已成功从您的菜单中删除！');</script>");
                Response.Write("<script language=javascript>javascript:location.href='Menu.aspx'</script>");
            }
            else
            {
                Response.Write("<script language='javascript'>alert('抱歉您没有点" + o.Foodname + " 哦！');</script>");
            }
        }
        //增加食物1
        protected void Add_FoodClick1(object sender, EventArgs e)
        {
            m.Foodname = this.Label1.Text;
            dt_menu = menu.point_searchMenu(m);
            no=int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            add(no);
        }
        //删除食物1
        protected void Delete_FoodClick1(object sender, EventArgs e)
        {
            m.Foodname = this.Label1.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            delete(no);
        }
        //增加食物2
        protected void Add_FoodClick2(object sender, EventArgs e)
        {
            m.Foodname = this.Label2.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            add(no);
        }
        protected void Delete_FoodClick2(object sender, EventArgs e)
        {
            m.Foodname = this.Label2.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            delete(no);
        }
        //增加食物3
        protected void Add_FoodClick3(object sender, EventArgs e)
        {
            m.Foodname = this.Label3.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            add(no);
        }
        protected void Delete_FoodClick3(object sender, EventArgs e)
        {
            m.Foodname = this.Label3.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            delete(no);
        }
        //增加食物4
        protected void Add_FoodClick4(object sender, EventArgs e)
        {
            m.Foodname = this.Label4.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            add(no);
        }
        protected void Delete_FoodClick4(object sender, EventArgs e)
        {
            m.Foodname = this.Label4.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            delete(no);
        }
        //增加食物5
        protected void Add_FoodClick5(object sender, EventArgs e)
        {
            m.Foodname = this.Label5.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            add(no);
        }
        protected void Delete_FoodClick5(object sender, EventArgs e)
        {
            m.Foodname = this.Label5.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            delete(no);
        }
        //增加食物6
        protected void Add_FoodClick6(object sender, EventArgs e)
        {
            m.Foodname = this.Label6.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            add(no);
        }
        protected void Delete_FoodClick6(object sender, EventArgs e)
        {
            m.Foodname = this.Label6.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            delete(no);
        }
        //增加食物7
        protected void Add_FoodClick7(object sender, EventArgs e)
        {
            m.Foodname = this.Label7.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            add(no);
        }
        protected void Delete_FoodClick7(object sender, EventArgs e)
        {
            m.Foodname = this.Label7.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            delete(no);
        }
        //增加食物8
        protected void Add_FoodClick8(object sender, EventArgs e)
        {
            m.Foodname = this.Label8.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            add(no);
        }
        protected void Delete_FoodClick8(object sender, EventArgs e)
        {
            m.Foodname = this.Label8.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            delete(no);
        }
        //增加食物9
        protected void Add_FoodClick9(object sender, EventArgs e)
        {
            m.Foodname = this.Label9.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            add(no);
        }
        protected void Delete_FoodClick9(object sender, EventArgs e)
        {
            m.Foodname = this.Label9.Text;
            dt_menu = menu.point_searchMenu(m);
            no = int.Parse(dt_menu.Rows[0]["foodno"].ToString());
            delete(no);
        }
        //点击“提交订单”按钮
        protected void saveOrder_ServerClick(object sender, EventArgs e)
        {
            Random r = new Random();
            bool flag = false;
            do{
                int i = r.Next(1000000, 9999999);               
                b.Billno = i;
                flag = bill.SearchNo(b);//搜索到订单号则为false
            } while (flag == false);
                if (flag)
                {
                    b.Username = Session["username"].ToString();
                    bool flag2 = bill.ProduceBill(b);
                    if (flag2)
                    {
                        Response.Write("<script language='javascript'>alert('提交订单成功！');</script>");
                        Response.Write("<script language=javascript>javascript:location.href='Menu.aspx'</script>");

                    }
                    else
                    {
                        Response.Write("<script language='javascript'>alert('对不起您还没有点餐！');</script>");
                    }
                }
        }
        //点餐表是否可见
        protected void downOrder_ServerClick(object sender, EventArgs e)
        {
            vsb = "hidden";
        }

        protected void upOrder_ServerClick(object sender, EventArgs e)
        {
            vsb = "visible";
        }

    }
}