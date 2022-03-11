#pragma once
#include <string>
#include <vector>
/// <summary>
/// ����� �������
/// </summary>
class STUDENT
{
	std::string name; // ��� ��������
	std::string group; // ������ ��������
	std::vector<int> marks; // ������ ��������
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

