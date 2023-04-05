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
                string sqlText = "select distinct id, name, iddept, admin, closed, passw from workers";
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
        /// Выдать ФИО сотрудника по его идентификатору
        /// </summary>
        /// <param name="idwrk">идентификатор работника</param>
        /// <returns>ФИО сотрудника в случае успешного выполнения запроса, иначе - пустая строка</returns>
        public string GetWorkerNameByID(long idwrk)
        {
            string wrkname = string.Empty;
            string sqlText = $"select name from workers where id = {idwrk}";
            try
            {
                wrkname = conn.Query<string>(sqlText).FirstOrDefault();
            }
            catch (Exception ex)
            {
                wrkname = string.Empty;
                _errorText = ex.Message;
            }
            return wrkname;
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
            string sqlText = "update workers set name = @pname, iddept = @piddept, admin = @padmin, closed = @pclosed where id = @pid";
            try
            {
                nrec = conn.Execute(sqlText, new {pname = name, padmin = admin, pclosed = closed, piddept = deptid, pid = iduser });
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
        /// Зарыть запись пользователя
        /// </summary>
        /// <param name="iduser">идентификатор работника</param>
        /// <returns>1 - успешное выполнение запроса, 0 - ошибка выполения запроса</returns>
        public int CloseUserRecord(long iduser)
        {
            int nrec = 0;
            string sqlText = "update workers set closed = 1 where id = @pid";
            try
            {
                nrec = conn.Execute(sqlText, new { pid = iduser });
            }
            catch (Exception ex)
            {

                _errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Закрыта ли запись пользователя
        /// </summary>
        /// <param name="iduser">идентификатор пользователя</param>
        /// <returns>true - закрыта, false - действующая</returns>
        public bool IsUserRecordClosed(long iduser)
        {
            bool res = true;
            _errorText = string.Empty;
            string sqlText = "select closed from workers where id = @pid";
            try
            {
                res = conn.Query<bool>(sqlText, new { pid = iduser }).FirstOrDefault();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return res;
        }
        /// <summary>
        /// Получить список подразделений
        /// </summary>
        /// <returns>список, если запрос удачно выполнен, иначе null</returns>
        public async Task<List<Department>> GetDepartmentsList()
        {
            string sqlText = "select id, name, location from departments";
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
            string sqlText = "insert into departments (name, location) values(@pname, @ploc)";
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
            string sqlText = "update departments set name = @pname, location = @ploc where id = @pid";
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
        /// Удалить запись об отделе. Если в отделе есть сотрудники, то будет выдано исключение
        /// </summary>
        /// <param name="iddept">идентификатор отдела</param>
        /// <returns>1 - если запрос успешно выполнен, 0 - иначе</returns>
        public int DeleteDepartment(long iddept)
        {
            int nrec = 0;
            string sqlText = $"delete from departments where id = {iddept}";
            try
            {
                nrec = conn.Execute(sqlText);
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
        /// Добавить номер телефона
        /// </summary>
        /// <param name="phonenum">номер телефона</param>
        /// <param name="charge">тариф в руб. в мин</param>
        /// <returns>1 - если запрос успешно выполнен, 0 -иначе</returns>
        public int AddPhone(string phonenum, double charge)
        {
            int nrec = 0;
            string sqlText = "insert into phones (number, charge) values (@pname, @pcharge)";
            try
            {
                nrec = conn.Execute(sqlText, new { pname = phonenum, pcharge = charge });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
                
            }
            return nrec;
        }
        /// <summary>
        /// Править номер телефона
        /// </summary>
        /// <param name="idphone">идентификатор телефона</param>
        /// <param name="phonenum">номер телефона</param>
        /// <param name="charge">тариф в руб. в мин</param>
        /// <returns>1 - если запрос успешно выполнен, 0 -иначе</returns>
        public int UpdatePhone(long idphone, string phonenum, double charge)
        {
            int nrec = 0;
            string sqlText = "update phones set number @pnum, charge =  @pcharge where id = @pid";
            try
            {
                nrec = conn.Execute(sqlText, new { pname = phonenum, pcharge = charge });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;

            }
            return nrec;
        }

        /// <summary>
        ///  Удалить номер телефона
        /// </summary>
        /// <param name="idphone">идентификатор телефона</param>
        /// <param name="phonenum">номер телефона</param>
        /// <param name="charge">тариф в руб. в мин</param>
        /// <returns>1 - если запрос успешно выполнен, 0 -иначе</returns>
        public int DeletePhone(long idphone)
        {
            int nrec = 0;
            string sqlText = $"delete from phones where id = {idphone}";
            try
            {
                nrec = conn.Execute(sqlText);
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;

            }
            return nrec;
        }
        /// <summary>
        /// Получить номер телефона по его идентификатору
        /// </summary>
        /// <param name="phoneId">идентификатор телефона</param>
        /// <returns>строку с номером телефона в случае успешного выполнения запроса, иначе - пустую строку</returns>
        public string GetPhoneNumberByID(long phoneId)
        {
            string numb = string.Empty;
            string sqlText = $"select number from phones where id ={phoneId}";
            try
            {
                numb = conn.Query<string>(sqlText).FirstOrDefault();
            }
            catch (Exception ex)
            {
                numb = string.Empty;
                _errorText = ex.Message;
            }
            return numb;
        }
        /// <summary>
        /// Возвращает идентификатор работника, которому присвоен номер телефона
        /// </summary>
        /// <param name="numPhone">номер присоенного телефона</param>
        /// <returns>-1 - ошибка выполнения запроса, 0 - номер не присоен работнику, иначе - идентификатор работника</returns>
        public long PhoneLinked(long phoneId)
        {
            long idworker = -1;
            string sqlText = $"select idworker from wrkphone join phones on phones.id = wrkphone.idphone where phones.id ={phoneId}";
            try
            {
                idworker = conn.Query<long>(sqlText).FirstOrDefault();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;

            }
            return idworker;
        }

        /// <summary>
        /// Привязка немера телефона к сотруднику
        /// </summary>
        /// <param name="idworker">идентификатор сотрудника</param>
        /// <param name="idphone">идентификатор телефона</param>
        /// <param name="bindDate">дата привязки</param>
        /// <returns>1 - если телефон был привязан, 0 - иначе</returns>
        public int LinkPhone(long idworker, long idphone, DateTime bindDate)
        {
            int nrec = 0;
            string sdt = bindDate.ToString("yyyyMMdd");
            string sqlText = $"insert into wrkphone (idworker, idphone, binddate) values({idworker},{idphone},'{sdt}')";
            try
            {
                nrec = conn.Execute(sqlText);
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Отвязка немера телефона от сотрудника
        /// </summary>
        /// <param name="idworker">идентификатор сотрудника</param>
        /// <param name="idphone">идентификатор телефона</param>
        /// <returns>1 - если телефон был привязан, 0 - иначе</returns>
        public int UnlinkPhone(long idworker, long idphone)
        {
            int nrec = 0;
            string sqlText = $"delete from wrkphone where idworker = {idworker} and idphone = {idphone}";
            try
            {
                nrec = conn.Execute(sqlText);
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Получение списка сотрудников с привязанными к ним телефоеами
        /// </summary>
        /// <returns>список, если запрос удачно выполнен, иначе null</returns>
        public async Task<List<UsersPhones>> GetUsersPhones()            
        {
            string sqlText = "select distinct workerid, workername, iddept, deptname, deptlocation, idphone, phonenumber, charge, binddate, recstatus from phonesview";
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
        /// <summary>
        /// Добавить телефонные вызов
        /// </summary>
        /// <param name="idphone">идентификатор телефона</param>
        /// <param name="callTime">дата и время вызова</param>
        /// <param name="input">входящий или исходящий вызов</param>
        /// <param name="calltime">время разговора в мин</param>
        /// <returns>1 - запрос удачно выполнен, 0 - иначе</returns>
        public int AddCall(long idphone, DateTime callTime, bool input, double calltime)
        {
            int nrec = 0;
            string sqlText = $"insert into calls (calldate, input, idphone, calltime) values (@pdate, @pinput, @pidphone, @ptime)";
            try
            {
                nrec = conn.Execute(sqlText, new {pdate = callTime, pinput = input, pidphone = idphone, ptime =  calltime});
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Удаление записи о звонке
        /// </summary>
        /// <param name="idcall">идентификатор звонка</param>
        /// <returns>1 - запрос удачно выполнен, 0 - иначе</returns>
        public int DeleteCall(long idcall)
        {
            int nrec = 0;
            string sqlText = $"delete from calls where id = {idcall}";
            try
            {
                nrec = conn.Execute(sqlText);
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Выдать список вызовов для телефона сотрудника
        /// </summary>
        /// <param name="workerid">идентификато сотрудника</param>
        /// <returns>Список вызовов в случае успешного выполнения запроса, иначе - null</returns>
        public async Task<List<CallsView>> GetCallsByWorkerID(long workerid)
        {
            string sqlText = $"select distinct idphone, phonenumber, idcall, calldate,calltype,calltime from phonesview where workerid ={workerid}";
            try
            {
                var task = await conn.QueryAsync<CallsView>(sqlText);
                return task.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return null;
        }
        /// <summary>
        /// Выдать отчётную форму
        /// </summary>
        /// <param name="workerid">идентификато сотрудника</param>
        /// <returns>Список вызовов в случае успешного выполнения запроса, иначе - null</returns>
        public async Task<List<ReportPhone>> GetReportData(DateTime db, DateTime de, double sum = 0.0)
        {
            string sqlText = Properties.Settings.Default.ReportCallsQuery;
            try
            {
                var task = await conn.QueryAsync<ReportPhone>(sqlText,
                    new { pdbegin = db, pdend = de, psum = sum });
                return task.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return null;
        }
    }
}
