#pragma once
using namespace System;

namespace CppCLRWinFormsProject {
    /// <summary>
    /// ������ � �������� �����
    /// </summary>
    ref struct AddressBook
    {
        long id; // ������������� ������
        String^ name; // ���
        String^ phone; // ����� ��������
        DateTime^ birth_date; // ����
        String^ address; // �����
        String^ comments;  // �������

    };
    /// <summary>
    /// ������ � ��������
    /// </summary>
    ref struct Note
    {
        long id; // ������������� ������
        DateTime^ note_datetime; // ���� � ����� �������
        String^ comments; // ���������� �������
    };
}

