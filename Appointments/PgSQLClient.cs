using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Dapper;

namespace Appointments
{
    class PgSQLClient
    {
        private NpgsqlConnection m_connection;
        private String m_errorText;
        /// <summary>
        ///  открыта ли БД
        /// </summary>
        public bool isOpened { get { return m_connection.State == System.Data.ConnectionState.Open; } }
        public string errorText { get { return m_errorText; } }

        public PgSQLClient()
        {
            m_connection = new NpgsqlConnection(AppSettings.Default.ConnectionString);
            try
            {
                m_connection.Open();
            }
            catch(Exception ex)
            {
                m_errorText = ex.Message;
            }
        }
        /// <summary>
        /// Закрыть соединение
        /// </summary>
        public void Close() { if (isOpened) m_connection.Close(); }
        /// <summary>
        /// Получить список пользователей для выбора текущего пользователя
        /// </summary>
        /// <returns>список пользователей для выбора текущего пользователя</returns>
        public List<User> getUsers()
        {
            string sqlText = "select u.id, u.name, u.roleid, r.name rolename, u.password  " +
                        "from public.users u " +
                        "join public.roles r on r.id = u.roleid where not u.closed";
            List<User> lusr = null;
            if(isOpened)
            {
                lusr = m_connection.Query<User>(sqlText).ToList();
            }
            return lusr;
        }

    }
}
