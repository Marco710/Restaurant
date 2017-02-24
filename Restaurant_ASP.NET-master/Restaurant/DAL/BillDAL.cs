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
    public class BillDAL
    {
        DBOperation db = new DBOperation();//作为公共的实例化
        ProOperation pr = new ProOperation();

        //生成账单
        public bool ProduceBill(Model.Bill b)
        {
            DataTable dt = new DataTable();
            bool flag = false;
            IDataParameter[] parameter = {                                                             
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@ischecked",SqlDbType.VarChar,10)
                                     };
            parameter[0].Value = b.Username;
            parameter[1].Value = "NULL";
            dt = pr.GetDataTable("ProduceBill", parameter);
            if (dt.Rows.Count > 0)
            {
                IDataParameter[] parameter1 = {                                                             
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@ischecked",SqlDbType.VarChar,10)
                                     };
                parameter1[0].Value = b.Username;
                parameter1[1].Value = "NULL";
                int sumprice = pr.ExcuteProReturnInt("ProduceBill1", parameter1);             
                IDataParameter[] parameter2 = { 
                                                           new SqlParameter("@billno",SqlDbType.Int),
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@totalprice",SqlDbType.VarChar,10)
                                     };
                parameter2[0].Value = b.Billno;
                parameter2[1].Value = b.Username;
                parameter2[2].Value = sumprice;
                pr.ExcutePro("ProduceBill2", parameter2);               
                IDataParameter[] parameter3 = {                                                    
                                                           new SqlParameter("@username",SqlDbType.VarChar,10)                                                         
                                     };
                parameter3[0].Value = b.Username;
                pr.ExcutePro("ProduceBill3", parameter3);              
                flag = true;
                return flag;
            }
            else
            {
                return flag;
            }
            /*----------------------------------------------------------------------------------------------------------------------------------*/
            //DataTable dt = new DataTable();
            //bool flag = false;
            //string SQL = "select * from [order] where username='" + b.Username + "' and ischecked='NULL'";
            //dt = db.SQLGetDataTable(SQL);
            //if (dt.Rows.Count > 0)
            //{
            //    string SQL1 = "select sum(sumprice) from [order] where username='" + b.Username + "' and ischecked='NULL'";
            //    int sumprice = db.SQLExecuteReturnInt(SQL1);
            //    string SQL2 = "insert into[bill](billno,username,totalprice)values('"+b.Billno+"','" + b.Username + "','" + sumprice + "')";
            //    db.SQLExecute(SQL2);
            //    string SQL3 = "update [order]  set ischecked='checked' where username='" + b.Username + "'";
            //    db.SQLExecute(SQL3);
            //    flag = true;
            //    return flag;
            //}
            //else
            //{
            //    return flag;
            //}
        }

        //搜索账单号确保随机数不重复
        public bool SearchNo(Model.Bill b)
        {
            bool flag = false;
            DataTable dt = new DataTable();
            IDataParameter[] parameter = { 
                                                           new SqlParameter("@billno",SqlDbType.Int)                                                         
                                     };

            parameter[0].Value = b.Billno;
            dt = pr.GetDataTable("SearchNo", parameter);
            if (dt.Rows.Count > 0)
            {
                return flag;
            }
            else
            {
                flag = true;
                return flag;
            }
            /*-------------------------------------------------------------------------------*/
            //bool flag = false;
            //DataTable dt = new DataTable();
            //string SQL = "select * from [bill] where billno='" + b.Billno + "'";
            //dt = db.SQLGetDataTable(SQL);
            //if (dt.Rows.Count > 0)
            //{
            //    return flag;
            //}
            //else
            //{
            //    flag = true;
            //    return flag;
            //}
        }

        //搜索整个账单
        public DataTable searchBillInformation()
        {
            DataTable dt = new DataTable();
            IDataParameter[] parameter = { 
                                                           
                                     };

            dt = pr.GetDataTable("searchBillInformation", parameter);
            //string SQL = "select * from [bill]";
            //dt = db.SQLGetDataTable(SQL);
            return dt;
            /*-------------------------------------------*/
            //DataTable dt = new DataTable();
            //string SQL = "select * from [bill]";
            //dt = db.SQLGetDataTable(SQL);
            //return dt;
        }

        //统计每日营业额
        public DataTable DailyBill()
        {
            DataTable dt = new DataTable();
            IDataParameter[] parameter = { 
                                                           
                                     };

            dt = pr.GetDataTable("DailyBill", parameter);
            //string SQL = "select Convert(varchar(200),datetime,111) as date,sum(totalprice) as profit,count(username) as guestnum from [bill] Group by Convert(varchar(200),datetime,111)";
            //dt = db.SQLGetDataTable(SQL);
            return dt;
            /*----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            //DataTable dt = new DataTable();
            //string SQL = "select Convert(varchar(200),datetime,111) as date,sum(totalprice) as profit,count(username) as guestnum from [bill] Group by Convert(varchar(200),datetime,111)";
            //dt = db.SQLGetDataTable(SQL);
            //return dt;
        }

        //管理员查询相应的用户名和日期
        public DataTable searchPointedBillInformation(Model.Bill b, string date)
        {
            DataTable dt = new DataTable();
            IDataParameter[] parameter = {       
                                                          
                                                           new SqlParameter("@username",SqlDbType.VarChar,10),
                                                           new SqlParameter("@date",SqlDbType.VarChar,200)
                                     };

            parameter[0].Value = b.Username;
            parameter[1].Value = date;
            dt = pr.GetDataTable("searchPointedBillInformation", parameter);
            //string SQL = "select * from [bill] where username='" + b.Username + "' and Convert(varchar(200),datetime,111)='" + date + "'";
            //dt = db.SQLGetDataTable(SQL);
            return dt;
            /*-------------------------------------------------------------------------------------------------------------------------------------------*/
            //DataTable dt = new DataTable();
            //string SQL = "select * from [bill] where username='" + b.Username + "' and Convert(varchar(200),datetime,111)='" + date + "'";
            //dt = db.SQLGetDataTable(SQL);
            //return dt;
        }

        //管理员查询相应日期的记录
        public DataTable search_Date_BillInformation(string date)
        {
            DataTable dt = new DataTable();
            IDataParameter[] parameter = {       
                                                           new SqlParameter("@date",SqlDbType.VarChar,200)
                                     };

            parameter[0].Value = date;
            dt = pr.GetDataTable("search_Date_BillInformation", parameter);
            //string SQL = "select * from [bill] where Convert(varchar(200),datetime,111)='" + date + "'";
            //dt = db.SQLGetDataTable(SQL);
            return dt;
            /*------------------------------------------------------------------------------------------------------*/
            //DataTable dt = new DataTable();
            //string SQL = "select * from [bill] where Convert(varchar(200),datetime,111)='" + date + "'";
            //dt = db.SQLGetDataTable(SQL);
            //return dt;
        }

        //管理员查询相应用户名的记录
        public DataTable search_User_BillInformation(Model.Bill b)
        {
            DataTable dt = new DataTable();
            IDataParameter[] parameter = {                                                                
                                                           new SqlParameter("@username",SqlDbType.VarChar,10)
                                     };

            parameter[0].Value = b.Username;
            dt = pr.GetDataTable("search_User_BillInformation", parameter);
            //string SQL = "select * from [bill] where username='" + b.Username + "'";
            //dt = db.SQLGetDataTable(SQL);
            return dt;
            /*----------------------------------------------------------------------------------*/
            //DataTable dt = new DataTable();
            //string SQL = "select * from [bill] where username='" + b.Username + "'";
            //dt = db.SQLGetDataTable(SQL);
            //return dt;
        }
    }
}
