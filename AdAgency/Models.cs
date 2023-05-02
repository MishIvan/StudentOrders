using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdAgency
{
    /// <summary>
    /// Договор
    /// </summary>
    public class Contract
    {
        public string number { get; set; }
        public DateTime odate { get; set; }
        public DateTime deadline { get; set; }
        public double price { get; set; }
        public int status { get; set; }
        public string statusname { get; set; }
        public long? idjuridical { get; set; }
        public long? idphish { get; set; } 
        public long? idcontract { get; set; }
    }
}
