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
        /// <summary>
        /// Гос. номер авто
        /// </summary>
        public string govnum { get; set; }
        public bool closed { get; set; }
    }
    /// <summary>
    /// Модель записи о действии над ато
    /// </summary>
    internal class Actions
    {
        /// <summary>
        /// Идентификатор авто, ссылка на запись в коллекции
        /// </summary>
        public long idauto { get; set; }
        /// <summary>
        /// Ном. документа (доверенность, продажа, ремонт)
        /// </summary>
        public string nomdoc { get; set; }
        /// <summary>
        /// Дата начала (доверенность, ремонт)
        /// </summary>
        public DateTime bdate { get; set; }
        /// <summary>
        /// Дата окончания (доверенность, ремонт)
        /// </summary>
        public DateTime edate { get; set; }
        /// <summary>
        /// Комментарии
        /// </summary>
        public string comments { get; set; }
        /// <summary>
        /// Содержимое документа
        /// </summary>
        public Byte[] doc { get; set; }
        /// <summary>
        /// Идентификатор действия
        /// 1 - выдача доверенности, 2 - отзыв доверенности, 3 - ремонт (прокачка) авто, 4 - продажа, 5 - дарение
        /// </summary>
        public int idevt { get; set; }
        /// <summary>
        /// Сумма (продажа, ремонт)
        /// </summary>
        public double summa { get; set; }
        /// <summary>
        /// Наименование действия, вычисляется по его идентификатору
        /// </summary>
        public string nameevt { get; set; }

    }
}
