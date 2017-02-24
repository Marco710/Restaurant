using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL.App_Code;

namespace DAL
{
  public class UserDAL
    {
        DBOperation db = new DBOperation();//作为公共的实例化
        ProOperation pr = new ProOperation();

      //登录
      public bool Login(Model.User ur)
      {  
          bool flag=false;
          DataTable dt = new DataTable();
          IDataParameter[] parameter = { 
                                                            new SqlParameter("@username",SqlDbType.VarChar,10),
                                                            new SqlParameter("@pwd",SqlDbType.VarChar,20)
                                     };
          parameter[0].Value = ur.Username;
          parameter[1].Value = ur.Pwd;
          dt = pr.GetDataTable("login",parameter);
          if (dt.Rows.Count > 0)
              flag = true;
          return flag;
      }

      //登录时数据的返回
      public DataTable LoginRecord(Model.User ur)
      {
          DataTable dt = new DataTable();
          IDataParameter[] parameter = { 
                                                            new SqlParameter("@username",SqlDbType.VarChar,10),
                                                            new SqlParameter("@pwd",SqlDbType.VarChar,20)
                                     };
          parameter[0].Value = ur.Username;
          parameter[1].Value = ur.Pwd;
          dt = pr.GetDataTable("Login", parameter);
          return dt;
      }

      //用户注册
      public bool AddUser(Model.User ur)
      {
          bool flag = false;
          DataTable dt = new DataTable();
          IDataParameter[] parameter = { 
                                                            new SqlParameter("@username",SqlDbType.VarChar,10)
                                                            
                                     };
          parameter[0].Value = ur.Username;

          dt = pr.GetDataTable("AddUser", parameter);
          if (dt.Rows.Count > 0)
          {
              return flag;
          }
          else
          {
              IDataParameter[] parameter1 = { 
                                                            new SqlParameter("@email",SqlDbType.VarChar,50),
                                                            new SqlParameter("@username",SqlDbType.VarChar,10),
                                                            new SqlParameter("@pwd",SqlDbType.VarChar,20),
                                                            new SqlParameter("@role",SqlDbType.VarChar,6)
                                     };
              parameter1[0].Value = ur.Email;
              parameter1[1].Value = ur.Username;
              parameter1[2].Value = ur.Pwd;
              parameter1[3].Value = "用户";
              pr.ExcutePro("AddUser1", parameter1);
              flag = true;
              return flag;
          }
          //string SQL1 = "select * from [user] where username='" + ur.Username + "'";
          //dt = db.SQLGetDataTable(SQL1);
          //if (dt.Rows.Count > 0)
          //{
          //    return flag;
          //}
          //else
          //{
          //    string ConnString = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
          //    SqlConnection conn = new SqlConnection(ConnString);
          //    string SQL2 = "insert into [user](email,username,pwd,role)"
          //           + "values('" + ur.Email + "','" + ur.Username + "','" + ur.Pwd + "','用户')";
          //    SqlCommand cmd2 = new SqlCommand(SQL2, conn);
          //    conn.Open();
          //    cmd2.ExecuteNonQuery();
          //    conn.Close();
          //    flag = true;
          //    return flag;
          //}
      }

      //显示整张用户数据表
      public  DataTable searchUser()
      {
          DataTable dt = new DataTable();
          IDataParameter[] parameter = { 
                                                                                                          
                                     };
          dt = pr.GetDataTable("searchUser", parameter);
          return dt;
          //string SQL = "select * from [user]";
          //dt = db.SQLGetDataTable(SQL);
          //return dt;
      }

      //搜索某个指定的用户
      public DataTable point_searchUser(Model.User u)
      {
          DataTable dt = new DataTable();
          IDataParameter[] parameter = { 
                                                            new SqlParameter("@username",SqlDbType.VarChar,10)
                                                            
                                     };
          parameter[0].Value = u.Username;

          dt = pr.GetDataTable("point_searchUser", parameter);
          return dt;
          //string SQL = "select * from [user] where username='"+u.Username+"'";
          //dt = db.SQLGetDataTable(SQL);
          //return dt;
      }

      //管理员删除用户表里的数据
      public void DeleteUser(Model.User u)
      {
          IDataParameter[] parameter = { 
                                                            new SqlParameter("@ID",SqlDbType.VarChar,10)                                                          
                                     };
          parameter[0].Value = u.Id;
          pr.ExcutePro("DeleteUser", parameter);
          //string SQL = "delete from [user] where id='" + u.Id + "'";
          //db.SQLExecute(SQL);
      }
    }
}
