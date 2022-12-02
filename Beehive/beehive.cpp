#include "beehive.h"

BeeHive::BeeHive()
{
    m_nectarStore = 0.0;

}

void BeeHive::Populate()
{
    cout << "Введите сроки жизни для матки, строителя и собирателя (ед. времени): ";
    cin >> m_motherLiveTime >> m_builderLiveTime >> m_collectorLiveTime;

    cout << "Введите пределы жизненных сил для матки, строителя и собирателя (ед. количества мёда): ";
    cin >> m_motherLiveEnergy >> m_builderLiveEnergy >> m_collectorLiveEnergy;

    cout << "Введите нормы потребления для матки, строителя и собирателя (ед. количества мёда на ед. времени)";
    cin >> m_motherConsumption >> m_builderConsumption >> m_collectorConsumption;

    cout << "Введите среднее количество нектара, которое приности собиратель за один рейс: ";
    cin >> m_nectarPerTrip;

    // заведение пчёл строителей и собирателей
    int nbuild, ncollect;
    cout << "Введите количество пчёл строителей и собирателей: ";
    cin >> nbuild >> ncollect;
    for(int i=0; i < nbuild; i++)
    {
        BuilderBee bee(m_builderLiveEnergy, m_builderConsumption, m_builderLiveTime);
        m_builders.push_back(bee);
    }

    for(int i=0; i < ncollect; i++)
    {
        CollectorBee bee(m_collectorLiveEnergy, m_collectorConsumption,
                         m_collectorLiveTime, m_nectarPerTrip);
        m_collectors.push_back(bee);
    }

    // параметры матки
    m_mother.setConsumption(m_motherConsumption);
    m_mother.setLiveEnergyLimit(m_motherLiveEnergy);
    m_mother.setLiveTimeLimit(m_motherLiveTime);
}
