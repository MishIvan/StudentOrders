#include "Integer.h"
/// <summary>
/// �������� �� ����� �������
/// </summary>
/// <returns>true - ��������, false - ����� ����� ��������, �� �������</returns>
bool Integer::IsSimple()
{
	FindDividers();
	int n = dividers.size();
	return n < 1;
}
/// <summary>
/// ����� �������� ����� � �������� �� � ������ ���������
/// </summary>
void Integer::FindDividers()
{
	if (dividers.size() > 0) return; // �������� ��� �������
	for (int i = 2; i < value; i++)
	{
		if (value % i == 0) dividers.push_back(i);
	}
}
/// <summary>
/// �������� �� ����� �����������
/// </summary>
/// <returns>true - ����� �����������, false - �� ����������� �����</returns>
bool Integer::IsPerfect()
{
	if (IsSimple()) return false;
	FindDividers();
	int k = 1;
	int n = dividers.size();
	for (int i =0; i < n; i++)
	{
		k += dividers[i];
	}
	return k == value;
}

