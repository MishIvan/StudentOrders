#include "MATRIX.h"
/// <summary>
/// Конструктор матрицы M x N, всем элементам которой присваивается значение val
/// </summary>
/// <param name="M">число строк матрицы</param>
/// <param name="N">число столбцов матрицы</param>
/// <param name="val"></param>
MATRIX::MATRIX(int M, int N, double val)
{
	m_columns = m_rows = 0;
	m_data = 0;
	if (M < 1 || N < 1) return;
	m_rows = M; m_columns = N;
	this->m_data = new double[this->m_rows * this->m_columns];
	for (int i = 0; i < M; i++)
		for (int j = 0; j < N; j++)
			*(m_data + i * m_columns + j) = val;
}
/// <summary>
/// Конструктор копирования матрицы из матрицы src 
/// </summary>
/// <param name="src">исходная матрица для копирования</param>
MATRIX::MATRIX(const MATRIX& src)
{
	if (!this->m_data) delete[] this->m_data;
	this->m_columns = src.m_columns;
	this->m_rows = src.m_rows;
	this->m_data = new double[this->m_rows * this->m_columns];
	for (int i = 0; i < this->m_rows; i++)
		for (int j = 0; j < this->m_columns; j++)
			*(this->m_data + i * this->m_columns + j) = *(src.m_data + i*src.m_columns +j);
}
/// <summary>
/// Перегрузка оператора присваивания
/// </summary>
/// <param name="src">матрица для присваивания</param>
/// <returns></returns>
MATRIX& MATRIX::operator=(const MATRIX& src)
{
	if (!this->m_data) delete[] this->m_data;
	this->m_columns = src.m_columns;
	this->m_rows = src.m_rows;
	this->m_data = new double[this->m_rows * this->m_columns];
	for (int i = 0; i < this->m_rows; i++)
		for (int j = 0; j < this->m_columns; j++)
			*(this->m_data + i * this->m_columns + j) = *(src.m_data + i * src.m_columns + j);
	return *this;
}
/// <summary>
/// Перегрузка оператора умножения матриц matr1 и matr2
/// Число столбцов матрицы matr1 должно быть равно числу строк матрицы matr2
/// </summary>
/// <param name="matr1">первая матрица</param>
/// <param name="matr2">вторая матрица</param>
/// <returns>матрицу, произведение</returns>
MATRIX& operator*(const MATRIX& matr1, const MATRIX& matr2)
{
	MATRIX pmatr(matr1.m_rows, matr2.m_columns);
	if (matr1.m_columns != matr2.m_rows) return pmatr;
	int i, j;
	for(i = 0; i < matr1.m_rows; i++)
		for (j = 0; j < matr2.m_columns; j++)
		{
			double prod = 0.0;
			for (int k = 0; k < matr1.m_columns; k++)
				prod += *(matr1.m_data + i * matr1.m_columns + k) * *(matr2.m_data + k * matr2.m_columns + j);
			*(pmatr.m_data + i * pmatr.m_columns + j) = prod;
		}
	return pmatr;
}
/// <summary>
/// Перегрузка оператора вывода на консоль или в файловый поток (файл должен быть открыт для чтения) 
/// </summary>
/// <param name="s"></param>
/// <param name="matr">матрица</param>
/// <returns></returns>
ostream& operator<<(ostream& s, MATRIX& matr)
{
	int m = matr.m_rows;
	int n = matr.m_columns;
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++)
			s << *(matr.m_data + i * n + j) << ' ';
	return s;
}
/// <summary>
/// Перегрузка оператора ввода с консоли или в файловый поток (файл должен быть открыт для записи) 
/// </summary>
/// <param name="s"></param>
/// <param name="matr">матрица</param>
/// <returns></returns>
istream& operator>>(istream& s, MATRIX& matr)
{
	int m = matr.m_rows;
	int n = matr.m_columns;
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++)
			s >> *(matr.m_data + i * n + j);
	return s;
}
/// <summary>
/// Считывание данных их файла и загрузка их в матрицу matr
/// </summary>
/// <param name="fileName">полное имя файла</param>
/// <param name="matr">матрица</param>
/// <returns>true - в случае успешного считывания данных, false - в случае ошибки</returns>
bool MATRIX::readFromFile(const char* fileName, MATRIX& matr)
{
	ifstream fs;
	fs.open(fileName);
	if (fs.is_open())
	{
		fs >> matr.m_rows >> matr.m_columns;
		fs >> matr;
		return true;
	}
	return false;
}
/// <summary>
///  Запись данных в файл
/// </summary>
/// <param name="fileName">полное имя файла для записи</param>
/// <returns>true - в случае успешного считывания данных, false - в случае ошибки</returns>
bool MATRIX::writeToFile(const char* fileName, MATRIX& matr)
{
	ofstream fs;
	fs.open(fileName);
	if(fs.is_open()){
		fs << matr.m_rows << ' ' << matr.m_columns << endl;
		fs << matr;
		return true;
	}
	return false;
}
/// <summary>
/// Деструктор: освобождение памяти, занимаемой под матрицу
/// </summary>
MATRIX::~MATRIX()
{
	if (!m_data) delete[] m_data;
}