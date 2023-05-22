using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Ascents
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static DBHelper m_helper;
        [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            m_helper = new DBHelper();
            if(!m_helper.isOpened)
            {
                MessageBox.Show("Не удалось соединиться с базой данных");
                Application.Exit();
            }
            else
             Application.Run(new MainForm());
        }
        public static void DBErrorMessage()
        {
            MessageBox.Show(m_helper.errorText, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
