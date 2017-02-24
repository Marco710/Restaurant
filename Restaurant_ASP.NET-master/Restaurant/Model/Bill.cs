using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bill
    {
        public Bill() { }
        private int _Billno;
        private string _Username;
        private int _Totalprice;
        private DateTime _Datetime;

        public int Billno
        {
            set { _Billno = value; }
            get { return _Billno; }
        }
        public string Username
        {
            set { _Username = value; }
            get { return _Username; }
        }
        public int Totalprice
        {
            set { _Totalprice = value; }
            get { return _Totalprice; }
        }
        public DateTime Datetime
        {
            set { _Datetime = value; }
            get { return _Datetime; }
        }

    }
}
