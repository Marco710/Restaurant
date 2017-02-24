using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Menu
    {
        public Menu() { }
        private int _Id;
        private int _Foodno;
        private string _Foodname;
        private float _Foodprice;
        private string _FoodImage;
        private string _Addno;
        private string _Deleteno;
        private string _Enable;

        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public int Foodno
        {
            set { _Foodno = value; }
            get { return _Foodno; }
        }
        public string Foodname
        {
            set { _Foodname = value; }
            get { return _Foodname; }
        }
        public float Foodprice
        {
            set { _Foodprice = value; }
            get { return _Foodprice; }
        }
        public string FoodImage
        {
            set { _FoodImage = value; }
            get { return _FoodImage; }
        }
        public string Addno
        {
            set { _Addno = value; }
            get { return _Addno; }
        }
        public string Deleteno
        {
            set { _Deleteno = value; }
            get { return _Deleteno; }
        }
        public string Enable
        {
            set { _Enable = value; }
            get { return _Enable; }
        }

    }
}
