using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseClub
{
    internal static class Program
    {
        public static DBHelper m_helper;
        public static int m_userId;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            m_userId = 0;
            m_helper = new DBHelper();
            if (!m_helper.isOpened)
            {
                MessageBox.Show("Не удалось соединиться с базой данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
                Application.Run(new MainForm());
        }
        /// <summary>
        /// Сообщения об ошибках
        /// </summary>
        public static void DBErrorMessage()
        {
            ShowErrorMessage(m_helper.errorText);
        }
        public static void ShowErrorMessage(string message) 
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
