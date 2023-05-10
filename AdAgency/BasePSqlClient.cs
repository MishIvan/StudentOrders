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
                using (var tran = m_connection.BeginTransaction())
                {
                    nrec = m_connection.Execute(sqlText, transaction: tran);
                    sqlText = "insert into public.ordertable_temp (number, numstr,idadservice, count price) " +
                $"select number, numstr,idadservice, count price from public.ordertable_temp where number = {ord.number}";
                    m_connection.Execute(sqlText, transaction: tran);                    
                    sqlText = $"delete from public.ordertable_temp where number = {ord.number}";
                    nrec = m_connection.Execute(sqlText, transaction: tran);
                    tran.Commit();
                }
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
        /// <summary>
        /// Получить таблицу услуг по заказу
        /// </summary>
        /// <param name="onum">номер заказа</param>
        /// <returns></returns>
        public async Task<List<OrderTable>> GetOrderTable(string onum)
        {
            List<OrderTable> lst = null;
            string sqlText = $"select ot.numstr, ot.number, ot.idadservice, (select s.name from public.adservice s where s.id = ot.idadservice) service_name, ot.count, ot.price form public.ordertable where ot.number ='{onum}' ot order by ot.numstr";
            try
            {
                var t = await m_connection.QueryAsync<OrderTable>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// Добавить запись во временную об услуге по заказу
        /// </summary>
        /// <param name="tabl">объект с данными</param>
        /// <returns>1 -  запись успешно добавлена, 0 - иначе</returns>
        public int AddOrderTableRecord(OrderTable tabl)
        {
            int nrec = 0; 
            try
            {
                tabl.numstr = m_connection.QueryFirstOrDefault<int>($"select public.next_num_order_table('{tabl.number}')");
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
                return nrec;
            }

            string sqlText = "insert into public.ordertable_temp (number, numstr,idadservice, count price) values(@pnumber, @pnumstr, @pidadservice, @pcount, @pprice)";
            try
            {
                m_connection.Execute(sqlText, new { pnumber = tabl.number, pnumstr = tabl.numstr, pidadservice = tabl.idadservice, count = tabl.count, pprice = tabl.price  });
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Изменение записи во временной таблице услуг по заказау
        /// </summary>
        /// <param name="tabl">объект с данными</param>
        /// <returns>1 -  запись успешно изменена, 0 - иначе</returns>
        public int UpdateOrderTableRecord(OrderTable tabl)
        {
            int nrec = 0;
           
            string sqlText = "update public.ordertable_temp set idadservice = @pidadservice, count = @pcount, price = @pprice where  number = @pnumber and numstr = @pnumstr";
            try
            {
                m_connection.Execute(sqlText, new { pnumber = tabl.number, pnumstr = tabl.numstr, pidadservice = tabl.idadservice, });
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Удаление записи из временной таблицы услуг по заказу
        /// </summary>
        /// <param name="ordernum"></param>
        /// <param name="nstr"></param>
        /// <returns></returns>
        public int DeleteOrderTableRecord(string ordernum, int nstr)
        {
            int nrec = 0;

            string sqlText = $"delete public.ordertable_temp where number = '{ordernum}' and numstr = {nstr}";
            try
            {
                m_connection.Execute(sqlText);
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Заполнить таблицу услуг по временной таблице
        /// </summary>
        /// <returns>чило добавленных записей, иначе 0</returns>
        public int FillTempOrderTable(string ordernum, NpgsqlTransaction tran)
        {
            int nrec = 0;

            string sqlText = "insert into public.ordertable_temp (number, numstr,idadservice, count price) " + 
                $"select number, numstr,idadservice, count price from public.ordertable where number = {ordernum}";
            try
            {
                m_connection.Execute(sqlText,);
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Почистить временную таблицу заказов
        /// </summary>
        /// <param name="ordernum"></param>
        /// <returns></returns>
        public int ClearTempOrderTable(string ordernum)
        {
            int nrec = 0;

            string sqlText = $"select number, numstr,idadservice, count price from public.ordertable_temp where number = {ordernum}";
            try
            {
                m_connection.Execute(sqlText);
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return nrec;
        }
        #endregion

        #region Phisical_Person
        public PhisicalPerson GetPhisicalPersonByID(long id)
        {
            PhisicalPerson php = null;
            string sqlText = $"select id, pname, passport from public.phisperson where id = {id}";
            try
            {
                php = m_connection.QueryFirstOrDefault<PhisicalPerson>(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return php;
        }
        #endregion

        #region Juridical_Person
        /// <summary>
        /// Возвращает список юридических лиц
        /// </summary>
        /// <returns></returns>
        public async Task<List<JuridicalPerson>> GetPesons()
        {
            List<JuridicalPerson> lst = null;
            string sqlText = "select id, pname, inn, kpp, address from public.juridicalperson order by pname";
            try
            {
                var t = await m_connection.QueryAsync<JuridicalPerson>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// Получить объект по идентификатору из БД
        /// </summary>
        /// <param name="id">идентификатор юрлица</param>
        /// <returns>в случае успешного выполнения запроса объект, иначе - null</returns>
        public JuridicalPerson GetJuridicalPersonByID(long id)
        {
            JuridicalPerson jp = null;
            string sqlText = $"select id, pname, inn, kpp, address from public.juridicalperson where id = {id}";
            try
            {
                jp = m_connection.QueryFirstOrDefault<JuridicalPerson>(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return jp;
        }
        /// <summary>
        /// Добавление юридического лица
        /// </summary>
        /// <param name="jpers"> объект с данными</param>
        /// <returns>1 - запись добавлена, 0 - иначе</returns>
        public int AddJuridicalPerson(JuridicalPerson jpers)
        {
            int nrec = 0;
            string sqlText = $"insert into public.juridicalperson (pname, inn, kpp, address) values('{jpers.pname}', '{jpers.inn}', '{jpers.kpp}','{jpers.address}')";
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
        /// Изменение реквизитьв юридического лица
        /// </summary>
        /// <param name="jpers">объект с данными</param>
        /// <returns>1 - изменения сделаны и внесены в БД, 0 - иначе</returns>
        public int UpdateJuridicalPerson(JuridicalPerson jpers)
        {
            int nrec = 0;
            string sqlText = $"update public.juridicalperson set pname = '{jpers.pname}', inn = '{jpers.inn}', kpp = '{jpers.kpp}', address = '{jpers.address}' where id = {jpers.id}";
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

        #region Contract
        /// <summary>
        /// Выдать список договоров
        /// </summary>
        /// <returns></returns>
        public async Task<List<ContractView>> GetContracts()
        {
            List<ContractView> lst = null;
            string sqlText = "select id, cnumber, cname, cdate, datefrom, dateto, pname from public.contractview order by cname";
            try
            {
                var t = await m_connection.QueryAsync<ContractView>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// Получить объект по идентификатору
        /// </summary>
        /// <param name="ID">идентификатор договора</param>
        /// <returns>объект, в случае успешно выполненного запроса, null - иначе</returns>
        public Contract GetContractByID(long ID)
        {
            Contract contr = null;
            //string sqlText = $"select id,number, cdate, datefrom, dateto, idjuridical, idphis, comments, name, content,contenttype from public.contract where id = {ID}";
            string sqlText = $"select c.* from public.contract c where id = {ID}";
            try
            {
                contr = m_connection.QueryFirstOrDefault<Contract>(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return contr;
        }
        /// <summary>
        /// Добавить договор
        /// </summary>
        /// <param name="contr">Объект с данными по договору</param>
        /// <returns>1 - договор внесён в БД, 0 - иначе</returns>
        public int AddContract(Contract contr)
        {
            int nrec = 0;
            // формирование запроса
            string sqlText = "insert into public.contract (number, cdate, datefrom, dateto, name, comments, content, contenttype ";
            
            if (contr.idjuridical.HasValue && contr.idjuridical.Value > 0)
                sqlText += $",idjuridical ";
            if (contr.idphis.HasValue && contr.idphis.Value > 0)
                sqlText += $",idphis ";
            string scdate = contr.cdate.ToString("yyyy-MM-dd hh:mm:ss");
            string sdatefrom = contr.datefrom.ToString("yyyy-MM-dd hh:mm:ss");
            string sdateto = contr.dateto.ToString("yyyy-MM-dd hh:mm:ss");

            sqlText += $") values (@pnum, '{scdate}', '{sdatefrom}', '{sdateto}', @pname, @pcomments, @pcontent, @pcontenttype ";
            if (contr.idjuridical.HasValue && contr.idjuridical.Value > 0)
                sqlText += $",{contr.idjuridical} ";
            if (contr.idphis.HasValue && contr.idphis.Value > 0)
                sqlText += $", {contr.idphis} ";
            sqlText += ")";
            try
            {
                nrec = m_connection.Execute(sqlText, 
                    new { pname = contr.name, pnum = contr.number, pcomments = contr.comments, pcontent = contr.content, pcontenttype = contr.contenttype } );
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Изменить рекизиты договора
        /// </summary>
        /// <param name="contr">Объект с данными по договору</param>
        /// <returns>1 - реквизиты договора изменены в БД, 0 - иначе</returns>
        public int UpdateContract(Contract contr)
        {
            int nrec = 0;

            // формирование запроса
            string scdate = contr.cdate.ToString("yyyy-MM-dd hh:mm:ss");
            string sdatefrom = contr.datefrom.ToString("yyyy-MM-dd hh:mm:ss");
            string sdateto = contr.dateto.ToString("yyyy-MM-dd hh:mm:ss");

            string sqlText = $"update public.contract set number = @pnum, cdate = '{scdate}', datefrom =  '{sdatefrom}', dateto = '{sdateto}', name = @pname, comments =   @pcomments ";

            if (contr.idjuridical.HasValue && contr.idjuridical.Value > 0)
                sqlText += $",idjuridical = {contr.idjuridical} ";
            if (contr.idphis.HasValue && contr.idphis.Value > 0)
                sqlText += $",idphis = {contr.idphis} ";
            sqlText += " where id = @pid";
            try
            {
                nrec = m_connection.Execute(sqlText, 
                    new {pid = contr.id, pname = contr.name, pnum = contr.number, pcomments = contr.comments,  });
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Загрузить текст договора
        /// </summary>
        /// <param name="ID">идентификатор договора</param>
        /// <param name="content">текст договора в двоичном формате</param>
        /// <returns>1 - если удалось внести текст в БД, 0 - иначе</returns>
        public int UploadContractContent(long ID, Content dtext)
        {
            int nrec = 0;
            string sqlText = "update public.contract set content = @pcontent, contenttype = @pcontenttype where id = @pid";
            try
            {
                nrec = m_connection.Execute(sqlText, new {pid = ID, pcontent = dtext.content, pcontenttype = dtext.contenttype });
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return nrec;
        }
        /// <summary>
        /// Скачать текст договора 
        /// </summary>
        /// <param name="ID">идентификатор договора</param>
        /// <returns> массив байтов с содержимым договора, null - иначе</returns>
        public Content DownloadContractContent(long ID)
        {
            Content cnt = null;
            string sqlText = $"select content, contenttype from public.contract where id = {ID}";
            try
            {
                cnt = m_connection.QueryFirstOrDefault<Content>(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return cnt;
        }
        /// <summary>
        /// Удалить договор
        /// </summary>
        /// <param name="ID">идентификатор договора</param>
        /// <returns>1 - если договор удалён, 0 - иначе</returns>
        public int DeleteContract(long ID)
        {
            int nrec = 0;
            string sqlText = $"delete from public.contract where id = {ID}";
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
