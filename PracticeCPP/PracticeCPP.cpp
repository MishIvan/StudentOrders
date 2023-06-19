// PracticeCPP.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <math.h>
#include <vector>
/// <summary>
/// Лабораторная работа №1
/// </summary>
/// <param name="x"></param>
/// <param name="y"></param>
/// <param name="z"></param>
/// <returns></returns>
double LabW01(double x, double y, double z)
{
    return (exp(fabs(x - y)) * pow(fabs(x - y), x + y)) / (atan(x) + atan(z)) + pow(pow(x, 6.0) + pow(log(y), 2.0), 1.0 / 3.0);
}
/// <summary>
/// Лабораторная работа №2
/// </summary>
/// <param name="x"></param>
/// <param name="y"></param>
/// <returns></returns>
double LabW02(double x, double y)
{
    double s = 0.0;
    if (x / y < 0.0)
        s = pow(x * x + y, 3.0);
    else if (x / y > 0.0)
        s = log(fabs(x / y)) + x / y;
    else
        s = pow(fabs(sin(y)), 1.0 / 3.0);
    return s;
}
/// <summary>
/// Лаб. работа №3
/// </summary>
/// <param name="x"></param>
/// <returns></returns>
double LabW03(double x)
{
    double s = 0.0;
    for (int n = 1; n < 21; n++)
        s += (2 * n * n + 1) * pow(x, 2 * n + 2) / (2 * n);
    return s;
}
/// <summary>
/// Лбораторная работа №4. Удалить из массива максимальный и минимальный элемент
/// </summary>
/// <param name="vect"></param>
void LabW04(std::vector<int>& vect)
{
    int n = vect.size();
    int elmax = vect.at(0);
    int k = 0;
    for (int i = 1; i < n; i++)
    {
        double el = vect.at(i);
        if (el > elmax)
        {
            k = i;
            elmax = el;
        }
    }
    vect.erase(vect.begin() + k);

    n = vect.size();
    int elmin = vect.at(0);
    for (int i = 1; i < n; i++)
    {
        double el = vect.at(i);
        if (el < elmin)
        {
            k = i;
            elmin = el;
        }
    }
    vect.erase(vect.begin() + k);
}

int main()
{
    setlocale(LC_ALL, "");
    double s = LabW01(-2.235e-2, 2.23, 15.221);
    std::cout << "Лаб. работа №1. Результат: " << s << "\n";

    /*std::cout << "Введите x и y:";
    double x, y;
    std::cin >> x >> y;
    s = LabW02(x, y);
    std::cout << "Лаб. работа №2. Результат: " << s << "\n";*/

    std::cout << "Лаб. работа №3. Результат.\n";
    std::cout << "X\tY\n";
    double a = 0.1, h = 0.1;
    double b = a;
    while (b < 1.2)
    {
        double y = LabW03(b);
        b += h;
        std::cout << b << "\t" << y << "\n";
    }

    /*std::cout << "Лаб. работа №4. Введите шесть целых чисел: ";
    std::vector<int> v1(6);
    std::cin >> v1[0] >> v1[1] >> v1[2] >> v1[3] >> v1[4] >> v1[5];
    LabW04(v1);
    std::cout << "Массив после удаления максимального и минимального элементов" << std::endl;
    std::cout << v1[0] << " " << v1[1] << " " << v1[2] << " " << v1[3];*/

    /// Лабораторная работа №5. Найти минимальный, среди элементов, лежащих выше главной диагонали
    std::cout << "Лаб. работа №5. Введите размерность массива NxM: ";
    int n, m;
    std::cin >> n >> m;
    double* arr = new double[n * m];
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            std::cin >> arr[i * m + j];
    double elmin = 1.7e308;
    int imin = -1, jmin = -1;
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
        {
            if (i >= j) continue;
            if (arr[i * m + j] < elmin)
            {
                elmin = arr[i * m + j];
                imin = i + 1; jmin = j + 1;
            }
        }
    std::cout << "Минимальный элемент arr(" << imin << "," << jmin << ") = " << elmin << std::endl;
    delete[] arr;


}
