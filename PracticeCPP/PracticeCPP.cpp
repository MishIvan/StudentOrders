// PracticeCPP.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <math.h>
#include <vector>
#include <string>
#include <windows.h>
#include <limits>
#include <iomanip>
#include <ctime>
#include <sstream>
#include <chrono>
#include <fstream>

#if defined(max)
#undef max
#endif

/// <summary>
/// Книга
/// </summary>
struct Book
{
    std::string m_regNumber; // рег. номер
    std::string m_author; // автор
    std::string m_name; // наименование
    int m_year; // год издания
    std::string m_publishingHouse; // издательство
    int m_pages; // кол-во страниц
};

/// <summary>
/// Работник
/// </summary>
struct Worker
{
    std::string m_name; // ФИО
    int m_nomDept; // номер отдела
    std::string m_pos; // должность
    tm m_date; // дата поступления на работу
    Worker& operator=(Worker& src)
    {
        m_name = src.m_name;
        m_pos = src.m_pos;
        m_nomDept = src.m_nomDept;
        m_date = src.m_date;
        return *this;

    }
};

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
/// Лаб. работа №3. Она же и лабораторная работа №8
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
/// <summary>
/// Проверка, состоит ли строка олшько из символов табуляции и пробелов.
/// </summary>
/// <param name="str">строка</param>
/// <returns></returns>
bool IsWhiteSpace(std::string& str)
{
    int n = str.size();
    for (int i = 0; i < n; i++)
    {
        if (str[i] != ' ' || str[i] !='\t')  return false;
    }
    return true;
}
/// <summary>
/// Лбораторная работа №6. Подсчитать количество слов, начинающихся с "а"
/// </summary>
/// <param name="str">исходная строка</param>
/// <returns>списко слов, начинающихся на "а"</returns>
int LabW06(std::string& str)
{
    std::string::size_type n = 0, i = 0;
    std::vector<std::string> slist;
    std::string s1;
    // Сформировать список слов
    while(n != std::string::npos)
    {
        n = str.find_first_of(' ', i);
        if (n != std::string::npos)
        {
            s1 = str.substr(i, n - i);
            i = n + 1;
            if(!s1.empty())
                slist.push_back(s1);
        }
        else
        {
            s1 = str.substr(i);
            slist.push_back(s1);
        }
    }

    // Подсчитать число слов, начинающихся с "а"
    int nw = 0;
    int k = slist.size();
    for (int j = 0; j < k; j++)
    {
        std::string s1 = slist[j];
        std::cout << s1 << std::endl;
        if (s1.at(0) == 'а') nw++;
    }
    return nw;    
}
/// <summary>
/// Для лабораторной работы №9. Запись данных о сотрудниках
/// </summary>
/// <param name="fname">имя файла</param>
/// <param name="wrk">массив данных для записи</param>
/// <param name="n">размерность массива</param>
void WriteWorkers(const char* fname, Worker *wrk, int n)
{
    std::fstream fs;
    fs.open(fname, std::ios::out | std::ios::binary);
    if (fs.is_open())
    {
        fs.write((const char*)&n, sizeof(int));
        for (int i = 0; i < n; i++)
        {
            int k = wrk[i].m_name.size();
            fs.write((const char*)&k, sizeof(int));
            fs.write(wrk[i].m_name.data(), k);

            k = wrk[i].m_pos.size();
            fs.write((const char*)&k, sizeof(int));
            fs.write(wrk[i].m_pos.data(), k);
            fs.write((const char*)&wrk[i].m_nomDept, sizeof(int));
            fs.write((const char*)&wrk[i].m_date, sizeof(tm));
            
            
        }
        fs.close();
    }

}
/// <summary>
/// Для лабораторной работы №9. Считывание считывание данных о сотрудниках с возвратом укзателя
/// </summary>
/// <param name="fname">имя файла данных</param>
/// <param name="wrk">считываемые данные</param>
Worker *ReadWorkers(const char* fname)
{
    std::fstream fs;
    fs.open(fname, std::ios::in | std::ios::binary);
    Worker* wrk = nullptr;
    if (fs.is_open())
    {
        int n = 0;
        fs.read((char*)&n, sizeof(int));
        wrk = new Worker[n];
        for (int i = 0; i < n; i++)
        {
            char buff[1024];
            int k;
            fs.read((char *)&k, sizeof(int));
            fs.read(buff, k);
            buff[k] = '\0';
            wrk[i].m_name = buff;

            fs.read((char*)&k, sizeof(int));
            fs.read(buff, k);
            buff[k] = '\0';
            wrk[i].m_pos = buff;

            fs.read((char*)&k, sizeof(int));
            wrk[i].m_nomDept = k;

            tm t;
            fs.read((char *)&t, sizeof(tm));
            wrk[i].m_date = t;
        }
        fs.close();
        return wrk;
    }
}

