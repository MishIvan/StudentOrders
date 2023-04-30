using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoltJunction
{
    static class Program
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
            string fname = "Properties\\boltnut.db";
            string documentsPath = System.Environment.GetCommandLineArgs()[0];
            string path = documentsPath.Replace("BoltJunction.exe", fname);
            m_helper = new DBHelper(path);
            if(!m_helper.isOpen)
            {
                MessageBox.Show(m_helper.errorText, "Ошибка");
                Application.Exit();
            }
            Application.Run(new MainForm());
        }

        
    }

    
}
