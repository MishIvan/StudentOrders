#include <vector>
#include <iostream>
#include "Tasks.h"

/// ----------------------------------------------------------
/// Задача №2
/// ----------------------------------------------------------
/// <summary>
/// Вычисление длины вектора
/// </summary>
/// <param name="v1">вектор</param>
/// <returns>длина вектора</returns>
double Length(std::vector<double> v1)
{
	int size = v1.size();
	double val = 0.0;
	for (int i = 0; i < size; i++)
		val += v1[i] * v1[i];
	return sqrt(val);
}
/// <summary>
/// Вычисление скалярного произведения векторов
/// </summary>
/// <param name="v1">первый вектор</param>
/// <param name="v2">второй вектор</param>
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
/// Определить, являются ли веторы коллинеарными
/// </summary>
/// <param name="v1">первый ветор</param>
/// <param name="v2">второй вектор</param>
/// <returns>true - если коллинеарны, false - если не коллинеарны</returns>
bool IsVectorsCollinear(std::vector<double> v1, std::vector<double> v2)
{
	if (v1.size() != v2.size()) return false;
	if (Length(v1) == 0.0 && Length(v2) == 0.0)
		return true;
	else if ((Length(v1) == 0.0 && Length(v2) != 0.0) ||
		(Length(v1) != 0.0 && Length(v2) == 0.0)
		)
		return false;
	// если косинус угла между векторами равен 1.0 (или -1.0), то вектора коллинеарны
	else
	{
		double cang = Scalar(v1, v2) / (Length(v1) * Length(v2));
		return abs(cang - 1.0) < EPS || abs(cang + 1.0) < EPS;
	}
}

/// ----------------------------------------------------------
/// Задача №5
/// ----------------------------------------------------------

/// <summary>
/// Определение суммы отрицательных элементов до максимального элемента
/// и положительных элементов после максимального элемента
/// </summary>
/// <param name="v1">исходный вектор</param>
/// <param name="isNegative">true - сумма отрицательных, false - сумма положительных чисел</param>
/// <returns>сумму элементов</returns>
double SumElements(std::vector<double> v1, bool isNegative)
{
	// определить максимальный элемент
	double maxel = v1[0];
	int size = v1.size();
	int idx = -1; // индекс максимального элемента
	for (int i = 1; i < size; i++)
	{
		if (v1[i] > maxel) { idx = i; maxel = v1[i]; }
	}

	double sum = 0.0;
	if (isNegative)
	{
		// определить сумму отрицательных элементов до максимального элемента
		for (int i = 0; i < idx; i++)
			sum += v1[i] < 0.0 ? v1[i] : 0.0;

	}
	else
	{
		// определить сумму положительных элементов после максимального элемента
		for (int i = idx + 1; i < size; i++)
			sum += v1[i] > 0.0 ? v1[i] : 0.0;

	}
	return sum;
}
/// ----------------------------------------------------------
/// Задача №6
/// ----------------------------------------------------------

/// <summary>
/// Возвращает вектор, элементы которого расположены в обратном порядке
/// относительно исходного вектора
/// </summary>
/// <param name="Src">исходный вектор</param>
/// <returns>вектор в обратном порядке</returns>
std::vector<int> ReverseVector(std::vector<int> &Src)
{
	std::vector<int> Dest;
	for (std::vector<int>::reverse_iterator it = Src.rbegin(); it != Src.rend(); ++it)
		Dest.push_back(*it);
	return Dest;
}
/// <summary>
/// Убрать из вектора первый и последний элементы
/// </summary>
/// <param name="Src">вектор</param>
void EraseFirstAndLast(std::vector<int> &Src)
{
	std::vector<int>::iterator it = Src.erase(Src.begin());
	Src.erase(it + Src.size() - 1);
}

/// ----------------------------------------------------------
/// Задача №8
/// ----------------------------------------------------------

/// <summary>
/// Рассчитать количество прямоугольных и равносторонних треугольников
/// </summary>
/// <param name="n">Количество треугольников</param>
void InputOutputTriangle(int n)
{
	std::vector<SidedTriangle> vt(n);	
	for (int i = 0; i < n; i++)
	{
		std::cout << "Введите данные по длинам сторон треугольника № " << i + 1 << std::endl;
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
	std::cout << "Равносторонних треугольников: " << nes << std::endl;
	std::cout << "Прямоугольных тругольниов: " << nra << std::endl;
	vt.~vector();

}

		
