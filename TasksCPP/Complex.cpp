#include "Complex.h"
/// <summary>
/// Перегрузка операторов
/// </summary>
/// <param name="v1"></param>
/// <param name="v2"></param>
/// <returns></returns>
Complex operator + (Complex& v1, Complex& v2)
{
	return Complex(v1.Re + v2.Re, v1.Im + v2.Im);
}
bool operator==(Complex& v1, Complex& v2)
{
	return v1.Re == v2.Re && v1.Im == v2.Im;
}
bool operator!=(Complex& v1, Complex& v2)
{
	return !(v1.Re == v2.Re && v1.Im == v2.Im);
}
Complex operator - (Complex& v1, Complex& v2)
{
	return Complex(v1.Re - v2.Re, v1.Im - v2.Im);
}
Complex operator * (Complex& v1, Complex& v2)
{
	return Complex(v1.Re * v2.Re - v1.Im * v2.Im, v1.Im * v2.Re + v2.Im * v1.Re);
}
Complex operator / (Complex& v1, Complex& v2)
{
	double module = v2.Re * v2.Re + v2.Im * v2.Im;
	double re = (v1.Re * v2.Re + v1.Im * v1.Im) / module;
	double im = (v2.Re * v1.Im - v1.Re * v2.Im) / module;
	return Complex(re, im);
}
std::string Complex::ToString()
{
	std::string s1;
	s1 = std::to_string(Re);
	if (Im >= 0.0)
		s1 += " + i";
	else
		s1 += " - i";
	s1 += std::to_string(abs(Im));
	return s1;
}


