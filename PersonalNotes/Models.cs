using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotes
{
    /// <summary>
    /// запись в адресной книге
    /// </summary>
    public class AddressBook
    {
        public long id { get; set; }
        public string name { get; set; } // ФИО
        public string phone { get; set; } // номер телефона
        public DateTime birth_date { get; set; } // дата
        public string address { get; set; } // адрес
        public string comments { get; set; }  // заметки

    }
    /// <summary>
    /// запись в заметках
    /// </summary>
    public class Notes
    {
        public long id { get; set; }
        public DateTime note_datetime { get; set; } // дата и время заметки
        public string comments { get; set; } // содержание заметки
    }
}