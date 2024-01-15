using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSalary
{
    /// <summary>
    /// Пользователи
    /// </summary>
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
    /// <summary>
    /// Простые справочники
    /// </summary>
    public class SimpleRef
    { 
        public long id { get; set; } 
        public string name { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
    /// <summary>
    /// Преподаватель
    /// </summary>
    public class Teacher: SimpleRef
    {
        public long idpost { get; set; }
        public long iddepartment { get; set; }
        public double salary { get; set; }
    }
    /// <summary>
    /// Группа студентов
    /// </summary>
    public class Group
    { 
        public long id { get; set; } 
        public string number { get; set; }
        public int year { get; set; }
        public override string ToString()
        {
            return number;
        }
    }
    /// <summary>
    /// Ведомость занятий
    /// </summary>
    public class Sheet
    {
        public long id { get; set; }
        public DateTime classdate { get; set; }
        public long iddiscipline { get; set; }
        public long idclasstype { get; set; }
        public long idteacher { get; set; }
        public long? idgroup { get; set; }
        public int hours { get; set; }
    }
    /// <summary>
    /// Отображение ведомости на главном виде
    /// </summary>
    public class SheetView : Sheet
    {
        public string discipline { get; set; }
        public string classtype { get; set; }
        public string teacher { get; set; }
        public string stgroup { get; set; }
        public long iddepartment { get; set; }

    }
}
