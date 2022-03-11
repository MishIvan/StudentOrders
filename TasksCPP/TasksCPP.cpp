﻿// TasksCPP.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include "Tasks.h"
#include "Integer.h"
#include <vector>
#include <string>
#include "TasksCPP.h"
#include "Student.h"
#include <Windows.h>

// задача №1
double f1(double ang)
{
    double angrad = ang * PI / 180.0;
    return (sin(2.0 * angrad) + sin(5.0 * angrad) - sin(3.0 * angrad)) 
        / (cos(angrad) + 1.0 - 2.0 * pow(sin(2.0 * angrad),2.0));
}
double f2(double ang)
{
    double angrad = ang * PI / 180.0;
    return 2.0 * sin(angrad);
}
void RunTask1(int n)
{
    std::cout << "Значения углов в градусах:\r\n";
    std::vector<double> v1(n);
    for (int i = 0; i < n; i++)
        std::cin >> v1[i];
    int i = 0;
    while (i < n)
    {
        std::cout << "Значение первой функции: " << f1(v1[i]) << std::endl;
        std::cout << "Значение второй функции: " << f2(v1[i]) << std::endl;
        i++;
    }
    v1.~vector();
}

// задача №2
void RunTask2(int n)
{
    std::cout << "Введите первый вектор:\r\n";
    std::vector<double> v1(n);
    for (int i = 0; i < n; i++)
        std::cin >> v1[i];
    std::cout << "\r\nВведите второй вектор:\r\n";
    std::vector<double> v2(n);
    for (int i = 0; i < n; i++)
        std::cin >> v2[i];
    if(IsVectorsCollinear(v1, v2))
        std::cout << "Векторы коллинеарны\r\n";
    else
        std::cout << "Векторы не коллинеарны\r\n";  
    v1.~vector();
    v2.~vector();
}

// задача №4
void RunTask4()
{
    std::cout << "Введите последовательность целых чисел:\r\n";
    std::vector<Integer> v1;
    int k = -1;
    while (true)
    {
        std::cin >> k;
        if (k > 0) {
            Integer ival(k);
            v1.push_back(ival);
        }
        else break;
    }
    k = v1.size();
    int nsimple = 0;
    int nperfect = 0;
    for (int i = 0; i < k; i++)
    {
        v1[i].FindDividers();
        int val = v1[i].GetValue();
        if (v1[i].IsSimple())
        {
            std::cout << "Число " << val  << " простое" << std::endl;
            nsimple++;
        }
            
        if (v1[i].IsPerfect())
        {
            std::cout << "Число " << val << " совершенное" << std::endl;
            nperfect++;
        }            
    }
    std::cout << "Простых чисел " << nsimple << ", совершенных " << nperfect << std::endl;
    // Очистить память
    for (int i = 0; i < k; i++)
    {
        v1[i].~Integer();
    }
    v1.~vector();

}
// задача №5
void RunTask5(int n)
{    
    std::cout << "Введите вектор:\r\n";
    std::vector<double> v1(n);
    for (int i = 0; i < n; i++)
        std::cin >> v1[i];
    std::cout << "Сумма отрицательных элеметов: " << SumElements(v1, true) << std::endl;
    std::cout << "Сумма положительтных элеметов: " << SumElements(v1, false) << std::endl;
    v1.~vector();
}

// задача №6
void RunTask6(int n)
{
    std::vector<int> v1(n);
    std::cout << "Введите исходный вектор:\r\n";
    for (int i = 0; i < n; i++)
        std::cin >> v1[i];

    std::vector<int>v2 = ReverseVector(v1);
    std::cout << "Исходный вектор: ";
    for (int i = 0; i < n; i++)
        std::cout << v1[i] <<" ";
    std::cout << "\r\nВектор с элементами в обратном порядке: ";
    for (int i = 0; i < n; i++)
        std::cout << v2[i] << " ";

    std::cout << "\r\nИсходный вектор с удалалённым первым и последним элементом: ";
    EraseFirstAndLast(v1);
    int k = v1.size();
    for (int i = 0; i < k; i++)
        std::cout << v1[i] << " ";
        
    EraseFirstAndLast(v2);
    std::cout << "\r\nВектор с элементами в обратном порядке с удалалённым первым и последним элементом: ";
    k = v2.size();
    for (int i = 0; i < k; i++)
        std::cout << v2[i] << " ";

    v2.clear();
    v1.~vector();
}

