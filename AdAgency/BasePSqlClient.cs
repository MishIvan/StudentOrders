using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace AdAgency
{
    class BasePSqlClient : IDisposable
    {
        protected NpgsqlConnection m_connection;
        protected String m_errorText;
        /// <summary>
        ///  открыта ли БД
        /// </summary>
        public bool isOpened { get { return m_connection.State == System.Data.ConnectionState.Open; } }
        public string errorText { get { return m_errorText; } }

        public BasePSqlClient()
        {
            m_connection = new NpgsqlConnection(AppSettings.Default.ConnectionString);
            try
            {
                m_connection.Open();
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
        }
        /// <summary>
        /// Закрыть соединение
        /// </summary>
        public void Dispose() { if (isOpened) m_connection.Close(); }
    }
    class PSqlClient : BasePSqlClient
    {
        public PSqlClient() : base()
        { }
    }
}
