#pragma once
#include <string>
#include <vector>
/// <summary>
/// Класс Студент
/// </summary>
class STUDENT
{
	std::string name; // ФИО студента
	std::string group; // группа студента
	std::vector<int> marks; // оценки студента
public:
	STUDENT(std::string &Name, std::string &Group, std::vector<int> &Marks)
	{
		name = Name;
		group = Group;
		int n = Marks.size();
		for (int i = 0; i < n; i++)
			marks.push_back(Marks[i]);
	}
	std::string getName() { return name; }
	std::string getGroup() { return group; }
	bool HasBadMark();	
	int getMark(int i);
	~STUDENT()
	{
		marks.~vector();	
	}
};

