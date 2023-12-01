#pragma once
#include <iostream> 
#include <fstream>
#include <math.h>

using namespace std;
class MATRIX;

/// <summary>
/// ����� ������ - n-������ ������
/// </summary>
class VECTOR
{
	double* m_data;
	int m_size;
public:
	VECTOR(int n, double val = 0.0);
	VECTOR(const VECTOR& src);
	inline int size() { return m_size; } // ������� ����������� �������
	double norm();

	VECTOR& operator=(const VECTOR& src);
	friend double operator*(const VECTOR& v1, const VECTOR& v2);
	friend VECTOR operator+(const VECTOR& v1, const VECTOR& v2);
	friend VECTOR operator-(const VECTOR& v1, const VECTOR& v2);
	friend ostream& operator<<(ostream& s, VECTOR& v);
	friend istream& operator>>(istream& s, VECTOR& v);
	static bool readFromFile(const char* fileName, VECTOR& vect);
	static bool writeToFile(const char* fileName, VECTOR& vect);
	friend VECTOR operator*(const MATRIX& matr, const VECTOR& v);

	friend bool Gauss(const MATRIX& a, const VECTOR& b, VECTOR& x);
	friend void CompactSchemeSolve(MATRIX& A, VECTOR& b, VECTOR& x);
	friend void QRDecompositionSolve(MATRIX& A, VECTOR& b, VECTOR& x);
	friend void LLTDecompositionSolve(MATRIX& A, VECTOR& b, VECTOR& x);

	~VECTOR();
};

