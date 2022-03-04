#include "Triangle.h"
#include <math.h>
#include "Tasks.h"
/// <summary>
/// Длина стороны AB
/// </summary>
/// <param name="A">точка А</param>
/// <param name="B">точка B</param>
/// <returns>длина стороны</returns>
double SideLenth(const Point2D& A, const Point2D& B)
{
	return sqrt((A.x - B.x) * (A.x - B.x) + (A.y - B.y) * (A.y - B.y));
}
/// <summary>
/// Вычисление скалярного произведения векторов BA и CA
/// </summary>
/// <param name="A">точка A</param>
/// <param name="B">точка B</param>
/// <param name="C">точка C</param>
/// <returns>скалярное произведение</returns>
double Scalar(const Point2D& A, const Point2D& B, const Point2D& C)
{
	Point2D vb;
	vb.x = B.x - A.x;
	vb.y = B.y - A.y;
	Point2D vc;
	vc.x = C.x - A.x;
	vc.y = C.y - A.y;
	return sqrt(vb.x * vc.x + vb.y * vc.y);


}
/// <summary>
/// Конструктор
/// </summary>
/// <param name="A">точка А</param>
/// <param name="B">точка B</param>
/// <param name="C">точка C</param>
Triangle::Triangle(Point2D& A, Point2D& B, Point2D& C)
{
	this->A.x = A.x;
	this->B.x = B.x;
	this->C.x = C.x;
}
/// <summary>
/// Вычисление периметра треугольника
/// </summary>
/// <returns>периметр треугольника</returns>
double Triangle::Perimeter()
{
	double a = SideLenth(A, B);
	double b = SideLenth(B, C);
	double c = SideLenth(A, C);
	return a + b + c;
}
/// <summary>
/// Вычисление площади треугольника
/// </summary>
/// <returns>площадь треугольника</returns>
double Triangle::Square()
{
	double a = SideLenth(A, B);
	double b = SideLenth(B, C);
	double c = SideLenth(A, C);
	double p = (a + b + c) * 0.5;
	return sqrt(p * (p - a) * (p - b) * (p - c));
}
/// <summary>
/// Определяет вырожденность треугольника (нулевая площадь)
/// </summary>
/// <returns>true - невырожденный, false - вырожденный</returns>
bool Triangle::IsSingular()
{
	return abs(Square()) < EPS;
}
/// <summary>
/// Определение углов треугольника в градусах
/// </summary>
/// <param name="i"></param>
/// <returns></returns>
double Triangle::Angle(int i)
{
	if (IsSingular() || i < 1 || i > 3) return 0.0;
	double a = SideLenth(A, B);
	double b = SideLenth(B, C);
	double c = SideLenth(A, C);

	switch (i)
	{
	case 1: // угол A
		return acos(Scalar(A, B, C)/(a*c))*180.0/PI;
	case 2: // угол B 
		return acos(Scalar(B, A, C) / (a * b)) * 180.0 / PI;
	case 3:	// угол C
		return acos(Scalar(C, A, B) / (c * b)) * 180.0 / PI;
	}
	return 0.0;
}
/// <summary>
/// Является ли треугольник прямоугольным
/// </summary>
/// <returns>true - тругольник прямоугольный, false - треугольник не прямоугольный</returns>
bool Triangle::IsRightAngled()
{
	for (int i = 0; i < 3; i++)
		if (abs(Angle(i) - 90.0) < EPS) return true;
	return false;
}



