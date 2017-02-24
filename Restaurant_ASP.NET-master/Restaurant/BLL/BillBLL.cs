using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BillBLL
    {
        DAL.BillDAL bill = new DAL.BillDAL();

        public bool ProduceBill(Model.Bill b)
        {
            return bill.ProduceBill(b);
        }
        public bool SearchNo(Model.Bill b)
        {
            return bill.SearchNo(b);
        }
        public DataTable searchBillInformation()
        {
            return bill.searchBillInformation();
        }
        public DataTable DailyBill()
        {
            return bill.DailyBill();
        }
        public DataTable searchPointedBillInformation(Model.Bill b,string date)
        {
            return bill.searchPointedBillInformation(b,date);
        }
        public DataTable search_Date_BillInformation(string date)
        {
            return bill.search_Date_BillInformation(date);
        }
        public DataTable search_User_BillInformation(Model.Bill b)
        {
            return bill.search_User_BillInformation(b);
        }
    }
}
