#include "timespan.h"
#include <math.h>
#include <regex>

TimeSpan::TimeSpan()
{
        m_hours = 0; m_minutes = 0; m_seconds = 0;
}
TimeSpan::TimeSpan(int hr, int mn, int s = 0)
{
    m_hours = hr; m_minutes = mn; m_seconds = s;
}
TimeSpan::TimeSpan(double secs)
{
    m_hours = (int)floor(secs/3600.0);
    m_minutes = (int)floor((secs - m_hours*3600.0)/60.0);
    m_seconds = (int)floor(secs - m_hours*3600.0 - m_minutes*60.0);
}

double TimeSpan::Seconds()
{
    return m_hours*3600.0 + m_minutes*60.0 + m_seconds;
}

string TimeSpan::toString()
{
    char buff[16];
    sprintf(buff,"%02d:%02d:%02d", m_hours, m_minutes, m_seconds);
    return string(buff);

}

bool TimeSpan::Parse(string strTime, TimeSpan &ts)
{
     regex rexp ("[0-9]+");
     string s1 = strTime;
     smatch m;
     int val[3] = {0,0,0};
     int j = 0;
     while(regex_search(s1, m, rexp))
     {
         int n = m.size();
         for(int i =0; i < n; i++)
         {
             try {
                 val[j] = stoi(m[i]);
             } catch (...) {
                 return false;
             }
         }
         j++;
         s1 = m.suffix().str();
     }
     if(val[0] < 0 || val[0] > 23 || val[1] < 0 || val[1] > 59 || val[2] < 0 || val[2] > 59)
         return false;
     ts = TimeSpan(val[0], val[1], val[2]);
        return true;

}

// перегрузка операторов
TimeSpan& TimeSpan::operator = (TimeSpan ts)
{
    this->m_hours = ts.m_hours;
    this->m_minutes = ts.m_minutes;
    this->m_seconds = ts.m_seconds;
    return *this;
}

bool operator > (TimeSpan one, TimeSpan two)
{
      return one.Seconds() > two.Seconds();
}

bool operator >= (TimeSpan one, TimeSpan two)
{
      return one.Seconds() >= two.Seconds();
}


bool operator < (TimeSpan one, TimeSpan two)
{
      return one.Seconds() < two.Seconds();
}

bool operator <= (TimeSpan one, TimeSpan two)
{
      return one.Seconds() < two.Seconds();
}


bool operator == (TimeSpan one, TimeSpan two)
{
      return one.Seconds() == two.Seconds();
}

 TimeSpan operator - (TimeSpan one, TimeSpan two)
{
      double secs =  one.Seconds() - two.Seconds();
      return TimeSpan(secs);
}

 TimeSpan operator + (TimeSpan one, TimeSpan two)
{
      double secs =  one.Seconds() + two.Seconds();
      return TimeSpan(secs);
}

 ostream& operator<< (ostream &os, const  TimeSpan & ts)
 {
      os << ((TimeSpan)ts).toString();
      return os;
 }

 istream& operator>> (istream &is,  TimeSpan & ts)
 {
      string s1;      
      is >> s1;
      TimeSpan::Parse(s1, ts);
      return is;
 }
