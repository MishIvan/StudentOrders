#include <iostream>
#include <cmath>

// 1aя задача
// вычисление выражения
double ftask1(double x, double y)
{
    double z = (log(abs(x - y)) + x * pow(cos(y), 2.0)) /
        (x * x + pow(cos(x * y), 2.0) + exp(-x * y));
    double t = z * exp(sin(z)) / (x * x + z * z);
    return t;
}

// 2я задача
// Программа преобразования вещественного вектора X(x1, x2, x3) 
// по правилу : если x1<x2<x3, то всем компонентам присвоить значение наибольшей из них х3, 
// если x1>x2>x3, то вектор оставить без изменения, в противном случае все компоненты заменить их квадратами.
// x - вектор для преобразования размерностью 3
void ftask2(double* x)
{
    if (x[0] < x[1] && x[1] < x[2]) // x1<x2<x3
    {
        double mx = fmax(fmax(x[0], x[1]), x[2]);
        for (int i = 0; i < 3; i++)
            x[i] = mx;
    }
    else if (x[0] > x[1] && x[1] > x[2]) // x1>x2>x3
        return;
    else // прочие случаи
    {
        for (int i = 0; i < 3; i++)
            x[i] = x[i] * x[i];
    }
}
// 3я задача
// Определить максимальное целое число n, удовлетворяющее условию 3n^2 - 730n < 5
int ftask3()
{
    int n = 0;
    while (3 * n * n - 730 * n < 5) n++;
    return --n;
}

int main()
{
    setlocale(LC_ALL, "");

    std::cout << "Задание №1" << std::endl;
    std::cout << "Введите аргументы x и  y через пробел: ";
    double x, y;
    std::cin >> x >> y;
    double res = ftask1(x, y);
    std::cout << "Результат: " << res << std::endl;

    std::cout << "Задание №2" << std::endl;
    std::cout << "Введите три компоненты вектора через пробел: ";
    double v[3];
    std::cin >> v[0] >> v[1] >> v[2];
    ftask2(v);
    std::cout << "Результат: (" << v[0] << "," << v[1] << "," << v[2] << ")" << std::endl;

    std::cout << "Задание №3" << std::endl;
    int n = ftask3();
    std::cout << "Максимальное число: " << n << std::endl;

    return 1;
}