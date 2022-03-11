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

// Задание 7

void ReadMatrix(const char* fileName)
{
	std::fstream inp;
	inp.open(fileName, std::ios::in);
	// объявление локального массива
	//int matrix[MATRIX_ROWS][MATRIX_COLUMNS];
	// динамический массив
	int** matrix = new int* [MATRIX_ROWS];
	for (int i = 0; i < MATRIX_ROWS; i++)
		matrix[i] = new int[MATRIX_COLUMNS];
	if (inp.is_open())
	{
		for (int i = 0; i < MATRIX_ROWS; i++)
			for (int j = 0; j < MATRIX_COLUMNS; j++)
				inp >> matrix[i][j];

		// количество столбцов содержащих хотя бы один нулевой элемент
		int k = 0;
		for (int j = 0; j < MATRIX_COLUMNS; j++)
			for (int i =0; i < MATRIX_ROWS; i++)
				if (matrix[i][j] == 0) {
					k++; break;
				}
		std::cout << "Количество столбцов, содержащих хотя бы один нулевой элемент: " << k << std::endl;
		
		
		// номер строки, в которой находится самая длинная серия элементов
		std::vector<int> series(MATRIX_ROWS);
		for (int i = 0; i < MATRIX_ROWS; i++)
		{
			int p = 0; // самая длинная серия в строке
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
			std::cout << "Строка с самой длииной серией : " << p+1 << std::endl;
		else
			std::cout << "Элементы строк матрицы различаются" << std::endl;

		// для локального массива убрать операторы с delete
		for (int i = 0; i < MATRIX_ROWS; i++)
			delete matrix[i];
		delete matrix;

	}
	inp.close();
}

// Задача 16

/// <summary>
/// Упорядочивание списка студентов сначала по ФИО, потом по группе
/// </summary>
/// <param name="students">список студентов</param>
void SortStudents(std::vector<STUDENT>& students)
{
	std::vector<STUDENT> sorted;
	
	std::string s1;	
	std::vector<STUDENT>::iterator it;
	while (!students.empty())
	{
		s1 = students[0].getName() + students[0].getGroup();
		// найти индекс первого студента в алфавитном порядке
		int k = -1;
		int n = students.size();
		for (int i = 0; i < n; i++)
		{
			STUDENT student = students[i];
			std::string ng = student.getName() + student.getGroup();
			// найти 
			if (ng < s1) {
				s1 = ng; k = i;
			}
		}

		// перенести в сортированный список
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

	// Перенесение элементов в исходный список из сортированного
	int n = sorted.size();
	for (int i = 0; i < n; i++)
	{
		students.push_back(sorted[i]);
	}
	sorted.~vector();
}

/// <summary>
/// Упорядочивание списка студентов сначала по ФИО, потом по группе
/// </summary>
/// <param name="fileName">имя файла</param>
/// <param name="students">список студентов</param>
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
/// Запись информации о студентах в двоичный файл 
/// </summary>
/// <param name="fileName">имя файла</param>
/// <param name="students">список студентов</param>
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
/// Считывание информации о студентах в двоичный файла
/// </summary>
/// <param name="fileName">имя файла</param>
/// <param name="students">список студентов</param>
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

		
