using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Runtime.Versioning;

namespace HorseClub
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
        /// Выдать спиcок записей  клиентов
        /// </summary>
        /// <returns>список записей</returns>
        public async Task<List<SimpleRef>> GetSimpleRefRecords()
        {
            List<SimpleRef> lst = null;
            string sqlText = $"select id, name from dbo.clients order by name";
            try
            {
                var t = await conn.QueryAsync<SimpleRef>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;
        }

        /// <summary>
        /// Добавить запись в справочник клиентов
        /// </summary>
        /// <param name="name">наименование</param>
        /// <returns>1 - если запись добавлена, иначе - 0</returns>
        public int AddSimpleRefRecord(string name)
        {
            int recs = 0;
            string sqlText = $"insert into dbo.clients (name) values(@pname)";
            try
            {
                recs = conn.Execute(sqlText, new { pname = name });
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
        /// <param name="name">новое наименование</param>
        /// <param name="id">идентификатор изменяемой записи</param>
        /// <returns>1 - если запись изменена, иначе - 0</returns>
        public int UpdateSimpleRefRecord(string name, long id)
        {
            int recs = 0;
            string sqlText = $"update dbo.clients set name = @pname where id  = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = id, pname = name });
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
        public int DeleteSimpleRefRecord(long id)
        {
            int recs = 0;
            string sqlText = $"delete from dbo.clients where id  = @pid";
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
        public async Task<List<Service>> GetServices()
        {
            List<Service> lst = null;
            string sqlText = "select id, name,isumma from dbo.services order by name"; 
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
            string sqlText = "delete from dbo.teachers where id = @pid";
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
        /// Выдать список групп студентов
        /// </summary>
        /// <returns></returns>
        public async Task<List<Group>> GetGroups()
        {
            List<Group> lst = null;
            string sqlText = "select id, number, year from dbo.stgroup order by number";
            try
            {
                var t = await conn.QueryAsync<Group>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;

        }

        /// <summary>
        /// Получить объект с данными группы
        /// </summary>
        /// <param name="id">идентификатор группы</param>
        /// <returns></returns>
        public Group GetGroupById(long id)
        {
            Group gr = null;
            string sqlText = "select id, number, year from dbo.stgroup where id = @pid";
            try
            {
                gr = conn.QueryFirstOrDefault<Group>(sqlText, new { pid = id });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return gr;

        }

        /// <summary>
        /// Добавить группу студентов
        /// </summary>
        /// <param name="group">объект с данными группы</param>
        /// <returns>1 - если запись добавлена, 0 - иначе</returns>
        public  int AddGroup(Group group)
        {
            int recs = 0;
            string sqlText = "insert into dbo.stgroup (number, year) values(@pnum, @pyear)";
            try
            {
                recs = conn.Execute(sqlText, new { pnum = group.number, pyear = group.year });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }

        /// <summary>
        /// Изменить данные группы студентов
        /// </summary>
        /// <param name="group">объект с данными группы</param>
        /// <returns>1 - если запись изменена, 0 - иначе</returns>
        public int UpdateGroup(Group group)
        {
            int recs = 0;
            string sqlText = "update dbo.stgroup set number = @pnum, year = @pyear where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = group.id, pnum = group.number, pyear = group.year });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }

        /// <summary>
        /// Удалить запись о группшстудентов
        /// </summary>
        /// <param name="id">идентификатор удаляемой группы</param>
        /// <returns>1 - если запись удалена, 0 - иначе</returns>
        public int DeleteGroup(long id)
        {
            int recs = 0;
            string sqlText = "delete from dbo.stgroup where id = @pid";
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
        /// Выдать ведомость проведённых занятий
        /// </summary>
        /// <param name="iddept">фильтр по идентификатору кафедры</param>
        /// <param name="classdate">фильтр по дате занятий</param>
        /// <param name="tfilter">фильтр по фамилии преподавателя</param>
        /// <returns>ведомость проведённых занятий</returns>
        public async Task<List<SheetView>> GetSheetViewRecords(long iddept,DateTime classdate, string tfilter = "")
        {
            List<SheetView> lst = null;
            string stdate = classdate.ToString("yyyyMMdd");
            string sqlText = "select id,classdate,iddiscipline,discipline,idclasstype,classtype,idteacher,teacher," +
                $"idgroup,stgroup,hours,iddepartment from dbo.sheet_view where iddepartment = {iddept}" +
                (classdate == DateTime.MinValue ? string.Empty : $" and classdate = '{stdate}'") +
                (string.IsNullOrEmpty(tfilter) ? string.Empty : $" and teacher like '%{tfilter}%'");
            try
            {
                var t = await conn.QueryAsync<SheetView>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }

            return lst;
        }

        /// <summary>
        /// Выдать объект записи ведомости
        /// </summary>
        /// <param name="id">идентификатор записи ведомости</param>
        /// <returns></returns>
        public Sheet GetSheetRecordById(long id) 
        {
            Sheet sheet = null;
            string sqlText = "select id,classdate,iddiscipline,idclasstype,idteacher,idgroup,hours from dbo.sheet where id = @pid";
            try
            {
                sheet = conn.QueryFirstOrDefault<Sheet>(sqlText, new { pid = id});
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return sheet;

        }
        /// <summary>
        /// Добавить запись в ведомость
        /// </summary>
        /// <param name="sheet">объект с данными</param>
        /// <returns>1 - запись добавлена, 0 - иначе</returns>
        public int AddSheetRecord(Sheet sheet)
        {
            int recs = 0;
            string sdt = sheet.classdate.ToString("yyyMMdd");
            string sqlText = $"insert into dbo.sheet (classdate,iddiscipline,idclasstype,idteacher,idgroup,hours) values ('{sdt}', @pidd, @pic, @pit, @pigr, @ph)";
            try
            {
                recs = conn.Execute(sqlText, new { pidd = sheet.iddiscipline, pic = sheet.idclasstype, pit = sheet.idteacher, pigr = sheet.idgroup, ph = sheet.hours });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }
        /// <summary>
        /// Изменить запись в ведомости
        /// </summary>
        /// <param name="sheet">данные записи, которую требуется изменить</param>
        /// <returns>1 - запись изменена, 0 - иначе</returns>
        public int UpdateSheetRecord(Sheet sheet)
        {
            int recs = 0;
            string sdt = sheet.classdate.ToString("yyyMMdd");
            string sqlText = $"update dbo.sheet set classdate = '{sdt}',iddiscipline = @pidd,idclasstype = @pic,idteacher = @pit,idgroup = @pigr,hours = @ph where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = sheet.id, pidd = sheet.iddiscipline, pic = sheet.idclasstype, pit = sheet.idteacher, pigr = sheet.idgroup, ph = sheet.hours });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }
        /// <summary>
        /// Удалить запись из ведомости
        /// </summary>
        /// <param name="idsh">идентификатор удаляемой записи</param>
        /// <returns>1 - запись удалена, 0 - иначе</returns>
        public  int DeleteSheetRecord(long idsh)
        {
            int recs = 0;
            string sqlText = "delete from dbo.sheet where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = idsh });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }
        /// <summary>
        /// Выдать сводную ведомость по зарплате за период
        /// </summary>
        /// <param name="dateBegin">начало периода</param>
        /// <param name="dateEnd">окончание периода</param>
        /// <returns>ведомость</returns>
        public async Task<List<OverallSheet>> GetOverallSheets(DateTime dateBegin, DateTime dateEnd)
        {
            List<OverallSheet> sheet = null;
            string d1 = dateBegin.ToString("yyyyMMdd");
            string d2 = dateEnd.ToString("yyyyMMdd");
            string sqlText = string.Empty;//string.Format(Properties.Resources.OverallSheetQueryString, d1, d2);
            try 
            {
                var t = await conn.QueryAsync<OverallSheet>(sqlText);
                sheet = t.ToList();

            }
            catch (Exception ex) 
            {
                _errorText = ex.Message;
            }
            return sheet;
        }

    }
}
