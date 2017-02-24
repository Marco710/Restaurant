using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.App_Code;

namespace DAL
{
    public class MenuDAL
    {
        DBOperation db = new DBOperation();//作为公共的实例化
        ProOperation pr = new ProOperation();

        //搜索menu表显示在网页上
        public DataTable searchMenu(Model.Menu m)
        {
            DataTable dt = new DataTable();
            IDataParameter[] parameter = { 
                                                                                                          
                                     };

            dt = pr.GetDataTable("searchMenu", parameter);
            //string SQL = "select * from [menu]";
            //dt = db.SQLGetDataTable(SQL);
            return dt;
            /*---------------------------------------------------------------------------------------------------------*/
            //DataTable dt = new DataTable();
            //string SQL = "select * from [menu]";
            //dt = db.SQLGetDataTable(SQL);
            //return dt;
        }

        //根据搜索条件显示表格
        public DataTable point_searchMenu(Model.Menu m)
        {
            DataTable dt = new DataTable();
            IDataParameter[] parameter = {                                                       
                                                            new SqlParameter("@foodname",SqlDbType.VarChar,50)                                                                                                                 
                                     };

            parameter[0].Value = m.Foodname;
            dt = pr.GetDataTable("point_searchMenu", parameter);
            return dt;
            /*---------------------------------------------------------------------------------------------------------*/
            //DataTable dt = new DataTable();
            //string SQL = "select foodno,foodname,foodprice from [menu] where foodname='"+m.Foodname+"'";
            //dt = db.SQLGetDataTable(SQL);
            //return dt;
        }

        //将Add菜的信息录入到datatable，为生成订单表里的记录做准备
        public DataTable AddInfo(Model.Menu m)
        {
            DataTable dt = new DataTable();
            IDataParameter[] parameter = { 
                                                            
                                                           new SqlParameter("@foodno",SqlDbType.Int)
                                     };


            parameter[0].Value = m.Foodno;
            dt = pr.GetDataTable("AddInfo", parameter);
            //String SQL = "select foodname,foodprice from [menu] where foodno='" + m.Foodno + "'";
            //dt = db.SQLGetDataTable(SQL);
            return dt;
            /*---------------------------------------------------------------------------------------------------------*/
            //DataTable dt = new DataTable();
            //String SQL = "select foodname,foodprice from [menu] where foodno='" + m.Foodno + "'";
            //dt = db.SQLGetDataTable(SQL);
            //return dt;
        }
     
        //管理员删除菜
        public void DeleteFood(Model.Menu m)
        {
            IDataParameter[] parameter = {                                                            
                                                           new SqlParameter("@foodno",SqlDbType.Int)
                                     };

            parameter[0].Value = m.Foodno;
            pr.ExcutePro("DeleteFood", parameter);
            /*---------------------------------------------------------------------------------------------------------*/
            //string SQL = "delete from [menu] where foodno='" + m.Foodno + "'";
            //db.SQLExecute(SQL);
        }

        //管理员添加新菜
        public bool addFood(Model.Menu m)
        {
            bool flag = false;
            IDataParameter[] parameter = {                                                            
                                                           new SqlParameter("@foodno",SqlDbType.Int),
                                                           new SqlParameter("@foodname",SqlDbType.VarChar,50),
                                                           new SqlParameter("@foodprice",SqlDbType.Int),
                                                           new SqlParameter("@foodimage",SqlDbType.VarChar,50)
                                     };

            parameter[0].Value = m.Foodno;
            parameter[1].Value = m.Foodname;
            parameter[2].Value = m.Foodprice;
            parameter[3].Value = m.FoodImage;
            pr.ExcutePro("addFood", parameter);
            //string SQL = "insert into [menu](foodno,foodname,foodprice,foodimage)values('"+m.Foodno+"','"+m.Foodname+"','"+m.Foodprice+"','"+m.FoodImage+"')";
            //db.SQLExecute(SQL);
            flag = true;
            return flag;

            //bool flag = false;
            //string SQL = "insert into [menu](foodno,foodname,foodprice,foodimage)values('"+m.Foodno+"','"+m.Foodname+"','"+m.Foodprice+"','"+m.FoodImage+"')";
            //db.SQLExecute(SQL);
            //flag = true;
            //return flag;
        }
    }
}
