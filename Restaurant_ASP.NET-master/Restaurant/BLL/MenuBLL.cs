using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MenuBLL
    {
        DAL.MenuDAL menu = new DAL.MenuDAL();

        public DataTable searchMenu(Model.Menu m)
        {
            return menu.searchMenu(m);
        }
        public DataTable point_searchMenu(Model.Menu m)
        {
            return menu.point_searchMenu(m);
        }
        public DataTable AddInfo(Model.Menu m)
        {
            return menu.AddInfo(m);
        }
        public void DeleteFood(Model.Menu m)
        {
            menu.DeleteFood(m);
        }
        public bool addFood(Model.Menu m)
        {
            return menu.addFood(m);
        }
    }
}
