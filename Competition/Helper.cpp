#include<iostream>
#include <cmath>
#include<vector>
#include <algorithm>
#include <fstream>
#include "Helper.h"

using namespace std;

// Ввод данных участников соревнований по возрастным группам
// youngGroup - группа от 18 до 30 лет
// middleGroup  - группа от 31 до 55 лет
// oldGroup - группа от 56 до 75 лет
void InputDataFromConsole(vector<Participant> &youngGroup,
                          vector <Participant> &middleGroup,
                          vector<Participant> &oldGroup)
{
    cout << "Введите участников соревнований" << endl;

    TimeSpan tbegin[3];
    string age_groups[3] = {"от 18 до 30", "от 31 до 55", "от 56 до 75"};
    TimeSpan one, two;

    for(int i =0 ; i < 3; i++)
    {
          while(true)
          {
              string begin_time;
              cout << "Введите время старта для возрастной \r\nгруппы " << age_groups[i] <<" лет в формате HH:mm:ss: ";
              cin >> begin_time;
              if(!TimeSpan::Parse(begin_time, tbegin[i])) break;
                cerr << "Ошибка задания времени: " << begin_time[i] << endl;
          }
    }

    int count;
    while(true)
    {
        cout << "Введите количество участников соревнований (от 1 до 18): ";
        cin >> count;
        if(count >= 1 && count <= 18) break;
        else
          cerr << "Число участников соревнований должно находится в пределах от 1 до 18" << endl;
    }

    for(int i =0 ; i < count; i++)
    {
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        string fio;
        cout << "Введите ФИО участника: ";
        getline(cin,fio );

        int age = 0;
        do {
            cout << "Введите возраст участника: ";
            cin >> age;
          if(age < 18 || age > 75)
            cerr << "Возраст должен находиться в пределах от 18 до 75 лет." << endl;
        } while(age < 18 || age > 75);

        TimeSpan btime;
        if(age >=18 && age <=30)
            btime = tbegin[0];
        else if (age >=31 && age <=55)
            btime = tbegin[1];
        else
            btime = tbegin[2];

        string s1;
        TimeSpan etime;
        while(true)
        {
            cout << "Введите время финиша участника в формате HH:mm:ss:";
            cin >> s1;
            if(TimeSpan::Parse(s1, etime))
            {
                if(etime <= btime)
                    cerr << "Ошибка: старт не может быть раньше финиша" << endl;
                else
                    break;
            }
            else
                cerr << "Ошибка задания времени: " << s1 << endl;
        }

        Participant person;
        person.Name = fio;
        person.Age = age;
        person.TimeBegin = btime;
        person.TimeEnd = etime;
        if(age >=18 && age <=30)
        {
            if(youngGroup.size() >= 18)
                cerr << "Число участников не может быть более 18" << endl;
            else
                youngGroup.push_back(person);
        }
        else if (age >=31 && age <=55)
        {
            if(middleGroup.size() >= 18)
                cerr << "Число участников не может быть более 18" << endl;
            else
                middleGroup.push_back(person);
        }
        else
        {
            if(oldGroup.size() >= 18)
                cerr << "Число участников не может быть более 18" << endl;
            else
                oldGroup.push_back(person);
        }

    }
}

// Ввод данных об участниках соревнований по возрастной группе
// group - возрастная группа
// count - число участников
void OutputParticipantsToConsole(vector<Participant> &group, int count = 0)
{
    int n;
    if(count == 0) n = group.size();
    else n = min(count, (int)group.size());
    for(int i = 0; i < n; i++)
    {
        Participant elem  = group[i];
        cout << "-------------------------------------------------------" << endl;
        cout << "ФИО: " << elem.Name << endl;
        cout << "Возраст: " << elem.Age << endl;
        cout << "Время старта: " << elem.TimeBegin << endl;
        cout << "Время финиша: " << elem.TimeEnd << endl;
        cout << "Время прохождения дистанции: " << elem.TimeEnd - elem.TimeBegin << endl;
    }
}
// Функуия сравнения по времени для сортировки списка
int CompareByFinish(Participant one, Participant two)
{
      if(one.TimeEnd > two.TimeEnd) return 1;
      else if(one.TimeEnd < two.TimeEnd) return -1;
      else return 0;
}