double WorkerDateDiff(Worker &w1, Worker &w2)
{
    tm tm1, tm2;
    tm1 = w1.m_date;
    tm2 = w2.m_date;
    time_t t1 = mktime(&tm1);
    time_t t2 = mktime(&tm2);
    return difftime(t1, t2);
}
/// <summary>
/// Лабораторная работа №10. Сортировка вставкой
/// </summary>
/// <param name="wrk">список работников</param>
/// <param name="n">число элементов списка</param>
void SortByInsert(Worker *wrk, int n)
{
    int i, j, t;
    for (i = 1; i < n; i++) //  Перебор элементов
    {
        Worker t = wrk[i]; //  Выбор элемента
        for (j = i - 1; j >= 0 && WorkerDateDiff(t, wrk[j]) < 0; j--) // Поиск необходимой позиции
            wrk[j + 1] = wrk[j]; //  для втавки элемента
        wrk[j + 1] = t; //  Вставка элемента
    }
}
/// <summary>
/// Лабораторная работа №11. Метод двоичного поиска
/// </summary>
/// <param name="wrk">список работников</param>
/// <param name="n">число элементов списка</param>
/// <param name="year">год</param>
/// <returns>индек элемента списка</returns>
int BinarySearchWorker(Worker *wrk, int n, int year)
{
    int i = 0, j = n - 1, m;
    while (i < j)
    {
        m = (i + j) / 2; // Вычисление индекса среднего элемента
        if (year > wrk[m].m_date.tm_year+1900) i = m + 1; // Исключение  левой половины массива
        else j = m;  // Исключение  правой половины массива
    }
    if (wrk[i].m_date.tm_year + 1900 == year) return i; // Искомый элемент найден
    else return -1; // Искомый элемент не найден 
}

/// <summary>
/// Лабораторная работа №11. Метод полного перебора
/// </summary>
/// <param name="wrk">список работников</param>
/// <param name="n">число элементов списка</param>
/// <param name="year">год</param>
/// <returns>индек элемента списка</returns>
int FullSearchWorker(Worker* wrk, int n, int year)
{
    for (int i = 0; i < n; i++)
    {
        if (wrk[i].m_date.tm_year + 1900 == year) return i;
    }
    return -1;
}

