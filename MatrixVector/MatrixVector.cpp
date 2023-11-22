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

int main(int argc, char *argv[])
{
    setlocale(LC_ALL, ""); // для от ображения кириллицы
    char path[1024]; // буфер пути файла данных
    /*
    /// Вектор. Считывание данных
    GetFullPathInWD(argv[0], "Vector_in.txt", path);
    VECTOR v(1);
    bool success = VECTOR::readFromFile(path, v);
    if (success)
    {
        cout << "Вектор разменостью " << v.size() << endl;
        cout << v << endl;
    }

    /// Вектор. Считывание данных с консоли и запись в файл
    VECTOR v_in(5);
    cout << "Введите вектор размерностью 5 с консоли" << endl;
    cin >> v_in;
    cout << "Вектор разменостью " << v_in.size() << endl;
    cout << v_in << endl;
    GetFullPathInWD(argv[0], "Vector_out.txt", path);
    VECTOR::writeToFile(path, v_in);
    */

    /// Матрица. Считывание из файла
    GetFullPathInWD(argv[0], "Matrix_in.txt", path);
    MATRIX matr(3,3);
    bool success = MATRIX::readFromFile(path, matr);
    if (success)
    {
        cout << "Матрица " << matr.rows() << " x " << matr.columns() << endl;
        cout << matr << endl;
    }

    ///  Матрица. Ввод с консоли и запись в файл
    MATRIX matr_in(3, 5);
    cout << "Введите матрицу 3 х 5 с консоли" << endl;
    cin >> matr_in;
    cout << "Введена матрица" << endl;
    cout << matr_in << endl;
    GetFullPathInWD(argv[0], "Matrix_out.txt", path);
    MATRIX::writeToFile(path, matr_in);

    //cout << "Нажмите любую клавишу для завершения работы программы" << endl;
    //getchar();

}

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
