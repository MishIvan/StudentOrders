#pragma once
#include <string>
#include <tuple>
using namespace std;

class TupleSimple
{
	tuple<string,int,string,string,double> *m_tuple;
public:
	TupleSimple(string, int, string, string, double);
	~TupleSimple() {}
};

