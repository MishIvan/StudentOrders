using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;

namespace AutoCollection
{
    /// <summary>
    /// Класс, реализующий взаимодействие и управление базой данных
    /// </summary>
    internal class DBHelper : IDisposable
    {
        private SqlConnection conn;
        private string _errorText;
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
        public DBHelper()
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

        /// <summary>
        /// Выполнение запроса, не возвращающего курсор
        /// </summary>
        /// <param name="sqlText">Текст запроса</param>
        /// <returns>Возврат числа записей, на которые повлияла команда</returns>        
        private int ExecuteSQL(String sqlText)
        {
            if (!isOpened) return -1;
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            int code = cmd.ExecuteNonQuery();
            return code;
        }

        #region autos
        /// <summary>
        /// Получение списка всей коллекции или части коллекции по фильтру
        /// </summary>
        /// <param name="filter">фильтр по наименованию</param>
        /// /// <param name="closed">true - показать </param>

        /// <returns>Список коллекции из БД</returns>
        public async Task<List<Auto>> GetAutoList(string filter = "", bool closed = false)
        {            
            if (!isOpened) return null;
            int flag = closed ? 1 : 0;
            string sqlText = $"select id, name, kilometrage, price, relyear, govnum from autos where closed = {flag}";
            if(!string.IsNullOrEmpty(filter) && !string.IsNullOrWhiteSpace(filter))
            {
                sqlText += $" and name like '%{filter}%'";
            }
            try
            {
                var task = await conn.QueryAsync<Auto>(sqlText);
                return task.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return null;
        }
        /// <summary>
        /// Получить объект модели из БД по идентификатору записи
        /// </summary>
        /// <param name="id">идентификатор записи в коллекции</param>
        /// <returns>объект в случае успешного выполнения запроса или null</returns>
        public Auto GetAutoByID(long id)
        {
            Auto car = null;
            if (!isOpened) return car;
            string sqlText = $"select id, name, kilometrage, price, relyear, govnum from autos where id = {id}";
            try
            {
                car = conn.QueryFirstOrDefault<Auto>(sqlText);
            }
            catch(Exception ex)
            {
                _errorText = ex.Message;
            }
            return car;

        }
        /// <summary>
        /// Добавление записи об авто в коллекцию
        /// </summary>
        /// <param name="name">Наименование авто</param>
        /// <param name="kilom">пробег в км</param>
        /// <param name="price">цена в руб.</param>
        /// <param name="year">год выпуска</param>
        /// <returns>1 - если запись добавлена, -1 - если нет соединения, 0 - если произошла ошибка</returns> 
        public int AddAuto(string name, double kilom, double price, int year, string govn)
        {
            if (!isOpened) return -1;
            int nrec = 0;
            String sqlText = "insert into autos (name, kilometrage, price, relyear, govnum, closed) values (@pname, @pkilometrage, @pprice, @pyear, @pnum, 0)";
            try
            {
                nrec = conn.Execute(sqlText, new { pname = name, pkilometrage = kilom, pprice = price, pyear = year, pnum = govn });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return nrec;
        }

        /// <summary>
        /// Правка данных по авто в коллекции
        /// </summary>
        /// <param name="id">идентификатор авто для правки</param>
        /// <param name="name">Наименование</param>
        /// <param name="kilom">пробег в км</param>
        /// <param name="price">цена в руб.</param>
        /// <param name="year">год выпуска</param>
        /// <returns>1 - если запись изменена, -1 - если нет соединения, 0 - если произошла ошибка</returns>
        public int UpdateAutoData(long id, string name, double kilom, double price, int year, string govn)
        {
            if (!isOpened) return -1;
            int nrec = 0;
            String sqlText = "update autos set name = @pname, kilometrage = @pkilometrage, price =  @pprice, relyear = @pyear, govnum = @pnum where id = @pid";
            try
            {
                nrec = conn.Execute(sqlText, new {pid = id, pname = name, pkilometrage = kilom, pprice = price, pyear = year, pnum = govn });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return nrec;

        }

        /// <summary>
        /// Удаление записи об авто из коллекции
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteAuto(long id)
        {
            if (!isOpened) return -1;
            int nrec = 0;
            String sqlText = "delete from autos where id = @pid";
            var cond = new { pid = id };
            using (var tran = conn.BeginTransaction())
            { 
                try
                {                   
                    nrec = conn.Execute("delete from history where idauto = @pid", cond, transaction: tran);
                    nrec = conn.Execute(sqlText, cond, transaction: tran);
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    _errorText = ex.Message;
                }

            }
            return nrec;
        }
        #endregion
        #region Actions
        /// <summary>
        /// Добавляет действие для выбранного автомобиля
        /// </summary>
        /// <param name="idauto">идентификатор в коллекции</param>
        /// <param name="db">начальная дата</param>
        /// <param name="de">конечная дата</param>
        /// <param name="nomdoc">номер документа-основания для действия</param>
        /// <param name="idevt">идентификатор действия: 1 - выдача доверености, 2 - отзыв доверенности, 3 - ремонт, 4 - продажа, 5 - дарение</param>
        /// <param name="comments">дополнительная информация по действию</param>
        /// <param name="summa">сумма (ремонта или продажи)</param>
        /// <param name="summa">сумма (ремонта или продажи)</param>
        /// <returns>1 - если добавление произошло успешно, иначе меньше 1</returns>
        public int AddAction(long idauto, DateTime db, DateTime de, string nomdoc, int idevt, string comments = "", double summa = 0.0, byte[] dcont = null)
        {
            if (!isOpened) return -1;
            int nrec = 0;
            string sdb = db.ToString("yyyMMdd");
            string sde = de.ToString("yyyMMdd");
            string sqlText = "insert into actions (idauto, nomdoc, bdate, edate, comments, idevt, summa, doc) ";
            sqlText += $"values(@pidauto, @pnumdoc,'{sdb}','{sde}',@pcomments, @pidevt, @psumma, @pdoc)";
            try
            {
                byte[] doccont = dcont == null ? new byte[] { 0 } : dcont;
                nrec = conn.Execute(sqlText,
                    new { pidauto = idauto, pnumdoc = nomdoc, pidevt = idevt, pcomments = comments, psumma = summa, pdoc = doccont});
            }
            catch(Exception ex)
            {
                _errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Удалить запись о действии
        /// </summary>
        /// <param name="idaction">идентификатор записи действия</param>
        /// <param name="idauto">идентификатор записи авто, для которого совершено действие</param>
        /// <returns></returns>
        public int DeleteAction(long idaction, long idauto)
        {
            if (!isOpened) return -1;
            int nrec = 0;
            string sqlText = "delete from actions where id =@pid and idauto = @pida";
            try
            {
                nrec = conn.Execute(sqlText, new { pid = idaction, pida = idauto });
            }
            catch(Exception ex)
            {
                _errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Проверка совершаемого действия на правильность
        /// </summary>
        /// <param name="idauto"></param>
        /// <param name="idaction"></param>
        /// <param name="nomdoc"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ValidateAction(long idauto, int idaction, string nomdoc, DateTime dt)
        {
            // болванка функции
            bool res = true;
            string sqlText;
            string sdt = dt.ToString("yyyyMMdd");
            switch(idaction)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;


            }
            return res;
        }
        #endregion between
    }
}
