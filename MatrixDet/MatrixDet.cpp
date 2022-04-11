// MatrixDet.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <math.h>
#include <fstream>
#include <vector>

void GetFullPathInWD(char* fullExePath, const char* dataFileName, char* fullFileName);
void LinearSystemSolve(int n, double** A, double* b, double* &x, double& det, bool onlyDet);
bool ReadData(const char* fullFileName, double** &A, double* &b, int& size, bool onlyDet);
double errNorm(int n, double** A, double* b, double* x);
void PrintMatrix(const char* header, int size, double** A);
void PrintVector(const char* header, int size, double* x);
double Minor(int n, double** A, int i, int j);

int main(int argc, char* argv[])
{
    setlocale(LC_ALL, "");
    char path[1024]; // буфер пути файла данных
    double** A; // задаваемая матрирца
    double* b;
    double* x;
    double norm, det;
    int size = 0;
    bool onlyDet = true;
    GetFullPathInWD(argv[0], "MatrixT1.txt", path);
    if(!ReadData(path, A, b, size, onlyDet)) return -1;
    PrintMatrix("Матрица А", size, A);
    LinearSystemSolve(size, A, b, x, det, onlyDet);
    if (!onlyDet)
    {
        PrintVector("Вектор b", size, b);
        PrintVector("Решение", size, x);
        norm = errNorm(size, A, b, x);
        std::cout << "Норма ошибки " << norm << std::endl;
        delete x;
        delete b;
    }
    std::cout << "Детерминант матрицы А = " << det << std::endl;
    int i, j;
    int imax = -1, jmax = -1;
    double meanval = 0.0, maxval = -1.7E+308, minor = 0.0;        
    for (i = 0; i < size; i++)
    {        
        for (j = 0; j < size; j++)
        {
            minor = Minor(size, A, i, j);
            
            meanval += minor;
            if (minor > maxval)
            {
                imax = i; jmax = j;
                maxval = minor;
            }
        }
    }
    meanval /= (double)size * (double)size;

    for (int i = 0; i < size; i++)
        delete[] A[i];
    delete A;

    std::cout << "Среднее значение миноров матрицы A = " << meanval << std::endl;
    std::cout << "Максимальное значение минора M(" << imax + 1 <<","<< jmax + 1 <<") = " << maxval << std::endl;
}

/// <summary>
/// Получить полный путь файла в папке, из которой запускается исполняемый файл программы
/// </summary>
/// <param name="fullExePath">полный путь запуска программы</param>
/// <param name="dataFileName">имя файла данных в каталоге, где расположен исполняемый файл</param>
/// <param name="fullFileName">имя файла данных в каталоге, где расположен исполняемый файл</param>
/// <returns></returns>
void GetFullPathInWD(char* fullExePath, const char* dataFileName, char* fullFileName)
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

/// <summary>
/// Решение системы линейных уравнений с параллельным вычислением демерминанта матрицы
/// </summary>
/// <param name="n">размерность системы уравнений</param>
/// <param name="A">матрица системы уравнений</param>
/// <param name="b">вектор правой части системы уравнений</param>
/// <param name="x">решение системы уравнений</param>
/// <param name="det">определитель матрицы A</param>
/// <param name="onlyDet">true - рассчитать только детернминант, false - решать систему и рассичтать детерминант</param>
void LinearSystemSolve(int n, double** A, double* b, double* &x, double& det, bool onlyDet)
{
    double **alpha = new double *[n];
    double* beta;

    // инициализируем нулём
    for(int i = 0; i < n ;i++)
    {
        alpha[i] = new double[n];
        for (int j = 0; j < n; j++)
        {
            alpha[i][j] = 0.0; 
        }
    }

    for (int i = 0; i < n; i++)
        alpha[i][0] = A[i][0];
    for (int k = 1; k < n; k++)
        alpha[0][k] = A[0][k]/A[0][0];
    double sum = 0.0;
    int k = 1, i = 1;
    while (i < n)
    {
        if (k >= n)
        {
            k = 1; i++;
            if (i >= n) break;
        }
        if (i >= k)
        {                
            sum = 0.0;
            for (int j = 0; j <= k - 1; j++)
            {
                sum += alpha[i][j] * alpha[j][k];
            }
            alpha[i][k] = A[i][k] - sum;
        }
        else
        {
            sum = 0.0;
            for (int j = 0; j <= i - 1; j++)
            {
                sum += alpha[i][j] * alpha[j][k];
            } 
            if (alpha[i][i] == 0.0)
            {
                for (i = 0; i < n; i++)
                    delete[] alpha[i];
                delete[] alpha;
                det = 0.0; return;
            }
            alpha[i][k] = (A[i][k] - sum) / alpha[i][i];
        }
        k++;
    }
    
    if(!onlyDet)
    {
        beta = new double[n];
        x = new double[n];
        for (int i = 0; i < n; i++)
        {
            x[i] = 0.0;
            beta[i] = 0.0;
        }
        beta[0] = b[0] / A[0][0];
        for (int i = 1; i < n; i++)
        {
            sum = 0.0;
            for (int j = 0; j <= i - 1; j++)
                sum += alpha[i][j] * beta[j];
            beta[i] = (b[i] - sum) / alpha[i][i];
        }

        // решение системы уравнений    
        x[n - 1] = beta[n - 1];    
        for (int i = n - 2; i >= 0 ; i--)
        {        
            sum = 0.0;
            for (int j = n-1; j > i; j--)
                sum += alpha[i][j] * x[j];
            x[i] = beta[i] - sum;
        }
        delete[] beta;
    }
    det = 1.0;
    for (int i = 0; i < n; i++)
        det *= alpha[i][i];
    for (i = 0; i < n; i++)
        delete[] alpha[i];
    delete[] alpha;
}

