#pragma once
/// <summary>
/// Точка на плоскости
/// </summary>
struct Point2D
{
	double x, y;
};
/// <summary>
/// Треугольник
/// </summary>
class Triangle
{
	Point2D A, B, C; // точки, образующие треугольник
public:
	Triangle(Point2D& A, Point2D& B, Point2D& C);
	double Perimeter();
	double Square();
	bool IsSingular();
	double Angle(int i);
	bool IsRightAngled();
};

