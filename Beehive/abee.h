#ifndef ABEE_H
#define ABEE_H
// статус собирателя (незадействован, в рейсе, на восстановлении)
enum CollectorStatus
{
    NOT_WORKED = 1, IN_TRIP, RECREATION
};

// пчела - базовый класс для всех пчёл
class ABee
{
protected:
    // предельное значение жизненной силы,
    // обнуление её означает смерть пчелы
    double m_liveEnergyLimit;
    double m_liveTimeLimit; // срок жизни в единицах времени
    double m_consumption; // потребление, ед. мёда в ед. времени
public:
    ABee();

    // параметры live_limit - предел жизненных сил
    // live_limit - предел жизненных сил
    // consumption - норматив потребления
    // time_limit - продолжительность жизни
    ABee(double live_limit, double consumption, double time_limit);

    // значение предела жизненной силы
    double liveEnergyLimit();
    void setLiveEnergyLimit(double val);

    // значение предела жизненной силы
    double liveTimeLimit();
    void setLiveTimeLimit(double val);

    // потребление
    double consumption();
    virtual void setConsumption(double val);
};

// матка
class MotherBee : public ABee
{
public:
    MotherBee();

    // параметры live_limit - предел жизненных сил
    // live_limit - предел жизненных сил
    // consumption - норматив потребления
    // time_limit - продолжительность жизни
    MotherBee(double live_limit, double consumption, double liveEnergy);
};

// пчела сборщик нектара
class CollectorBee : public ABee
{
    CollectorStatus m_Status;
    double m_idleConsumption;
    double m_nectarToTrip;
public:

    // параметры live_limit - предел жизненных сил
    // live_limit - предел жизненных сил
    // consumption - норматив потребления
    // time_limit - продолжительность жизни
    // nectarToTrip - количество нектара, переносимое за рейс
    CollectorBee(double live_limit, double consumption, double liveEnergy, double nectarToTrip);
    CollectorStatus status();
    void setStatus(CollectorStatus stat);
    void setConsumption(double builderConsumption);
};

// пчела строитель
class BuilderBee  : public ABee
{
public:
    // параметры live_limit - предел жизненных сил
    // live_limit - предел жизненных сил
    // consumption - норматив потребления
    // time_limit - продолжительность жизни
    BuilderBee(double live_limit, double consumption,double liveEnergy);
};

#endif // ABEE_H
