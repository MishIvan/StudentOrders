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
}
