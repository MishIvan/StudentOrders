using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftApp
{
    /// <summary>
    /// Программное обеспечение
    /// </summary>
    class Soft
    {
        private string m_name;
        private string m_vendor;
        private double m_price;
        /// <summary>
        /// Наименование
        /// </summary>
        public string SoftName
        {
            get { return m_name; }
            set { m_name = value; }
        }
        /// <summary>
        /// Производитель
        /// </summary>
        public string SoftVendor
        {
            get { return m_vendor; }
            set { m_vendor = value; }
        }
        /// <summary>
        /// Стоимость
        /// </summary>
        public double SoftPrice
        {
            get { return m_price; }
            set { m_price = value; }
        }
        /// <summary>
        /// Свободное ли программное обеспечение
        /// </summary>
        public bool IsFreeSoft
        {
            get { return m_price == 0.0; }
        }
        public Soft()
        {
            m_name = string.Empty;
            m_vendor = string.Empty;
            m_price = 0.0;
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Наименование</param>
        /// <param name="vendor">Производитель</param>
        /// <param name="price">Цена</param>
        public Soft(string name, string vendor, double price = 0.0)
        {
            m_name = name;
            m_price = price;
            m_vendor = vendor;
        }
    }
}
