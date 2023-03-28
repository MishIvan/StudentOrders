using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallAccounting
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static DBHelper m_helper;
        public static Worker m_currentUser;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            m_helper = new DBHelper();
            if(!m_helper.isOpened)
            {
                MessageBox.Show("Неудачная попытка соединения с базой данных");
                Application.Exit();
            }
            m_currentUser = new Worker();
            Application.Run(new AutorizationForm());
        }
    }
}
