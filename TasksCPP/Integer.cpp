#include "Integer.h"
/// <summary>
/// Является ли число простым
/// </summary>
/// <returns>true - является, false - число имеет делители, не простое</returns>
bool Integer::IsSimple()
{
	FindDividers();
	int n = dividers.size();
	return n < 1;
}
/// <summary>
/// Найти делители числа и записать их в вектор делителей
/// </summary>
void Integer::FindDividers()
{
	if (dividers.size() > 0) return; // делители уже найдены
	for (int i = 2; i < value; i++)
	{
		if (value % i == 0) dividers.push_back(i);
	}
}
/// <summary>
/// Является ли число совершенным
/// </summary>
/// <returns>true - число совершенное, false - не совершенное число</returns>
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

