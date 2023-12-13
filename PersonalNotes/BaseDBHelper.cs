using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalNotes
{
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

    class DBHelper : BaseDBHelper
    {
        public DBHelper(string dataFileName) : base(dataFileName)
        {

        }

        /// <summary>
        /// Выдать список адресов
        /// </summary>
        /// <returns></returns>
        public async Task<List<AddressBook>> GetAddressData()
        {
            List<AddressBook> lst = null;
            string sqlText = "select id, name, birth_date, phone, address, comments from address_book order by name";
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
            string sqlText = $"select id, name, birth_date, pbone, address, comments from address_book where id ={idrec}";
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
        /// Добавить запись
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
        /// Изменить запись по шаблону
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
        /// Выдать список гаек
        /// </summary>
        /// <returns></returns>
        /*public async Task<List<Nut>> GetNuts()
        {
            List<Nut> lst = null;
            string sqlText = "select id, name, d, m, s, e, p from nut";
            try
            {
                var task = await m_conn.QueryAsync<Nut>(sqlText);
                lst = task.ToList();
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// Выдать список шайб
        /// </summary>
        /// <returns></returns>
        public async Task<List<Washer>> GetWashers()
        {
            List<Washer> lst = null;
            string sqlText = "select id, name, d, d1, d2, s from washer";
            try
            {
                var task = await m_conn.QueryAsync<Washer>(sqlText);
                lst = task.ToList();
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// Выдать список материалов
        /// </summary>
        /// <returns></returns>
        public async Task<List<Material>> GetMaterials()
        {
            List<Material> lst = null;
            string sqlText = "select id, name, sigmt, sigmv from material order by name";
            try
            {
                var task = await m_conn.QueryAsync<Material>(sqlText);
                lst = task.ToList();
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// Заполнить список диаметров болтов
        /// </summary>
        /// <returns></returns>
        public async Task<List<double>> GetBoltDiams()
        {
            List<double> lst = null;
            string sqlText = "select distinct d from bolt order by d";
            try
            {
                var task = await m_conn.QueryAsync<double>(sqlText);
                lst = task.ToList();
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return lst;
        }*/
    }
}
