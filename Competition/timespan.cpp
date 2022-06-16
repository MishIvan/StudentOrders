#include "timespan.h"
#include <math.h>

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
        char tpart[4];
        int n = strTime.size();
        if(n != 5 && n != 8)
        { return false;}
        if(strTime[2] != ':')
         {return false;}
        if(n == 8 && strTime[5] != ':')
            return false;

        // преобразовать время в  чася минуты и секунды
        tpart[0] = strTime[0];
        tpart[1] = strTime[1];
        tpart[3] = '\0';
        if(!isdigit(tpart[0]) || !isdigit(tpart[1]))
            {return  false;}
        int i = atoi(tpart);
        if(i < 0 || i > 23 )
            return false;
        ts.m_hours = i;

        tpart[0] = strTime[3];
        tpart[1] = strTime[4];
        tpart[3] = '\0';
        if(!isdigit(tpart[0]) || !isdigit(tpart[1]))
            return false;
        i = atoi(tpart);
        if( i < 0 || i > 59 )
            return false;
        ts.m_minutes = i;

        if(strTime.size() == 8)
        {
            tpart[0] = strTime[6];
            tpart[1] = strTime[7];
            tpart[3] = '\0';
            if(!isdigit(tpart[0]) || !isdigit(tpart[1]))
                return false;
            i = atoi(tpart);
            if (i < 0 || i > 59 )
                return false;
            ts.m_seconds = i;
        }
        else
            ts.m_seconds = 0;
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
