using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisabilityList
{
    internal static class Program
    {
        public static DBHelper m_helper;
        public static List<string> m_tmpFiles; // список временных файлов, которые по завершению следует удалить
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            m_helper = new DBHelper();
            m_tmpFiles = new List<string>();

            if (!m_helper.isOpened)
            {
                ShowErrorMessage("Не удалось соединиться с базой данных");
                Application.Exit();
            }
            else
                Application.Run(new MainForm());
        }
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

        /// <summary>
        /// Расчёт пособия по нетрудоспособности
        /// </summary>
        /// <param name="deliveryDate">дата выдачи листка нетрудоспособности</param>
        /// <param name="dfrom">дата начала нетрудоспособности</param>
        /// <param name="dto">дата окончания нетрудоспособности</param>
        /// <param name="salary">средний заработок работника за два предшествующие года</param>
        /// <param name="wtime">стаж, лет</param>
        /// <returns>размер пособия по нетрудоспособности</returns>
        public static double CalculateWelfare(DateTime deliveryDate, DateTime dfrom, DateTime dto, double salary, double wtime)
        {
            double welfare = 0.0; // размер пособия
            int days = dto.Subtract(dfrom).Days; // число дней нетрудоспособности
            double minpay = 19242.0; // МРОТ
            int deliveryYear = deliveryDate.Year; // год выдачи листка нетрудоспособности
            double limSumma = deliveryYear - 1 <= 2022 ? 1570000.0 : 1917000.0;

            if (salary <= minpay * 24.0)
                salary = 24.0 * minpay;
            else if (salary >= limSumma)
                salary = limSumma;

            if (wtime < 0.5)
                welfare = 24.0 * minpay * days / 730.0;
            else if (wtime >= 0.5 && wtime < 5.0)
                welfare = salary * days * 0.6 / 730.0;
            else if (wtime >= 5.0 && wtime < 8.0)
                welfare = salary * days * 0.8 / 730.0;
            else
                welfare = salary * days / 730.0;

            return Math.Round(welfare, 2);
        }

    }
}
