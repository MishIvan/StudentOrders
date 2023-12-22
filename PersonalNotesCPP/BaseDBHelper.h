#pragma once
using namespace System;
using namespace System::Collections::Generic;
using namespace System::Data::SQLite;
using namespace System::Linq;
using namespace System::Text;
using namespace System::Threading::Tasks;
using namespace System::Windows::Forms;
#include "Models.h"

namespace CppCLRWinFormsProject {
    /// <summary>
    /// ������� ����� ��� ������ � ����� ������
    /// �������� � �������� ����������
    /// �������� �������� ���� ������, �������� ����������
    /// </summary>

    ref class BaseDBHelper
    {
        protected:
            SQLiteConnection^ m_conn; // ������ ����������
            String^ m_errorText; // ������ � �������
        public:
            // ������ ������
            String^ getErrorText() { return m_errorText; }
            // ������� ��  ����������
            bool isOpen() { return m_conn->State == System::Data::ConnectionState::Open; }
            BaseDBHelper(String^ dataFileName);
            virtual ~BaseDBHelper();
    };

    ref class DBHelper : BaseDBHelper
    {
    public:
        /// <summary>
        /// ����������� ����� �� BaseDBHelper ��� ���������� �������
        /// ��������� �������, ���������, ���������, �������� ������
        /// </summary>
        DBHelper(String^ dataFileName) : BaseDBHelper(dataFileName)
        {

        }
        List<AddressBook^>^ GetAddressData(String^ letter);


    };

}
/*

/// ������ ��� ������ � ����� ������
/// �������� � �������� ����������, ��������� ���������� �� �������
/// ����������, ��������� � �������� ������� � �������� ������

namespace PersonalNotes
{
    class DBHelper : BaseDBHelper
    {
        public DBHelper(string dataFileName) : base(dataFileName)
        {

        }

        /// <summary>
        /// ������ ������ �������
        /// </summary>
        /// <returns>������ ��������, ������������� �������</returns>
        public async Task<List<AddressBook>> GetAddressData(string letter = "")
        {
            List<AddressBook> lst = null;
            string sqlText = string.IsNullOrEmpty(letter) ? "select id, name, birth_date, phone, address, comments from address_book order by name" :
                $"select id, name, birth_date, phone, address, comments from address_book where substr(name,1,1) = '{letter}' order by name";
            try
            {
                var task = await m_conn.QueryAsync<AddressBook>(sqlText);
                lst = task.ToList();
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// ���������� ������ �� �������� ����� �� ��������������
        /// </summary>
        /// <param name="idrec"></param>
        /// <returns></returns>
        public AddressBook GetAddressDataRecord(long idrec)
        {
            AddressBook rec = null;
            string sqlText = $"select id, name, birth_date, phone, address, comments from address_book where id ={idrec}";
            try
            {
                rec = m_conn.QueryFirstOrDefault<AddressBook>(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }

            return rec;
        }
        /// <summary>
        /// �������� ������ � �������� ������
        /// </summary>
        /// <param name="rec">��������� ��� ���������� ������</param>
        /// <returns>����� ����������� �������</returns>
        public int AddAddressRecord(AddressBook rec)
        {
            int recs = 0;
            string sdate = rec.birth_date.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlText = $"insert into address_book(name, phone, birth_date, address,comments) values('{rec.name}', '{rec.phone}', '{sdate}', '{rec.address}', '{rec.comments}')";
            try
            {
                recs = m_conn.Execute(sqlText);
            }
            catch(Exception ex)
            {
                m_errorText = ex.Message;
            }

            return recs;
        }
        /// <summary>
        /// �������� ������ � �������� ������ �� �������
        /// </summary>
        /// <param name="rec">������, ������ ��� ��������� ������</param>
        /// <returns></returns>
        public int UpdateAdressRecord(AddressBook rec)
        {
            int recs = 0;
            string sdate = rec.birth_date.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlText = $"update address_book set name = '{rec.name}', phone = '{rec.phone}', birth_date = '{sdate}', address = '{rec.address}',comments = '{rec.comments}' where id = {rec.id}";
            try
            {
                recs = m_conn.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }

            return recs;
        }
        /// <summary>
        /// �������� ������ � �������� ������
        /// </summary>
        /// <param name="id">������������� ��������� ������</param>
        /// <returns></returns>
        public int DeleteAddressRecord(long id)
        {
            int recs = 0;
            string sqlText = $"delete from address_book where id = {id}";
            try
            {
                recs = m_conn.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }

            return recs;

        }
        /// <summary>
        /// ������ ������ ������� � �������� ������
        /// </summary>
        /// <returns>������ ��������, ������������� �������</returns>
        public async Task<List<Note>> GetNotes()
        {
            List<Note> lst = null;
            string sqlText = "select id, note_datetime, comments from notes order by note_datetime";
            try
            {
                var task = await m_conn.QueryAsync<Note>(sqlText);
                lst = task.ToList();
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }
            return lst;
        }
        /// <summary>
        /// ���������� ������ �� ������� �� ��������������
        /// </summary>
        /// <param name="idrec"></param>
        /// <returns></returns>
        public Note GetNotesDataRecord(long idrec)
        {
            Note rec = null;
            string sqlText = $"select id, note_datetime, comments from notes where id ={idrec}";
            try
            {
                rec = m_conn.QueryFirstOrDefault<Note>(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }

            return rec;
        }

        /// <summary>
        /// �������� ������ � �������
        /// </summary>
        /// <param name="rec">��������� ��� ���������� ������</param>
        /// <returns>����� ����������� �������</returns>
        public int AddNoteRecord(Note rec)
        {
            int recs = 0;
            string sdate = rec.note_datetime.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlText = $"insert into notes(note_datetime,comments) values( '{sdate}', '{rec.comments}')";
            try
            {
                recs = m_conn.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }

            return recs;
        }
        /// <summary>
        /// �������� ������ �� �������
        /// </summary>
        /// <param name="rec">������, ������ ��� ��������� ������</param>
        /// <returns></returns>
        public int UpdateNotesRecord(Note rec)
        {
            int recs = 0;
            string sdate = rec.note_datetime.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlText = $"update notes set note_datetime = '{sdate}', comments = '{rec.comments}' where id = {rec.id}";
            try
            {
                recs = m_conn.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }

            return recs;
        }
        /// <summary>
        /// �������� ������ � �������� ������
        /// </summary>
        /// <param name="id">������������� ��������� ������</param>
        /// <returns></returns>
        public int DeleteNotesRecord(long id)
        {
            int recs = 0;
            string sqlText = $"delete from notes where id = {id}";
            try
            {
                recs = m_conn.Execute(sqlText);
            }
            catch (Exception ex)
            {
                m_errorText = ex.Message;
            }

            return recs;

        }

    }
}

*/

