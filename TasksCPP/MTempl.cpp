#pragma once
#include "Tasks.h"
#include <iostream>

// Задача №12

/// <summary>
/// Шаблон функциисчитывающей матрицу
/// выдача количества столбцов, содержащих хотя бы один элемент
/// выдача строки с самой длинной серией одинаковых элементов
/// </summary>
/// <typeparam name="T">тип (double, int, float)</typeparam>
/// <param name="matrix">Матрица</param>
/// <param name="rows">число строк</param>
/// <param name="cols">число столбцов</param>
template <typename T>
void ReadMatrixT(T** matrix, int rows, int cols)
{
	// количество столбцов содержащих хотя бы один нулевой элемент
	int k = 0;
	for (int j = 0; j < cols; j++)
		for (int i = 0; i < rows; i++)
			if (matrix[i][j] == 0) {
				k++; break;
			}
	std::cout << "Количество столбцов, содержащих хотя бы один нулевой элемент: " << k << std::endl;


	// номер строки, в которой находится самая длинная серия элементов
	std::vector<T> series(rows);
	for (int i = 0; i < rows; i++)
	{
		int p = 0; // самая длинная серия в строке
		int kmax = 1;
		while (p < cols)
		{
			int val = matrix[i][p]; k = 1;
			for (int j = 0; j < cols; j++)
				if (matrix[i][j] == val && p != j) k++;

			if (k > kmax) kmax = k;
			p++;
		}
		series[i] = kmax;
	}

	k = 1;
	int p = -1;
	for (int i = 0; i < series.size(); i++)
	{
		if (series[i] > k && series[i] != 1) { k = series[i]; p = i; }
	}
	if (p > 0)
		std::cout << "Строка с самой длииной серией : " << p + 1 << std::endl;
	else
		std::cout << "Элементы строк матрицы различаются" << std::endl;
}
