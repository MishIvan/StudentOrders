using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdAgency
{
    static class Program
    {
        public static PSqlClient m_helper;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            m_helper = new PSqlClient();

            if(m_helper == null)
            {
                MessageBox.Show(Properties.Resources.CONNECTION_FAILED, "Ошибка");
                Application.Exit();
                return;
            }

            if(!m_helper.isOpened)
            {
                ErrorMessageDB();
                Application.Exit();
                return;
            }

            Application.Run(new MainForm());
        }

        public static void ErrorMessageDB()
        {
            MessageBox.Show(m_helper.errorText, "Ошибка");
        }
    }
}