bool ReadData(const char* fullFileName,
              vector<Participant> &youngGroup,
              vector <Participant> &middleGroup,
              vector<Participant> &oldGroup)
{
    fstream inp;
    inp.open(fullFileName, ios::in);

    if (inp.is_open())
    {
        try
        {
           TimeSpan tbegin[3];
            string begin_time[3];
            inp >> tbegin[0] >> tbegin[1] >> tbegin[2];

            int count;
            inp >> count;
            if(count < 1 || count > 18)
            {
                cerr << "Число участников соревнований должно находится в пределах от 1 до 18" << endl;
                inp.close();
                return false;
            }

            for(int i =0 ; i < count; i++)
            {
                string fio;
                inp.ignore(numeric_limits<streamsize>::max(), '\n');
                getline(inp,fio );

                string s1;
                int age = 0;
                TimeSpan etime, btime;
                 inp >> age >> etime;
                  if(age < 18 || age > 75)
                  {
                    cerr << "Возраст должен находиться в пределах от 18 до 75 лет." << endl;
                    inp.close();
                    return false;
                  }


                if(age >=18 && age <=30)
                    btime = tbegin[0];
                else if (age >=31 && age <=55)
                    btime = tbegin[1];
                else
                    btime = tbegin[2];

                  if(etime <= btime)
                   {
                       cerr << "Ошибка: старт не может быть раньше финиша" << endl;
                       inp.close();
                       return false;
                   }

                Participant person;
                person.Name = fio;
                person.Age = age;
                person.TimeBegin = btime;
                person.TimeEnd = etime;
                if(age >=18 && age <=30)
                {
                    if(youngGroup.size() >= 18)
                        cerr << "Число участников не может быть более 18" << endl;
                    else
                        youngGroup.push_back(person);
                }
                else if (age >=31 && age <=55)
                {
                    if(middleGroup.size() >= 18)
                        cerr << "Число участников не может быть более 18" << endl;
                    else
                        middleGroup.push_back(person);
                }
                else
                {
                    if(oldGroup.size() >= 18)
                        cerr << "Число участников не может быть более 18" << endl;
                    else
                        oldGroup.push_back(person);
                }

            }



        }

        catch (...)
        {
            inp.close();
            cerr << "Неверный формат файла " << fullFileName;
            return false;

        }

    inp.close();
    return true;
    }
    else
    {
        cerr << "Неверный формат файла " << fullFileName << " или файл не найден";
        return false;
    }
}

void WriteData(const char *fullFileName, vector<Participant> &group, const char *ngroup)
{
    fstream outp;
    outp.open(fullFileName, ios::out);

    if (outp.is_open())
    {
        int n =  group.size();
        outp << "Участники возрастной группы " << ngroup << endl << endl;
        Participant elem;
        for(int i = 0; i < n; i++)
        {
            elem  = group[i];
            outp << "-------------------------------------------------------" << endl;
            outp << "ФИО: " << elem.Name << endl;
            outp << "Возраст: " << elem.Age << endl;
            outp << "Время старта: " << elem.TimeBegin << endl;
            outp << "Время финиша: " << elem.TimeEnd << endl;
            outp << "Время прохождения дистанции: " << elem.TimeEnd - elem.TimeBegin << endl;
        }

        elem  = group[0];
        outp << endl << "!!! Чемпион возрастной группы !!!" << endl;
        outp << "ФИО: " << elem.Name << endl;
        outp << "Возраст: " << elem.Age << endl;
        outp << "Время старта: " << elem.TimeBegin << endl;
        outp << "Время финиша: " << elem.TimeEnd << endl;
        outp << "Время прохождения дистанции: " << elem.TimeEnd - elem.TimeBegin << endl;

        outp.close();
    }
    else
    {
        cerr << "Не удалось записать файл " << fullFileName << endl;
    }

}

