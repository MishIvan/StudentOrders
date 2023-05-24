using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascents
{
    /// <summary>
    /// Альпинисты и их спортивный разряды
    /// </summary>
    public class Person : AbstractPerson
    {
        public int rank { get; set; }
        public string rankname { get; set; }
        public DateTime birthdate { get; set; }
        public bool closed { get; set; }
        public string comments { get; set; }
        public string closedname { get; set; }
        public override string ToString()
        {
            return name + ", " + rankname;
        }
    }
    public class AbstractPerson
    {
        public long id { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
    /// <summary>
    /// Отображение члена группы альпинистов при введении информации о восхождении
    /// </summary>
    public class Group : AbstractPerson
    {
        public bool leader { get; set; }
    }
    /// <summary>
    /// Вершина
    /// </summary>
    public class Peak
    {
        public long id { get; set; }
        public string name { get; set; }
        public double height { get; set; }
        public int idmountains { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
    /// <summary>
    /// Горная система
    /// </summary>
    public class Mountains
    {
        public int id { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
    public class PeakMountain : Peak
    {
        public string mountains { get; set; }
        public override string ToString()
        {
            return $"{name} ({height} м), {mountains}";
        }
    }
    public class Ascent
    {
        public long idascent { get; set; }
        public long idpeak { get; set; }
        public string peakname { get; set; }
        public double height { get; set; }
        public int idmountains { get; set; }
        public string mountains { get; set; }
        public DateTime ascdate { get; set; }
        public int status { get; set; }
        public string statusname { get; set; }
    }
    /// <summary>
    /// объект с информацмей для отчёта
    /// </summary>
    public class AscentReport
    {
        public string person { get; set; }
        public DateTime ascdate { get; set; }
        public string peakname { get; set; }
        public double height { get; set; }
        public string mountains { get; set; }
    }
}
