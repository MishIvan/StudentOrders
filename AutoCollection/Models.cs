using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCollection
{
    /// <summary>
    /// Модель записи об авто
    /// </summary>
    internal class Auto
    {
        /// <summary>
        /// идентификатор авто
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// Наименование авто
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Пробег в километрах
        /// </summary>
        public double kilometrage { get; set; }
        /// <summary>
        /// Цена в руб.
        /// </summary>
        public double price { get; set; }
        /// <summary>
        /// Год выпуска, четырёхзначное число
        /// </summary>
        public int relyear { get; set; }
    }
}
