#pragma once
/// <summary>
/// ����� �� ���������
/// </summary>
struct Point2D
{
	double x, y;
};
/// <summary>
/// �����������
/// </summary>
class Triangle
{
	Point2D A, B, C; // �����, ���������� �����������
public:
	Triangle(Point2D& A, Point2D& B, Point2D& C);
	double Perimeter();
	double Square();
	bool IsSingular();
	double Angle(int i);
	bool IsRightAngled();
};

