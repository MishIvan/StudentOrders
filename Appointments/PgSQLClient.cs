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
        public static long ConvertToUnixTime(DateTime datetime)
        {
            DateTime sTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            return (long)(datetime - sTime).TotalSeconds;
        }
        #region Users and Roles
        /// <summary>
        /// Получить список всех пользователей 
        /// </summary>
        /// <returns>список пользователей или </returns>
        public List<User> getUsers()
        {
            string sqlText = string.Empty;
            sqlText = "select u.id, u.name, u.roleid, r.name rolename, u.password, u.closed  " +
                        "from public.users u " +
                        "join public.roles r on r.id = u.roleid where not u.closed";

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
        public List<Candidate> getCandidates()
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
        public Candidate getCandidateById(long id)
        {
            Candidate cnd = null;
            if (isOpened)
            {
                try 
                {
                    string sqlText = $"select id, name, phone, email from public.candidates where id = {id}";
                    cnd = m_connection.QueryFirstOrDefault<Candidate>(sqlText);
                }
                catch(Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return cnd;
        }
        /// <summary>
        /// Установить параметры соискателя по его идентификатору
        /// </summary>
        /// <param name="cnd">объект записи кандидата</param>
        /// <returns>-1 БД не открыта, 0 - запись не обновлена, 1 - запись обновлена</returns>
        public int updateCandidate(Candidate cnd)
        {
            int rval = -1;
            if(isOpened)
            {
                try 
                {

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
        public long insertCandidate(string cname, string cphone, string cemail)
        {
            long rval = -1;
            if (isOpened)
            {
                try
                {
                    long cid = m_connection.ExecuteScalar<long>("select coalesce(max(id),0) + 1 cnt from public.candidates");
                    string sqlText = "insert into public.candidates (id,name,phone,email) " +
                        "values(@qid, @qname, @qphone, @qmail)";
                    rval = m_connection.Execute(sqlText,
                        new {qid = cid, qname = cname, qphone = cphone, qmail = cemail });
                }
                catch (Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return rval;
        }

        /// <summary>
        /// Удалить запись соискателя по её идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns>число удалённых записей (1 - удаление успешно, 0 - запись не найдена, -1 - ошибка</returns>
        public int deleteCandidate(long id)
        {
            int rval = -1;
            if (isOpened)
            {
                try
                {
                    rval = m_connection.Execute($"delete from public.candidates where id = {id}");
                }
                catch (Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return rval;

        }
        #endregion

        #region Projects
        /// <summary>
        /// Получить список всех руководителей проекта
        /// </summary>
        /// <returns>список всех руководителей проекта или null</returns>
        public List<UserBrief> getProjectChiefs()
        {
            List<UserBrief> chiefs = null;
            if(isOpened)
            {
                string sqlText = "select u.id, u.name from public.users u join public.roles r on r.id = u.roleid " +
                    "where r.name = 'Руководитель проекта'";
                chiefs = m_connection.Query<UserBrief>(sqlText).ToList();
            }
            return chiefs;
        }
        /// <summary>
        /// Добавить запись о проекте
        /// </summary>
        /// <param name="name">наименование проекта</param>
        /// <param name="chiefid">идентификатор его руководителя</param>
        /// <returns></returns>
        public int insertProject(string name, long chiefid)
        {
            int rval = -1;
            if (isOpened)
            {
                try
                {
                    string sqlText = "insert into public.projects(name,chiefid) " +
                        "values(@qname,@qid)";
                    rval = m_connection.Execute(sqlText,
                        new
                        {
                            qname = name,
                            qid = chiefid
                        });
                }
                catch (Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return rval;
        }
        /// <summary>
        /// Изменить параметры проекта по его мдентификатору
        /// </summary>
        /// <param name="id">идентификатор проекта</param>
        /// <param name="name">наименование проекта</param>
        /// <param name="chiefid">идентификатор пользователя с ролью руководителя проекта</param>
        /// <returns>1 - если операция прошла успешно, 0 - проект с идентификатором id не найден, -1 - ошибка</returns>
        public int updateProject(long id, string name, long chiefid)
        {
            int rval = -1;
            if (isOpened)
            {
                try
                {
                    string sqlText = "update public.projects set name = @qname,chiefid =  @qid" +
                        "where id = @pid";
                    rval = m_connection.Execute(sqlText,
                        new
                        {
                            qname = name,
                            qid = chiefid,
                            pid = id
                        });
                }
                catch (Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return rval;

        }
        /// <summary>
        /// Удалить запись о проекте по её идентификатору
        /// </summary>
        /// <param name="id">идентификатор проекта</param>
        /// <returns>1 - если операция прошла успешно, 0 - проект с идентификатором id не найден, -1 - ошибка</returns>
        public int deleteProject(long id)
        {
            int rval = -1;
            if (isOpened)
            {
                try
                {
                    string sqlText = $"delete from public.projects where id = {id}";
                    rval = m_connection.Execute(sqlText);
                }
                catch (Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return rval;

        }
        public Project getProjectById(long id)
        {
            Project prj = null;
            if (isOpened)
            {
                try
                {
                    string sqlText = "select p.id, p.name, p.chiefid, ch.name chiefname "+
                        "from public.projects p left join public.users ch on ch.id = p.chiefid "+
                        $"where p.id = {id}";
                    prj = m_connection.QueryFirstOrDefault<Project>(sqlText);
                }
                catch (Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return prj;

        }
        public List <Project> getProjects()
        {
            List<Project> prjList = null;
            if (isOpened)
            {
                try
                {
                    string sqlText = $"select p.id, p.name, p.chiefid, ch.name chiefname " +
                        "from public.projects p left join public.users ch on ch.id = p.chiefid" ;
                    prjList = m_connection.Query<Project>(sqlText).ToList();
                }
                catch (Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return prjList; 

        }
        #endregion

        #region Vacations
        /// <summary>
        /// Получисть список всех вакансий
        /// </summary>
        /// <returns>список вакансий или null</returns>
        public List <Vacation> getVacations()
        {
            List<Vacation> vlist = null;
            if(isOpened)
            {
                string sqlText = "select v.id, v.plandate, v.vname, v.appointmentid, c.aname," +
                    "v.projectid,v.pname, v.chname, v.descrioption, v.salary from view.vacations v";
                vlist = m_connection.Query<Vacation>(sqlText).ToList();
            }
            return vlist;
        }
        /// <summary>
        /// Получить вакансию по её идентификатору
        /// </summary>
        /// <param name="id">идентификатор выкансии</param>
        /// <returns>объект вакансии или null</returns>
        public Vacation getVacationById(long id)
        {
            Vacation vc = null;
            if(isOpened)
            {
                string sqlText = "select v.id, v.plandate, v.vname, v.appointmentid, c.aname," +
                    "v.projectid,v.pname, v.chname, v.description, v.salary from view.vacations v " +
                    $"where v.id ={id}";
                vc = m_connection.QueryFirstOrDefault<Vacation>(sqlText);
            }
            return vc;
        }
        /// <summary>
        /// Изменить параметры вакансии
        /// </summary>
        /// <param name="vc">объект вакансии</param>
        /// <returns>1 - запись обновлена, 0 - не удалось обновить запись, -1 - ошибка</returns>
        public int updateVacation(Vacation vc)
        {
            int rval = -1;
            if (isOpened)
            {
                try
                { 
                    string frmtDate = vc.plandate.ToString("yyyy-MM-dd HH:mm:ss");
                    string sqlText = "update public.vacations set plandate = @qpdate, name = @qvname, appointmentid =@qaid, " +
                        "projectid = @qpid,description = @qd, v.salary = @qs where id = @qid";
                     rval = m_connection.Execute(sqlText, 
                         new { qpdate = frmtDate,  qvname = vc.vname, 
                             qaid = vc.appointmentid, qpid = vc.projectid, qd = vc.description, qs = vc.salary });
                }
                catch(Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return rval;
        }
        /// <summary>
        /// Добавление записи о вакансии
        /// </summary>
        /// <param name="vc">объект вакансии</param>
        /// <returns>1 - запись обновлена, 0 - не удалось обновить запись, -1 - ошибка</returns>
        public int insertVacation(Vacation vc)
        {
            int rval = -1;
            if (isOpened)
            {
                try
                {
                    string frmtDate = vc.plandate.ToString("yyyy-MM-dd HH:mm:ss");
                    long id = m_connection.ExecuteScalar<long>("select coalesce(max(id),0) + 1 id from public.vacations");
                    string sqlText = "insert into public.vacations (id,plandate,name,appointmentid,projectid,description,salary) " +
                        $"values({id},'{frmtDate}','{vc.vname}',{vc.appointmentid},{vc.projectid},'{vc.description}',{vc.salary})";
                    rval = m_connection.Execute(sqlText);
                }
                catch (Exception ex)
                {
                    m_errorText = ex.Message;
                }
            }
            return rval;

        }
        /// <summary>
        /// Удалить вакансию и все связанные с ней события в транзакции
        /// </summary>
        /// <param name="id">идентификатор вакансии</param>
        /// <returns>1 - транзакция успешно прошла, 0 - транзакция не прошла, -1 - ошибка выполения</returns>
        public int deleteVacation(long id)
        {
            int rval = -1;
            if(isOpened)
            {
                rval = 0;
                using (var tran = m_connection.BeginTransaction())
                {
                    string sqlText = $"delete from public.history where vacationid = {id}";
                    rval += m_connection.Execute(sqlText, transaction : tran );
                    sqlText = $"delete from public.vacations where id = {id}";
                    rval += m_connection.Execute(sqlText, transaction: tran);
                    tran.Commit();                    
                }

            }
            return rval;
        }
        #endregion

    }
}
