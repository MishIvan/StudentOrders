#include "Student.h"
bool STUDENT::HasBadMark()
{
	int n = marks.size();
	for (int i = 0; i < n; i++)
	{
		if (marks[i] < 3) return true;
	}
	return false;
}
int STUDENT::getMark(int i)
{
	return marks[i];
}
