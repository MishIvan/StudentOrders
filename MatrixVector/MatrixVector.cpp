// MatrixVector.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "MATRIX.h"

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
/// Тест перегрузки операции умножения матриц
/// </summary>
void TestMatrixMultiplication(char *appPath, char * path)
{
    GetFullPathInWD(appPath, "MatrixMult_in.txt", path);
    // считывание данных
    ifstream fs;
    fs.open(path);
    if (fs.is_open())
    {
        int m, n;
        fs >> m >> n;
        MATRIX A(m, n);
        fs >> A;
        cout << "Матрица A" << endl;
        cout << A;

        fs >> m >> n;
        MATRIX B(m, n);
        fs >> B;
        cout << endl << "Матрица B" << endl;
        cout << B;

        MATRIX C(A.rows(), B.columns());
        C = A * B;
        cout << endl << "Матрица C = A*B" << endl;
        cout << C;

        fs.close();
    }
}

/// <summary>
/// Тест перегрузки операции умножения матрицы на вектор 
/// </summary>
void TestMatrixVectorMultiplication(char* appPath, char* path)
{
    GetFullPathInWD(appPath, "MatrixVectMult_in.txt", path);
    // считывание данных
    ifstream fs;
    fs.open(path);
    if (fs.is_open())
    {
        int m, n;
        fs >> m >> n;
        MATRIX A(m, n);
        fs >> A;
        cout << "Матрица A" << endl;
        cout << A;

        fs >> n;
        VECTOR v(n);
        fs >> v;
        cout << endl << "Вектор v" << endl;
        cout << v;

        VECTOR vp(A.rows());
        vp = Multyply(A, v);
        cout << endl << "Вектор  vp= A*v" << endl;
        cout << vp;

        fs.close();
    }
}


int main(int argc, char *argv[])
{
    setlocale(LC_ALL, ""); // для от ображения кириллицы
    char path[1024]; // буфер пути файла данных
    
    /// Вектор. Считывание данных
    GetFullPathInWD(argv[0], "Vector_in.txt", path);
    VECTOR v(1);
    bool success = VECTOR::readFromFile(path, v);
    if (success)
    {
        cout << "Вектор размерностью " << v.size() << " считан из файла" << endl;
        cout << v << endl;
    }
    else
        cout << "Неудачная попытка чтения вектора из файла" << endl;

    /// Вектор. Считывание данных с консоли и запись в файл
    VECTOR v_in(5);
    cout << "Введите вектор размерностью 5 с консоли" << endl;
    cin >> v_in;
    cout << "Вектор разменостью " << v_in.size() << endl;
    cout << v_in << endl;
    GetFullPathInWD(argv[0], "Vector_out.txt", path);
    success = VECTOR::writeToFile(path, v_in);
    if (success)
        cout << "Вектор, введённый с консоли, записан в файл" << endl;
    else
        cout << "Неудачная попытка записи вектора, введённого с консоли" << endl;

    
    /// Матрица. Считывание из файла
    GetFullPathInWD(argv[0], "Matrix_in.txt", path);
    MATRIX matr(3,3);
    success = MATRIX::readFromFile(path, matr);
    if (success)
    {
        cout << "Считаны данные матрицы " << matr.rows() << " x " << matr.columns() << endl;
        cout << matr << endl;
    }
    else
        cout << "Неудачная попытка считывания данных матрицы" << endl;
    
    ///  Матрица. Ввод с консоли и запись в файл
    MATRIX matr_in(3, 5);
    cout << "Введите матрицу 3 х 5 с консоли" << endl;
    cin >> matr_in;
    //cout << "Введена матрица" << endl;
    //cout << matr_in << endl;
    GetFullPathInWD(argv[0], "Matrix_out.txt", path);
    success = MATRIX::writeToFile(path, matr_in);
    if (success)
        cout << "Матрица, введённая с консоли, записана в файл" << endl;
    else
        cout << "Неудачная попытка записи матрицы, введённой с консоли" << endl;
    
    /// Матрица. Умножение матриц
    TestMatrixMultiplication(argv[0], path);

    /// Матрица. Умножение вестора на матрицу
    TestMatrixVectorMultiplication(argv[0], path);
    
    /*
    ///  Матрицы
    MATRIXEXT A(4, 5);
    MATRIXEXT B(3, 7);
    double D;
    double Q;
    int DinA;
    int QinB;
    //ввод данных с подсказками
    cout << "Введите матрицу А(4х5):\n";
    cin >> A;
    cout << "Введите матрицу B(3х7):\n";
    cin >> B;
    std::cout << "Введите число D:\n";
    std::cin >> D;
    std::cout << "Введите число Q:\n";
    std::cin >> Q;

    //Поиск значений
    DinA = A.getCountNotNumsUnderMD(D);
    QinB = B.getCountNotNumsUnderMD(Q);
    
    //Вывод результатов
    cout << "Число элементов матрицы А стоящих ниже главной диагонали и равных D: "
        << D << ", равно " << DinA << endl;
    cout << "Число элементов матрицы B стоящих ниже главной диагонали и равных Q: "
        << Q << ", равно " << QinB << endl;
        */

}