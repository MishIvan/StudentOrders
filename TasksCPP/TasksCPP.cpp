// TasksCPP.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include "Tasks.h"
#include "Integer.h"
#include <vector>
#include <string>
#include "TasksCPP.h"

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
/// <summary>
/// Получить полный путь файла в папке, из которой запускается исполняемый файл программы
/// </summary>
/// <param name="fullExePath">полный путь запуска программы</param>
/// <param name="dataFileName">ммя файла данных в каталоге, где расположен исполняемый файл</param>
/// <returns>Полное имя файла данных</returns>
char * GetFullPathInWD(char* fullExePath, const char *dataFileName)
{
    char * fileName =  new char[1024];
    strcpy_s(fileName, 1024, fullExePath);
    std::string s1 = fileName;
    int k = s1.find_last_of('\\');
    s1.replace(k+1, s1.size() - 1, dataFileName);
    strcpy_s(fileName, 1024, s1.data());
    return fileName;    
}

int main(int argc, char* argv[])
{
    setlocale(LC_ALL,"");
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
    
    char* path;

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
        path = GetFullPathInWD(argv[0], "Matrix.txt");
        ReadMatrix(path);
        delete path;
        break;
    case 8:
        RunTask8(4);
        break;
    default:
        return 0;
    }
    return 1;   
}

