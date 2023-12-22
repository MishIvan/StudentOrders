#include "pch.h"
#include "BaseDBHelper.h"

using namespace CppCLRWinFormsProject;

/// <summary>
/// Создать объект соединения и открыть созаное соединение
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
///  Закрыть открытое соединение
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
        
    }       
    catch (Exception^ ex)
    {
        m_errorText = ex->Message;
    }
    return lst;

}
