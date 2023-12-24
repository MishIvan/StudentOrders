#include "pch.h"
#include "BaseDBHelper.h"

using namespace CppCLRWinFormsProject;

/// <summary>
/// ������� ������ ���������� � ������� ������� ����������
/// </summary>
/// <param name="dataFileName"></param>
BaseDBHelper::BaseDBHelper(String^ dataFileName)
{
    m_errorText = String::Empty;
    try
    {
        SQLiteFactory^ factory = gcnew SQLiteFactory;
        m_conn = (SQLiteConnection^)factory->CreateConnection();
        m_conn->ConnectionString = String::Format(L"Data Source={0}; Version=3;", dataFileName);
        m_conn->Open();
    }
    catch (Exception^ ex)
    {
        m_errorText = ex->Message;
    }
}
/// <summary>
///  ������� �������� ����������
/// </summary>
BaseDBHelper::~BaseDBHelper()
{
    if (isOpen()) m_conn->Close();
}

List<AddressBook^>^ DBHelper::GetAddressData(String^ letter)
{
    List<AddressBook^>^ lst = nullptr;
    String^ sqlText = String::IsNullOrEmpty(letter) ? L"select id, name, birth_date, phone, address, comments from address_book order by name" :
        String::Format(L"select id, name, birth_date, phone, address, comments from address_book where substr(name,1,1) = '{0}' order by name", letter);
    try
    {
        SQLiteCommand^ cmd = m_conn->CreateCommand();
        cmd->CommandText = sqlText;
        SQLiteDataReader^ reader = cmd->ExecuteReader();
        lst = gcnew List<AddressBook^>();
        while (reader->Read())
        {
            AddressBook^ bk = gcnew AddressBook;
            bk->id = Convert::ToInt64(reader["id"]); 
            bk->name = reader["name"]->ToString();
            bk->birth_date = Convert::ToDateTime(reader["birth_date"]);
            bk->phone = reader["phone"]->ToString();
            bk->address = reader["address"]->ToString();
            bk->comments = reader["comments"]->ToString();
            lst->Add(bk);
        }
        reader->Close();
        
    }       
    catch (Exception^ ex)
    {
        m_errorText = ex->Message;
    }
    return lst;

}
/// <summary>
/// ���������� ������ �� �������� ����� �� ��������������
/// </summary>
/// <param name="idrec"></param>
/// <returns></returns>
AddressBook^ DBHelper::GetAddressDataRecord(long idrec)
{
    AddressBook^ bk = nullptr;
    String^ sqlText = String::Format("select id, name, birth_date, phone, address, comments from address_book where id ={0}", idrec);
    try
    {
        SQLiteCommand^ cmd = m_conn->CreateCommand();
        cmd->CommandText = sqlText;
        SQLiteDataReader^ reader = cmd->ExecuteReader();
        while (reader->Read())
        {
            bk = gcnew AddressBook;
            bk->id = Convert::ToInt64(reader["id"]);
            bk->name = reader["name"]->ToString();
            bk->birth_date = Convert::ToDateTime(reader["birth_date"]);
            bk->phone = reader["phone"]->ToString();
            bk->address = reader["address"]->ToString();
            bk->comments = reader["comments"]->ToString();
        }
        reader->Close();

    }
    catch (Exception^ ex)
    {
        m_errorText = ex->Message;
    }

    return bk;
}

