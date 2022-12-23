using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Dapper;
using Dapper.Contrib.Extensions;

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
        #region Users and Roles

        public List<User> getUsers(long roleid = 0)
        {
            string sqlText = string.Empty;
            if(roleid == 0)
                sqlText = "select u.id, u.name, u.roleid, r.name rolename, u.password, u.closed  " +
                            "from public.users u " +
                            "join public.roles r on r.id = u.roleid";
            else
                sqlText = $"select u.id, u.name, u.roleid, r.name rolename, u.password, u.closed,  " +
                            "from public.users u " +
                            "join public.roles r on r.id = u.roleid where u.roleid = {roleid}";

            List<User> lusr = null;
            if(isOpened)
            {
                lusr = m_connection.Query<User>(sqlText).ToList();
            }
            return lusr;
        }
        /// <summary>
        /// Получить список пользователей для представления
        /// </summary>
        /// <returns></returns>
        public List<UsersView> getUserForGrid()
        {
            string sqlText = "select u.id, u.name, u.roleid, u.rolename, u.status, u.closed  " +
                            "from views.users u ";
            List<UsersView> lusr = null;
            if (isOpened)
            {
                lusr = m_connection.Query<UsersView>(sqlText).ToList();
            }
            return lusr;

        }
        /// <summary>
        /// Возвращает параметры пользователя по его идентификатору
        /// </summary>
        /// <param name="id">идентификатор пользователя</param>
        /// <returns>объект Пользователь или null, если пользователя с таким идентификаторорм не существует </returns>
        public User getUserById(long id)
        {
            if(!isOpened) return null;
            string sqlText = "select u.id, u.name, u.roleid, r.name rolename, u.password, u.closed  " +
                "from public.users u join public.roles r on r.id = u.roleid " +
                $"where u.id = {id}";
            User usr = m_connection.QueryFirstOrDefault<User>(sqlText);
            return usr;

        }
        /// <summary>
        /// Добавить нового пользователя (это право дано только админу)
        /// </summary>
        /// <param name="userName">ФИО пользователя</param>
        /// <param name="rid">идентификатор роли</param>
        /// <param name="passw">пароль</param>
        /// <param name="state">true - запись закрытая, false - запись открытая </param>
        /// <returns>число вставленных записей</returns>
        public int insertUser(string userName, long rid, string passw, bool state)
        {
            int rows = -1;
            if(isOpened)
            {
                long id = m_connection.ExecuteScalar<long>("select coalesce(max(id),0)+1 cnt from public.users");
                string sqlText = "insert into public.users(id,name, roleid, password, closed) " +
                    "values(@uid, @qname, @qrid, @qpwd, @qclosed)";
                try
                {
                    rows = m_connection.Execute(sqlText,
                        new { uid = id, qname = userName, qrid = rid, qpwd =passw, qclosed = state  });
                }
                catch(Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return rows;
        }
        /// <summary>
        /// Изменить параметры пользователя
        /// </summary>
        /// <param name="id">идентификатор пользователя</param>
        /// <param name="userName">ФИО пользователя</param>
        /// <param name="rid">идентификатор роли пользователя</param>
        /// <param name="passw">пароль</param>
        /// <param name="state">true - запись закрытая, false - запись открытая</param>
        /// <returns>число вставленных записей</returns>
        public int updateUser(long id, string userName, long rid, string passw, bool state)
        {
            int rows = -1;
            if (isOpened)
            {
                string sqlText = "update public.users set name = @qname, roleid = @qrid, " + 
                    "password = @qpwd, closed = @qclosed where id = @qid";
                try
                {
                    rows = m_connection.Execute(sqlText,
                        new { qname = userName, qrid = rid, qpwd = passw, qclosed = state, qid = id });
                }
                catch (Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return rows;
        }
        /// <summary>
        /// Удалить пользователя по его идентификатору
        /// </summary>
        /// <param name="id">идентификатор пользователя</param>
        /// <returns>число удалённых записей</returns>
        public int deleteUser(long id)
        {
            int rows = -1;
            if (isOpened)
            {
                string sqlText = $"delete from public.users where id = {id}";
                try
                {
                    rows = m_connection.Execute(sqlText);
                }
                catch (Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return rows;

        }
        /// <summary>
        /// Заполнить список ролей
        /// </summary>
        /// <returns>список ролей</returns>
        public List<Role> getRoles()
        {
            List<Role> roleList = null;
            if(isOpened)
            {
                string sqlText = "select r.id, r.name from public.roles r";
                roleList = m_connection.Query<Role>(sqlText).ToList();
            }
            return roleList;
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

        #region Candidate
        /// <summary>
        /// Выдать список всех кандидатов на вакансии
        /// </summary>
        /// <returns>список всех кандидатов на вакансии</returns>
        List<Candidate> getCandidates()
        {
            if (!isOpened) return null;
            string sqlText = "select id, name, phone, email from public.candidates";
            List<Candidate> clist = m_connection.Query<Candidate>(sqlText).ToList();
            return clist;
        }
        /// <summary>
        /// Возврат объекта кандидата по его идентификатору
        /// </summary>
        /// <param name="id">идентификатор записи</param>
        /// <returns></returns>
        Candidate getCandidateById(long id)
        {
            return isOpened ? null : m_connection.Get<Candidate>(id);
        }
        /// <summary>
        /// Установить параметры соискателя по его идентификатору
        /// </summary>
        /// <param name="cid">идентификатор соискателя</param>
        /// <param name="cname">ФИО соискателя</param>
        /// <param name="cphone">его телефон</param>
        /// <param name="cemail">его email</param>
        /// <returns>-1 БД не открыта, 0 - запись не обновлена, 1 - запись обновлена</returns>
        int updateCandidate(long cid, string cname, string cphone, string cemail)
        {
            int rval = -1;
            if(isOpened)
            {
                try 
                {

                    Candidate cnd = new Candidate
                    {
                        id = cid,
                        name = cname,
                        phone = cphone,
                        email = cemail
                    };
                    bool res = m_connection.Update<Candidate>(cnd);
                    rval = res ? 1 : 0;
                }
                catch(Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return rval;
        }
        /// <summary>
        /// Добавление соискателя в БД
        /// </summary>
        /// <param name="cname">ФИО </param>
        /// <param name="cphone"></param>
        /// <param name="cemail"></param>
        /// <returns></returns>
        long insertCandidate(string cname, string cphone, string cemail)
        {
            long rval = -1;
            if (isOpened)
            {
                try
                {
                    long cid = m_connection.ExecuteScalar<long>("select coalesce(max(id),0) + 1 cnt from public.candidates");
                    Candidate cnd = new Candidate
                    {
                        id = cid,
                        name = cname,
                        phone = cphone,
                        email = cemail
                    };
                    rval = m_connection.Insert<Candidate>(cnd);
                }
                catch (Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return rval;
        }
        #endregion

    }
}
