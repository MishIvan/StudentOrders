using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization
{
    /// <summary>
    /// Делегат вещественной функции одного аргумета. Делегат - аналог указателя на функцию С++
    /// </summary>
    /// <param name="x">аргумент</param>
    /// <returns></returns>
    delegate double opt_fun(double x);
    class Program
    {
        static double eps = 0.001;
        static double delta = 0.0001;
        static double fi = (1.0 + Math.Sqrt(5.0)) * 0.5;
        static void Main(string[] args)
        {
            Console.WriteLine("**** Одномерная оптимизация ****\n\r");
            Console.WriteLine("Введите интервал поиска экстремума\n\r");

            Console.WriteLine("Начальное значение: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Конечное значение: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double xopt = 0.0;
            Console.WriteLine("*** Метод дихотомии ***\n\r");
            Dichotomy(a, b, ref xopt, functionForOptimize);
            Console.WriteLine(String.Format("Точка экстремума {0,15:F6}, экстремальное заначение {1,15:F6}\n\r",
                xopt, functionForOptimize(xopt)));

            Console.WriteLine("*** Метод поразрядного поиска ***\n\r");
            BitByBitSearch(a, b, ref xopt, functionForOptimize);
            Console.WriteLine(String.Format("Точка экстремума {0,15:F6}, экстремальное заначение {1,15:F6}\n\r",
                xopt, functionForOptimize(xopt)));

            Console.WriteLine("*** Метод золотого сечения ***\n\r");
            GoldenCut(a, b, ref xopt, functionForOptimize);
            Console.WriteLine(String.Format("Точка экстремума {0,15:F6}, экстремальное заначение {1,15:F6}\n\r",
                xopt, functionForOptimize(xopt)));


            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();

        }
        /// <summary>
        /// Метод дихотомии
        /// </summary>
        /// <param name="a">начальная точка интевала</param>
        /// <param name="b">конечная точка интервала</param>
        /// <param name="xopt">точка экстремума</param>
        /// <param name="f1">функция оптимизации</param>
        /// <returns>true - успешно, при ошибке </returns>
        static bool Dichotomy(double a, double b, ref double xopt, opt_fun f1)
        {
            if (a >= b) return false;
            double d = (b - a) * 0.0005;
            double x1 = (a + b) * 0.5 - d;
            double x2 = (a + b) * 0.5 + d;
            double a1 = a, b1 = b;
            while (true)
            {
                // вычисление интервалов
                double v1 = f1(x1);
                double v2 = f1(x2);
                if (v1 > v2)
                {
                    a1 = x1;

                }
                else
                {
                    b1 = x2;
                }
                if (Math.Abs(b1 - a1) <= eps || Math.Abs(v2 - v1) <= eps) break;
                d = (b1 - a1) * 0.005;
                x1 = (a1 + b1) * 0.5 - d;
                x2 = (a1 + b1) * 0.5 + d;
            }
            xopt = (x1 - x2) * 0.5;
            return true;
        }
        /// <summary>
        /// Метод поразрядного поиска
        /// </summary>
        /// <param name="a">начальная точка интевала</param>
        /// <param name="b">конечная точка интервала</param>
        /// <param name="xopt">точка экстремума</param>
        /// <param name="f1">функция оптимизации</param>
        /// <returns>true - успешно, при ошибке </returns>
        static bool BitByBitSearch(double a, double b, ref double xopt, opt_fun f1)
        {
            if (a >= b) return false;
            double x0 = a;
            double step = (b - a) * 0.25;
            while (true)
            {
                double x1 = x0 + step;
                if (f1(x0) > f1(x1))
                {
                    if (x1 > a && x1 < b) { x0 = x1; continue; }
                }
                if (Math.Abs(step) <= eps)
                {
                    xopt = x0; break;
                }
                else
                {
                    x0 = x1; step *= -0.25;
                }
            }
            xopt = x0;
            return true;
        }

        /// <summary>
        /// Метод золотого сечения
        /// </summary>
        /// <param name="a">начальная точка интевала</param>
        /// <param name="b">конечная точка интервала</param>
        /// <param name="xopt">точка экстремума</param>
        /// <param name="f1">функция оптимизации</param>
        /// <returns>true - успешно, при ошибке </returns>
        static bool GoldenCut(double a, double b, ref double xopt, opt_fun f1)
        {
            if (a >= b) return false;
            double a1 = a, b1 = b;
            double x1, x2;
            x1 = b1 - (b1 - a1) / fi;
            x2 = a1 + (b1 - a1) / fi;
            while (Math.Abs(b1-a1)<=eps)
            {
                double y1 = f1(x1); 
                double y2 = f1(x2);
                if(y1 <= y2)
                {
                    b1 = x2; x2 = x1;
                    x1 = b1 - (b1 - a1) / fi;
                }
                else
                {
                    a1 = x1; x1 = x2;
                    x2 = a1 + (b1 - a1) / fi;
                }
            }
            xopt = f1(x1) > f1(x2) ? x2 : x1;
            return true;
        }


        /// <summary>
        /// Функция для одномерной оптимизации
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double functionForOptimize(double x)
        {
            return (1.0 + x) * x + 1.0 / (1 + x * x);
        }
        /// <summary>
        /// Производная функции для одномерной оптимизации
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double derivativefunctionForOptimize(double x)
        {
            return 1.0 + 2.0 * x - 2.0 * x / Math.Pow(1 + x * x, 2.0);
        }
    }
}
