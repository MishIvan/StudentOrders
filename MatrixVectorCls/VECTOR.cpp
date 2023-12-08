#include "VECTOR.h"
/// <summary>
/// ����������� �������: ��������� ������ ��� ��������� � ������������� ��������� ������� ���������� val
/// </summary>
/// <param name="n">����������� �������</param>
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
/// ����������� ����������� ������� src
/// </summary>
/// <param name="src">�������� ������ ��� �����������</param>
VECTOR::VECTOR(const VECTOR& src)
{
	if (!this->m_data) delete[] this->m_data;
	this->m_data = new double[src.m_size];
	this->m_size = src.m_size;
	for (int i = 0; i < this->m_size; i++)
		*(this->m_data + i) = *(src.m_data + i);
}

/// <summary>
/// ���������� ����� ������� (��������� � ���������� ������ �������)
/// </summary>
/// <returns>y���� �������</returns>
double VECTOR::length()
{
	double val = 0.0;
	for (int i = 0; i < m_size; i++)
		val += *(m_data + i) * *(m_data + i);
	return sqrt(val);
}

/// <summary>
/// 
/// </summary>
/// <param name="src">�������� ������ ��� ����������</param>
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
/// ���������� ��������� ������������ �������� v1 � v2
/// ������� ������ ���� ����� �����������
/// </summary>
/// <param name="v1">������ ������</param>
/// <param name="v2">������ ������</param>
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
/// ���������� ���������� ��������� � �������� �������� v1 � v2
/// ����������� �������� ������ ���������
/// </summary>
/// <param name="v1"></param>
/// <param name="v2"></param>
/// <returns>������ - �������� (�����) ��������  </returns>
VECTOR operator-(const VECTOR& v1, const VECTOR& v2)
{
	if (v1.m_size != v2.m_size) return VECTOR(3);
	VECTOR res(v1.m_size);
	for (int i = 0; i < res.m_size; i++)
		*(res.m_data + i) = *(v1.m_data + i) - *(v2.m_data + i);
	return res;
}

VECTOR operator+(const VECTOR& v1, const VECTOR& v2)
{
	if (v1.m_size != v2.m_size) return VECTOR(3);
	VECTOR res(v1.m_size);
	for (int i = 0; i < res.m_size; i++)
		*(res.m_data + i) = *(v1.m_data + i) - *(v2.m_data + i);
	return res;
}

/// <summary>
/// ���������� ��������� ������ �� ������� ��� � �������� ����� (���� ����� ����� ������� ��� ������)
/// </summary>
/// <param name="s"></param>
/// <param name="v">������</param>
/// <returns></returns>
ostream& operator<<(ostream& s, VECTOR& v)
{
	int n = v.m_size;
	for (int i = 0; i < n; i++)
		s << *(v.m_data + i) << ' ';
	return s;
}
/// <summary>
/// ���������� ��������� ����� � ������� ��� � �������� ����� (���� ������ ���� ������ ��� ������) 
/// </summary>
/// <param name="s"></param>
/// <param name="v">������</param>
/// <returns></returns>
istream& operator>>(istream& s, VECTOR& v)
{
	int n = v.m_size;
	for (int i = 0; i < n; i++)
		s >> *(v.m_data + i);
	return s;
}

/// <summary>
/// ������ ������� �� ���������� �����
/// </summary>
/// <param name="fileName">������ ��� �����</param>
/// <param name="vect">������, ����������� �� ������ �����</param>
/// <returns>true - � ������ ��������� ���������� ������, false - � ������ ������ </returns>
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
/// ������ ������ � ��������� ����
/// </summary>
/// <param name="fileName">������ ��� ���������� �����</param>
/// <returns>true - � ������ ��������� ���������� ������, false - � ������ ������</returns>
bool VECTOR::writeToFile(const char* fileName, VECTOR& vect)
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
/// ����������. ������������ ������
/// </summary>
VECTOR::~VECTOR()
{
	if (m_data) delete[] m_data;
}
