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
        #region Users

        public List<User> getUsers(long roleid = 0)
        {
            string sqlText = string.Empty;
            if(roleid == 0)
                sqlText = "select u.id, u.name, u.roleid, r.name rolename, u.password, u.closed,  " +
                            "case when u.closed then 'Закрытая' else 'Действующая' end sclosed " +
                            "from public.users u " +
                            "join public.roles r on r.id = u.roleid";
            else
                sqlText = $"select u.id, u.name, u.roleid, r.name rolename, u.password, u.closed,  " +
                            "case when u.closed then 'Закрытая' else 'Действующая' end sclosed " +
                            "from public.users u " +
                            "join public.roles r on r.id = u.roleid where u.roleid = {roleid}";

            List<User> lusr = null;
            if(isOpened)
            {
                lusr = m_connection.Query<User>(sqlText).ToList();
            }
            return lusr;
        }

        #endregion
        #region Appointments

        /// <summary>
        /// Получить список должностей
        /// </summary>
        /// <returns>список должностей</returns>
        public List<Appointment> getAppointments()
        {
            string sqlText = "select a.id, a.name from public.appointments a";
            List<Appointment> alst = null;
            if (isOpened)
            {
                alst = m_connection.Query<Appointment>(sqlText).ToList();
            }
            return alst;
        }

        /// <summary>
        /// Получение объекта Должности по идентификатору
        /// </summary>
        /// <param name="id">идентификатор записи</param>
        /// <returns>Объект с указанным идентификатором или null</returns>
        public Appointment getAppointmentById(long id)
        {
            Appointment app = null;
            if (isOpened)
            {
                string sqlText = $"select a.id, a.name from public.appointments a where a.id = {id}";
                try
                {
                    app = m_connection.QueryFirstOrDefault<Appointment>(sqlText);
                }
                catch(Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return app;
        }

        /// <summary>
        /// Добавить должность
        /// </summary>
        /// <param name="name">Наименование должности</param>
        /// <returns>число вставленных записей</returns>
        public int addAppointment(string name)
        {
            if(isOpened)
            {
                string sqlText = $"insert into public.appointments(name) values('{name}')";
                int rows = 0;
                try
                {
                    rows = m_connection.Execute(sqlText);
                }
                catch(Exception ex)
                {
                    m_errorText = ex.Message;
                }
                return rows;
            }
            else
                return -1;
        }

        /// <summary>
        /// Установить наименование должности по её идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <param name="aname"></param>
        /// <returns>число изменённых записей</returns>
        public int changeAppointmentName(long id, string aname)
        {
            if (isOpened)
            {
                string sqlText = $"update public.appointments set name =@qname where id = @qid ";
                int rows = 0;
                try
                {
                    rows = m_connection.Execute(sqlText, new { qname = aname, qid = id } );
                }
                catch (Exception ex)
                {
                    m_errorText = ex.Message;
                }
                return rows;
            }
            else
                return -1;

        }
        /// <summary>
        /// Удалить запись о должности по её идентификатору
        /// </summary>
        /// <param name="id">идентификатор записи</param>
        /// <returns>число удалённых рядов</returns>
        public int deleteAppointmentById(long id)
        {
            if (isOpened)
            {
                string sqlText = $"delete from public.appointments where id = {id} ";
                int rows = 0;
                try
                {
                    rows = m_connection.Execute(sqlText);
                }
                catch (Exception ex)
                {
                    m_errorText = ex.Message;
                }
                return rows;
            }
            else
                return -1;
        }

        #endregion

    }
}
