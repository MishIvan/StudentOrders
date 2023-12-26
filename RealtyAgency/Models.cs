using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyAgency
{
    /// <summary>
    /// Представление агентского договора (сделки)
    /// </summary>
    public class ContractView
    {
        public long id { get; set; }
        public string contract { get; set; }
        public long idprincipal { get; set; }
        public string principal { get; set; }
        public long idagent { get; set; }
        public string agent { get; set; }
        public long idrealty { get; set; }
        public string address { get; set; }
        public long idchief { get; set; }
        public string sail { get; set; }
        public double csumma { get; set; }
        public long deal_status_id { get; set; }
        public string deal_status { get; set; }
    }
    /// <summary>
    /// Модель записи о договоре (сделке)
    /// </summary>
    public class Contract : Content
    {
        public long id { get; set; }
        public long idprincipal { get; set; }
        public string number { get; set; } 
        public DateTime cdate { get; set; }
        public long idagent { get; set; }
        public bool sail { get; set; }
        public long idrealty { get; set; }
        public double csumma { get; set; } = 1.0;
        public double premium { get; set; } = 0.5;
        public long deal_status_id { get; set; }
        public override string ToString()
        {
            return $" Договор № {number} от " + cdate.ToString("dd.MM.yyyy");
        }

    }
    /// <summary>
    /// Контент агентского договора и его тип
    /// </summary>
    public class Content
    {
        public byte[] content { get; set; }
        public string contenttype { get; set; }
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
    /// <summary>
    /// Модель записи Агента 
    /// </summary>
    public class Agent : Simple
    {
        public string phone { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public long? idchief { get; set; }
        public override string ToString()
        {
            return name;
        }

    }
    /// <summary>
    /// Модкль записи объекта недвижимости
    /// </summary>
    public class RealtyObject
    {
        public long id { get; set; }
        public string address { get; set; }
        public double full_square { get; set; }
        public int room_count { get; set; }
        public bool mortage { get; set; }
        public bool secondary { get; set; }
        public string repair { get; set; }
        public double rsumma { get; set; }
        public bool deal { get; set; } 
        public override string ToString()
        {
            return $"{address} - {full_square} кв. м";
        }
    }
    /// <summary>
    /// Модель записи принципала физлица или юрлица
    /// </summary>
    public class Principal : Simple
    {
        public string passport { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public string phone { get; set; }
        public string email { get; set; }
        public string inn { get; set; }
        public string kpp { get; set; }
        public string ogrn { get; set; }
        public override string ToString()
        {
            return name;
        }

    }
}
