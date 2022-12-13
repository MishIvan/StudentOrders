#ifndef HELPER_H
#define HELPER_H
#include<iostream>
#include <vector>
#include "timespan.h"

// участник соревнований
struct Participant
{
    std::string Name; // ФИО участника
    TimeSpan TimeBegin; // Время старта
    TimeSpan TimeEnd; // Время финиша
    int Age; // возраст участника
};

void InputDataFromConsole(std::vector<Participant> & ,  std::vector <Participant> & , std::vector<Participant> & );
int CompareByFinish(Participant , Participant );
void OutputParticipantsToConsole(std::vector<Participant> & , int);
bool ReadData(const char* fullFileName, std::vector<Participant> &youngGroup,
              std::vector <Participant> &middleGroup,
              std::vector<Participant> &oldGroup);
void WriteData(const char * , std::vector<Participant> & , const char *);

#endif // HELPER_H
