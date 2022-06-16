#ifndef TIMESPAN_H
#define TIMESPAN_H
#include <string>

using namespace std;

class TimeSpan
{
    int m_hours; // часы
    int m_minutes; // минуты
    int m_seconds; // секунды
    double Seconds();
public:
    TimeSpan();
    TimeSpan(int hr, int mn, int s);
    TimeSpan(double secs);
    string toString();
    static bool Parse(string , TimeSpan &);
    TimeSpan & operator = (TimeSpan  );
    friend bool operator > (TimeSpan , TimeSpan );
    friend bool operator < (TimeSpan one, TimeSpan two);
    friend bool operator <= (TimeSpan one, TimeSpan two);
    friend bool operator >= (TimeSpan one, TimeSpan two);
    friend bool operator == (TimeSpan one, TimeSpan two);
    friend TimeSpan operator -(TimeSpan one, TimeSpan two);
    friend TimeSpan operator +(TimeSpan one, TimeSpan two);
};

#endif // TIMESPAN_H
