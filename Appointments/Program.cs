﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointments
{
    static class Program
    {
        public static MSSqlCient m_sqlClient;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            m_sqlClient = new MSSqlCient();
            Application.Run(new AutorizationForm());
        }
    }
}
