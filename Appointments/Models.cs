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
        public void Copy(User src)
        {
            id = src.id;
            name = src.name;
            roleid = src.roleid;
            rolename = src.rolename;
            closed = false;
            password = string.Empty;
        }
    }
    public class Appointment
    {
        public long id { get; set; }
        public string name { get; set; }
    }
    public class Vacation
    {
        public long id { get; set; }
        public string vname { get; set; }
        public DateTime plandate { get; set; }
        public long appointmentid { get; set; }
        public string aname { get; set; }
        public string description { get; set; }
    }
    public class History
    {
        public long vacationid { get; set; }
        public DateTime eventdate { get; set; }
        public string ename { get; set; }
        public long managerid { get; set; }
        public string mname { get; set; }
        public long candidateid { get; set; }
        public string cname { get; set; }

    }
}
