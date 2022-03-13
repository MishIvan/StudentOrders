#pragma once
#include "Tasks.h"
#include <iostream>

// ������ �12

/// <summary>
/// ������ ������������������ �������
/// ������ ���������� ��������, ���������� ���� �� ���� �������
/// ������ ������ � ����� ������� ������ ���������� ���������
/// </summary>
/// <typeparam name="T">��� (double, int, float)</typeparam>
/// <param name="matrix">�������</param>
/// <param name="rows">����� �����</param>
/// <param name="cols">����� ��������</param>
template <typename T>
void ReadMatrixT(T** matrix, int rows, int cols)
{
	// ���������� �������� ���������� ���� �� ���� ������� �������
	int k = 0;
	for (int j = 0; j < cols; j++)
		for (int i = 0; i < rows; i++)
			if (matrix[i][j] == 0) {
				k++; break;
			}
	std::cout << "���������� ��������, ���������� ���� �� ���� ������� �������: " << k << std::endl;


	// ����� ������, � ������� ��������� ����� ������� ����� ���������
	std::vector<T> series(rows);
	for (int i = 0; i < rows; i++)
	{
		int p = 0; // ����� ������� ����� � ������
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
		std::cout << "������ � ����� ������� ������ : " << p + 1 << std::endl;
	else
		std::cout << "�������� ����� ������� �����������" << std::endl;
}
