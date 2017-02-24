using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public User() { }
        private string _Id;
        private string _Email;
        private string _Username;
        private string _Pwd;
        private string _Role;

        public string Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public string Email
        {
            set { _Email = value; }
            get { return _Email; }
        }
        public string Username
        {
            set { _Username = value; }
            get { return _Username; }
        }
        public string Pwd
        {
            set { _Pwd = value; }
            get { return _Pwd; }
        }
        public string Role
        {
            set { _Role = value; }
            get { return _Role; }
        }
    }
}
