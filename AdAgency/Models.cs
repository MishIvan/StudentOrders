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
        public long id { get; set; }
        public string number { get; set; }
        public DateTime cdate { get; set; }
        public DateTime datefrom { get; set; }
        public DateTime dateto { get; set; }
        public long? idjuridical { get; set; }
        public long? idphis { get; set; }
        public string comments { get; set; }
        public string name { get; set; }
        public byte[] content { get; set; }
        public string contenttype { get; set; }
    }

    /// <summary>
    /// Вид для отображения договора
    /// </summary>
    public class ContractView
    {
        public long id { get; set; }
        public string cnumber { get; set; }
        public DateTime cdate { get; set; }
        public string cname { get; set; }
        public DateTime datefrom { get; set; }
        public DateTime dateto { get; set; }
        public string pname { get; set; }
    }
    /// <summary>
    /// Текст договора
    /// </summary>
    public class Content
    {
        public byte[] content { get; set; }
        public string contenttype { get; set; }
    }
    /// <summary>
    /// Заголовочная часть заказа
    /// </summary>
    public class Order
    {
        public string number { get; set; }
        public DateTime odate { get; set; }
        public DateTime deadline { get; set; }
        public double summa { get; set; }
        public int status { get; set; }
        public long? idjuridical { get; set; }
        public long? idphis { get; set; }
        public long? idcontract { get; set; }
    }
    public class OrderTable
    {
        public string number { get; set; }
        public long idadservice { get; set; }
        public string service_name { get; set; }
        public double count { get; set; }
        public double price { get; set; }
        public int numstr { get; set; }


    }
    public class OrderView
    {       
        public string order_number { get; set; }
        public DateTime order_date { get; set; }
        public DateTime deadline { get; set; }
        public double summa { get; set; }
        public int idstatus { get; set; }
        public string status { get; set; }
        public long idjuridical { get; set; }
        public long idphis { get; set; }
        public string pname { get; set; }
        public long idcontract { get; set; }
        public string contract_name { get; set; }
    }
    /// <summary>
    /// Виды рекламых услуг
    /// </summary>
    public class AdService
    {
        public int id { get; set; }
        public string sname { get; set; }
        public override string ToString()
        {
            return sname;
        }
    }
    /// <summary>
    /// Клиент - юридическое лицо
    /// </summary>
    public class JuridicalPerson
    {
        public long id { get; set; }
        public string pname { get; set; }
        public string inn { get; set; }
        public string kpp { get; set; }
        public string address { get; set; }
        public override string ToString()
        {
            return pname;
        }
    }

    /// <summary>
    /// Клиент - физическое лицо
    /// </summary>
    public class PhisicalPerson
    {
        public long id { get; set; }
        public string pname { get; set; }
        public string inn { get; set; }
        public string passport { get; set; }
        public override string ToString()
        {
            return pname;
        }
    }
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        public int id { get; set; }
        public string uname { get; set; }
        public int role { get; set; }
        public string passw { get; set; }
        public override string ToString()
        {
            return uname;
        }
    }
}
