#pragma once
#include <vector>
# include <math.h>
#include "Student.h"

#define EPS 1.0e-8
#define PI 3.1415926535897932384626433832795

bool IsVectorsCollinear(std::vector<double> v1, std::vector<double> v2);
double SumElements(std::vector<double> v1, bool isNegative);
std::vector<int> ReverseVector(std::vector<int> &Src);
void EraseFirstAndLast(std::vector<int> &Src);
void ReadMatrix(const char* fileName);
void SortStudents(std::vector<STUDENT>& students);
void ReadStudentsFromFile(const char* fileName, std::vector<STUDENT>& students);
void WriteStudentsToFileB(const char* fileName, std::vector<STUDENT>& students);
void ReadStudentsFromFileB(const char* fileName, std::vector<STUDENT>& students);

/// <summary>
/// ����������� ���������� ������� ��� ������
/// </summary>
struct SidedTriangle
{
	double a;
	double b;
	double c;
	/// <summary>
	/// �������� �� ����������� ��������������
	/// </summary>
	/// <returns>true - ����������� ��������������, false - ����������� �� ��������������</returns>
	bool IsEqualSided()
	{
		return abs(a - b) < EPS && abs(a - c) < EPS && abs(b-c) < EPS ;
	}

	/// <summary>
	/// �������� �� ����������� �������������
	/// </summary>
	/// <returns>true - ����������� ��������������, false - ����������� �� ��������������</returns>
	bool IsRightAngled()
	{
		return abs(a * a + b * b - c * c) < EPS || abs(a * a + c * c - b * b) < EPS || abs(c * c + b * b - a * a) < EPS;
	}

};
void InputOutputTriangle(int n);