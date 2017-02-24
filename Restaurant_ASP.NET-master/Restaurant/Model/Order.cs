using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public Order() { }
        private int _Id;
        private string _Username;
        private string _Foodname;
        private int _Foodprice;
        private int _Foodnum;
        private DateTime _Datetime;

        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public string Username
        {
            set { _Username = value; }
            get { return _Username; }
        }
        public string Foodname
        {
            set { _Foodname = value; }
            get { return _Foodname; }
        }
        public int Foodprice
        {
            set { _Foodprice = value; }
            get { return _Foodprice; }
        }
        public int Foodnum
        {
            set { _Foodnum = value; }
            get { return _Foodnum; }
        }

        public DateTime Datetime
        {
            set { _Datetime = value; }
            get { return _Datetime; }
        }
    }
}
