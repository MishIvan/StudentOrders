using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Runtime.Versioning;
using System.Windows.Forms;

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
        /// <returns>список с данными врачей</returns>
        public async Task<List<Doctor>> GetDoctors()
        {
            List<Doctor> lst = null;
            string sqlText = "select id, name, idspeciality, idhospital from dbo.doctors order by name"; 
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

    }
}
