using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class BillInformation1 : System.Web.UI.Page
    {
        protected DataTable dt = new DataTable();

        BLL.BillBLL bill = new BLL.BillBLL();
        Model.Bill b = new Model.Bill();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dt = bill.searchBillInformation();
            }
        }

        protected void search_ServerClick(object sender, EventArgs e)
        {
            if (this.txtUserName.Text != "" && this.txtDateTime.Text != "")
            {
                string d = this.txtDateTime.Text;
                string date = Convert.ToDateTime(d).ToString("yyyy/MM/dd");
                b.Username = this.txtUserName.Text;
                dt = bill.searchPointedBillInformation(b, date);
            }
            else if (this.txtUserName.Text == "" && this.txtDateTime.Text != "")
            {
                string d = this.txtDateTime.Text;
                string date = Convert.ToDateTime(d).ToString("yyyy/MM/dd");
                dt = bill.search_Date_BillInformation(date);
            }
            else if (this.txtUserName.Text != "" && this.txtDateTime.Text == "")
            {
                b.Username = this.txtUserName.Text;
                dt = bill.search_User_BillInformation(b);
            }
            else
            {
                Response.Write("<script>alert('您未输入搜索条件!');</script>");
            }
        }

        protected void back_ServerClick(object sender, EventArgs e)
        {
            dt = bill.searchBillInformation();
        }
    }
}