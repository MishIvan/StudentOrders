#pragma once
#include <iostream>
#include <string>

/// <summary>
/// Комплексное число
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
	/// Перегрузка оператора присваивания
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
	/// Возвращает сопряжённое число
	/// </summary>
	/// <returns>сопряжённое число</returns>
	Complex Conjugate()
	{
		return Complex(Re, -Im);
	}
	/// <summary>
	/// Преобразование для вывода числа на консоль
	/// <returns>Строковое представление числа</returns>
	/// </summary>
	std::string ToString();
	friend Complex operator + (Complex& v1, Complex& v2);
	friend bool operator==(Complex& v1, Complex& v2);
	friend bool operator!=(Complex& v1, Complex& v2);
	friend Complex operator - (Complex& v1, Complex& v2);
	friend Complex operator * (Complex& v1, Complex& v2);
	friend Complex operator / (Complex& v1, Complex& v2);

};

