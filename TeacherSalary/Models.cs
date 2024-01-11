﻿using System;
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

    public class Teacher: SimpleRef
    {
        public long idpost { get; set; }
        public long iddepartment { get; set; }
        public double salary { get; set; }
    }
}