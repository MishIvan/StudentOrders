#include "beehive.h"

BeeHive::BeeHive()
{
    m_mother = 0;
    m_isAlive = true;
    m_nectarStore = 0.0;
    m_koeffHoneyStore = 0.8;
    m_honeyStore = 0.0;
}

BeeHive::~BeeHive()
{
    m_builders.clear();
    m_collectors.clear();
    if(m_mother!=0) delete m_mother;
}

bool BeeHive::isAlive()
{ return m_isAlive;}

void BeeHive::populate()
{
    cout << "��������� ������ ��� (��. ����������): ";
    cin >> m_honeyStore;

    cout << "������� ����� ����� ��� �����, ��������� � ���������� (��. �������): ";
    cin >> MotherBee::m_ageLimit >> BuilderBee::m_ageLimit >> CollectorBee::m_ageLimit;

    cout << "������� ������� ��������� ��� ��� �����, ��������� � ���������� (��. ����������): ";
    cin >> MotherBee::m_liveEnergyLimit >> BuilderBee::m_liveEnergyLimit >> CollectorBee::m_liveEnergyLimit;

    cout << "������� ����� ����������� ��� �����, ��������� � ���������� (��. ���������� � ��. �������)";
    cin >> MotherBee::m_normConsumption >> BuilderBee::m_normConsumption >> CollectorBee::m_idleConsumption;

    cout << "������� ������� ���������� �������, ������� �������� ���������� �� ���� ���� (��. ����������): ";
    cin >> CollectorBee::m_nectarToTrip;

    // ��������� ���� ���������� � �����������
    int nbuild, ncollect;
    cout << "������� ���������� ���� ���������� � �����������: ";
    cin >> nbuild >> ncollect;
    for(int i=0; i < nbuild; i++)
    {
        BuilderBee bee;
        m_builders.push_back(bee);
    }

    for(int i=0; i < ncollect; i++)
    {
        CollectorBee bee;
        m_collectors.push_back(bee);
    }

    // ��������� �����
    m_mother = new MotherBee();
}

void BeeHive::dispatchCollectors(int count)
{
    if(count < 1) return;
    int n = m_collectors.size();
    for(int i=0; i < n; i++)
    {
        if(m_collectors[i].status() == IDLE)
        {
            m_collectors[i].setStatus(IN_TRIP);
            if(--count < 1) break;
        }
    }

}

double BeeHive::overallConsumption(bool norm)
{
    double val = 0.0;
    // ��������� ��������� ����������
    int n = m_builders.size();
    for(int i=0; i < n; i++)
    {
        val += norm ? BuilderBee::m_normConsumption : m_builders[i].consumption();
    }

    // ���������� �� ���������� � �����
    n = m_collectors.size();
    for(int i=0; i < n; i++)
    {
        double cons = norm ?  m_collectors[i].normConsumption() :m_collectors[i].consumption();
        val += m_collectors[i].status() != IN_TRIP ? cons : 0.0;
    }

    val += norm ? MotherBee::m_normConsumption : m_mother->consumption();
    return val;
}

void BeeHive::correctPopulationQuantity()
{

    bool motherLiveOver = MotherBee::m_ageLimit <= m_mother->age();

    if(m_mother->currentLiveEnergy() < MotherBee::m_liveEnergyLimit*0.01
            || motherLiveOver)
    {
        if(motherLiveOver) // �������� ����� �����
        {
            delete m_mother;
            m_mother = new MotherBee();
            m_isAlive = true;
        }
        else
        {
            m_isAlive = false;
            return;
        }
    }

    int i = 0;
    while(i < (int)m_builders.size())
    {
        if(m_builders[i].currentLiveEnergy() < BuilderBee::m_liveEnergyLimit*0.01
                || BuilderBee::m_ageLimit <= m_builders[i].age())
            m_builders.erase(m_builders.begin() + i);
        else
            i++;
    }
    if(m_builders.empty())
    {
        m_isAlive = false;
        return;
    }
    i = 0;
    while(i < (int)m_collectors.size())
    {
        if(m_collectors[i].currentLiveEnergy() < CollectorBee::m_liveEnergyLimit*0.01
                || CollectorBee::m_ageLimit <= m_collectors[i].age())
            m_collectors.erase(m_collectors.begin() + i);
        else
            i++;
    }
    if(m_collectors.empty())
    {
        m_isAlive = false; return;
    }
    cout << "���������� ���������� :" << m_builders.size() << endl;
    cout << "���������� �����������: " << m_collectors.size() << endl;
}

