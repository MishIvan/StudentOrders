using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointments
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static PgSQLClient m_pgConnection;
        public static User m_currentUser;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.m_pgConnection = new PgSQLClient();
            Program.m_currentUser = new User();
            Application.Run(new AutorizationForm());
        }
    }
}
