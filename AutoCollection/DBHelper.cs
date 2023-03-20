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
    class DBHelper : IDisposable
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
        /// <summary>
        /// Добавление авто в коллекцию
        /// </summary>
        /// <param name="name">Наименование авто</param>
        /// <param name="kilom">пробег в км</param>
        /// <param name="price">цена в руб.</param>
        /// <param name="year">год выпуска</param>
        /// <returns>1 - если запись добавлена, -1 - если нет соединения, 0 - если произошла ошибка</returns> 
        public int AddAuto(string name, double kilom, double price, double year)
        {
            if (!isOpened) return -1;
            int nrec = 0;
            String sqlText = "insert into autos (name, kilometrage, price, relyear) values (@pname, @pkilometrage, @pprice, @pyear)";
            try
            {
                nrec = conn.Execute(sqlText, new { pname = name, pkilometrage = kilom, pprice = price, pyear = year });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Правка данных по авто
        /// </summary>
        /// <param name="id">идентификатор авто для правки</param>
        /// <param name="name">Наименование</param>
        /// <param name="kilom">пробег в км</param>
        /// <param name="price">цена в руб.</param>
        /// <param name="year">год выпуска</param>
        /// <returns>1 - если запись изменена, -1 - если нет соединения, 0 - если произошла ошибка</returns>
        public int UpdateAutoData(long id, string name, double kilom, double price, double year)
        {
            if (!isOpened) return -1;
            int nrec = 0;
            String sqlText = "update autos set name = @pname, kilometrage = @pkilometrage, price =  @pprice, relyear = @pyear  where id = @pid";
            try
            {
                nrec = conn.Execute(sqlText, new {pid = id, pname = name, pkilometrage = kilom, pprice = price, pyear = year });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return nrec;

        }
    }
}
