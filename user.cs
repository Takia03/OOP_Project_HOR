using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_HOR
{
    internal class user
    {
        public string name { get; set; }
        public string uname { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string password { get; set; }
        public string hudai { get; set; }
        public user(string name, string uname, string email, string mobile, string password)
        {
            this.name = name;
            this.uname = uname;
            this.email = email;
            this.mobile = mobile;
            this.password = password;
        }
    }
}
