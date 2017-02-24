using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class Chart : System.Web.UI.Page
    {
        BLL.BillBLL bill = new BLL.BillBLL();
        Model.Bill b = new Model.Bill();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt=bill.DailyBill();
            this.Chart1.DataSource = dt;//绑定数据
            Chart1.Series[0].XValueMember = "date";//X轴数据成员列
            Chart1.Series[1].XValueMember = "date";
            Chart1.Series[0].YValueMembers = "profit";//Y轴数据成员列
            Chart1.Series[1].YValueMembers = "guestnum";
            Chart1.Series[0].IsValueShownAsLabel = true;//显示坐标值
            Chart1.Series[1].IsValueShownAsLabel = true;

            this.Chart1.Series[0].LegendText = "每日营业额";
            this.Chart1.Series[1].LegendText = "每日就餐人数";
           //this.Chart1.Legends.Add();
        }
    }
}