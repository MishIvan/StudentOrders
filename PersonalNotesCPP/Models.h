#pragma once
using namespace System;

namespace CppCLRWinFormsProject {
    /// <summary>
    /// запись в адресной книге
    /// </summary>
    ref struct AddressBook
    {
        long id; // идентификатор записи
        String^ name; // ФИО
        String^ phone; // номер телефона
        DateTime^ birth_date; // дата
        String^ address; // адрес
        String^ comments;  // заметки

    };
    /// <summary>
    /// запись в заметках
    /// </summary>
    ref struct Note
    {
        long id; // идентификатор записи
        DateTime^ note_datetime; // дата и время заметки
        String^ comments; // содержание заметки
    };
}

