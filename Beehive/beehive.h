// класс, реализующий модель улья
#ifndef BEEHIVE_H
#define BEEHIVE_H
#include "abee.h"
#include <vector>
#include <iostream>

using namespace std;

class BeeHive
{
    double m_nectarStore; // запасы нектара
    double m_honeyStore; // запасы мёда

    // время жизни матки, строителя и собирателя
    double m_motherLiveTime;
    double m_builderLiveTime;
    double m_collectorLiveTime;

    // предел жизненных сил матки, строителя и собирателя
    double m_motherLiveEnergy;
    double m_builderLiveEnergy;
    double m_collectorLiveEnergy;

    // норматив потребления для поддержания жизненных сил
    // для матки, строителя и собирателя
    double m_motherConsumption;
    double m_builderConsumption;
    double m_collectorConsumption;

    // среднее количество нектара, которое несёт собиратель за рейс
    double m_nectarPerTrip;

    vector <CollectorBee> m_collectors;
    vector <BuilderBee> m_builders;
    MotherBee m_mother;

public:
    BeeHive();

    // ввод параметров модели и заведение пчёл в улье
    // функция вызывается сразу же после вызова конструктора
    void Populate();
};

#endif // BEEHIVE_H
