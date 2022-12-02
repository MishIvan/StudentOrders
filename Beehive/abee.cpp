#include "abee.h"

ABee::ABee()
{
    m_liveTimeLimit = 0.0;
    m_consumption = 0.0;
    m_liveEnergyLimit = 0.0;
}

ABee::ABee(double live_limit, double consumption, double time_limit)
{
    m_liveTimeLimit = time_limit;
    m_consumption = consumption;
    m_liveEnergyLimit = live_limit;

}

double ABee::liveEnergyLimit() {return m_liveEnergyLimit;}
void ABee::setLiveEnergyLimit(double val) {m_liveEnergyLimit = val;}

double ABee::liveTimeLimit() {return m_liveTimeLimit;}
void ABee::setLiveTimeLimit(double val) {m_liveTimeLimit = val;}

double ABee::consumption() {return m_consumption;}
void ABee::setConsumption(double val) {m_consumption = val;}


MotherBee::MotherBee(double live_limit, double consumption,double time_limit) :
    ABee(live_limit, consumption, time_limit)
{

}
MotherBee::MotherBee() : ABee()
{

}

CollectorBee::CollectorBee(double live_limit, double consumption, double time_limit, double nectarToTrip) :
    ABee(live_limit, consumption, time_limit)
{
    m_Status = NOT_WORKED;
    m_idleConsumption = consumption;
    m_nectarToTrip = nectarToTrip;

}
CollectorStatus CollectorBee::status() {return m_Status;}
void CollectorBee::setStatus(CollectorStatus stat)
{
    m_Status = stat;
}
void CollectorBee::setConsumption(double builderConsumption)
{
    if(m_Status == IN_TRIP)
        m_consumption = m_idleConsumption + m_nectarToTrip*0.2;
    else if(m_Status == RECREATION)
          m_consumption = 4.0*builderConsumption;
    else
        m_consumption = m_idleConsumption;

}


BuilderBee::BuilderBee(double live_limit, double consumption, double time_limit) :
    ABee(live_limit, consumption, time_limit)
{

}
