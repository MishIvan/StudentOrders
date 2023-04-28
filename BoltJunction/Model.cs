using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltJunction
{
    public class Bolt
    {
        public long id { get; set; }
        public string name { get; set; }
        public double l { get; set; }
        public double k { get; set; }
        public double b { get; set; }
        public double d { get; set; }
        public double S { get; set; }
        public double e { get; set; }
        public double p{ get; set; }
        public override string ToString()
        {
            return name;
        }
    }

    public class Nut
    {
        public long id { get; set; }
        public string name { get; set; }
        public double d { get; set; }
        public double m { get; set; }
        public double S { get; set; }
        public double e { get; set; }
        public double p { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
    public class Washer
    {
        public long id { get; set; }
        public string name { get; set; }
        public double d { get; set; }
        public double d1 { get; set; }
        public double d2 { get; set; }
        public double s { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
}
