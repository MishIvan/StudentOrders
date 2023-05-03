using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Dapper;

namespace AdAgency
{
    class BasePSqlClient : IDisposable
    {
        protected NpgsqlConnection m_connection;
        protected String m_errorText;
        /// <summary>
        ///  открыта ли БД
        /// </summary>
        public bool isOpened { get { return m_connection.State == System.Data.ConnectionState.Open; } }
        public string errorText { get { return m_errorText; } }

        public BasePSqlClient()
        {
            m_connection = new NpgsqlConnection(AppSettings.Default.ConnectionString);
            try
            {
                m_connection.Open();
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
        }
        /// <summary>
        /// Закрыть соединение
        /// </summary>
        public void Dispose() { if (isOpened) m_connection.Close(); }
    }
    class PSqlClient : BasePSqlClient
    {
        public PSqlClient() : base()
        { }

        #region AdService
        /// <summary>
        /// Выдать полную номенклатуру рекламных услуг
        /// </summary>
        /// <returns></returns>
        public async Task<List<AdService>> GetAdServices()
        {
            List<AdService> lst = null;
            string sqlText = "select id, sname from public.adservice order by sname";
            try
            {
                var t = await m_connection.QueryAsync<AdService>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return lst;
        }
        private int NewServiceID()
        {
            int nrec = 0;
            string sqlText = "select coalesce(max(svc.id),0) + 1 from public.adservice svc";
            try
            {
                nrec = m_connection.ExecuteScalar<int>(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Добавить услугу в список номенклатуры рекламных услуг
        /// </summary>
        /// <param name="servname"></param>
        /// <returns>1 - запись добавлена, 0 - иначеы</returns>
        public int AddAdService(string servname)
        {
            int nrec = 0;
            int id = NewServiceID();
            string sqlText = $"insert into public.adservice(id,sname) values({id}, '{servname}')";
            try
            {
                nrec = m_connection.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Изменить наименование услуги
        /// </summary>
        /// <param name="ids">ИД услуги</param>
        /// <param name="servname">новое наименование услуги</param>
        /// <returns>1 - запись изменена, 0 - иначе</returns>
        public int UpdateAdService(int ids, string servname)
        {
            int nrec = 0;
            string sqlText = $"update public.adservice set sname = '{servname}' where id = {ids}";
            try
            {
                nrec = m_connection.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return nrec;
        }
        #endregion
        
        #region Orders
        /// <summary>
        /// Выдать список всех заказов
        /// </summary>
        /// <returns></returns>
        public async Task<List<OrderView>> GetOrders()
        {
            List<OrderView> lst = null;
            string sqlText = "select order_number, order_date, deadline,summa, idstatus, status, idjuridical, idphis, pname, idcontract, contract_name form public.orderview order by order_number";
            try
            {
                var t = await m_connection.QueryAsync<OrderView>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// Добавить заказ
        /// </summary>
        /// <param name="ord">объект "Заказ"</param>
        /// <returns>1 - запись добавлена, 0 - иначе</returns>
        public int AddOrder(Order ord)
        {
            int nrec = 0;

            // сформировать запрос 
            string sqlText = "insert into public.\"order\"";
            sqlText += " (number, odate, deadline, summa, status";
            
            if (ord.idjuridical.HasValue)
                sqlText += ",idjuridical";
            if (ord.idphis.HasValue)
                sqlText += ",idphis";
            if (ord.idcontract.HasValue)
                sqlText += ",idcontract";

            string sodate = ord.odate.ToString("yyyy-MM-dd hh:mm:ss");
            string sdeadline = ord.deadline.ToString("yyyy-MM-dd hh:mm:ss");

            sqlText += $") values ('{ord.number}', '{sodate}', '{sdeadline}', {ord.summa}, {ord.status} ";
            
            if (ord.idjuridical.HasValue)
                sqlText += $",{ord.idjuridical}";
            if (ord.idphis.HasValue)
                sqlText += $",{ord.idphis}";
            if (ord.idcontract.HasValue)
                sqlText += $",{ord.idcontract}";
            sqlText += ")";

            try
            {
                nrec = m_connection.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Удалитьзаказ с номером ord_num
        /// </summary>
        /// <param name="ord_num">Номер заказа</param>
        /// <returns>1 - запись удалена, 0 - иначе</returns>
        public int DeleteOrder(string ord_num)
        {
            int nrec = 0;
            string sqlText = $"delete from public.\"order\" where number = '{ord_num}'";
            try
            {
                nrec = m_connection.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Изменить параметры заказа
        /// </summary>
        /// <param name="ord">Объект, содержащий параметры заказа</param>
        /// <returns>1 - запись изменена, 0 - иначе</returns>
        public int UpdateOrder(Order ord)
        {
            int nrec = 0;
            // сформировать запрос 
            string sodate = ord.odate.ToString("yyyy-MM-dd hh:mm:ss");
            string sdeadline = ord.deadline.ToString("yyyy-MM-dd hh:mm:ss");

            string sqlText = "update public.\"order\" set ";
            sqlText += $"odate = '{sodate}', deadline = '{sdeadline}', summa = {ord.summa}, status =  {ord.status} ";

            if (ord.idjuridical.HasValue)
                sqlText += $",idjuridical = {ord.idjuridical} ";
            if (ord.idphis.HasValue)
                sqlText += $",idphis = {ord.idphis} ";
            if (ord.idcontract.HasValue)
                sqlText += $",idcontract = {ord.idcontract} ";

            sqlText += $"where number = '{ord.number}'";

            try
            {
                nrec = m_connection.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return nrec;
        }
        #endregion
    }
}
