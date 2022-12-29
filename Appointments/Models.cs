using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Appointments
{
    public class UserBrief
    {
        public long id { get; set; }
        public string name { get; set; }

    }
    public class User : UserBrief
    {
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
    public class Role
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
    [Table("public.candidates")]
    public class Candidate
    {
        [Key]
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
    public class Project
    {
        public long id { get; set; }
        public string name { get; set; }
        public long chiefid { get; set; }
        public string chiefname { get; set; }

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
        public long eventid { get; set; }
        public string ename { get; set; }
        public long managerid { get; set; }
        public string mname { get; set; }
        public long candidateid { get; set; }
        public string cname { get; set; }
        public int nstr { get; set; }
    }
    public class Event
    {
        public long id { get; set; }
        public string name { get; set; }
    }
    public class Resume 
    {
        public long candidateid { get; set; }
        public byte [] content { get; set; }
        public string contenttype { get; set; }
    }

}
