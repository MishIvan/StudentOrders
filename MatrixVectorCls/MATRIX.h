#pragma once
#include "VECTOR.h"
/// <summary>
/// ����� "�������" ������� ������� M x N
/// </summary>
class MATRIX
{
protected:
	int m_rows; //  ����� �����
	int m_columns; // ����� ��������
	double* m_data; // ������ �������
public:
	MATRIX(int M, int N, double val = 0.0);
	MATRIX(const MATRIX& src);
	inline int rows() { return m_rows; }
	inline int columns() { return m_columns; }

	MATRIX& operator=(const MATRIX& src);
	double& operator()(int i, int j);
	friend MATRIX operator*(const MATRIX& matr1, const MATRIX& matr2);
	friend ostream& operator<<(ostream& s, MATRIX& matr);
	friend istream& operator>>(istream& s, MATRIX& matr);
	friend VECTOR operator*(const MATRIX& matr, const VECTOR& v);

	static bool readFromFile(const char* fileName, MATRIX& matr);
	static bool writeToFile(const char* fileName, MATRIX& matr);

	~MATRIX();
};
