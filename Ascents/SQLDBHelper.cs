using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;

namespace Ascents
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
        public DBHelper() : base() {}
        /// <summary>
        /// Выдать список вершин
        /// </summary>
        /// <returns>список вершин в случае удачного выполнения запроса, null - иначе</returns>
        public async Task<List<Peak>> GetPeaks()
        {
            List<Peak> lst = null;
            string sqlText = "select p.id, p.name, p.height, p.idmountains from dbo.peaks p order by name";
            try 
            {
                var t = await conn.QueryAsync<Peak>(sqlText);
                lst = t.ToList();
            }
            catch(Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// Выдать список горных систем
        /// </summary>
        /// <returns>список горных систем в случае удачного выполнения запроса, null - иначе</returns>
        public async Task<List<Mountains>> GetMountains()
        {
            List<Mountains> lst = null;
            string sqlText = "select m.id, m.name from dbo.mountains m order by name";
            try
            {
                var t = await conn.QueryAsync<Mountains>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// Выдать объект вершины с наименованием горной системы
        /// </summary>
        /// <param name="id">идентификатор вершины</param>
        /// <returns>объект, в случае удачного выполнения запросаб иначе null</returns>
        public PeakMountain GetPeakMountainByID(long id)
        {
            PeakMountain pm = null;
            string sqlText = $"select p.id, p.name, p.idmountains, (select m.name from dbo.mountains m where m.id = p.idmountains) mountains from dbo.peaks p order where p.id = {id}";
            try
            {
                pm = conn.QueryFirstOrDefault<PeakMountain>(sqlText);
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return pm;
        }
        /// <summary>
        /// Добавить запись о вершине в БД
        /// </summary>
        /// <param name="pk">объект с данными для добавления</param>
        /// <returns>1 - добавление успешно, 0 - иначе</returns>
        public int AddPeak(Peak pk)
        {
            int nrec = 0;
            string sqlText = "insert into dbo.peaks (name, height, idmountains) values(@pname, @ph, @pidm)";
            try
            {
                nrec = conn.Execute(sqlText, new { pname = pk.name, ph = pk.height, pidm = pk.idmountains });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Изменить вершину
        /// </summary>
        /// <param name="pk">объект с данными для изменения</param>
        /// <returns>1 - изменение успешно, 0 - иначе</returns>
        public int UpdatePeak(Peak pk)
        {
            int nrec = 0;
            string sqlText = "update dbo.peaks set name = @pname, height =  @ph, idmountains = @pidm where id = @pid";
            try
            {
                nrec = conn.Execute(sqlText, new { pname = pk.name, ph = pk.height, pidm = pk.idmountains, pid = pk.id });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Выдать спи сок альпинистов
        /// </summary>
        /// <returns>список альпинистов, если запрос успешно выполнен, иначе - null</returns>
        public async Task<List<Person>> GetPersons()
        {
            List<Person> lst = null;
            string sqlText = "select p.id, p.name, p.rank, (select r.name from dbo.ranks r where r.id = p.rank) rankname, p.birthdate, p.closed, p.comments, p.closedname from dbo.persons p order by p.name";
            try
            {
                var t = await conn.QueryAsync<Person>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;
        }
    }
}
