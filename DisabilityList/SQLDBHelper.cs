using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace DisabilityList
{
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
        public DBHelper() : base() { }


        /// <summary>
        /// Выдать спиcок лечебных учреждений
        /// </summary>
        /// <returns>список записей</returns>
        public async Task<List<Hospital>> GetHospitals()
        {
            List<Hospital> lst = null;
            string sqlText = "select id, name, address, govregnum from dbo.hospitals order by name";
            try
            {
                var t = await conn.QueryAsync<Hospital>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;
        }

        /// <summary>
        /// Добавить запись в лечебных учреждений
        /// </summary>
        /// <param name="hosp">даные для добавления записи</param>
        /// <returns>1 - если запись добавлена, иначе - 0</returns>
        public int AddHospital(Hospital hosp)
        {
            int recs = 0;
            string sqlText = "insert into dbo.hospitals (name, addressб govregnum) values(@pname, @padr, @pnum)";
            try
            {
                recs = conn.Execute(sqlText, new { pname = hosp.name, padr = hosp.adress, pnum = hosp.govregnum });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }

        /// <summary>
        /// Изменить запись в справочнике клиентов
        /// </summary>
        /// <param name="hosp">даные для добавления записи</param>
        /// <param name="id">идентификатор изменяемой записи</param>
        /// <returns>1 - если запись изменена, иначе - 0</returns>
        public int UpdateHospital(Hospital hosp)
        {
            int recs = 0;
            string sqlText = "update dbo.hospitals set name = @pname, address = @padr, govregnum = @pnum where id  = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = hosp.id, pname = hosp.name, padr = hosp.adress, pnum = hosp.govregnum });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }

        /// <summary>
        /// Удалить запись справочника
        /// </summary>
        /// <param name="id">идентификатор записи</param>
        /// <returns>1 - если запись удалена, иначе - 0</returns>
        public int DeleteHospital(long id)
        {
            int recs = 0;
            string sqlText = "delete from dbo.hospitals where id  = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = id });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }

        /// <summary>
        /// Получить список дополнительных услуг
        /// </summary>
        /// <returns>список с данными преподавателей</returns>
        /*public async Task<List<Service>> GetServices()
        {
            List<Service> lst = null;
            string sqlText = "select id, name,summa from dbo.services order by name"; 
            try
            {
                var t = await conn.QueryAsync<Service>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;

        }

        /// <summary>
        /// Добавить запись о доп. услуге
        /// </summary>
        /// <param name="svc">Объект с данными для добавления</param>
        /// <returns>1 - если запись добавлена, иначе - 0</returns>
        public int AddService(Service svc)
        {
            int recs = 0;
            string sqlText = "insert into dbo.services (name,summa) values(@pname, @psumma)";
            try
            {
                recs = conn.Execute(sqlText, new { pname = svc.name, psumma = svc.summa });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }

        /// <summary>
        /// Изменить запись о доп. услуге
        /// </summary>
        /// <param name="svc">Объект с данными для изменения</param>
        /// <returns>1 - если запись изменена, иначе - 0</returns>
        public int UpdateService(Service svc)
        {
            int recs = 0;
            string sqlText = "update dbo.services set name = @pname, summa = @ps where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = svc.id, pname = svc.name, ps = svc.summa });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }

        /// <summary>
        /// Удалить запись о преподавателя
        /// </summary>
        /// <param name="id">идентификатор удаляемой записи</param>
        /// <returns>1 - если запись удалена, иначе - 0</returns>
        public int DeleteService(long id)
        {
            int recs = 0;
            string sqlText = "delete from dbo.services where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = id });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }
        /// <summary>
        /// Выдать список посещений клуба для отображения
        /// </summary>
        /// <returns></returns>
        public async Task<List<Visit_view>> GetVisitList()
        {
            List<Visit_view> lst = null;
            string sqlText = "select id, imonth, month_name, iyear, days_count, service_name , client_name, summa from dbo.visits_view order by iyear, imonth, client_name";
            try
            {
                var t = await conn.QueryAsync<Visit_view>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;

        }

        /// <summary>
        /// Получить объект с данными о визите
        /// </summary>
        /// <param name="id">идентификатор записи о визите</param>
        /// <returns></returns>
        public Visit GetVisitById(long id)
        {
            Visit vis = null;
            string sqlText = "select id, month, year, idclient, days, idservice, summa from dbo.visits where id = @pid";
            try
            {
                vis = conn.QueryFirstOrDefault<Visit>(sqlText, new { pid = id });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return vis;

        }

        /// <summary>
        /// Добавить запись о визите
        /// </summary>
        /// <param name="vis">объект с данными о визите</param>
        /// <returns>1 - если запись добавлена, 0 - иначе</returns>
        public  int AddVisitRecord(Visit vis)
        {
            int recs = 0;
            string sqlText = "insert into dbo.visits (month, year, idclient, days, idservice, summa) values(@pmonth, @pyear, @pidc, @pdays, @pids, @ps)";
            try
            {
                recs = conn.Execute(sqlText, new { pmonth = vis.month, pyear = vis.year, pidc = vis.idclient, pdays = vis.days, pids = vis.idservice, ps = vis.summa });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }

        /// <summary>
        /// Изменить данные записи о визите
        /// </summary>
        /// <param name="vis">объект с данными о визите</param>
        /// <returns>1 - если запись изменена, 0 - иначе</returns>
        public int UpdateVisitRecord(Visit vis)
        {
            int recs = 0;
            string sqlText = "update dbo.visits set month = @pmonth, year = @pyear, idclient = @pidc, days = @pdays, idservice = @pids, summa = @ps where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, 
                    new { pid = vis.id, pmonth = vis.month, pyear = vis.year, pidc = vis.idclient, pdays = vis.days, pids = vis.idservice, ps = vis.summa });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }

        /// <summary>
        /// Удалить запись о визите
        /// </summary>
        /// <param name="id">идентификатор удаляемой записи</param>
        /// <returns>1 - если запись удалена, 0 - иначе</returns>
        public int DeleteVisitRecord(long id)
        {
            int recs = 0;
            string sqlText = "delete from dbo.visits where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = id });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }

        /// <summary>
        /// Изменить стоимость дневного посещения клуба
        /// </summary>
        /// <param name="season">1 - зима, 2 - весна и осень, 3 - лето</param>
        /// <param name="summa">новое значение суммы</param>
        /// <returns>1 - запись изменена, 0 - иначе</returns>
        public int UpdateSummaForDay(int season, double summa)
        {
            int recs = 0;
            string sqlText = "update dbo.sumforday set summa = @psum ";
            switch(season)
            {
                case 1:
                    sqlText += "where month in (1, 2, 12)"; break;
                case 2:
                    sqlText += "where month in (3, 4, 5, 9, 10, 11)"; break;
                case 3:
                    sqlText += " where month in (6, 7, 8)"; break;
                default:
                    return recs; 
            }
            try
            {
                recs = conn.Execute(sqlText, new { psum = summa});
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }
        /// <summary>
        /// Получить стоимость 1 дня посещения в сезон
        /// </summary>
        /// <param name="season">isMonth = false: 1 - зима, 2 - весна и осень, 3 - лето, иначе месяц</param>
        /// <returns></returns>
        public async Task<double> GetSummaForDay(int season, bool isMonth = false)
        {
            double sum = double.NaN; 
            string sqlText = "select top 1 summa from dbo.sumforday ";
            if (!isMonth)
            {
                switch (season)
                {
                    case 1:
                        sqlText += "where month in (1, 2, 12)"; break;
                    case 2:
                        sqlText += "where month in (3, 4, 5, 9, 10, 11)"; break;
                    case 3:
                        sqlText += " where month in (6, 7, 8)"; break;
                    default:
                        return sum;
                }
            }
            else
                sqlText += $" where month = {season}";
            try
            {
                sum = await conn.QuerySingleAsync<double>(sqlText);
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return sum;

        }*/


    }
}
