using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascents
{
    /// <summary>
    /// Альпинисты и их спортивный разряды
    /// </summary>
    public class Person
    {
        public long id { get; set; }
        public string name { get; set; }
        public int rank { get; set; }
        public string rank_name { get; set; }
        public DateTime birthdate { get; set; }
        public DateTime? deathdate { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
    public class Peak
    {
        public long id { get; set; }
        public string name { get; set; }
        public double height { get; set; }
        public string mountains { get; set; }
    }
    public class Ascent
    {
        public long idascent { get; set; }
        public long idpeak { get; set; }
        public long idgroup { get; set; }
        public long idleader { get; set; }
        public string leadername { get; set; }
        public string peakname { get; set; }
        public double height { get; set; }
        public string mountains { get; set; }
        public int status { get; set; }
        public string statusname { get; set; }
    }
}
