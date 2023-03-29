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
        public List<Worker> GetWorkersList()
        {
            List<Worker> lst = null;
            try
            {
                string sqlText = "select id, name, iddept, admin, closed, passw from workers";
                lst = conn.Query<Worker>(sqlText).ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// Установка пароля пользователя, зашифрованного в base64
        /// </summary>
        /// <param name="iduser">идентификатор пользователя, работника</param>
        /// <param name="passw">строка с незашифрованным паролем</param>
        /// <returns>1 - успешное выполнение запроса, 0 - ошибка выполения запроса</returns>
        public int UpdateWorker(long iduser, string name, long deptid, bool admin, bool closed, string passw = "123456")
        {
            int nrec = 0;
            string sqlText = "update workers set name = @pname, iddept = @piddept, admin = @padmin. closed = @pclosed, passw = @pwd where id = @pid";
            try
            {
                string b64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(passw));
                byte [] bt = Encoding.UTF8.GetBytes(b64);
                nrec = conn.Execute(sqlText, new {pname = name, padmin = admin, pcolsed = closed, piddept = deptid, pwd = bt, pid = iduser });
            }
            catch(Exception ex)
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
