using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Appointments
{
    [Table("public.users")]
    public class User
    {
        [Key]
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
            closed = src.closed;
            password = string.Empty;
        }
    }

    [Table("roles")]
    class Role
    {
        [Key]
        public long id { get; set; }
        public string name { get; set; }
    }

    public class UsersView
    {
        public long id { get; set; }
        public string name { get; set; }
        public long roleid { get; set; }
        public string rolename { get; set; }
        public string status { get; set; }
        public bool closed { get; set; }

    }
    public class Candidate
    {
        public long id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

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
        public long projectid { get; set; }
        public string pname { get; set; }
        public string chname { get; set; }
        public string description { get; set; }
        public double salary { get; set; }
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