int BeeHive::calculateIdleCollectors()
{
    int q = 0;
    int n = m_collectors.size();
    for(int i = 0; i <n; i++)
    {
        if(m_collectors[i].status() == IDLE) { q++; }
    }
    return q;
}

void BeeHive::setBeesAge()
{
    int n = m_collectors.size();   
    for(int i = 0; i <n; i++)
        m_collectors[i].setAge(m_collectors[i].age() + 1);
    n = m_builders.size();
    for(int i = 0; i <n; i++)
        m_builders[i].setAge(m_builders[i].age() + 1);
    m_mother->setAge(m_mother->age() + 1);

}

void BeeHive::generateWorkingBees(int ncollectors, int nbuilders)
{
    for(int i = 0; i < ncollectors; i++)
    {
        CollectorBee bee;
        m_collectors.push_back(bee);
    }

    for(int i = 0; i < nbuilders; i++)
    {
        BuilderBee bee;
        m_builders.push_back(bee);
    }
}

void BeeHive::step()
{

    // ������ �������
    int n = m_collectors.size();
    double nectarq = 0.0;
    for(int i = 0; i <n; i++)
    {
        if(m_collectors[i].status() == IN_TRIP)
        {
            nectarq += CollectorBee::m_nectarToTrip;
            m_collectors[i].decreaseLiveEnergy();
            m_collectors[i].setStatus(RECREATION);
            m_collectors[i].setConsumption(0.0);
        }
    }
    m_nectarStore += nectarq;

    // ��������� ���
    n = m_builders.size();
    double qn = m_nectarStore/n; // ������� ������� ���������� �� ���� �����-���������
    if(qn > 10.0) // �����-��������� �������������� �������� 10 ��. �������
       qn = 10.0;
     double qhoney = 0.0;
     for(int i = 0; i <n; i++)
     {
         qhoney += m_builders[i].produceHoney(qn);
         m_builders[i].decreaseLiveEnergy();
         m_nectarStore -= qn;
     }
     m_honeyStore += qhoney; // ���������� �������

     // ����� ����������� �� ��. �������
     cout << "������� �������: " << nectarq << endl;
     cout << "���������� ���: " << qhoney << endl;
     cout << "������ �������: " << m_nectarStore << endl;
     cout << "������ ���: " << m_honeyStore << endl << endl;
     cout << "����������� �������" << endl;

     // ����������� ������� ��� �����������������
     double overallNorm = overallConsumption(true);

     // ���������� �������� �����������
      double overall = overallConsumption(false);

      // ����������
      n = m_collectors.size();
      for(int i = 0; i <n; i++)
      {
          double cons = m_honeyStore*m_koeffHoneyStore < overallNorm ?
              m_honeyStore*m_koeffHoneyStore*m_collectors[i].consumption()/overall :
                   m_collectors[i].normConsumption();
           CollectorStatus st = m_collectors[i].status();

           if(st != IN_TRIP)
           {
                m_collectors[i].setConsumption(cons); // �����������
                m_collectors[i].increaseLiveEnergy(); // ���������� ��������� �������
            }

             //��������, ��������� �� �������������� ��������� ��� ����������
             if(st == RECREATION)
             {
                 //  ������ �� �����-���������� � �������� � ����
                 if(m_collectors[i].currentLiveEnergy() >= CollectorBee::m_liveEnergyLimit*0.85)
                       m_collectors[i].setStatus(IDLE);
             }

       }

      n = m_builders.size();
       for(int i = 0; i <n; i++)
       {
           double cons = m_honeyStore*m_koeffHoneyStore < overallNorm ?
               m_honeyStore*m_koeffHoneyStore*m_builders[i].consumption()/overall :
                    BuilderBee::m_normConsumption;
           m_builders[i].setConsumption(cons); // �����������
           m_builders[i].increaseLiveEnergy(); // ���������� ��������� �������

       }

       double cons = m_honeyStore*m_koeffHoneyStore < overallNorm ?
                   m_honeyStore*m_koeffHoneyStore*m_mother->consumption()/overall :
                   MotherBee::m_normConsumption;
       m_mother->setConsumption(cons); // �����������
       m_mother->increaseLiveEnergy(); // ���������� ��������� �������

       m_honeyStore -= overall;
       cout << "������ ���: " << m_honeyStore << endl;

       // ��������� �����������, ������ � ����� �� �����
       n = m_collectors.size();
       for(int i = 0; i <n; i++)
       {

              if(m_collectors[i].status() == IN_TRIP)
                  m_collectors[i].setStatus(RECREATION);
        }

}
