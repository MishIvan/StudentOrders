using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalNotes
{
    internal static class Program
    {
        public static DBHelper m_helper;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string fname = "Properties\\notebook.db";
            string documentsPath = System.Environment.GetCommandLineArgs()[0];
            string path = documentsPath.Replace("PersonalNotes.exe", fname);
            m_helper = new DBHelper(path);
            if (!m_helper.isOpen)
            {
                MessageBox.Show(m_helper.errorText, "Ошибка подключения БД");
                Application.Exit();
            }
            Application.Run(new MainForm());
        }
    }
}
