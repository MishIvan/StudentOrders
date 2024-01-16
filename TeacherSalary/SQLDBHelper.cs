using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Runtime.Versioning;

namespace TeacherSalary
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
        /// Выдать список пользователей
        /// </summary>
        /// <returns></returns>
        public async Task<List<User>> GetUsers()
        {
            List<User> lst = null;
            string sqlText = "select id, name, password from dbo.users order by name";
            try
            {
                var t = await conn.QueryAsync<User>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;
        }

        /// <summary>
        /// Выдать спиcок записей простого справочника
        /// </summary>
        /// <returns></returns>
        public async Task<List<SimpleRef>> GetSimpleRefRecords(string refName)
        {
            List<SimpleRef> lst = null;
            string sqlText = $"select id, name from dbo.{refName} order by name";
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
        /// Добавить запись в простой справочник
        /// </summary>
        /// <param name="refName">имя таблицы в БД</param>
        /// <param name="name">наименование</param>
        /// <returns>1 - если запись добавлена, иначе - 0</returns>
        public int AddSimpleRefRecord(string refName, string name)
        {
            int recs = 0;
            string sqlText = $"insert into dbo.{refName} (name) values(@pname)";
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
        /// Изменить запись простого справочника
        /// </summary>
        /// <param name="refName">имя справочника</param>
        /// <param name="name">новое наименование</param>
        /// <param name="id">идентификатор изменяемой записи</param>
        /// <returns>1 - если запись изменена, иначе - 0</returns>
        public int UpdateSimpleRefRecord(string refName, string name, long id)
        {
            int recs = 0;
            string sqlText = $"update dbo.{refName} set name = @pname where id  = @pid";
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
        /// <param name="refName">имя таблицы справочника</param>
        /// <param name="id">идентификатор записи</param>
        /// <returns>1 - если запись удалена, иначе - 0</returns>
        public int DeleteSimpleRefRecord(string refName, long id)
        {
            int recs = 0;
            string sqlText = $"delete from dbo.{refName} where id  = @pid";
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
        /// Получить список преподавателей
        /// </summary>
        /// <param name="iddept">фильтр преподавателей по идентификатору кафедры. Если =0 выдать весь список</param>
        /// <returns>список с данными преподавателей</returns>
        public async Task<List<Teacher>> GetTeachers(long iddept = 0)
        {
            List<Teacher> lst = null;
            string sqlText = iddept > 0 ? $"select id, name,idpost, iddepartment, salary from dbo.teachers where iddepartment = {iddept} order by name" :
                $"select id, name,idpost, iddepartment, salary from dbo.teachers order by name";
            try
            {
                var t = await conn.QueryAsync<Teacher>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;

        }

        /// <summary>
        /// Получить объект с реквизитами преподавателя
        /// </summary>
        /// <param name="id">идентификатор преподавателя</param>
        /// <returns></returns>
        public Teacher GetTeacherbyId(long id)
        {
            Teacher t = null;
            string sqlText = "select id, name,idpost, iddepartment, salary from dbo.teachers where id = @pid";
            try
            {
                t = conn.QueryFirstOrDefault<Teacher>(sqlText, new { pid = id });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return t;

        }
        /// <summary>
        /// Добавить запись о преподавателе
        /// </summary>
        /// <param name="teacher">Объект с данными для добавления</param>
        /// <returns>1 - если запись добавлена, иначе - 0</returns>
        public int AddTeacher(Teacher teacher)
        {
            int recs = 0;
            string sqlText = "insert into dbo.teachers (name,idpost, iddepartment, salary) values(@pname, @pidp, @pidd, @ps)";
            try
            {
                recs = conn.Execute(sqlText, new { pname = teacher.name, pidp = teacher.idpost, pidd = teacher.iddepartment, ps = teacher.salary });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }

        /// <summary>
        /// Изменить запись о преподавателе
        /// </summary>
        /// <param name="teacher">Объект с данными для изменения</param>
        /// <returns>1 - если запись изменена, иначе - 0</returns>
        public int UpdateTeacher(Teacher teacher)
        {
            int recs = 0;
            string sqlText = "update dbo.teachers set name = @pname,idpost = @pidp, iddepartment = @pidd, salary = @ps where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = teacher.id, pname = teacher.name, pidp = teacher.idpost, pidd = teacher.iddepartment, ps = teacher.salary });
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
        public int DeleteTeacher(long id)
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


    }
}