int main()
{
    setlocale(LC_ALL, "");
    SetConsoleCP(1251); // для того, чтобы понимал ввод кириллицы из строки
    double s = LabW01(-2.235e-2, 2.23, 15.221);
    std::cout << "Лаб. работа №1. Результат: " << s << "\n";

    std::cout << "Введите x и y:";
    double x, y;
    std::cin >> x >> y;
    s = LabW02(x, y);
    std::cout << "Лаб. работа №2. Результат: " << s << "\n";

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

    std::cout << "Лаб. работа №4. Введите шесть целых чисел: ";
    std::vector<int> v1(6);
    std::cin >> v1[0] >> v1[1] >> v1[2] >> v1[3] >> v1[4] >> v1[5];
    LabW04(v1);
    std::cout << "Массив после удаления максимального и минимального элементов" << std::endl;
    std::cout << v1[0] << " " << v1[1] << " " << v1[2] << " " << v1[3];

    /// Лабораторная работа №5. Найти минимальный, среди элементов, лежащих выше главной диагонали
    int n, m;
    std::cout << "Лаб. работа №5. Введите размерность массива NxM: ";
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

    std::cout << "Лаб. работа №6. Введите строку: ";
    std::string str;
    getline(std::cin, str);
    if (str.empty() || IsWhiteSpace(str))
    {
        std::cout << "Введённая вами строка либо пустая, либо соcтоит из пробелов и символов табуляции" << std::endl;
        return -1;
    }
    int wc = LabW06(str);
    std::cout << "Число строк, начинающихся на 'а': " << wc << std::endl;

    std::cout << "Лаб. работа №7. Введите информацию о книгах" << std::endl;
    n = 5;
    Book* bk = new Book[n];
    for (int i = 0; i < n; i++)
    {
        std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
        std::cout << "Регистрационный номер: ";
        getline(std::cin, bk[i].m_regNumber);

        std::cout << "Автор: ";
        getline(std::cin, bk[i].m_author);

        std::cout << "Наименование: ";
        getline(std::cin, bk[i].m_name);

        std::cout << "Издательство: ";
        getline(std::cin, bk[i].m_publishingHouse);

        std::cout << "Год издания: ";
        std::cin >> bk[i].m_year;
        
        std::cout << "Количество страниц: ";
        std::cin >> bk[i].m_pages;
    }

    int year = 0;
    std::cout << "Введите год издания: ";
    std::cin >> year;

    std::cout << "Введите год издания: ";
    for (int i = 0; i < n; i++)
    {
        if (bk[i].m_year > year)
            std::cout << bk[i].m_author << " ";
    }
    std::cout << std::endl;

    std::cout << "Лаб. работа №9. Введите информацию о сотрудниках" << std::endl;
    n = 5;
    Worker* wrk = new Worker[n];
    for (int i = 0; i < n; i++)
    {                
        std::cout << "ФИО: ";
        getline(std::cin, wrk[i].m_name);

        std::cout << "Должность: ";
        getline(std::cin, wrk[i].m_pos);

        std::cout << "Дата поступления на работу в формате дд.мм.гггг: ";
        std::string s1;
        tm t = {};
        std::cin >> s1;
        std::istringstream ss(s1.data());
        ss >> std::get_time(&t, "%d.%m.%Y");
        wrk[i].m_date.tm_year = t.tm_year;
        wrk[i].m_date.tm_mon = t.tm_mon;
        wrk[i].m_date.tm_mday = t.tm_mday;
        wrk[i].m_date.tm_hour = 0;
        wrk[i].m_date.tm_min = 0;
        wrk[i].m_date.tm_sec = 0;

        std::cout << "Номер отдела: ";
        std::cin >> wrk[i].m_nomDept;
        std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
    }

    // Эти строки пока закомментированы. Но проверено - работает
    //WriteWorkers("wrk.bin", wrk, n);
    //Worker* wrk = ReadWorkers("wrk.bin");
    //if (!wrk) return 0;
 
    auto now = std::chrono::system_clock::now();
    std::time_t now_time = std::chrono::system_clock::to_time_t(now);
    for (int i = 0; i < n; i++)
    {
        tm ttm = wrk[i].m_date;
        std::time_t t1 = mktime(&ttm);
        double secs = difftime(now_time, t1);
        if (secs / (360.0 * 24.0 * 3600.0) > 20.0)
        {
            if(i == 0)
                std::cout << "Сотрудники, проработавшие более 20 лет" << std::endl;
            char buff[128];
            sprintf(buff, ", дата начала работы: %2d.%02d.%4d", ttm.tm_mday, ttm.tm_mon + 1, ttm.tm_year + 1900);
            std::cout << "ФИО: " << wrk[i].m_name << ", должность: " << wrk[i].m_pos << ", ном. отдела: " << wrk[i].m_nomDept << buff << std::endl;
        }
    } 

    /// <summary>
    /// Лабораторная работа №10. Сортировка вставкой по дате начала работы
    /// </summary>
    std::cout << "Список сотрудников, отсортированный по дате начала работы" << std::endl;
    SortByInsert(wrk, n);
    for (int i = 0; i < n; i++)
    {
        tm ttm = wrk[i].m_date;
        char buff[128];
        sprintf(buff, ", дата начала работы: %2d.%02d.%4d", ttm.tm_mday, ttm.tm_mon + 1, ttm.tm_year + 1900);
        std::cout << "ФИО: " << wrk[i].m_name << ", должность: " << wrk[i].m_pos << ", ном. отдела: " << wrk[i].m_nomDept << buff << std::endl;
        
    }

    // Лабораторная работа №11. Поиск сотрудника методом бинарного поиска
    std::cout << "*** Сотрудник, работающий с 2003 года. Метод бинарного поиска ***" << std::endl;
    int idx = BinarySearchWorker(wrk, n, 2003);
    if (idx > -1)
    {
        std::cout << "Сотрудник, работающий с 2003 года" << std::endl;
        tm ttm = wrk[idx].m_date;
        char buff[128];
        sprintf(buff, ", дата начала работы: %2d.%02d.%4d", ttm.tm_mday, ttm.tm_mon + 1, ttm.tm_year + 1900);
        std::cout << "ФИО: " << wrk[idx].m_name << ", должность: " << wrk[idx].m_pos << ", ном. отдела: " << wrk[idx].m_nomDept << buff << std::endl;
    }
    else
    {
        std::cout << "Сотрудник, работающий с 2003 года не найден" << std::endl;
    }

    std::cout << "*** Сотрудник, работающий с 2003 года. Метод полного перебора ***" << std::endl;
    idx = FullSearchWorker(wrk, n, 2003);
    if (idx > -1)
    {
        std::cout << "Сотрудник, работающий с 2003 года" << std::endl;
        tm ttm = wrk[idx].m_date;
        char buff[128];
        sprintf(buff, ", дата начала работы: %2d.%02d.%4d", ttm.tm_mday, ttm.tm_mon + 1, ttm.tm_year + 1900);
        std::cout << "ФИО: " << wrk[idx].m_name << ", должность: " << wrk[idx].m_pos << ", ном. отдела: " << wrk[idx].m_nomDept << buff << std::endl;
    }
    else
    {
        std::cout << "Сотрудник, работающий с 2003 года не найден" << std::endl;
    }

    delete[] wrk; 

}