// задача №8
void RunTask8(int n)
{
    InputOutputTriangle(n);
}
// задача №9
void RunTask9(char* fullExeFileName)
{
    std::vector<STUDENT> students;
    char path[1024];
    GetFullPathInWD(fullExeFileName, "Students.txt", path);
    ReadStudentsFromFile(path,students);
    GetFullPathInWD(fullExeFileName, "Students.bin", path);
    WriteStudentsToFileB(path, students);
    students.clear();
    ReadStudentsFromFileB(path, students);

    std::cout << "Информация о студентах, полученная из двоичного файла\r\n";
    int n = students.size();
    for (int i = 0; i < n; i++)
    {
        STUDENT student = students[i];            
        std::cout << "\r\nФИО: " << student.getName() << std::endl;
        std::cout << "Группа: " << student.getGroup() << std::endl;
        std::cout << "Оценки: ";
        for (int j = 0; j < 5; j++)
            std::cout << students[i].getMark(j) << " ";
    }

    students.~vector();
}

// задача №16
void RunTask16(int nst)
{
    std::string name, group; 
    std::vector<int> mark(5);
    std::vector<STUDENT> students;
    char buff1[512], buff2[16];
    for (int i = 0; i < nst; i++)
    {
        std::cout << "Введите ФИО студента: ";
        std::cin >> buff1 >> buff2;
        strcat_s(buff1, 512, " ");
        strcat_s(buff1, 512, buff2);
        name = buff1;
        std::cout << "Введите группу студента: ";
        std::cin >> buff1;
        group = buff1;
        std::cout << "Введите оценки студента: " << std::endl;
        for (int j = 0; j < 5; j++)
            std::cin >> mark[j];
        STUDENT st(name, group, mark);
        students.push_back(st);
    } 

    SortStudents(students); // сортировка списка студентов

    // вывод студентов получивших плохие отметки
    int n = students.size();
    int k = 0;
    for (int i = 0; i < n; i++)
    {
        STUDENT student = students[i];
        if (student.HasBadMark())
        {
            if (k == 0) std::cout << "Студенты, получившие плохие оценки\r\n";
            std::cout << "\r\nФИО: " << student.getName() << std::endl;
            std::cout << "Группа: " << student.getGroup() << std::endl;
            std::cout << "Оценки: ";
            for (int j = 0; j < 5; j++)
                std::cout << students[i].getMark(j) << " ";
            k++;
        }
    }
    if (k < 1)
        std::cout << "Нет студентов, получивших плохие оценки\r\n";

    students.~vector();
}
/// <summary>
/// Получить полный путь файла в папке, из которой запускается исполняемый файл программы
/// </summary>
/// <param name="fullExePath">полный путь запуска программы</param>
/// <param name="dataFileName">имя файла данных в каталоге, где расположен исполняемый файл</param>
/// <param name="fullFileName">имя файла данных в каталоге, где расположен исполняемый файл</param>
/// <returns></returns>
void GetFullPathInWD(char* fullExePath, const char *dataFileName, char * fullFileName)
{
    strcpy_s(fullFileName, 1024, fullExePath);
    std::string s1 = fullFileName;
    int k = s1.find_last_of('\\');
    if (k == std::string::npos)
        strcpy_s(fullFileName, 1024, dataFileName);
    else
    {
        s1.replace(k + 1, s1.size() - 1, dataFileName);
        strcpy_s(fullFileName, 1024, s1.data());
    }
}

int main(int argc, char* argv[])
{
    setlocale(LC_ALL,"");
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    if (argc < 2)
    {
        std::cout << "Не указан номер задачи. Укажите номер задачи.";
        return -1;
    }
    int itask = 0;
    try 
    {
        itask = std::stoi(argv[1]);
    }
    catch (...)
    {
        std::cout << "Неверный параметр. Следует указать номер задачи.";
        return -1;

    }

    char path[1024];
    std::string name;
    switch (itask)
    {
    case 1:
        RunTask1(5);
        break;
    case 2:
        RunTask2(3);
        break;
    case 4:
        RunTask4();
        break;
    case 5:
        RunTask5(7);
        break;
    case 6:
        RunTask6(5);
        break;
    case 7:        
        GetFullPathInWD(argv[0], "Matrix.txt", path );
        ReadMatrix(path);
        break;
    case 8:
        RunTask8(4);
        break;
    case 9:
        RunTask9(argv[0]);
        break;
    case 16:
        RunTask16(5);
        break;
    default:
        return 0;
    }
    return 1;   
}

