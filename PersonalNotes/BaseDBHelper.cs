using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// Классы для работы с базой данных
/// Создание и открытие соединения, получения информации об ошибках
/// добавления, изменения и удаления записей в записной книжке

namespace PersonalNotes
{
    /// <summary>
    /// Базовый класс для работы с базой данных
    /// создание и открытие соединения
    /// проверка открытия базы данных, закрытие соединения
    /// </summary>
    class BaseDBHelper : IDisposable
    {
        protected SQLiteConnection m_conn; // объект соединееия
        protected string m_errorText; // строка с ошибкой
        // строка ошибки
        public string errorText { get { return m_errorText; } }
        // открыто ли  соединение
        public bool isOpen { get { return m_conn.State == System.Data.ConnectionState.Open; } }

        /// <summary>
        /// Создать объект соединения и открыть созаное соединение
        /// </summary>
        /// <param name="dataFileName"></param>
        public BaseDBHelper(string dataFileName)
        {
            m_errorText = string.Empty;
            try
            {
                SQLiteFactory factory = new SQLiteFactory();
                m_conn = (SQLiteConnection)factory.CreateConnection();
                m_conn.ConnectionString = String.Format("Data Source={0}; Version=3;", dataFileName);
                m_conn.Open();
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
        }
        /// <summary>
        /// Закрыть соединение
        /// </summary>
        public void Dispose()
        {
            if (isOpen)
                m_conn.Close();
        }
    }
    /// <summary>
    /// Производный класс от BaseDBHelper для управления данными
    /// получение записей, добаление, изменение, удаление данных
    /// </summary>
    class DBHelper : BaseDBHelper
    {
        public DBHelper(string dataFileName) : base(dataFileName)
        {

        }

        /// <summary>
        /// Выдать список адресов
        /// </summary>
        /// <returns>список объектов, представление записей</returns>
        public async Task<List<AddressBook>> GetAddressData(string letter = "")
        {
            List<AddressBook> lst = null;
            string sqlText = string.IsNullOrEmpty(letter) ? "select id, name, birth_date, phone, address, comments from address_book order by name" :
                $"select id, name, birth_date, phone, address, comments from address_book where substr(name,1,1) = '{letter}' order by name";
            try
            {
                var task = await m_conn.QueryAsync<AddressBook>(sqlText);
                lst = task.ToList();
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// Возвратить запись из адресной книги по идентификатору
        /// </summary>
        /// <param name="idrec"></param>
        /// <returns></returns>
        public AddressBook GetAddressDataRecord(long idrec)
        {
            AddressBook rec = null;
            string sqlText = $"select id, name, birth_date, phone, address, comments from address_book where id ={idrec}";
            try
            {
                rec = m_conn.QueryFirstOrDefault<AddressBook>(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }

            return rec;
        }
        /// <summary>
        /// Добавить запись в адресную книжку
        /// </summary>
        /// <param name="rec">реквизиты для добавления записи</param>
        /// <returns>число добавленных записей</returns>
        public int AddAddressRecord(AddressBook rec)
        {
            int recs = 0;
            string sdate = rec.birth_date.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlText = $"insert into address_book(name, phone, birth_date, address,comments) values('{rec.name}', '{rec.phone}', '{sdate}', '{rec.address}', '{rec.comments}')";
            try 
            {
                recs = m_conn.Execute(sqlText);
            } 
            catch(Exception ex) 
            { 
                m_errorText = ex.Message;
            }
            
            return recs;
        }
        /// <summary>
        /// Изменить запись в адресной книжке по шаблону
        /// </summary>
        /// <param name="rec">объект, шаблон для изменения записи</param>
        /// <returns></returns>
        public int UpdateAdressRecord(AddressBook rec) 
        {
            int recs = 0;
            string sdate = rec.birth_date.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlText = $"update address_book set name = '{rec.name}', phone = '{rec.phone}', birth_date = '{sdate}', address = '{rec.address}',comments = '{rec.comments}' where id = {rec.id}";
            try
            {
                recs = m_conn.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }

            return recs;
        }
        /// <summary>
        /// Удаление записи в адресной книжке
        /// </summary>
        /// <param name="id">идентификатор удаляемой записи</param>
        /// <returns></returns>
        public int DeleteAddressRecord(long id)
        {
            int recs = 0;
            string sqlText = $"delete from address_book where id = {id}";
            try
            {
                recs = m_conn.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }

            return recs;

        }
        /// <summary>
        /// Выдать список заметок в записной книжке
        /// </summary>
        /// <returns>список объектов, представлений записей</returns>
        public async Task<List<Note>> GetNotes()
        {
            List<Note> lst = null;
            string sqlText = "select id, note_datetime, comments from notes order by note_datetime";
            try
            {
                var task = await m_conn.QueryAsync<Note>(sqlText);
                lst = task.ToList();
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// Возвратить запись из заметок по идентификатору
        /// </summary>
        /// <param name="idrec"></param>
        /// <returns></returns>
        public Note GetNotesDataRecord(long idrec)
        {
            Note rec = null;
            string sqlText = $"select id, note_datetime, comments from notes where id ={idrec}";
            try
            {
                rec = m_conn.QueryFirstOrDefault<Note>(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }

            return rec;
        }

        /// <summary>
        /// Добавить запись в заметки
        /// </summary>
        /// <param name="rec">реквизиты для добавления записи</param>
        /// <returns>число добавленных записей</returns>
        public int AddNoteRecord(Note rec)
        {
            int recs = 0;
            string sdate = rec.note_datetime.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlText = $"insert into notes(note_datetime,comments) values( '{sdate}', '{rec.comments}')";
            try
            {
                recs = m_conn.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }

            return recs;
        }
        /// <summary>
        /// Изменить запись по шаблону
        /// </summary>
        /// <param name="rec">объект, шаблон для изменения записи</param>
        /// <returns></returns>
        public int UpdateNotesRecord(Note rec)
        {
            int recs = 0;
            string sdate = rec.note_datetime.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlText = $"update notes set note_datetime = '{sdate}', comments = '{rec.comments}' where id = {rec.id}";
            try
            {
                recs = m_conn.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }

            return recs;
        }
        /// <summary>
        /// Удаление записи в записной книжке
        /// </summary>
        /// <param name="id">идентификатор удаляемой записи</param>
        /// <returns></returns>
        public int DeleteNotesRecord(long id)
        {
            int recs = 0;
            string sqlText = $"delete from notes where id = {id}";
            try
            {
                recs = m_conn.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }

            return recs;

        }

    }
}
