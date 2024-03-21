using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Runtime.Versioning;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Collections;
using System.Xml.Linq;

namespace DisabilityList
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
        /// Получить список кодов причины нетрудоспособности
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public async Task<List<Code>> GetCodes(int type = 1)
        {
            List<Code> lst = null;
            string tableName = string.Empty;
            switch(type)
            {
                case 1:
                    tableName = "dbo.BaseCodes"; break;
                case 2:
                    tableName = "dbo.AddCodes"; break;
                case 3:
                    tableName = "dbo.RelativeCodes"; break;
                default:
                    return lst;

            }
            string sqlText = $"select code, name from {tableName} order by code";
            try
            {
                var t = await conn.QueryAsync<Code>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;

        }
        /// <summary>
        /// Получить список листков нетрудоспособности
        /// </summary>
        /// <returns></returns>
        public async Task<List<DisabilityListView>> GetDiasabilityListsForView()
        {
            List<DisabilityListView> lst = null;
            string sqlText = "select id, delivery_date, date_from, date_to, patient, hospital from dbo.list_view order by delivery_date";
            try
            {
                var t = await conn.QueryAsync<DisabilityListView>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;

        }
        /// <summary>
        /// Получить список освобождений от работы для листка нетрудоспособности по его идентификатору
        /// </summary>
        /// <param name="idl">идентификатор листка для получения списка</param>
        /// <returns></returns>
        public async Task<List<FreeRecordView>> GetFreeFromWorkList(long idl) 
        {
            List <FreeRecordView> lst = null;
            string sqlText = "select idlist, relative_code,datefrom, dateto, idpatient, patient, " +
                "iddoctor, doctor, idhospital, speciality from dbo.free_list_view where idlist = @pid";
            try
            {
                var t = await conn.QueryAsync<FreeRecordView>(sqlText, new {pid = idl});
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;

        }

        /// <summary>
        /// Добавить запись о листке нетрудоспособности
        /// </summary>
        /// <param name="dlist">объект с данными листка нетрудоспособности</param>
        /// <param name="frl">таблица с записями об освобождении от работы</param>
        /// <returns></returns>
        public int AddDisabilityList(DisabilityListWithContent dlist, List<FreeRecordView> frl)
        {
            int nrec = 0;
            try
            {
                string ddt = dlist.delivery_date.ToString("yyyyMMdd");
                string sqlText = "insert into dbo.list_headers (delivery_date, reason_code, add_reason_code,idhospital, idpatient, regnum, code_sub,"+
                    "time_service, salary, list_content,  content_type) "
                    +$"values('{ddt}', @pcode, @paddcode, @pidhospital, @pidpatient, @pregnum, @pcs, @pts, @ps, @plc, @pct)";
                conn.Execute("set identity_insert dbo.free_list on");
                using (var tran = conn.BeginTransaction())
                {
                    nrec = conn.Execute(sqlText, transaction: tran, 
                        param: new { pcode = dlist.reason_code, paddcode = dlist.add_reason_code, 
                            pidhospital = dlist.idhospital, pidpatient = dlist.idpatient, 
                            pregnum = dlist.regnum, pcs = dlist.code_sub, 
                            pts = dlist.time_service, ps = dlist.salary, 
                            plc = dlist.list_content, pct = dlist.content_type });
                    if (nrec > 0)
                    {
                        long idlist = conn.QueryFirstOrDefault<long>("select ident_current('dbo.list_headers')", transaction: tran);
                        foreach (var el in frl)
                        {
                            string dd1 = el.datefrom.ToString("yyyyMMdd");
                            string dd2 = el.dateto.ToString("yyyyMMdd");
                            sqlText = $"insert into dbo.free_list (idlist, relative_code, idpatient, datefrom, dateto , iddoctor) "+
                                $" values (@pidlist, @prc, @pidpatient,'{dd1}', '{dd2}', @piddoctor)";
                            nrec = conn.Execute(sqlText, transaction: tran,
                                param: new { pidlist = idlist, prc = el.relative_code, 
                                    pidpatient = el.idpatient, piddoctor =el.iddoctor  });

                        }
                        tran.Commit();
                    }
                    else
                        tran.Rollback();
                }
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
                nrec = 0;
            }
            return nrec;
        }

        /// <summary>
        /// Изменить данные записи о листке нетрудоспособности
        /// </summary>
        /// <param name="dlist">объект с данными листка нетрудоспособности</param>
        /// <param name="frl">таблица с записями об освобождении от работы</param>
        /// <returns></returns>
        public int UpdateDisabilityList(DisabilityListWithContent dlist, List<FreeRecordView> frl)
        {
            int nrec = 0;
            try
            {
                string ddt = dlist.delivery_date.ToString("yyyyMMdd");
                string sqlText = $"update dbo.list_headers set delivery_date = '{ddt}', reason_code = @pcode, add_reason_code = @paddcode, " +
                    "idhospital = @pidhospital, idpatient = @pidpatient, regnum = @pregnum, code_sub = @pcs, " +
                    "time_service = @pts, salary = @ps, list_content = @plc,  content_type = @pct) where id = @pid";
                conn.Execute("set identity_insert dbo.free_list on");
                using (var tran = conn.BeginTransaction())
                {
                    nrec = conn.Execute(sqlText, transaction: tran,
                        param: new
                        {
                            pid = dlist.id,
                            pcode = dlist.reason_code,
                            paddcode = dlist.add_reason_code,
                            pidhospital = dlist.idhospital,
                            pidpatient = dlist.idpatient,
                            pregnum = dlist.regnum,
                            pcs = dlist.code_sub,
                            pts = dlist.time_service,
                            ps = dlist.salary,
                            plc = dlist.list_content,
                            pct = dlist.content_type
                        });
                    if (nrec > 0)
                    {

                        nrec = conn.Execute($"delete from dbo.free_list where idlist = {dlist.id}", transaction: tran);
                        foreach (var el in frl)
                        {
                            string dd1 = el.datefrom.ToString("yyyyMMdd");
                            string dd2 = el.dateto.ToString("yyyyMMdd");
                            sqlText = $"insert into dbo.free_list (idlist, relative_code, idpatient, datefrom, dateto , iddoctor) " +
                                $" values (@pidlist, @prc, @pidpatient,'{dd1}', '{dd2}', @piddoctor)";
                            nrec = conn.Execute(sqlText, transaction: tran,
                                param: new
                                {
                                    pidlist = el.idlist,
                                    prc = el.relative_code,
                                    pidpatient = el.idpatient,
                                    piddoctor = el.iddoctor
                                });

                        }
                        tran.Commit();
                    }
                    else
                        tran.Rollback();
                }
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
                nrec = 0;
            }
            return nrec;
        }

        /// <summary>
        /// Удалить данные о листке нетрудоспособности
        /// </summary>
        /// <param name="id">идентификатор листка нетрудоспособности</param>
        /// <returns></returns>
        public int DeleteDisabilityList(long id)
        {
            int recs = 0;
            string sqlText = "delete from dbo.list_headers where id  = @pid";
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
        /// Выдать спиcок лечебных учреждений
        /// </summary>
        /// <returns>список объектов с данными о лечебных учреждениях</returns>
        public async Task<List<Hospital>> GetHospitals()
        {
            List<Hospital> lst = null;
            string sqlText = "select id, name, address, govregnum from dbo.hospitals order by name";
            try
            {
                var t = await conn.QueryAsync<Hospital>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;
        }

        /// <summary>
        /// Добавить запись в лечебных учреждений
        /// </summary>
        /// <param name="hosp">даные для добавления записи</param>
        /// <returns>1 - если запись добавлена, иначе - 0</returns>
        public int AddHospital(Hospital hosp)
        {
            int recs = 0;
            string sqlText = "insert into dbo.hospitals (name, address, govregnum) values(@pname, @padr, @pnum)";
            try
            {
                recs = conn.Execute(sqlText, new { pname = hosp.name, padr = hosp.address, pnum = hosp.govregnum });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }

        /// <summary>
        /// Изменить запись о лечебном учреждении
        /// </summary>
        /// <param name="hosp">даные для добавления записи</param>
        /// <returns>1 - если запись изменена, иначе - 0</returns>
        public int UpdateHospital(Hospital hosp)
        {
            int recs = 0;
            string sqlText = "update dbo.hospitals set name = @pname, address = @padr, govregnum = @pnum where id  = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = hosp.id, pname = hosp.name, padr = hosp.address, pnum = hosp.govregnum });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }

        /// <summary>
        /// Удалить запись о лечебном учреждении
        /// </summary>
        /// <param name="id">идентификатор записи</param>
        /// <returns>1 - если запись удалена, иначе - 0</returns>
        public int DeleteHospital(long id)
        {
            int recs = 0;
            string sqlText = "delete from dbo.hospitals where id  = @pid";
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
        /// Получить список врачебных специальностей
        /// </summary>
        /// <returns>список с данными о врачебных специальностей</returns>
        public async Task<List<Simple>> GetDoctorSpecialities()
        {
            List<Simple> lst = null;
            string sqlText = "select id, name from dbo.specialities order by name";
            try
            {
                var t = await conn.QueryAsync<Simple>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;

        }


        /// <summary>
        /// Получить список врачей
        /// </summary>
        /// <param name="idhosp">Идентификатор лечебного учреждения для отбора врачей</param>
        /// <returns>список с данными врачей</returns>
        public async Task<List<Doctor>> GetDoctors(long idhosp = 0)
        {
            List<Doctor> lst = null;
            string sqlText = "select id, name, idspeciality, idhospital from dbo.doctors";
            sqlText += idhosp <= 0 ? string.Empty : $" where idhospital = {idhosp}";
            sqlText += " order by name";
            try
            {
                var t = await conn.QueryAsync<Doctor>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;

        }

        /// <summary>
        /// Получить список врачей для отображения
        /// </summary>
        /// <param name="idhosp">Идентификатор лечебного учреждения для отбора врачей</param>
        /// <returns>список с данными врачей</returns>
        public async Task<List<DoctorView>> GetDoctorsForView(long idhosp = 0)
        {
            List<DoctorView> lst = null;
            string sqlText = "select id, doct_name, idhospital, speciality from dbo.doctors_view";
            sqlText += idhosp <= 0 ? string.Empty : $" where idhospital = {idhosp}";
            sqlText += " order by doct_name";
            try
            {
                var t = await conn.QueryAsync<DoctorView>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;

        }


        /// <summary>
        /// Добавить запись о враче
        /// </summary>
        /// <param name="doct">Объект с данными для добавления</param>
        /// <returns>1 - если запись добавлена, иначе - 0</returns>
        public int AddDoctor(Doctor doct)
        {
            int recs = 0;
            string sqlText = "insert into dbo.doctors (name,idspeciality, idhospital) values(@pname, @pidspec, @pidhosp)";
            try
            {
                recs = conn.Execute(sqlText, new { pname = doct.name, pidspec = doct.idspeciality, pidhosp = doct.idhospital });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }

        /// <summary>
        /// Изменить запись о враче
        /// </summary>
        /// <param name="svc">Объект с данными для изменения</param>
        /// <returns>1 - если запись изменена, иначе - 0</returns>
        public int UpdateDoctor(Doctor doct)
        {
            int recs = 0;
            string sqlText = "update dbo.doctors set name = @pname, idspeciality = @pidspec, idhospital = @pidhosp where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = doct.id, pname = doct.name, pidspec = doct.idspeciality, pidhosp = doct.idhospital });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }

        /// <summary>
        /// Удалить запись о враче
        /// </summary>
        /// <param name="id">идентификатор удаляемой записи</param>
        /// <returns>1 - если запись удалена, иначе - 0</returns>
        public int DeleteDoctor(long id)
        {
            int recs = 0;
            string sqlText = "delete from dbo.doctors where id = @pid";
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
        /// Выдать список пациентов и их родвтсенников
        /// </summary>
        /// <returns></returns>
        public async Task<List<Patient>> GetPatients()
        {
            List<Patient> lst = null;
            string sqlText = "select id, name, birth_date, inn, snils, passport from dbo.patients order by name";
            try
            {
                var t = await conn.QueryAsync<Patient>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;

        }

        /// <summary>
        /// Добавить запись о пациенте или его родственнике
        /// </summary>
        /// <param name="p">объект с данными о пациенте или его родственнике</param>
        /// <returns>1 - если запись добавлена, 0 - иначе</returns>
        public int AddPatient(Patient p)
        {
            int recs = 0;
            string sdt = p.birth_date.ToString("yyyyMMdd");
            string sqlText = $"insert into dbo.patients (name, birth_date, inn, snils, passport) values(@pname, '{sdt}', @pinn, @psnils, @ppas)";
            try
            {
                recs = conn.Execute(sqlText, new { pname = p.name, pinn = p.inn, psnils = p.snils, ppas = p.passport });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }

        /// <summary>
        /// Изменить данные записи о визите
        /// </summary>
        /// <param name="vis">объект с данными о визите</param>
        /// <returns>1 - если запись изменена, 0 - иначе</returns>
        public int UpdatePatient(Patient p)
        {
            int recs = 0;
            string sdt = p.birth_date.ToString("yyyyMMdd");
            string sqlText = $"update dbo.patients set name = @pname, birth_date = '{sdt}', inn = @pinn, snils = @psnils, passport = @ppas where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, 
                    new { pid = p.id, pname = p.name, pinn = p.inn, psnils = p.snils, ppas = p.passport });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;

        }

        /// <summary>
        /// Удалить запись о пациенте или его родственнике
        /// </summary>
        /// <param name="id">идентификатор удаляемой записи</param>
        /// <returns>1 - если запись удалена, 0 - иначе</returns>
        public int DeletePatient(long id)
        {
            int recs = 0;
            string sqlText = "delete from dbo.patients where id = @pid";
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
        /// Получить данные листка нетрудоспособности по идентификатору
        /// </summary>
        /// <param name="id">идентификатор в БД</param>
        /// <returns>объект с данными</returns>
        public DisabilityListWithContent GetDisalbilityListByID(long id)
        {
            DisabilityListWithContent dl = null;
            string sqlText = "select id, name,delivery_date, reason_code, add_reason_code, idhospital, idpatient, " + 
                "regnum, code_sub, time_service, salary, list_content, content_type from dbo.list_headers where id = @pid";
                try
                {
                    dl = conn.QueryFirstOrDefault<DisabilityListWithContent>(sqlText, new { pid = id});
                }
                catch (Exception ex)
                {
                    _errorText = ex.Message;
                }
                return dl;
        }


    }
}
