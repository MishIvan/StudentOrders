using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation
{
    /// <summary>
    /// транспортное средство
    /// </summary>
    public class Vehicle
    {
        public String govnumber { get; set; }
        public string Name { get; set; }
    }
    /// <summary>
    /// номенклатура товаров
    /// </summary>
    public class Ware
    {
        public long id { get; set; }
        public String Name { get; set; }
    }
    /// <summary>
    /// склад
    /// </summary>
    public class Warehouse
    {
        public long WareID { get; set; }
        public String Name { get; set; }
        public double Count { get; set; }
        public double Price { get; set; }
        public double Summa { get; set; }
    }
    /// <summary>
    /// продажи
    /// </summary>
    public class Sailing
    {
        public long WareID { get; set; }
        public DateTime DateSailing { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public double Count { get; set; }
        public double Summa { get; set; }
        public long UserID { get; set; }
        public String User { get; set; }
        public String govnumber { get; set; }
        public String Vehicle { get; set; }
    }

}
