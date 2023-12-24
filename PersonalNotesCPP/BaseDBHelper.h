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
    /// Ѕазовый класс дл€ работы с базой данных
    /// создание и открытие соединени€
    /// проверка открыти€ базы данных, закрытие соединени€
    /// </summary>

    ref class BaseDBHelper
    {
        protected:
            SQLiteConnection^ m_conn; // объект соединееи€
            String^ m_errorText; // строка с ошибкой
        public:
            // строка ошибки
            String^ getErrorText() { return m_errorText; }
            // открыто ли  соединение
            bool isOpen() { return m_conn->State == System::Data::ConnectionState::Open; }
            BaseDBHelper(String^ dataFileName);
            virtual ~BaseDBHelper();
    };

    ref class DBHelper : BaseDBHelper
    {
    public:
        /// <summary>
        /// ѕроизводный класс от BaseDBHelper дл€ управлени€ данными
        /// получение записей, добаление, изменение, удаление данных
        /// </summary>
        DBHelper(String^ dataFileName) : BaseDBHelper(dataFileName)
        {

        }
        List<AddressBook^>^ GetAddressData(String^ letter);

        AddressBook^ GetAddressDataRecord(long idrec);

        int AddAddressRecord(AddressBook^ rec);

        int UpdateAdressRecord(AddressBook^ rec);

        int DeleteAddressRecord(long id);

        List<Note^>^ GetNotes();

        Note^ GetNotesDataRecord(long idrec);

        int AddNoteRecord(Note^ rec);

        int UpdateNotesRecord(Note^ rec);

        int DeleteNotesRecord(long id);


    };
}
