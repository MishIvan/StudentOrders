using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;

namespace BoltJunction
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
            catch(Exception ex)
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
        /// Выдать список болтов
        /// </summary>
        /// <returns></returns>
        public async Task<List<Bolt>> GetBolts()
        {
            List<Bolt> lst = null;
            string sqlText = "select id, name, l, k, b, d, S, e, p from bolt";
            try
            {
                var task = await m_conn.QueryAsync<Bolt>(sqlText);
                lst = task.ToList();
            }
            catch(Exception ex)
            {
                m_errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// Выдать список гаек
        /// </summary>
        /// <returns></returns>
        public async Task<List<Nut>> GetNuts()
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
    }
}
