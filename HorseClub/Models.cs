using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseClub
{
    /// <summary>
    /// Простые справочники (ИД и Наименование)
    /// </summary>
    public class SimpleRef
    { 
        public long id { get; set; } 
        public string name { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
    /// <summary>
    /// Дополнительная услуга
    /// </summary>
    public class Service: SimpleRef
    {
        public double summa { get; set; }
    }
     
    public class Month
    { 
        private int m_imonth { get; set; }
        public int imonth { get { return m_imonth; } }
        public Month(int imonth)
        {
            m_imonth = imonth;
        }

        public override string ToString()
        {
            switch(m_imonth) 
            { 
                case 1:
                    return "Январь";
                case 2:
                    return "Февраль";
                case 3:
                    return "Март";
                case 4:
                    return "Апрель";
                case 5:
                    return "Май";
                case 6:
                    return "Июнь";
                case 7:
                    return "Июль";
                case 8:
                    return "Август";
                case 9:
                    return "Сентябрь";
                case 10:
                    return "Октябрь";
                case 11:
                    return "Ноябрь";
                case 12:
                    return "Декабрь";
                default:
                    return string.Empty;
            }
        }
    }
    /// <summary>
    /// Посещение клуба
    /// </summary>
    public class Visit
    {
        public long id { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public long idclient { get; set; }
        public int days { get; set; }
        public long idservice { get; set; }
        public double summa { get; set; }
    }
    /// <summary>
    ///  Запись вида отображения посещения клуба
    /// </summary>
    public class Visit_view
    { 
        public long id { get; set; }
        public int imonth { get; set; }
        public string month_name { get; set; }
        public int iyear { get; set; }
        public int days_count { get; set; }
        public string service_name { get; set; }
        public string client_name { get; set;}
        public double summa { get; set; }
    }
  
}
