using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Appointments
{
    public class User
    {
        public long id { get; set; }
        public string name { get; set; }
        public long roleid { get; set; }
        public string rolename { get; set; }
        public string password { get; set; }
        public bool closed { get; set; }
    }
}
