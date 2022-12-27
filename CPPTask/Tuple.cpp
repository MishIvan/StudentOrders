#include "Tuple.h"

TupleSimple::TupleSimple(string one, int two, string three, string four, double five)
{
	m_tuple = new tuple<string, int, string, string, double>(one, two, three, four, five);
}
