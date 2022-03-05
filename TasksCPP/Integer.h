#pragma once
#include <vector>
class Integer
{
	int value;
	std::vector<int> dividers;
public:
	Integer(int n) { value = n; }
	int GetValue() { return value; }
	bool IsSimple();
	void FindDividers();
	bool IsPerfect();
	~Integer() { dividers.clear(); }

};

