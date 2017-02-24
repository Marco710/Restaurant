using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderBLL
    {
        DAL.OrderDAL order = new DAL.OrderDAL();

        public bool AddFood(Model.Order o)
        {
            return order.AddFood(o);
        }

        public bool DeleteFood(Model.Order o)
        {
            return order.DeleteFood(o);
        }

        public DataTable searchOrder(Model.Order o)
        {
            return order.searchOrder(o);
        }
        public DataTable searchPointedOrderInformation(Model.Order o,string date)
        {
            return order.searchPointedOrderInformation(o,date);
        }
        public DataTable searchOrderInformation(Model.Order o)
        {
            return order.searchOrderInformation(o);
        }
        public DataTable search_Date_OrderInformation(string date)
        {
            return order.search_Date_OrderInformation(date);
        }
        public DataTable search_User_OrderInformation(Model.Order o)
        {
            return order.search_User_OrderInformation(o);
        }
    }
}
