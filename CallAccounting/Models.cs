using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallAccounting
{
    public class Worker
    {
        public long id { get; set; }
        public string name { get; set; }
        public long iddept { get; set; }
        public bool admin { get; set; }
        public bool closed { get; set; }
        public byte [] passw { get; set; }

    }

    public class Department
    {
        public long id { get; set; }
        public string name { get; set; }
        public string location { get; set; }

    }

    public class UsersPhones
    {
        public long workerid { get; set; }
        public string workername { get; set; }
        public long iddept { get; set; }
        public string deptname { get; set; }
        public string deptlocation { get; set; }
        public long idphone { get; set; }
        public string phonenumber { get; set; }
        public float charge { get; set; }
        public DateTime binddate { get; set; }
        public string recstatus { get; set; }


    }
}
