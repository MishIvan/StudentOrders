using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCollection
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static DBHelper m_helper; // класс, реализующий взаимодействие и управление базой данных

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.m_helper = new DBHelper();
            if (!Program.m_helper.isOpened)
            {
                MessageBox.Show("Соединение с базой данных не установлено.");
                Application.Exit();
            }
            Application.Run(new MainForm());

        }
    }
}
