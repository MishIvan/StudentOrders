#pragma once
#include "VECTOR.h"
/// <summary>
/// ����� "�������" ������� ������� M x N
/// </summary>
class MATRIX
{
protected:
	const int MIN_SIZE_FOR_THREAD = 100; // ����������� ������ �������, ������� � �������� ����������� ������ ��� ���������� �������� �������
	int m_rows; //  ����� �����
	int m_columns; // ����� ��������
	double* m_data; // ������ �������
	double FormMatrixCompactScheme(MATRIX& alpha);
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
	MATRIX Transpose();
	MATRIX Reverse();

	double Determinant();
	double Minor(int i, int j);
	bool IsSymmetric();

	static bool readFromFile(const char* fileName, MATRIX& matr);
	static bool writeToFile(const char* fileName, MATRIX& matr);
	
	friend bool Gauss(const MATRIX& a, const VECTOR& b, VECTOR& x);
	friend void CompactSchemeSolve(MATRIX& A, VECTOR& b, VECTOR& x);
	friend void QRDecompositionSolve(MATRIX& A, VECTOR& b, VECTOR& x);
	friend void LLTDecompositionSolve(MATRIX& A, VECTOR& b, VECTOR& x);
	

	bool QRDecomposition(MATRIX& Q, MATRIX& R);
	bool CholeskyDecomposition(MATRIX& L);

	~MATRIX();
};

class MATRIXEXT : public MATRIX
{
public:
	MATRIXEXT(int M, int N) : MATRIX(M, N) {};
	int getCountNotNumsUnderMD(double val);
	
};

