using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtyAgency
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static PSqlClient m_helper; // контроллер БД
        public static string m_username;    // имя пользователя
        public static long m_userid;
        public static int m_userrole;   // роль пользователя: 1 - админ, 2 - руководитель, 3 - агент

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            m_helper = new PSqlClient();

            if (m_helper == null)
            {
                MessageBox.Show("Неудачная попытка соединения с базой данных.\nРабота приложения завершена", "Ошибка");
                Application.Exit();
                return;
            }

            if (!m_helper.isOpened)
            {
                ErrorMessageDB();
                Application.Exit();
                return;
            }

            Application.Run(new AutorizationForm());
        }

        public static void ErrorMessageDB()
        {
            MessageBox.Show(m_helper.errorText, "Ошибка");
        }

    }
}
