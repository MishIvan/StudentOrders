using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Collections.ObjectModel;
using Dapper;
using FuelStation.Properties;

namespace FuelStation
{
    public class DBHelper : IDisposable
    {
        private string _errorText;
        /// <summary>
        ///  открыта ли БД
        /// </summary>
        public  bool isOpened { get { return _conn.State == System.Data.ConnectionState.Open; } }
        public string errorText { get { return _errorText; } }
        private SqlConnection _conn;
        
        /// <summary>
        /// установление соединения с БД
        /// </summary>
        public DBHelper()
        {
            _errorText = String.Empty;
            String connectionString = Settings.Default.ConnectionString;
            _conn = new SqlConnection(connectionString);            
            try
            {
                _conn.Open();
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
            if (isOpened) _conn.Close();
        }

        /// <summary>
        /// заполнение списка номенклатуры ГСМ на складе
        /// </summary>
        /// <returns>список номенклатуры ГСМ</returns>
        public List<Ware> GetWareList()
        {
            if (!isOpened) return null;
            List<Ware> wList = _conn.Query<Ware>("select id, name from Ware").ToList();
            return wList;
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
                new SqlCommand($"select distinct Name from dbo.Wares where lower(Name) like '%{filter.ToLower()}%'", _conn):
                new SqlCommand($"select distinct Name from dbo.Wares", _conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lst.Add(rd.GetString(0));
            }
            rd.Close();

        }

    }
}