/// <summary>
///  Евклидова норма погрешности вычисления 
/// </summary>
/// <param name="n">размерность</param>
/// <param name="A">матрица системы линейных уравнений</param>
/// <param name="b">вектор правой части системы линейных уравнений</param>
/// <param name="x">вектор решения</param>
/// <returns>евклидова норма погрешности вычислений</returns>
double errNorm(int n, double** A, double *b, double* x)
{
    double *verr = new double[n];
    for (int i = 0; i < n; i++)
    {
        double sum = 0.0;
        for (int j = 0; j < n; j++)
        {
            sum += A[i][j] * x[j];
        }
        verr[i] = sum - b[i] ;
    }
    double qnorm = 0.0;
    for (int i = 0; i < n; i++)
    {
        qnorm += verr[i] * verr[i];
    }
    delete[] verr;
    return sqrt(qnorm);
}
/// <summary>
/// Чтение данных из файла
/// </summary>
/// <param name="fullFileName">полное имя фйла</param>
/// <param name="A">матрица</param>
/// <param name="b">вектор</param>
/// <param name="size">размерность</param>
bool ReadData(const char* fullFileName, double** &A, double* &b, int& size, bool onlyDet)
{
    std::fstream inp;
    inp.open(fullFileName, std::ios::in);
    // динамический массив
    if (inp.is_open())
    {
        try
        {
            inp >> size;
            A = new double* [size];
            b = new double[size];
            for (int i = 0; i < size; i++)
            {

                A[i] = new double[size];
                for (int j = 0; j < size; j++)
                    inp >> A[i][j];
            }
            if (!onlyDet)
            {
                for (int j = 0; j < size; j++)
                    inp >> b[j];

            }
        }
        catch (...)
        {
            inp.close();
            std::cout << "Неверный формат файла " << fullFileName;
            return false;

        }
        
    inp.close();
    return true;
    }            
    else
    {
        std::cout << "Неверный формат файла " << fullFileName << " или файл не найден";
        return false;
    }
}
/// <summary>
/// Вывод матрицы на консоль
/// </summary>
/// <param name="header">Заголовок</param>
/// <param name="size">размерность</param>
/// <param name="A">матрица для вывода на консоль</param>
void PrintMatrix(const char* header, int size, double** A)
{
    std::cout << header << std::endl;
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
            std::cout << A[i][j] << " ";
        std::cout << std::endl;
    }

}
/// <summary>
/// Вывод на консоль вектора
/// </summary>
/// <param name="header">Заголовок</param>
/// <param name="size">размерность вектора</param>
/// <param name="x">вектор для выыода на консоль</param>
void PrintVector(const char* header, int size, double* x)
{
    std::cout << header << std::endl;
    for (int i = 0; i < size; i++)
        std::cout << x[i] << " ";
    std::cout << std::endl;

}
/// <summary>
/// Вычисление минора матрицы
/// </summary>
/// <param name="n">размерность матрицы</param>
/// <param name="A">матрица</param>
/// <param name="i">строка</param>
/// <param name="j">столбец</param>
/// <returns>значение минора</returns>
double Minor(int n, double **A,  int i, int j)
{
    if (i < 0 || j < 0 || i > n - 1 || j > n - 1) return 0.0;
    std::vector<std::vector<double>> vminor(n-1); // данные минора
    int k = 0, m, counter = -1;
    std::vector<double>str(n - 1);
    bool fill = true;

    // заполнение матрицы минора данными
    while(k < n)
    {
        fill = false;
        if (k != i)
        {
            str.clear();
            vminor.push_back(str);
            fill = true;
            counter++;
        }
        m = 0;
        while (m < n && fill && counter >= 0)
        {
            if (m != j)
            {
                vminor[counter].push_back(A[k][m]);
            }
            m++;
        }
        k++;
    }

    // получение матрицы минора
    double** minor = new double* [n - 1];
    for (k = 0; k < n - 1; k++)
    {
        minor[k] = new double[n - 1];
        for (m = 0; m < n - 1; m++)
        {
            minor[k][m] = vminor[k][m];
        }
        
    }

    // вычисление минора по его матрице
    double* b = nullptr, *x, det;
    LinearSystemSolve(n - 1, minor, b, x, det, true);
    
    for (k = 0; k < n - 1; k++)
        delete[] minor[k];
    delete [] minor;

    return det;
}