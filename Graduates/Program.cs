using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graduates
{
    internal static class Program
    {
        public static DBHelper dbHelper;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dbHelper = new DBHelper();
            if(!dbHelper.isOpen())
            {
                MessageBox.Show($"Неудачное соединение с базой данных: {dbHelper.errorMessage}");
                return;
            }
            Application.Run(new MainForm());
        }
    }
}
