// TasksCPP.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include "Tasks.h"
#include <vector>

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
}

void RunTask5(int n)
{
    
    std::cout << "Введите вектор:\r\n";
    std::vector<double> v1(n);
    for (int i = 0; i < n; i++)
        std::cin >> v1[i];
    std::cout << "Сумма отрицательных элеметов: " << SumElements(v1, true) << std::endl;
    std::cout << "Сумма положительтных элеметов: " << SumElements(v1, false) << std::endl;
}

int main(int argc, char* argv[])
{
    setlocale(LC_ALL,"");

    //InputOutputTriangle(5);
}

