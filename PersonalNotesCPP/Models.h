#pragma once
using namespace System;

namespace CppCLRWinFormsProject {
    /// <summary>
    /// ������ � �������� �����
    /// </summary>
    public ref class AddressBook
    {
        long m_id;
        String^ m_name; 
        String^ m_phone; 
        DateTime^ m_birth_date; 
        String^ m_address; 
        String^ m_comments; 

    public:
        property long id { public: long get() { return m_id; }; void set(long value) { m_id = value; }; }// ������������� ������
        property String^ name {public:  String^ get() { return m_name; }; void set(String^ value) { m_name = value; };  } // ���
        property String^ phone {public:  String^ get() { return m_phone; }; void set(String^ value) { m_phone = value; }; } // ����� ��������
        property DateTime^ birth_date {public:  DateTime^ get() { return m_birth_date; }; void set(DateTime^ value) { m_birth_date = value; }; } // ����
        property String^ address { public: String^ get() { return m_address; }; void set(String^ value) { m_address = value; }; } // �����
        property String^ comments {public:  String^ get() { return m_comments; }; void set(String^ value) { m_comments = value; }; }  // �������

    };
    /// <summary>
    /// ������ � ��������
    /// </summary>
    public ref class Note
    {
        long m_id; // ������������� ������
        DateTime^ m_note_datetime; // ���� � ����� �������
        String^ m_comments; // ���������� �������

    public :
        property long id{ public: long get() { return m_id; }; void set(long value) { m_id = value; }; }; // ������������� ������
        property DateTime^ note_datetime{ public:  DateTime ^ get() { return m_note_datetime; }; void set(DateTime^ value) { m_note_datetime = value; }; } // ���� � ����� �������
        property String^ comments{ public:  String ^ get() { return m_comments; }; void set(String^ value) { m_comments = value; }; } // ���������� �������
    };
}