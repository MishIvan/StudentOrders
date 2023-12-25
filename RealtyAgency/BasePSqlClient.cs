using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Dapper;
using System.ComponentModel;
using System.Xml.Linq;

namespace RealtyAgency
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

        #region Agents
        /// <summary>
        /// Выдать полную номенклатуру рекламных услуг
        /// </summary>
        /// <returns>списсок всех агентов, включая администратора</returns>
        public async Task<List<Agent>> GetAgents()
        {
            List<Agent> lst = null;
            string sqlText = "select id, name, phone, email, password, idchief from public.agents order by name";
            try
            {
                var t = await m_connection.QueryAsync<Agent>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// Получить объект записи агента по его идентификатору
        /// </summary>
        /// <param name="agentId">идентификатор агента</param>
        /// <returns>Объект записи об агенте</returns>
        public Agent GetAgentById(long agentId)
        {
            Agent agent = null;
            string sqlText = $"select id, name, phone, email, password, idchief from public.agents where id = {agentId}";
            try
            {
                agent = m_connection.QueryFirstOrDefault<Agent>(sqlText);
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return agent;
        }
        /// <summary>
        /// Установить пароль пользователя
        /// </summary>
        /// <param name="agentId">идентификатор пользователя</param>
        /// <param name="password">устанавливаемый пароль</param>
        /// <returns>идентификатор записи, для которой устанавливается пароль</returns>
        public long ChangeAgentPassword(long agentId, string password)
        {
            long id = 0;
            string sqlText = $"update public.agents set password = @passw where id = @pid returning id";
            try
            {
                id = m_connection.ExecuteScalar<long>(sqlText, new { pid = agentId, passw = password });
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return id;

        }
        /// <summary>
        /// Добавить новую запись об агенте
        /// </summary>
        /// <param name="agent">Шаблон для добавлпения записи</param>
        /// <returns>идентификатор новой записи</returns>
        public long AddAgent(Agent agent)
        {
            long iret = 0;
            if(agent == null) { return iret;}
            string sqlText = agent.idchief.HasValue ? "insert into public.agents(name, phone, email, password, idchief) values(@pname, @pphone, @email, @pwd, @ich) returning id" :
                $"insert into public.agents(name, phone, email, password) values(@pname, @pphone, @email, @pwd) returning id";
            try
            {
                iret = agent.idchief.HasValue ? m_connection.ExecuteScalar<long>(sqlText,
                    new { pname = agent.name, pphone = agent.phone, email = agent.email, pwd = agent.password, ich = agent.idchief.Value }) :
                    m_connection.ExecuteScalar<long>(sqlText,
                    new { pname = agent.name, pphone = agent.phone, email = agent.email, pwd = agent.password});

            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }

            return iret;
        }
        /// <summary>
        /// Изменить запись об агенте
        /// </summary>
        /// <param name="agent">шаблон для изменения записи</param>
        /// <returns>идентификатор изменённой записи</returns>
        public long UpdateAgent(Agent agent) 
        {
            long iret = 0;
            if (agent == null) { return iret; }
            string sqlText = "update public.agents set name = @pname, phone = @pphone, email = @email, password = @pwd, idchief = @ich where id = @ida returning id";
            try
            {
                iret = m_connection.ExecuteScalar<long>(sqlText,
                    new { ida = agent.id, pname = agent.name, pphone = agent.phone, email = agent.email, pwd = agent.password, ich = agent.idchief.GetValueOrDefault() });
                    
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }

            return iret;

        }
        /// <summary>
        /// Удалить запись об агенте
        /// </summary>
        /// <param name="ida">иденификатор записи</param>
        /// <returns>идентификатор удалённой записи</returns>
        public long DeleteAgent(long ida) 
        {
            long iret = 0;
            string sqlText = $"delete from public.agents where id = {ida} returning id";
            try
            {
                iret = m_connection.ExecuteScalar<long>(sqlText);
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
 
            return iret;
        }
        #endregion

        #region Contracts
        /// <summary>
        /// Получить список всех сделок
        /// </summary>
        /// <returns></returns>
        public async Task <List<ContractView>> GetContractList()
        {
            List<ContractView> lst = null;
            string sqlText = "select id, contract, idprincipal, principal, idagent, agent, idrealty, idchief, sail, csumma, deal_status_id, deal_status from public.contract_view order by contract";
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
        /// Выдать объект с информацией о договоре
        /// </summary>
        /// <param name="id">идке</param>
        /// <returns>Объект с информациоей о договоре</returns>
        public Contract GetContractByid(long id)
        {
            Contract contract = null;
            string sqlText = $"select id, idprincipal, idagent, idrealty, number, cdate, sail, csumma, premium, deal_status_id, content, contenttype from public.contract where id = {id}";
            try
            {
                contract = m_connection.QueryFirstOrDefault<Contract>(sqlText);
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return contract;

        }
        /// <summary>
        /// Загрузка содержания договора в БД
        /// </summary>
        /// <param name="idc">идентификатор договора</param>
        /// <param name="content">содержание договора</param>
        /// <param name="type">расширение загружаемого файла</param>
        /// <returns>идентификатор договора с загруженным содержанием</returns>
        public async Task<long> UploadContractContent(long idc, byte[] content, string type )
        {
            long id = 0;
            string sqlText = "updare public.contract set content = @cnt, contenttype = @ptype where id = @pid returning id";
            try
            {
                id = await m_connection.ExecuteScalarAsync<long>(sqlText, new {@cnt = content, @pid = idc, ptype = type});
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return id;

        }
        /// <summary>
        /// Добавить запись о договоре
        /// </summary>
        /// <param name="contract">шабло с данными</param>
        /// <returns>идентификатор добавленной записи</returns>
        public long AddContract(Contract contract)
        {
            long id = 0;
            string sdate = contract.cdate.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlText = contract.content[0] == '\x00' ? $"insert into public.realty (idprincipal, idagent,idrealty, number, cdate, sail, csumma, premium, deal_status_id) "+
                " values (@pidprincipal, @pidagent, @pidrealty, @pnum, '{sdate}', @psail, @psum,@pp, @pids) returning id" :
                $"insert into public.realty (idprincipal, idagent,idrealty, number, cdate, sail, csumma, premium, deal_status_id, content, contenttype) " +
                " values (@pidprincipal, @pidagent, @pidrealty, @pnum, '{sdate}', @psail, @psum,@pp, @pids, @pcontent, @ctype) returning id";
            try
            {
                object parm = null;
                if (contract.content[0] == '\x00')
                    parm = new
                    {
                        pidprincipal = contract.idprincipal,
                        pidagent = contract.idagent,
                        pidrealty = contract.idrealty,
                        pnum = contract.number,
                        psail = contract.sail,
                        psum = contract.csumma,
                        pp = contract.premium,
                        pids = contract.deal_status_id
                    };
                else
                    parm = new
                    {
                        pidprincipal = contract.idprincipal,
                        pidagent = contract.idagent,
                        pidrealty = contract.idrealty,
                        pnum = contract.number,
                        psail = contract.sail,
                        psum = contract.csumma,
                        pp = contract.premium,
                        pids = contract.deal_status_id,
                        pcontent = contract.content,
                        ctype = contract.contenttype
                    };
                id = m_connection.Execute(sqlText, parm); 
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return id;
        }
        /// <summary>
        /// Изменение записи о договоре
        /// </summary>
        /// <param name="contract">шаблон с данными об изменении записи</param>
        /// <returns>идентификатор изменённой записи</returns>
        public long UpdateContract(Contract contract)
        {
            long id = 0;
            string sdate = contract.cdate.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlText = contract.content[0] == '\x00' ? $"update public.realty set idprincipal = @pidprincipal, idagent = @pidagent,idrealty = @pidrealty, number = @pnum, cdate = '{sdate}'," +
                " sail = @psail, csumma = @psum, premium = @pp, deal_status_id = @pids where id = @pid returning id" :
                $"update public.realty set idprincipal = @pidprincipal, idagent = @pidagent,idrealty = @pidrealty, number = @pnum, cdate = '{sdate}'," +
                " sail = @psail, csumma = @psum, premium = @pp, deal_status_id = @pids, content = @pc, contenttype = @ptype where id = @pid returning id";
            try
            {
                object parms = null;
                if (contract.content[0] == '\x00')
                    parms = new
                    {
                        pid = contract.id,
                        pidprincipal = contract.idprincipal,
                        pidagent = contract.idagent,
                        pidrealty = contract.idrealty,
                        pnum = contract.number,
                        psail = contract.sail,
                        psum = contract.csumma,
                        pp = contract.premium,
                        pids = contract.deal_status_id
                    };
                else
                    parms = new
                    {
                        pid = contract.id,
                        pidprincipal = contract.idprincipal,
                        pidagent = contract.idagent,
                        pidrealty = contract.idrealty,
                        pnum = contract.number,
                        psail = contract.sail,
                        psum = contract.csumma,
                        pp = contract.premium,
                        pids = contract.deal_status_id,
                        pc = contract.content,
                        ptype = contract.contenttype
                    };
                id = m_connection.Execute(sqlText,parms);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return id;

        }
        /// <summary>
        /// Удалить запись о договоре
        /// </summary>
        /// <param name="idc">идкентификатор удаляемого договора</param>
        /// <returns>идентификатор удалённого договора</returns>
        public long DeleteContract(long idc) 
        {
            long id = 0;
            string sqlText = $"delete from public.realty where id = {idc} returning id";
            try
            {
                id = m_connection.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return id;

        }
        #endregion

        #region Realty
        /// <summary>
        /// Получить список объектов недвижимости
        /// </summary>
        /// <returns></returns>
        public async Task<List<RealtyObject>> GetRealtyObjects()
        {
            List<RealtyObject> lst = null;
            string sqlText = "select id, address, full_square, room_count, mortage, secondary, repair, rsumma from public.realty order by address";
            try
            {
                var t = await m_connection.QueryAsync<RealtyObject>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return lst;

        }
        /// <summary>
        /// Возврат объекта недвижимости
        /// </summary>
        /// <param name="idobject">идентификатор записи в БД</param>
        /// <returns>объект недвижимости</returns>
        public RealtyObject GetRealtyObjectById(long idobject)
        {
            RealtyObject realty = null;
            string sqlText = $"select id, address, full_square, room_count, mortage, secondary, repair, rsumma from public.realty where id = {idobject}";
            try
            {
                realty = m_connection.QueryFirstOrDefault<RealtyObject>(sqlText);   
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return realty;
        }
        /// <summary>
        /// Добавить запись об объекте недвижимости
        /// </summary>
        /// <param name="realty">шаблон объекта с данными</param>
        /// <returns>идентификатор вставленной записи</returns>
        public long AddRealtyObject(RealtyObject realty)
        {
            long id = 0;
            string sqlText = $"insert into public.realty (address, full_square, room_count, mortage, secondary, repair, rsumma) " +
                "values(@padr, @psquare, @pcount, @pm, @ps, @pr, @psum) returning id";
            try
            {
                id = m_connection.ExecuteScalar<long>(sqlText,
                    new { padr = realty.address, psquare = realty.full_square, pcount = realty.room_count, 
                        pm = realty.mortage, ps = realty.secondary, pr = realty.repair, psum = realty.rsumma });
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return id;
        }
        /// <summary>
        /// Изменить объект недвижимости
        /// </summary>
        /// <param name="realty">шаблон объекта недвижимости для изменения</param>
        /// <returns>идентификатор изменённой записи</returns>
        public long UpdateRealtyObject(RealtyObject realty)
        {
            long id = 0;
            string sqlText = $"update public.realty set address = @padr, full_square = @psquare, room_count = @pcount, mortage = @pm, secondary = @ps, repair = @pr, rsumma = @psum " +
                "where id = @pid returning id";
            try
            {
                id = m_connection.ExecuteScalar<long>(sqlText,
                    new
                    {
                        pid = realty.id,
                        padr = realty.address,
                        psquare = realty.full_square,
                        pcount = realty.room_count,
                        pm = realty.mortage,
                        ps = realty.secondary,
                        pr = realty.repair,
                        psum = realty.rsumma
                    });
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return id;

        }
        /// <summary>
        /// Удалить запись об объекте недвижимости
        /// </summary>
        /// <param name="idr">идентификатор записи</param>
        /// <returns>идентификатор удалённой записи</returns>
        public long DeleteRealtyObject(long idr)
        {
            long id = 0;
            string sqlText = $"delete from public.realty where id = @pid returning id";
            try
            {
                id = m_connection.ExecuteScalar<long>(sqlText,
                    new
                    {
                        pid = idr
                    });
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return id;

        }
        #endregion

        #region Principal
        /// <summary>
        /// Получить список принципалов
        /// </summary>
        /// <returns></returns>
        public async Task<List<Principal>> GetPrincipals()
        {
            List<Principal> lst = null;
            string sqlText = "select id, name, phone, email, address, passport, inn, kpp, ogrn from public.principals order by name";
            try
            {
                var t = await m_connection.QueryAsync<Principal>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {

                m_errorText = ex.Message;
            }
            return lst;

        }

        /// <summary>
        /// Возврат объекта принципала по его идентификатору
        /// </summary>
        /// <param name="idobject">идентификатор записи в БД</param>
        /// <returns>объект принципала</returns>
        public Principal GetPrincipalById(long idobject)
        {
            Principal pr = null;
            string sqlText = $"select id, name, inn, kpp, ogrn, address, passport, phone, email from public.principals where id = {idobject}";
            try
            {
                pr = m_connection.QueryFirstOrDefault<Principal>(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return pr;
        }
        /// <summary>
        /// Добавить запись о принципале
        /// </summary>
        /// <param name="pr">шаблон объекта с данными</param>
        /// <returns>идентификатор вставленной записи</returns>
        public long AddPrincipal(Principal pr)
        {
            long id = 0;
            string sqlText = $"insert into public.principals (name, inn, kpp, ogrn, address, passport, phone, email) " +
                "values(@pname, @pinn, @pkpp, @pogrn, @paddress, @ppass, @pphone, @pemail) returning id";
            try
            {
                id = m_connection.ExecuteScalar<long>(sqlText,
                    new
                    {
                        pname = pr.name,
                        pinn = pr.inn,
                        pkpp = pr.kpp,
                        pogrn = pr.ogrn,
                        paddress = pr.address,
                        ppass= pr.passport,
                        pphone = pr.phone,
                        pemail = pr.email
                    });
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return id;
        }
        /// <summary>
        /// Изменить запись о принципале
        /// </summary>
        /// <param name="pr">шаблон объекта с данными</param>
        /// <returns>идентификатор вставленной записи</returns>
        public long UpdatePrincipal(Principal pr)
        {
            long id = 0;
            string sqlText = $"update public.principals set name = @pname, inn = @pinn, kpp = @pkpp, ogrn = @pogrn, address = @paddress, passport = @ppass, phone = @pphone, email = @pemail " +
                "where id = @pid returning id";
            try
            {
                id = m_connection.ExecuteScalar<long>(sqlText,
                    new
                    {
                        pid = pr.id,
                        pname = pr.name,
                        pinn = pr.inn,
                        pkpp = pr.kpp,
                        pogrn = pr.ogrn,
                        paddress = pr.address,
                        ppass = pr.passport,
                        pphone = pr.phone,
                        pemail = pr.email
                    });
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return id;
        }
        /// <summary>
        /// Удалить запись о принципале
        /// </summary>
        /// <param name="pr">шаблон объекта с данными</param>
        /// <returns>идентификатор удалённой записи</returns>
        public long DeletePrincipal(long idp)
        {
            long id = 0;
            string sqlText = $"delete from public.principals where id = @pid returning id";
            try
            {
                id = m_connection.ExecuteScalar<long>(sqlText,
                    new
                    {
                        pid = idp
                    });
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return id;
        }

        #endregion
    }
}
