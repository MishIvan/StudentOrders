#include "Triangle.h"
#include <math.h>
#include "Tasks.h"
/// <summary>
/// ����� ������� AB
/// </summary>
/// <param name="A">����� �</param>
/// <param name="B">����� B</param>
/// <returns>����� �������</returns>
double SideLenth(const Point2D& A, const Point2D& B)
{
	return sqrt((A.x - B.x) * (A.x - B.x) + (A.y - B.y) * (A.y - B.y));
}
/// <summary>
/// ���������� ���������� ������������ �������� BA � CA
/// </summary>
/// <param name="A">����� A</param>
/// <param name="B">����� B</param>
/// <param name="C">����� C</param>
/// <returns>��������� ������������</returns>
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
/// �����������
/// </summary>
/// <param name="A">����� �</param>
/// <param name="B">����� B</param>
/// <param name="C">����� C</param>
Triangle::Triangle(Point2D& A, Point2D& B, Point2D& C)
{
	this->A.x = A.x;
	this->B.x = B.x;
	this->C.x = C.x;
}
/// <summary>
/// ���������� ��������� ������������
/// </summary>
/// <returns>�������� ������������</returns>
double Triangle::Perimeter()
{
	double a = SideLenth(A, B);
	double b = SideLenth(B, C);
	double c = SideLenth(A, C);
	return a + b + c;
}
/// <summary>
/// ���������� ������� ������������
/// </summary>
/// <returns>������� ������������</returns>
double Triangle::Square()
{
	double a = SideLenth(A, B);
	double b = SideLenth(B, C);
	double c = SideLenth(A, C);
	double p = (a + b + c) * 0.5;
	return sqrt(p * (p - a) * (p - b) * (p - c));
}
/// <summary>
/// ���������� ������������� ������������ (������� �������)
/// </summary>
/// <returns>true - �������������, false - �����������</returns>
bool Triangle::IsSingular()
{
	return abs(Square()) < EPS;
}
/// <summary>
/// ����������� ����� ������������ � ��������
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
	case 1: // ���� A
		return acos(Scalar(A, B, C)/(a*c))*180.0/PI;
	case 2: // ���� B 
		return acos(Scalar(B, A, C) / (a * b)) * 180.0 / PI;
	case 3:	// ���� C
		return acos(Scalar(C, A, B) / (c * b)) * 180.0 / PI;
	}
	return 0.0;
}
/// <summary>
/// �������� �� ����������� �������������
/// </summary>
/// <returns>true - ���������� �������������, false - ����������� �� �������������</returns>
bool Triangle::IsRightAngled()
{
	for (int i = 0; i < 3; i++)
		if (abs(Angle(i) - 90.0) < EPS) return true;
	return false;
}



