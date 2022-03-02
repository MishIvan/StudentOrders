#pragma once
#include <vector>
# include <math.h>
#define EPS 1.0e-8

bool IsVectorsCollinear(std::vector<double> v1, std::vector<double> v2);
double SumElements(std::vector<double> v1, bool isNegative);
/// <summary>
/// “реугольник задачаемый длинами трЄх сторон
/// </summary>
struct SidedTriangle
{
	double a;
	double b;
	double c;
	/// <summary>
	/// явл€етс€ ли треугольник равносторонным
	/// </summary>
	/// <returns>true - треугольник равносторонний, false - треугольник не равносторонний</returns>
	bool IsEqualSided()
	{
		return abs(a - b) < EPS && abs(a - c) < EPS && abs(b-c) < EPS ;
	}

	/// <summary>
	/// явл€етс€ ли треугольник пр€моугольным
	/// </summary>
	/// <returns>true - треугольник равносторонний, false - треугольник не равносторонний</returns>
	bool IsRightAngled()
	{
		return abs(a * a + b * b - c * c) < EPS || abs(a * a + c * c - b * b) < EPS || abs(c * c + b * b - a * a) < EPS;
	}

};
void InputOutputTriangle(int n);