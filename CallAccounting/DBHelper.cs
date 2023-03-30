using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CallAccounting
{
    /// <summary>
    /// Класс, в котором реализована работа с БД
    /// </summary>
    internal class BaseDBHelper : IDisposable
    {
        protected SqlConnection conn;
        protected string _errorText;
        /// <summary>
        ///  открыта ли БД
        /// </summary>
        public bool isOpened { get { return conn.State == System.Data.ConnectionState.Open; } }
        /// <summary>
        /// текст ошибки, если ошибки нет - пустое значение
        /// </summary>
        public string errorText { get { return _errorText; } }

        /// <summary>
        /// установление соединения с БД непосредственно в конструкторе
        /// </summary>
        public BaseDBHelper()
        {
            _errorText = "";
            String connectionString = AppSettings.Default.ConnectionString;
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }

        }
        /// <summary>
        /// закрытие соединения
        /// </summary>
        public void Dispose()
        {
            if (isOpened) conn.Close();
        }


    }

    internal class DBHelper : BaseDBHelper
    {
        public DBHelper() : base()
        {
        }

        /// <summary>
        /// Получить список сотрудников
        /// </summary>
        /// <returns>список сотрудников, если запрос успешно выполнен или null, если нет</returns>
        public async Task<List<Worker>> GetWorkersList()
        {
            try
            {
                string sqlText = "select id, name, iddept, admin, closed, passw from workers";
                var task = await conn.QueryAsync<Worker>(sqlText);
                return task.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return null;
        }
        /// <summary>
        /// Изменить параметры пользователя-работника
        /// </summary>
        /// <param name="iduser">идентификатор работника</param>
        /// <param name="name">ФИО работника</param>
        /// <param name="deptid">идентификатор отдела, в котором числится работник</param>
        /// <param name="admin">является ли пользователь администратором системы</param>
        /// <param name="closed">признак закрытой записи</param>
        /// <returns>1 - успешное выполнение запроса, 0 - ошибка выполения запроса</returns>
        public int UpdateWorker(long iduser, string name, long deptid, bool admin = false, bool closed = false)
        {
            int nrec = 0;
            string sqlText = "update workers set name = @pname, iddept = @piddept, admin = @padmin. closed = @pclosed where id = @pid";
            try
            {
                nrec = conn.Execute(sqlText, new {pname = name, padmin = admin, pcolsed = closed, piddept = deptid, pid = iduser });
            }
            catch(Exception ex)
            { 
                _errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Добаввить запсиь о работнике
        /// </summary>
        /// <param name="name">ФИО</param>
        /// <param name="deptid">ид отдела, в которм числится работник</param>
        /// <param name="admin">присвоить ли пользователю полномочия администратора системы</param>
        /// <param name="closed">признак закрытой записи</param>
        /// <returns>1 - успешное выполнение запроса, 0 - ошибка выполения запроса</returns>
        public int AddWorker(string name, long deptid, bool admin = false, bool closed = false)
        {
            int nrec = 0;
            string sqlText = "insert into workers(name, iddept, admin, closed) " +
                "values(@pname, @piddept, @padmin, @pclosed)";
            try
            {
                nrec = conn.Execute(sqlText, new { pname = name, piddept = deptid, padmin = admin, pclosed = closed });
            }
            catch (Exception ex)
            {

                _errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Установить пароль пользователя
        /// </summary>
        /// <param name="iduser">идентификатор работника</param>
        /// <param name="passw">строка с незашифрованным паролем</param>
        /// <returns>1 - успешное выполнение запроса, 0 - ошибка выполения запроса</returns>
        public int SetUserPassword(long iduser, string passw = "123456")
        {
            int nrec = 0;
            string b64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(passw));
            byte[] bt = Encoding.UTF8.GetBytes(b64);
            string sqlText = "update workers set passw = @ppwd where id = @pid";
            try
            {
                nrec = conn.Execute(sqlText, new { ppwd = bt, pid = iduser });
            }
            catch (Exception ex)
            {

                _errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Получить список подразделений
        /// </summary>
        /// <returns>список, если запрос удачно выполнен, иначе null</returns>
        public async Task<List<Department>> GetDepartmentsList()
        {
            string sqlText = "select id, name, location from depertments";
            try
            {
                var task = await conn.QueryAsync<Department>(sqlText);
                return task.ToList();
            }
            catch(Exception ex)
            {
                _errorText = ex.Message;
            }
            return null;
        }
        /// <summary>
        /// Добавление записи об отделе
        /// </summary>
        /// <param name="deptname">наименование отдела</param>
        /// <param name="deptlocation">местоположение отдела</param>
        /// <returns>1 - если запрос успешно выполнен, 0 - иначе</returns>
        public int AddDepartment(string deptname, string deptlocation)
        {
            int nrec = 0;
            string sqlText = "insert into dapartments (name, location) values(@pname, @ploc)";
            try
            {
                nrec = conn.Execute(sqlText, new { pname = deptname, ploc = deptlocation });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Изменить данные отдела
        /// </summary>
        /// <param name="iddept">идентификатор отдела</param>
        /// <param name="deptname">наименование отдела</param>
        /// <param name="deptlocation">местоположение отдела</param>
        /// <returns>1 - если запрос успешно выполнен, 0 - иначе</returns>
        public int UpdateDepartment(long iddept, string deptname, string deptlocation)
        {
            int nrec = 0;
            string sqlText = "update dapartments set name = @pname, location = @ploc where id = @pid";
            try
            {
                nrec = conn.Execute(sqlText, new { pid = iddept, pname = deptname, ploc = deptlocation });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;                
            }
            return nrec;
        }
        /// <summary>
        /// Получить список телефонов
        /// </summary>
        /// <returns>список, если запрос удачно выполнен, иначе null</returns>
        public async Task<List<Phone>> GetPhonesList()
        {
            string sqlText = "select id, number, charge from phones";
            try
            {
                var task = await conn.QueryAsync<Phone>(sqlText);
                return task.ToList();
            }
            catch(Exception ex)
            {
                _errorText = ex.Message;
            }
            return null;
        }
        /// <summary>
        /// Получение списка сотрудников с привязанными к ним телефоеами
        /// </summary>
        /// <returns>список, если запрос удачно выполнен, иначе null</returns>
        public async Task<List<UsersPhones>> GetUsersPhones()            
        {
            string sqlText = "select workerid, workername, iddept, deptname, deptlocation, idphone, phonenumber, charge, binddate, recstatus from phonesview";
            try
            {
                var task = await conn.QueryAsync<UsersPhones>(sqlText);
                return task.ToList();
            }
            catch(Exception ex)
            {
                _errorText = ex.Message;
            }
            return null;
        }

    }
}
