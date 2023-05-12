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
        public static List<string> m_tmpFiles; // список временных файлов, которые по завершению следует удалить
        public static string m_username;
        public static int m_userrole;
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

            m_tmpFiles = new List<string>();
            // System.Diagnostics.Process.Start(@"C:\Mish\Orders\2523322_files\13621597_1230427Пояснени.docx");
            Application.Run(new AutorizationForm());
        }

        public static void ErrorMessageDB()
        {
            MessageBox.Show(m_helper.errorText, "Ошибка");
        }
    }
}