/// <summary>
/// �������� ������ � �������� ������
/// </summary>
/// <param name="rec">��������� ��� ���������� ������</param>
/// <returns>����� ����������� �������</returns>
int DBHelper::AddAddressRecord(AddressBook^ rec)
{
    int recs = 0;
    String^ sdate = rec->birth_date->ToString("yyyy-MM-dd HH:mm:ss");
    String^ sqlText = String::Format("insert into address_book(name, phone, birth_date, address,comments) values('{0}', '{1}', '{2}', '{3}', '{4}')",
        rec->name, rec->phone, sdate, rec->address, rec->comments);
    try
    {
        SQLiteCommand^ cmd = m_conn->CreateCommand();
        cmd->CommandText = sqlText;
        recs = cmd->ExecuteNonQuery();
    }
    catch (Exception^ ex)
    {
        m_errorText = ex->Message;
    }

    return recs;
}
/// <summary>
/// �������� ������ � �������� ������ �� �������
/// </summary>
/// <param name="rec">������, ������ ��� ��������� ������</param>
/// <returns></returns>
int DBHelper::UpdateAdressRecord(AddressBook^ rec)
{
    int recs = 0;
    String^ sdate = rec->birth_date->ToString("yyyy-MM-dd HH:mm:ss");
    String^ sqlText = String::Format("update address_book set name = '{0}', phone = '{1}', birth_date = '{2}', address = '{3}',comments = '{4}' where id = {5}",
        rec->name, rec->phone, sdate,rec->address, rec->comments, rec->id);
    try
    {
        SQLiteCommand^ cmd = m_conn->CreateCommand();
        cmd->CommandText = sqlText;
        recs = cmd->ExecuteNonQuery();
    }
    catch (Exception^ ex)
    {
        m_errorText = ex->Message;
    }

    return recs;
}
/// <summary>
/// �������� ������ � �������� ������
/// </summary>
/// <param name="id">������������� ��������� ������</param>
/// <returns></returns>
int DBHelper::DeleteAddressRecord(long id)
{
    int recs = 0;
    String^ sqlText = String::Format("delete from address_book where id = {0}",id);
    try
    {
        SQLiteCommand^ cmd = m_conn->CreateCommand();
        cmd->CommandText = sqlText;
        recs = cmd->ExecuteNonQuery();
    }
    catch (Exception^ ex)
    {
        m_errorText = ex->Message;
    }

    return recs;

}
/// <summary>
/// ������ ������ ������� � �������� ������
/// </summary>
/// <returns>������ ��������, ������������� �������</returns>
List<Note^>^ DBHelper::GetNotes()
{
    List<Note^>^ lst = nullptr;
    String^ sqlText = "select id, note_datetime, comments from notes order by note_datetime";
    try
    {
        SQLiteCommand^ cmd = m_conn->CreateCommand();
        cmd->CommandText = sqlText;
        SQLiteDataReader^ reader = cmd->ExecuteReader();
        lst = gcnew List<Note^>;
        while (reader->Read())
        {
            Note^ note = gcnew Note;
            note->id = Convert::ToInt64(reader["id"]);
            note->note_datetime = Convert::ToDateTime(reader["note_datetime"]);
            note->comments = reader["comments"]->ToString();
            lst->Add(note);
        }
        reader->Close();
    }
    catch (Exception^ ex)
    {
        m_errorText = ex->Message;
    }
    return lst;
}

/// <summary>
/// ���������� ������ �� ������� �� ��������������
/// </summary>
/// <param name="idrec"></param>
/// <returns></returns>
Note^ DBHelper::GetNotesDataRecord(long idrec)
{
    Note^ note = nullptr;
    String^ sqlText = String::Format("select id, note_datetime, comments from notes where id ={0}",idrec);
    try
    {
        SQLiteCommand^ cmd = m_conn->CreateCommand();
        cmd->CommandText = sqlText;
        SQLiteDataReader^ reader = cmd->ExecuteReader();
        while (reader->Read())
        {
            note = gcnew Note;
            note->id = Convert::ToInt64(reader["id"]);
            note->note_datetime = Convert::ToDateTime(reader["note_datetime"]);
            note->comments = reader["comments"]->ToString();
        }
        reader->Close();
    }
    catch (Exception^ ex)
    {
        m_errorText = ex->Message;
    }

    return note;
}

/// <summary>
/// �������� ������ � �������
/// </summary>
/// <param name="rec">��������� ��� ���������� ������</param>
/// <returns>����� ����������� �������</returns>
int DBHelper::AddNoteRecord(Note^ rec)
{
    int recs = 0;
    String^ sdate = rec->note_datetime->ToString("yyyy-MM-dd HH:mm:ss");
    String^ sqlText = String::Format("insert into notes(note_datetime,comments) values( '{0}', '{1}')", sdate, rec->comments);
    try
    {
        SQLiteCommand^ cmd = m_conn->CreateCommand();
        cmd->CommandText = sqlText;
        recs = cmd->ExecuteNonQuery();
    }
    catch (Exception^ ex)
    {
        m_errorText = ex->Message;
    }

    return recs;
}
/// <summary>
/// �������� ������ �� �������
/// </summary>
/// <param name="rec">������, ������ ��� ��������� ������</param>
/// <returns></returns>
int DBHelper::UpdateNotesRecord(Note^ rec)
{
    int recs = 0;
    String^ sdate = rec->note_datetime->ToString("yyyy-MM-dd HH:mm:ss");
    String^ sqlText = String::Format("update notes set note_datetime = '{0}', comments = '{1}' where id = {2}", sdate, rec->comments, rec->id);
    try
    {
        SQLiteCommand^ cmd = m_conn->CreateCommand();
        cmd->CommandText = sqlText;
        recs = cmd->ExecuteNonQuery();
    }
    catch (Exception^ ex)
    {
        m_errorText = ex->Message;
    }

    return recs;
}
/// <summary>
/// �������� ������ � �������� ������
/// </summary>
/// <param name="id">������������� ��������� ������</param>
/// <returns></returns>
int DBHelper::DeleteNotesRecord(long id)
{
    int recs = 0;
    String^ sqlText = String::Format("delete from notes where id = {0}",id);
    try
    {
        SQLiteCommand^ cmd = m_conn->CreateCommand();
        cmd->CommandText = sqlText;
        recs = cmd->ExecuteNonQuery();
    }
    catch (Exception^ ex)
    {
        m_errorText = ex->Message;
    }

    return recs;

}



