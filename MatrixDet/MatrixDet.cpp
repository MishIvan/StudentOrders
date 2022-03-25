// MatrixDet.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <math.h>
#include <fstream>

void GetFullPathInWD(char* fullExePath, const char* dataFileName, char* fullFileName);
void LinearSystemSolve(int n, double** A, double* b, double* &x, double& det);
void ReadData(const char* fullFileName, double** &A, double* &b, int& size);
double errNorm(int n, double** A, double* b, double* x);
void PrintMatrix(const char* header, int size, double** A);
void PrintVector(const char* header, int size, double* x);

int main(int argc, char* argv[])
{
    setlocale(LC_ALL, "");
    char path[1024];
    double** A;
    double* b;
    double* x;
    double norm, det;
    int size = 0;
    GetFullPathInWD(argv[0], "MatrixT1.txt", path);
    ReadData(path, A, b, size);
    PrintMatrix("Матрица А", size, A);
    PrintVector("Вектор b", size, b);
    LinearSystemSolve(size, A, b, x, det);
    PrintVector("Решение", size, x);
    norm = errNorm(size, A, b, x);
    std::cout << "Норма ошибки " << norm << std::endl;
    std::cout << "Детерминант матрицы А " << det << std::endl;
    for (int i = 0; i < size; i++)
        delete[] A[i];
    delete A;
    delete b;
    delete x;

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


void LinearSystemSolve(int n, double** A, double* b, double* &x, double& det)
{
    double **gamma = new double *[n];
    double **alpha = new double *[n];
    double* beta = new double[n];
    x = new double[n];

    // инициализируем нулём
    for(int i = 0; i < n ;i++)
    {
        x[i] = 0.0;
        beta[i] = 0.0;
        gamma[i] = new double[n];
        alpha[i] = new double[n];
        for (int j = 0; j < n; j++)
        {
            alpha[i][j] = 0.0; gamma[i][j] = 0.0;
        }
    }

    for (int i = 0; i < n; i++)
        gamma[i][0] = A[i][0];
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
                sum += gamma[i][j] * alpha[j][k];
            }
            gamma[i][k] = A[i][k] - sum;
        }
        else
        {
            sum = 0.0;
            for (int j = 0; j <= i - 1; j++)
            {
                sum += gamma[i][j] * alpha[j][k];
            } 
            alpha[i][k] = (A[i][k] - sum)/gamma[i][i];
        }
        k++;
    }
    PrintMatrix("Gamma", n, gamma);
    PrintMatrix("Alpha", n, alpha);
    beta[0] = b[0] / A[0][0];
    for (int i = 1; i < n; i++)
    {
        sum = 0.0;
        for (int j = 0; j <= i - 1; j++)
            sum += gamma[i][j] * beta[j];
        beta[i] = (b[i] -  sum)/gamma[i][i];
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
    PrintVector("Beta", n, beta);
    for (i = 0; i < n; i++)
        delete [] alpha[i];
    delete [] alpha;
    delete [] beta;
    det = 1.0;
    for (int i = 0; i < n; i++)
        det *= gamma[i][i];
    for (i = 0; i < n; i++)
        delete[] gamma[i];
    delete [] gamma;
}

/// <summary>
///  Евклидова норма погрешности вычисления 
/// </summary>
/// <param name="n"></param>
/// <param name="A"></param>
/// <param name="b"></param>
/// <param name="x"></param>
/// <returns></returns>
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
void ReadData(const char* fullFileName, double** &A, double* &b, int& size)
{
    std::fstream inp;
    inp.open(fullFileName, std::ios::in);
    // динамический массив
    if (inp.is_open())
    {
        inp >> size;
        A = new double *[size];
        b = new double[size];
        for (int i = 0; i <= size; i++)
        {
            
            if (i <= size - 1)
            {
                A[i] = new double[size];
                for (int j = 0; j < size; j++)
                    inp >> A[i][j];
            }
            else
            {
                for (int j = 0; j < size; j++)
                    inp >> b[j];

            }
        }

    }
    inp.close();
}
/// <summary>
/// Вывод матрицы на консоль
/// </summary>
/// <param name="header">Заголовок</param>
/// <param name="size">равзмерность</param>
/// <param name="A">матрица</param>
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
/// <param name="header"></param>
/// <param name="size"></param>
/// <param name="x"></param>
void PrintVector(const char* header, int size, double* x)
{
    std::cout << header << std::endl;
    for (int i = 0; i < size; i++)
        std::cout << x[i] << " ";
    std::cout << std::endl;

}