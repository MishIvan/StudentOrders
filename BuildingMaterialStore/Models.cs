using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMaterialStore
{
    /// <summary>
    /// ед. изм.
    /// </summary>
    public class Units
    {
        public long id { get; set; }
        public string Name { get; set; }
    }
    /// <summary>
    /// номенклатура товаров
    /// </summary>
    public class Wares
    {
        public long id { get; set; }
        public string Name { get; set; }
    }
    /// <summary>
    /// вид отображения товара
    /// </summary>
    public class WaresView
    {
        public string Name { get; set; }
        public string Unit { get; set; }

    }
    /// <summary>
    /// склад
    /// </summary>
    public class Warehouse
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Count { get; set; }
        public double Price { get; set; }
        public double Summa { get; set; }
    }
    /// <summary>
    /// продажи
    /// </summary>
    public class Sailing
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public DateTime DateSailing { get; set; }
        public double Price { get; set; }
        public double Count { get; set; }
        public double Summa { get; set; }
    }    

}
