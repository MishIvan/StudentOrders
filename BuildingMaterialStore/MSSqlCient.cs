using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Collections.ObjectModel;

namespace BuildingMaterialStore
{
    public class MSSqlCient
    {
        private SqlConnection conn;
        private string _errorText;
        /// <summary>
        ///  открыта ли БД
        /// </summary>
        public  bool isOpened { get { return conn.State == System.Data.ConnectionState.Open; } }
        public string errorText { get { return _errorText; } } 
        
        /// <summary>
        /// установление соединения с БД
        /// </summary>
        public MSSqlCient()
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
        public void Close()
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
        /// Добавить товар
        /// </summary>
        /// <param name="Name">Наименование</param>
        /// <param name="UnitName">Наименование ед. измерения</param>
        /// <returns></returns>
        public int AddWare(String Name, string UnitName)
        {
            if (!isOpened) return -1;

            int code = ExecuteSQL($"exec AddWare '{Name}', '{UnitName}'");
            return code;
        }
        /// <summary>
        /// удалить товар
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public int DeleteWare(String Name)
        {
            if (!isOpened) return -1;

            int code = ExecuteSQL($"exec DeleteWare '{Name}'");
            return code;

        }
        /// <summary>
        /// заполнение списка товаров
        /// </summary>
        /// <param name="wList">список товаров: наименование, ед. изм.</param>
        public void FillWareList(IList<WaresView> wList)
        {
            if (!isOpened) return;
            wList.Clear();
            SqlCommand cmd = new SqlCommand("select Name, Unit from dbo.WaresView", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                wList.Add(new WaresView { Name = rd.GetString(0), Unit = rd.GetString(1) });
            }
            rd.Close();

        }
        /// <summary>
        /// заполнение списка ед. изм. 
        /// </summary>
        /// <param name="UnitsList">Списоок единиц измерения</param>
        public void FillUnitsList(IList<String> UnitsList)
        {
            if (!isOpened) return;
            UnitsList.Clear();
            SqlCommand cmd = new SqlCommand("select distinct Name from dbo.Units", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                UnitsList.Add(rd.GetString(0));
            }
            rd.Close();

        }
        /// <summary>
        /// Заполнение списка товаров, хранящихся на складе 
        /// </summary>
        /// <param name="whl"></param>
        public void FillWarehouseList(IList<Warehouse> whl)
        {
            if (!isOpened) return;
            whl.Clear();
            SqlCommand cmd = new SqlCommand("select Name, Unit, Count, Price, Summa from WarehouseView", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Warehouse wh = new Warehouse
                {
                    Name = rd.GetString(0),
                    Unit = rd.GetString(1),
                    Count = rd.GetDouble(2),
                    Price = rd.GetDouble(3),
                    Summa = rd.GetDouble(4)
                };
                
                whl.Add(wh);
            }
            rd.Close();

        }
        /// <summary>
        /// Заполнить список товаров с фильтрацией
        /// </summary>
        /// <param name="filter">строка фильтрации, если пустая или null, внести в список всю номенклатуру</param>
        /// <param name="lst">заполняемый список наименований</param>
        public void FillFilteredWareList(String filter, List<String> lst)
        {
            if (!isOpened) return;
            lst.Clear();
            SqlCommand cmd = !String.IsNullOrEmpty(filter) ? 
                new SqlCommand($"select distinct Name from dbo.Wares where lower(Name) like '%{filter.ToLower()}%'", conn):
                new SqlCommand($"select distinct Name from dbo.Wares", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lst.Add(rd.GetString(0));
            }
            rd.Close();

        }
        /// <summary>
        /// Заполнение списка продаж
        /// </summary>
        /// <param name="lst">заполняемый список продаж</param>
        public void FillSailingsList(IList<Sailing> lst)
        {
            if (!isOpened) return;
            lst.Clear();
            SqlCommand cmd = new SqlCommand("select DateSailing, Name, Unit, Count, Price, Summa from SailingsView", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Sailing sail = new Sailing
                {
                    DateSailing = rd.GetDateTime(0),
                    Name = rd.GetString(1),
                    Unit = rd.GetString(2),
                    Count = rd.GetDouble(3),
                    Price = rd.GetDouble(4),
                    Summa = rd.GetDouble(5)
                };

                lst.Add(sail);
            }
            rd.Close();

        }
        /// <summary>
        /// Оприходовать товар на склад
        /// </summary>
        /// <param name="Name">Наименование товара</param>
        /// <param name="count">количество</param>
        /// <param name="price">цена</param>
        /// <returns>Добавленное число записей, 0 - если не удалось добавить</returns>
        public int AddToWarehouse(String Name, double count, double price)
        {
            if (!isOpened) return -1;

            int code = ExecuteSQL($"exec InventoryReceipt '{Name}', {count}, {price}");
            return code;

        }
        /// <summary>
        /// Добавить продажу товара
        /// </summary>
        /// <param name="Name">Наименование</param>
        /// <param name="count">кол-во</param>
        /// <param name="price">цена</param>
        /// <returns>число добавленных записей</returns>
        public int AddSaling(String Name, double count, double price)
        {
            if (!isOpened) return -1;
            DateTime dt = DateTime.Now;
            String sdt = String.Format("{0:d4}{1:d2}{2:d2} {3:d2}:{4:d2}:{5:d2}", dt.Year, dt.Month, dt.Day,
                dt.Hour, dt.Minute, dt.Second);

            int code = ExecuteSQL($"exec Sailing '{Name}', {count}, {price}, '{sdt}'");
            return code;

        }
        /*        

                public int AddSailing(int tabNumber, String productName, DateTime dt, double sum)
                {
                    if (!isOpened) return -1;
                    String sdt = String.Format("{0:d4}{1:d2}{2:d2} {3:d2}:{4:d2}:{5:d2}", dt.Year, dt.Month, dt.Day,
                                    dt.Hour, dt.Minute, dt.Second);

                    return ExecuteSQL($"exec AddSailing {tabNumber},'{productName}', '{sdt}', {sum}");
                }

                public int DeleteSailing(int tabNumber, String productName, DateTime dt)
                {
                    if (!isOpened) return -1;
                    String sdt = String.Format("{0:d4}{1:d2}{2:d2} {3:d2}:{4:d2}:{5:d2}", dt.Year, dt.Month, dt.Day,
                                    dt.Hour, dt.Minute, dt.Second);
                    return ExecuteSQL($"exec DeleteSailing {tabNumber},'{productName}', '{sdt}'");

                }*/

    }
}
