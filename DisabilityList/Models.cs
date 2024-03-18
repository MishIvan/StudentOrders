using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisabilityList
{
    public class ReasonCode
    {
        public string code {  get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return $"{code} - {name}";
        }
    }
    public class Simple
    {
        public long id { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
    public class Hospital : Simple
    {
        public string govregnum { get; set; }
        public string address { get; set; }
    }
    public class Doctor : Simple
    {
        public long idhospital { get; set; }
        public long idspeciality { get; set; } 
    }
    public class Patient : Simple
    {
        public DateTime birth_date { get; set; }
        public string inn { get; set; }
        public string snils { get; set; }
        public string passport { get; set; }
    }
}
