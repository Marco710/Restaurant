using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public  class UserBLL
    {
       DAL.UserDAL User = new DAL.UserDAL();
       public bool Login(Model.User u)
       {
           return User.Login(u);
       }
       public DataTable LoginRecord(Model.User u)
       {
           return User.LoginRecord(u);
       }
       public bool AddUser(Model.User u)
       {
           return User.AddUser(u);
       }
       public DataTable searchUser()
       {
           return User.searchUser();
       }
       public DataTable point_searchUser(Model.User u)
       {
           return User.point_searchUser(u);
       }
       public void DeleteUser(Model.User u)
       {
            User.DeleteUser(u);
       }
    }
}
