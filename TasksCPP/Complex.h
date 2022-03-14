#pragma once
#include <iostream>
#include <string>

/// <summary>
/// ����������� �����
/// </summary>
class Complex
{
	double Re, Im;
public:
	Complex()
	{
		Re = 0.0; Im = 0.0;
	}
	Complex(double re, double im)
	{
		Re = re; Im = im;
	}	
	/// <summary>
	/// ���������� ��������� ������������
	/// </summary>
	/// <param name="val"></param>
	/// <returns></returns>
	Complex& operator=(const Complex& val)
	{
		Complex();
		Re = val.Re; Im = val.Im;
		return *this;
	}

	/// <summary>
	/// ���������� ���������� �����
	/// </summary>
	/// <returns>���������� �����</returns>
	Complex Conjugate()
	{
		return Complex(Re, -Im);
	}
	/// <summary>
	/// �������������� ��� ������ ����� �� �������
	/// <returns>��������� ������������� �����</returns>
	/// </summary>
	std::string ToString();
	friend Complex operator + (Complex& v1, Complex& v2);
	friend bool operator==(Complex& v1, Complex& v2);
	friend bool operator!=(Complex& v1, Complex& v2);
	friend Complex operator - (Complex& v1, Complex& v2);
	friend Complex operator * (Complex& v1, Complex& v2);
	friend Complex operator / (Complex& v1, Complex& v2);

};

