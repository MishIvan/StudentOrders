#pragma once
#include "VECTOR.h"
/// <summary>
/// Класс "матрица" матрица размера M x N
/// </summary>
class MATRIX
{
	int m_rows; //  число строк
	int m_columns; // число столбцов
	double* m_data; // данные матрицы
public:
	MATRIX(int M, int N, double val = 0.0);
	MATRIX(const MATRIX& src);
	int rows() { return m_rows; }
	int columns() { return m_columns; }

	MATRIX& operator=(const MATRIX& src);
	friend MATRIX& operator*(const MATRIX& matr1, const MATRIX& matr2);
	friend ostream& operator<<(ostream& s, MATRIX& matr);
	friend istream& operator>>(istream& s, MATRIX& matr);
	static bool readFromFile(const char* fileName, MATRIX& matr);
	static bool writeToFile(const char* fileName, MATRIX& matr);

	~MATRIX();
};

