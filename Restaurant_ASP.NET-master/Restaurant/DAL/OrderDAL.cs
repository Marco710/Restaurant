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
    public class OrderDAL
    {
        DBOperation db = new DBOperation();//作为公共的实例化
        ProOperation pr = new ProOperation();

        //添加到订单
        public bool AddFood(Model.Order o)
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            bool flag = false;
            IDataParameter[] parameter = { 
                                                            
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@foodname",SqlDbType.VarChar,50),
                                                           new SqlParameter("@ischecked",SqlDbType.VarChar,10)
                                     };

            parameter[0].Value = o.Username;
            parameter[1].Value = o.Foodname;
            parameter[2].Value = "NULL";
            dt1 = pr.GetDataTable("AddFood_order", parameter);
            if (dt1.Rows.Count > 0)
            {
                IDataParameter[] parameter1 = { 
                                                            
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@foodname",SqlDbType.VarChar,50),
                                                           new SqlParameter("@ischecked",SqlDbType.VarChar,10)
                                     };

                parameter1[0].Value = o.Username;
                parameter1[1].Value = o.Foodname;
                parameter1[2].Value = "NULL";
                pr.ExcutePro("AddFood_order1", parameter1);
                IDataParameter[] parameter2 = {                                                             
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@foodname",SqlDbType.VarChar,50)                                                 
                                     };

                parameter2[0].Value = o.Username;
                parameter2[1].Value = o.Foodname;
                dt2=pr.GetDataTable("AddFood_order2", parameter2);
                int price = int.Parse(dt2.Rows[0]["foodprice"].ToString());
                IDataParameter[] parameter3 = { 
                                                           new SqlParameter("@price",SqlDbType.Int),
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@foodname",SqlDbType.VarChar,50),
                                                           new SqlParameter("@ischecked",SqlDbType.VarChar,10)
                                     };
                parameter3[0].Value = price;
                parameter3[1].Value = o.Username;
                parameter3[2].Value = o.Foodname;
                parameter3[3].Value = "NULL";
                pr.ExcutePro("AddFood_order3", parameter3);
                flag = true;
                return flag;
            }
            else
            {
                IDataParameter[] parameter4 = { 
                                                          
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@foodname",SqlDbType.VarChar,50),
                                                           new SqlParameter("@foodprice",SqlDbType.Int),
                                                           new SqlParameter("@foodnum",SqlDbType.Int),
                                                           new SqlParameter("@foodprice_sum",SqlDbType.Int),
                                                           new SqlParameter("@ischecked",SqlDbType.VarChar,10)
                                     };
                parameter4[0].Value = o.Username;
                parameter4[1].Value = o.Foodname;
                parameter4[2].Value = o.Foodprice;
                parameter4[3].Value = 1;
                parameter4[4].Value = o.Foodprice;
                parameter4[5].Value = "NULL";
                pr.ExcutePro("AddFood_order4", parameter4);
                flag = true;
                return flag;
                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            //DataTable dt1 = new DataTable();
            //DataTable dt2 = new DataTable();
            //bool flag = false;
            //string SQL1 = "select * from [order] where username='" + o.Username + "' and foodname='" + o.Foodname + "' and ischecked='NULL'";
            //dt1 = db.SQLGetDataTable(SQL1);
            //if (dt1.Rows.Count > 0)
            //{
            //    string SQL3 = "update [order] set foodnum+=1 where username='" + o.Username + "' and foodname='" + o.Foodname + "' and ischecked='NULL'";
            //    db.SQLExecute(SQL3);
            //    string SQL2 = "select * from [order] where username='" + o.Username + "' and foodname='" + o.Foodname + "'";
            //    dt2 = db.SQLGetDataTable(SQL2);
            //    int price = int.Parse(dt2.Rows[0]["foodprice"].ToString());
            //    string SQL4 = "update [order]  set sumprice+='" + price + "' where username='" + o.Username + "' and foodname='" + o.Foodname + "' and ischecked='NULL'";
            //    db.SQLExecute(SQL4);
            //    flag = true;
            //    return flag;
            //}
            //else
            //{
            //    string SQL5 = "insert into[order](username,foodname,foodprice,foodnum,sumprice,ischecked)"
            //        + "values('" + o.Username + "','" + o.Foodname + "','" + o.Foodprice + "','" + 1 + "','" + o.Foodprice + "','NULL')";
            //    db.SQLExecute(SQL5);
            //    flag = true;
            //    return flag;
            }
        }

        //从订单中删除
        public bool DeleteFood(Model.Order o)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            bool flag = false;
            IDataParameter[] parameter = {                                                             
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@foodname",SqlDbType.VarChar,50),
                                                           new SqlParameter("@ischecked",SqlDbType.VarChar,10)
                                     };

            parameter[0].Value = o.Username;
            parameter[1].Value = o.Foodname;
            parameter[2].Value = "NULL";
            dt = pr.GetDataTable("DeleteFood_order", parameter);
            //string SQL1 = "select * from [order] where username='" + o.Username + "' and foodname='" + o.Foodname + "' and ischecked='NULL'";
            //dt = db.SQLGetDataTable(SQL1);
            if (dt.Rows.Count > 0)
            {
                if (int.Parse(dt.Rows[0]["foodnum"].ToString()) == 0)
                {
                    IDataParameter[] parameter1 = {                                                             
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@foodname",SqlDbType.VarChar,50),
                                                           new SqlParameter("@ischecked",SqlDbType.VarChar,10)
                                     };

                    parameter1[0].Value = o.Username;
                    parameter1[1].Value = o.Foodname;
                    parameter1[2].Value = "NULL";
                    pr.ExcutePro("DeleteFood_order1", parameter1);
                    //string SQL3 = "delete from [order] where foodname='" + o.Foodname + "' and username='" + o.Username + "' and ischecked='NULL'";
                    //db.SQLExecute(SQL3);
                    flag = false;
                }
                else
                {
                    IDataParameter[] parameter2 = {                                                             
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@foodname",SqlDbType.VarChar,50),
                                                           new SqlParameter("@ischecked",SqlDbType.VarChar,10)
                                     };

                    parameter2[0].Value = o.Username;
                    parameter2[1].Value = o.Foodname;
                    parameter2[2].Value = "NULL";
                    pr.ExcutePro("DeleteFood_order2", parameter2);
                    //string SQL2 = "update [order] set foodnum-=1 where username='" + o.Username + "' and foodname='" + o.Foodname + "' and ischecked='NULL'";
                    //db.SQLExecute(SQL2);

                    IDataParameter[] parameter3 = {                                                             
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@foodname",SqlDbType.VarChar,50),
                                                           new SqlParameter("@ischecked",SqlDbType.VarChar,10)
                                     };

                    parameter3[0].Value = o.Username;
                    parameter3[1].Value = o.Foodname;
                    parameter3[2].Value = "NULL";
                    dt = pr.GetDataTable("DeleteFood_order3", parameter3);
                    //string SQL5 = "select * from [order] where username='" + o.Username + "' and foodname='" + o.Foodname + "' and ischecked='NULL'";
                    //dt2 = db.SQLGetDataTable(SQL5);
                    int price = int.Parse(dt.Rows[0]["foodprice"].ToString());

                    IDataParameter[] parameter4 = {       
                                                           new SqlParameter("@price",SqlDbType.Int),
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@foodname",SqlDbType.VarChar,50),
                                                           new SqlParameter("@ischecked",SqlDbType.VarChar,10)
                                     };
                    parameter4[0].Value = price;
                    parameter4[1].Value = o.Username;
                    parameter4[2].Value = o.Foodname;
                    parameter4[3].Value = "NULL";
                    pr.ExcutePro("DeleteFood_order4", parameter4);
                    //string SQL4 = "update [order]  set sumprice-='" + price + "' where username='" + o.Username + "' and foodname='" + o.Foodname + "' and ischecked='NULL'";
                    //db.SQLExecute(SQL4);

                    IDataParameter[] parameter5 = {       
                                                          
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@foodname",SqlDbType.VarChar,50),
                                                           new SqlParameter("@ischecked",SqlDbType.VarChar,10)
                                     };

                    parameter5[0].Value = o.Username;
                    parameter5[1].Value = o.Foodname;
                    parameter5[2].Value = "NULL";
                    dt2 = pr.GetDataTable("DeleteFood_order5", parameter5);
                    //string SQL = "select * from [order] where username='" + o.Username + "' and foodname='" + o.Foodname + "' and ischecked='NULL'";
                    //dt2 = db.SQLGetDataTable(SQL);
                    if (dt2.Rows.Count > 0 && int.Parse(dt2.Rows[0]["foodnum"].ToString()) == 0)
                    {
                        IDataParameter[] parameter6 = {       
                                                          
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@foodname",SqlDbType.VarChar,50),
                                                           new SqlParameter("@ischecked",SqlDbType.VarChar,10)
                                     };

                        parameter6[0].Value = o.Username;
                        parameter6[1].Value = o.Foodname;
                        parameter6[2].Value = "NULL";
                        dt2 = pr.GetDataTable("DeleteFood_order6", parameter6);
                        //string SQL3 = "delete from [order] where foodname='" + o.Foodname + "' and username='" + o.Username + "' and ischecked='NULL'";
                        //db.SQLExecute(SQL3);
                        flag = true;
                    }
                    flag = true;
                }
                return flag;
            }
            else
            {
                return flag;
            }
            /*------------------------------------------------------------------------------------------------------------------------------------------------------*/
            //DataTable dt = new DataTable();
            //DataTable dt2 = new DataTable();
            //bool flag = false;
            //string SQL1 = "select * from [order] where username='" + o.Username + "' and foodname='" + o.Foodname + "' and ischecked='NULL'";
            //dt = db.SQLGetDataTable(SQL1);
            //if (dt.Rows.Count > 0)
            //{
            //    if (int.Parse(dt.Rows[0]["foodnum"].ToString()) == 0)
            //    {
            //        string SQL3 = "delete from [order] where foodname='" + o.Foodname + "' and username='" + o.Username + "' and ischecked='NULL'";
            //        db.SQLExecute(SQL3);
            //        flag = false;
            //    }
            //    else
            //    {
            //        string SQL2 = "update [order] set foodnum-=1 where username='" + o.Username + "' and foodname='" + o.Foodname + "' and ischecked='NULL'";
            //        db.SQLExecute(SQL2);

            //        string SQL5 = "select * from [order] where username='" + o.Username + "' and foodname='" + o.Foodname + "' and ischecked='NULL'";
            //        dt2 = db.SQLGetDataTable(SQL5);
            //        int price = int.Parse(dt2.Rows[0]["foodprice"].ToString());
            //        string SQL4 = "update [order]  set sumprice-='" + price + "' where username='" + o.Username + "' and foodname='" + o.Foodname + "' and ischecked='NULL'";
            //        db.SQLExecute(SQL4);

            //        string SQL = "select * from [order] where username='" + o.Username + "' and foodname='" + o.Foodname + "' and ischecked='NULL'";
            //        dt2 = db.SQLGetDataTable(SQL);
            //        if (dt2.Rows.Count > 0 && int.Parse(dt2.Rows[0]["foodnum"].ToString()) == 0)
            //        {
            //            string SQL3 = "delete from [order] where foodname='" + o.Foodname + "' and username='" + o.Username + "' and ischecked='NULL'";
            //            db.SQLExecute(SQL3);
            //            flag = true;
            //        }
            //        flag = true;
            //    }
            //    return flag;
            //}
            //else
            //{
            //    return flag;
            //}
        }

        //搜索用户的订餐
        public DataTable searchOrder(Model.Order o)
        {
            DataTable dt = new DataTable();
            IDataParameter[] parameter = {       
                                                          
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@ischecked",SqlDbType.VarChar,10)
                                     };

            parameter[0].Value = o.Username;
            parameter[1].Value = "NULL";
            dt = pr.GetDataTable("searchOrder", parameter);
            //string SQL = "select * from [order] where username='" + o.Username + "' and IsChecked='NULL'";
            //dt=db.SQLGetDataTable(SQL);
            return dt;
            /*---------------------------------------------------------------------------------------------------------*/
            //DataTable dt =new DataTable();
            //string SQL = "select * from [order] where username='" + o.Username + "' and IsChecked='NULL'";
            //dt=db.SQLGetDataTable(SQL);
            //return dt;
        }

        //查询整个订餐表
        public DataTable searchOrderInformation(Model.Order o)
        {
            DataTable dt = new DataTable();
            IDataParameter[] parameter = {       
                                                                                                             
                                     };
            dt = pr.GetDataTable("searchOrderInformation", parameter);
            //string SQL = "select * from [order]";
            //dt = db.SQLGetDataTable(SQL);
            return dt;
            /*-------------------------------------------------------------------------------*/
            //DataTable dt = new DataTable();
            //string SQL = "select * from [order]";
            //dt = db.SQLGetDataTable(SQL);
            //return dt;
        }
       
        //管理员查询相应的用户名和日期
        public DataTable searchPointedOrderInformation(Model.Order o,string date)
        {
            DataTable dt = new DataTable();
            IDataParameter[] parameter = {       
                                                          
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@date",SqlDbType.VarChar,200)
                                     };

            parameter[0].Value = o.Username;
            parameter[1].Value = date;
            dt = pr.GetDataTable("searchPointedOrderInformation", parameter);
            //string SQL = "select * from [order] where username='" + o.Username + "' and Convert(varchar(200),datetime,111)='" + date + "'";
            //dt = db.SQLGetDataTable(SQL);
            return dt;
            /*-------------------------------------------------------------------------------------------------------------------------------------------------*/
            //DataTable dt = new DataTable();
            //string SQL = "select * from [order] where username='" + o.Username + "' and Convert(varchar(200),datetime,111)='" + date + "'";
            //dt = db.SQLGetDataTable(SQL);
            //return dt;
        }

        //管理员查询相应日期的记录
        public DataTable search_Date_OrderInformation(string date)
        {
            DataTable dt = new DataTable();
            IDataParameter[] parameter = {       
                                                           new SqlParameter("@date",SqlDbType.VarChar,200)
                                     };

            parameter[0].Value = date;
            dt = pr.GetDataTable("search_Date_OrderInformation", parameter);
            //string SQL = "select * from [order] where Convert(varchar(200),datetime,111)='" + date + "'";
            //dt = db.SQLGetDataTable(SQL);
            return dt;
            /*---------------------------------------------------------------------------------------------------------*/
            //DataTable dt = new DataTable();
            //string SQL = "select * from [order] where Convert(varchar(200),datetime,111)='" + date + "'";
            //dt = db.SQLGetDataTable(SQL);
            //return dt;
        }

        //管理员查询相应用户名的记录
        public DataTable search_User_OrderInformation(Model.Order o)
        {
            DataTable dt = new DataTable();
            IDataParameter[] parameter = {       
                                                           new SqlParameter("@username",SqlDbType.VarChar,10)
                                     };

            parameter[0].Value = o.Username;
            dt = pr.GetDataTable("search_User_OrderInformation", parameter);
            //string SQL = "select * from [order] where username='" + o.Username + "'";
            //dt = db.SQLGetDataTable(SQL);
            return dt;
            /*--------------------------------------------------------------------------------------------------*/
            //DataTable dt = new DataTable();
            //string SQL = "select * from [order] where username='" + o.Username + "'";
            //dt = db.SQLGetDataTable(SQL);
            //return dt;
        }
    }
}
