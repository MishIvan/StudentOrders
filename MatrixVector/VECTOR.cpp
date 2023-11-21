#include "VECTOR.h"
/// <summary>
/// Конструктор вектора: выделение памяти под указатель и инициализация компонент вектора значениями val
/// </summary>
/// <param name="n">размерность вектора</param>
VECTOR::VECTOR(int n, double val)
{
	m_data = 0; m_size = 0;
	if (n < 1) 
		 return;
	m_size = n;
	m_data = new double[m_size];
	for (int i = 0; i < m_size; i++)
		*(m_data + i) = val;

}
/// <summary>
/// Конструктор копирования вектора src
/// </summary>
/// <param name="src">исходный вектор для копирования</param>
VECTOR::VECTOR(const VECTOR& src)
{
	if (!this->m_data) delete[] this->m_data;
	this->m_data = new double[src.m_size];
	this->m_size = src.m_size;
	for (int i = 0; i < this->m_size; i++)
		*(this->m_data + i) = *(src.m_data + i);
}
/// <summary>
/// 
/// </summary>
/// <param name="src">исходный вестор для присвоения</param>
/// <returns></returns>
VECTOR& VECTOR::operator=(const VECTOR& src)
{
	if (!this->m_data) delete[] this->m_data;
	this->m_data = new double[src.m_size];
	this->m_size = src.m_size;
	for (int i = 0; i < this->m_size; i++)
		*(this->m_data + i) = *(src.m_data + i);
	return *this;
}
/// <summary>
/// Возвращает скалярное произведение векторов v1 и v2
/// Вектора должны быть одной размерности
/// </summary>
/// <param name="v1">первый вектор</param>
/// <param name="v2">второй вектор</param>
/// <returns></returns>
double operator*(const VECTOR& v1, const VECTOR& v2)
{
	double prod = 0.0;
	if (v1.m_size != v2.m_size) return prod;
	for (int i = 0; i < v1.m_size; i++)
		prod += *(v1.m_data + i) * *(v2.m_data + i);
	return prod;
}
/// <summary>
/// Перегрузка оператора вывода на консоль или в файловый поток (файл нужно будет открыть для чтения)
/// </summary>
/// <param name="s"></param>
/// <param name="v">вектор</param>
/// <returns></returns>
ostream& operator<<(ostream& s, VECTOR& v)
{
	int n = v.m_size;
	for (int i = 0; i < n; i++)
		s << *(v.m_data + i) << ' ';
	return s;
}
/// <summary>
/// Перегрузка оператора ввода с консоли или в файловый поток (файл должен быть открыт для записи) 
/// </summary>
/// <param name="s"></param>
/// <param name="v">вектор</param>
/// <returns></returns>
istream& operator>>(istream& s, VECTOR& v)
{
	int n = v.m_size;
	for (int i = 0; i < n; i++)
		s >> *(v.m_data + i); 
	return s;
}

/// <summary>
/// Чтение вектора из текстового файла
/// </summary>
/// <param name="fileName">полное имя файла</param>
/// <param name="vect">вектор, создаваемый по данным файла</param>
/// <returns>true - в случае успешного считывания данных, false - в случае ошибки </returns>
bool VECTOR::readFromFile(const char* fileName, VECTOR& vect)
{
	ifstream fs;
	fs.open(fileName);
	if (fs.is_open())
	{
		int n = 0;
		fs >> n;
		if (n < 1) return false;
		VECTOR v_out(n);
		fs >> v_out;
		vect = v_out;
		fs.close();
		return true;
	}
	return false;
}
/// <summary>
/// Запись ветора в текстовый файл
/// </summary>
/// <param name="fileName">полное имя текстового файла</param>
/// <returns>true - в случае успешного считывания данных, false - в случае ошибки</returns>
bool VECTOR::writeToFile(const char* fileName, VECTOR &vect)
{
	ofstream fs;
	fs.open(fileName);
	if (fs.is_open())
	{
		int n = 0;
		fs << vect.m_size << endl;
		if (vect.m_size < 1) return false;
		fs << vect;
		fs.close();
		return true;
	}
	return false;

}
/// <summary>
/// Деструктор. Освобождение памяти
/// </summary>
VECTOR::~VECTOR()
{
	if (m_data) delete[] m_data;
}
