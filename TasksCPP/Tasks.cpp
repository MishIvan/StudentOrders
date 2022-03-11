#include <vector>
#include <iostream>
#include <fstream>
#include "Tasks.h"
#include <direct.h>
#include <windows.h>
#include <tchar.h>
#include "Student.h"

#define MATRIX_ROWS 4
#define MATRIX_COLUMNS 5
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

// ������� 7

void ReadMatrix(const char* fileName)
{
	std::fstream inp;
	inp.open(fileName, std::ios::in);
	// ���������� ���������� �������
	//int matrix[MATRIX_ROWS][MATRIX_COLUMNS];
	// ������������ ������
	int** matrix = new int* [MATRIX_ROWS];
	for (int i = 0; i < MATRIX_ROWS; i++)
		matrix[i] = new int[MATRIX_COLUMNS];
	if (inp.is_open())
	{
		for (int i = 0; i < MATRIX_ROWS; i++)
			for (int j = 0; j < MATRIX_COLUMNS; j++)
				inp >> matrix[i][j];

		// ���������� �������� ���������� ���� �� ���� ������� �������
		int k = 0;
		for (int j = 0; j < MATRIX_COLUMNS; j++)
			for (int i =0; i < MATRIX_ROWS; i++)
				if (matrix[i][j] == 0) {
					k++; break;
				}
		std::cout << "���������� ��������, ���������� ���� �� ���� ������� �������: " << k << std::endl;
		
		
		// ����� ������, � ������� ��������� ����� ������� ����� ���������
		std::vector<int> series(MATRIX_ROWS);
		for (int i = 0; i < MATRIX_ROWS; i++)
		{
			int p = 0; // ����� ������� ����� � ������
			int kmax = 1;
			while (p < MATRIX_COLUMNS)
			{
				int val = matrix[i][p]; k = 1;
				for (int j = 0; j < MATRIX_COLUMNS; j++)
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
		if(p > 0)
			std::cout << "������ � ����� ������� ������ : " << p+1 << std::endl;
		else
			std::cout << "�������� ����� ������� �����������" << std::endl;

		// ��� ���������� ������� ������ ��������� � delete
		for (int i = 0; i < MATRIX_ROWS; i++)
			delete matrix[i];
		delete matrix;

	}
	inp.close();
}

// ������ 16

/// <summary>
/// �������������� ������ ��������� ������� �� ���, ����� �� ������
/// </summary>
/// <param name="students">������ ���������</param>
void SortStudents(std::vector<STUDENT>& students)
{
	std::vector<STUDENT> sorted;
	
	std::string s1;	
	std::vector<STUDENT>::iterator it;
	while (!students.empty())
	{
		s1 = students[0].getName() + students[0].getGroup();
		// ����� ������ ������� �������� � ���������� �������
		int k = -1;
		int n = students.size();
		for (int i = 0; i < n; i++)
		{
			STUDENT student = students[i];
			std::string ng = student.getName() + student.getGroup();
			// ����� 
			if (ng < s1) {
				s1 = ng; k = i;
			}
		}

		// ��������� � ������������� ������
		if (k >= 0)
		{
			sorted.push_back(students[k]);
			it = students.begin();
			students.erase(it + k);
		}
		else 
		{
			if (!students.empty())
			{
				sorted.push_back(students[0]);
				it = students.begin();
				students.erase(it);
			}
		}
	}

	// ����������� ��������� � �������� ������ �� ��������������
	int n = sorted.size();
	for (int i = 0; i < n; i++)
	{
		students.push_back(sorted[i]);
	}
	sorted.~vector();
}

/// <summary>
/// �������������� ������ ��������� ������� �� ���, ����� �� ������
/// </summary>
/// <param name="fileName">��� �����</param>
/// <param name="students">������ ���������</param>
void ReadStudentsFromFile(const char * fileName, std::vector<STUDENT>& students)
{
	std::fstream inp;
	inp.open(fileName, std::ios::in);
	if (inp.is_open())
	{
		int n;
		char buff1[512], buff2[16];
		std::string name, group;
		std::vector<int> vmarks;
		inp >> n;
		int marks[5];
		for (int i = 0; i < n; i++)
		{
			inp >> buff1 >> buff2;
			strcat_s(buff1, 512, " ");
			strcat_s(buff1, 512, buff2);
			name = buff1;
			inp >> buff1;
			group = buff1;
			inp >> marks[0] >> marks[1] >> marks[2] >> marks[3] >> marks[4];
			vmarks.clear();
			for (int j = 0; j < 5; j++)
				vmarks.push_back(marks[j]);
			STUDENT student(name, group, vmarks);
			students.push_back(student);
		}

	}
	inp.close();

}

/// <summary>
/// ������ ���������� � ��������� � �������� ���� 
/// </summary>
/// <param name="fileName">��� �����</param>
/// <param name="students">������ ���������</param>
void WriteStudentsToFileB(const char* fileName, std::vector<STUDENT>& students)
{
	std::fstream inp;
	inp.open(fileName, std::ios::out | std::ios::binary);
	if (inp.is_open())
	{
		int n = students.size();
		inp.write((char *)&n, sizeof(int));
		for (int i = 0; i < n; i++)
		{
			int m = students[i].getName().size();
			inp.write((char*)&m, sizeof(int));
			inp.write(students[i].getName().data(), m);

			m = students[i].getGroup().size();
			inp.write((char*)&m, sizeof(int));
			inp.write(students[i].getGroup().data(), m);
			
			for (int j = 0; j < 5; j++)
			{
				m = students[i].getMark(j);
				inp.write((char*)&m, sizeof(int));
			}
				
		}
	}
	inp.close();
}

/// <summary>
/// ���������� ���������� � ��������� � �������� �����
/// </summary>
/// <param name="fileName">��� �����</param>
/// <param name="students">������ ���������</param>
void ReadStudentsFromFileB(const char* fileName, std::vector<STUDENT>& students)
{
	std::fstream inp;
	inp.open(fileName, std::ios::in | std::ios::binary);
	std::string name, group;
	std::vector<int> mark(5);

	if (inp.is_open())
	{
		int n;
		int m;
		inp.read((char *)&n, sizeof(int));
		char buff[512];
		for (int i = 0; i < n; i++)
		{
			inp.read((char*)&m, sizeof(int));
			inp.read(buff, m);
			buff[m] = '\0';
			name = buff;
			inp.read((char*)&m, sizeof(int));
			buff[0] = '\0';
			inp.read(buff, m);
			buff[m] = '\0';
			group = buff;
			for (int j = 0; j < 5; j++)
			{
				inp.read((char*)&m, sizeof(int));
				mark[j] = m;
			}
								
			STUDENT student(name, group, mark);
			students.push_back(student);
		}
	}
	inp.close();
}

		
