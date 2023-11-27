#pragma once
#include "VECTOR.h"
/// <summary>
/// Класс "матрица" матрица размера M x N
/// </summary>
class MATRIX
{
protected:
	int m_rows; //  число строк
	int m_columns; // число столбцов
	double* m_data; // данные матрицы
	double FormMatrixCompactScheme(MATRIX& alpha);
public:
	MATRIX(int M, int N, double val = 0.0);
	MATRIX(const MATRIX& src);
	int rows() { return m_rows; }
	int columns() { return m_columns; }

	MATRIX& operator=(const MATRIX& src);
	friend MATRIX operator*(const MATRIX& matr1, const MATRIX& matr2);
	friend ostream& operator<<(ostream& s, MATRIX& matr);
	friend istream& operator>>(istream& s, MATRIX& matr);
	double Determinant();
	static bool readFromFile(const char* fileName, MATRIX& matr);
	static bool writeToFile(const char* fileName, MATRIX& matr);
	friend VECTOR operator*(const MATRIX& matr, const VECTOR& v);
	friend bool Gauss(const MATRIX& a, const VECTOR& b, VECTOR& x);
	friend void CompactSchemeSolve(MATRIX& A, VECTOR& b, VECTOR& x);

	~MATRIX();
};

class MATRIXEXT : public MATRIX
{
public:
	MATRIXEXT(int M, int N) : MATRIX(M, N) {};
	int getCountNotNumsUnderMD(double val);
	
};

