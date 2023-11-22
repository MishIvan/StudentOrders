#pragma once
#include <iostream> 
#include <fstream>

using namespace std;
class MATRIX;

/// <summary>
/// Класс вектор - n-мерный вектор
/// </summary>
class VECTOR
{
	double* m_data;
	int m_size;
public:
	VECTOR(int n, double val = 0.0);
	VECTOR(const VECTOR& src);
	int size() { return m_size; } // возврат размерности вектора

	VECTOR& operator=(const VECTOR& src);
	friend double operator*(const VECTOR& v1, const VECTOR& v2);
	friend ostream& operator<<(ostream& s, VECTOR& v);
	friend istream& operator>>(istream& s, VECTOR& v);
	static bool readFromFile(const char* fileName, VECTOR& vect);
	static bool writeToFile(const char* fileName, VECTOR& vect);
	friend class VECTOR& Multyply(const MATRIX& matr, const VECTOR& v);

	~VECTOR();
};

