#include <vector>
#include <iostream>
#include "Tasks.h"

/// ----------------------------------------------------------
/// ������ �2
/// ----------------------------------------------------------
/// <summary>
/// ���������� ����� �������
/// </summary>
/// <param name="v1">������</param>
/// <returns>����� �������</returns>
double Length(std::vector<double> v1)
{
	int size = v1.size();
	double val = 0.0;
	for (int i = 0; i < size; i++)
		val += v1[i] * v1[i];
	return sqrt(val);
}
/// <summary>
/// ���������� ���������� ������������ ��������
/// </summary>
/// <param name="v1">������ ������</param>
/// <param name="v2">������ ������</param>
/// <returns></returns>
double Scalar(std::vector<double> v1, std::vector<double> v2)
{
	int size = v1.size();
	if (v2.size() != size) return 0.0;
	double val = 0.0;
	for (int i = 0; i < size; i++)
		val += v1[i] * v2[i];
	return val;

}
/// <summary>
/// ����������, �������� �� ������ �������������
/// </summary>
/// <param name="v1">������ �����</param>
/// <param name="v2">������ ������</param>
/// <returns>true - ���� �����������, false - ���� �� �����������</returns>
bool IsVectorsCollinear(std::vector<double> v1, std::vector<double> v2)
{
	if (v1.size() != v2.size()) return false;
	if (Length(v1) == 0.0 && Length(v2) == 0.0)
		return true;
	else if ((Length(v1) == 0.0 && Length(v2) != 0.0) ||
		(Length(v1) != 0.0 && Length(v2) == 0.0)
		)
		return false;
	// ���� ������� ���� ����� ��������� ����� 1.0 (��� -1.0), �� ������� �����������
	else
	{
		double cang = Scalar(v1, v2) / (Length(v1) * Length(v2));
		return abs(cang - 1.0) < EPS || abs(cang + 1.0) < EPS;
	}
}

/// ----------------------------------------------------------
/// ������ �5
/// ----------------------------------------------------------

/// <summary>
/// ����������� ����� ������������� ��������� �� ������������� ��������
/// � ������������� ��������� ����� ������������� ��������
/// </summary>
/// <param name="v1">�������� ������</param>
/// <param name="isNegative">true - ����� �������������, false - ����� ������������� �����</param>
/// <returns>����� ���������</returns>
double SumElements(std::vector<double> v1, bool isNegative)
{
	// ���������� ������������ �������
	double maxel = v1[0];
	int size = v1.size();
	int idx = -1; // ������ ������������� ��������
	for (int i = 1; i < size; i++)
	{
		if (v1[i] > maxel) { idx = i; maxel = v1[i]; }
	}

	double sum = 0.0;
	if (isNegative)
	{
		// ���������� ����� ������������� ��������� �� ������������� ��������
		for (int i = 0; i < idx; i++)
			sum += v1[i] < 0.0 ? v1[i] : 0.0;

	}
	else
	{
		// ���������� ����� ������������� ��������� ����� ������������� ��������
		for (int i = idx + 1; i < size; i++)
			sum += v1[i] > 0.0 ? v1[i] : 0.0;

	}
	return sum;
}
/// ----------------------------------------------------------
/// ������ �6
/// ----------------------------------------------------------

/// <summary>
/// ���������� ������, �������� �������� ����������� � �������� �������
/// ������������ ��������� �������
/// </summary>
/// <param name="Src">�������� ������</param>
/// <returns>������ � �������� �������</returns>
std::vector<int> ReverseVector(std::vector<int> &Src)
{
	std::vector<int> Dest;
	for (std::vector<int>::reverse_iterator it = Src.rbegin(); it != Src.rend(); ++it)
		Dest.push_back(*it);
	return Dest;
}
/// <summary>
/// ������ �� ������� ������ � ��������� ��������
/// </summary>
/// <param name="Src">������</param>
void EraseFirstAndLast(std::vector<int> &Src)
{
	std::vector<int>::iterator it = Src.erase(Src.begin());
	Src.erase(it + Src.size() - 1);
}

/// ----------------------------------------------------------
/// ������ �8
/// ----------------------------------------------------------

/// <summary>
/// ���������� ���������� ������������� � �������������� �������������
/// </summary>
/// <param name="n">���������� �������������</param>
void InputOutputTriangle(int n)
{
	std::vector<SidedTriangle> vt(n);	
	for (int i = 0; i < n; i++)
	{
		std::cout << "������� ������ �� ������ ������ ������������ � " << i + 1 << std::endl;
		std::cin >> vt[i].a;
		std::cin >> vt[i].b;
		std::cin >> vt[i].c;
	}
	int nes = 0;
	int nra = 0;
	for (int i = 0; i < vt.size(); i++)
	{
		if (vt[i].IsEqualSided()) nes++;
		if (vt[i].IsRightAngled()) nra++;
	}
	std::cout << "�������������� �������������: " << nes << std::endl;
	std::cout << "������������� �����������: " << nra << std::endl;
	vt.~vector();

}

		
