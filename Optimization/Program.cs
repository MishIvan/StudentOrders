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
    partial class Program
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

            Console.WriteLine("*** Метод средней точки ***\n\r");
            MeanPoint(a, b, ref xopt, derivativefunctionForOptimize);
            Console.WriteLine(String.Format("Точка экстремума {0,15:F6}, экстремальное заначение {1,15:F6}\n\r",
                xopt, functionForOptimize(xopt)));

            Console.WriteLine("*** Метод Ньютона ***\n\r");
            Newton(a,ref xopt, derivativefunctionForOptimize, derivative2functionForOptimize);
            Console.WriteLine(String.Format("Точка экстремума {0,15:F6}, экстремальное заначение {1,15:F6}\n\r",
                xopt, functionForOptimize(xopt)));

            Result res = new Result { x = 0.0, y = 0.0, iter = 0 };
            Console.WriteLine("*** Метод градиентного спуска (функция 1) ***\n\r");
            if(GradientDescent(x0, minusfun1, minusgradfun1, getlambdafun1, res))
                Console.WriteLine(String.Format("Точка экстремума ({0,15:F6};{1,15:F6}), экстремальное заначение {2,15:F6}. Число итераций {3,3:d}.\n\r",
                    res.x, res.y, fun1(res.x, res.y), res.iter));

            else
                Console.WriteLine("Метод не сходится. Вычисления прерваны по достижении предельного числа итераций.\n\r");

            res.x = 0.0; res.y = 0.0; res.iter = 0;
            x0[0] = x0[1] = 0.0;
            Console.WriteLine("*** Метод градиентного спуска (функция 2) ***\n\r");
            if (GradientDescent(x0, fun2, gradfun2, null, res))
                Console.WriteLine(String.Format("Точка экстремума ({0,15:F6};{1,15:F6}), экстремальное заначение {2,15:F6}. Число итераций {3,3:d}.\n\r",
                    res.x, res.y, fun2(res.x, res.y), res.iter));

            else
                Console.WriteLine("Метод не сходится. Вычисления прерваны по достижении предельного числа итераций.\n\r");

            res.x = 0.0; res.y = 0.0; res.iter = 0;
            Console.WriteLine("*** Нелинейное программирование ***\n\r");
            double m = 3.0, n = 2.0;
            NonLinear(n, m, 10.0, 15.0, res);
                Console.WriteLine(String.Format("Точка экстремума ({0,15:F6};{1,15:F6}), экстремальное заначение {2,15:F6}.\n\r",
                    res.x, res.y, nFunc(res.x, res.y, n, m)));

            Console.WriteLine("*** Симплекс-метод ***\n\r");
            SolveSimplex();

            Console.WriteLine("*** Транспортная задача (метод севверо-западного угла) ***\n\r");
            // стоимости
            double[,] c = { {2.0,4.0,1.0,4.0 },
                            {3.0,2.0,4.0,1.0 },
                            {4.0,9.0,2.0,9.0 }
            };
            double[] need = { 150.0, 100.0, 100.0, 200.0 }; // потребности
            double[] fund = { 110.0, 220.0, 330.0 }; // запасы
            double[,] x = SouthWestCorner(c, fund, need);
            int k = x.GetUpperBound(0) + 1;
            int p = x.GetUpperBound(1) + 1;
            int i, j;
            double sum = 0.0;
            String s1 = "";
            for (i = 0; i < k; i++)
            {
                s1 = "";
                for (j = 0; j < p; j++)
                {
                    s1 += $"{x[i, j]}\t";                    
                    sum += c[i, j] * x[i, j];
                }
                Console.WriteLine(s1);
                Console.WriteLine("\r\n");
            }
            Console.WriteLine($"Сумма {sum}\r\n");

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
        /// <returns>true - успешно, при ошибке - false</returns>
        static bool Dichotomy(double a, double b, ref double xopt, opt_fun f1)
        {
            if (a >= b) return false;
            //double d = (b - a) * 0.0005;
            double x1 = (a + b) * 0.5 - delta;
            double x2 = (a + b) * 0.5 + delta;
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
                x1 = (a1 + b1) * 0.5 - delta;
                x2 = (a1 + b1) * 0.5 + delta;
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
        /// <returns>true - успешно, при ошибке - false</returns>
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
        /// <returns>true - успешно, при ошибке - false</returns>
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
        /// Метод средней точки
        /// </summary>
        /// <param name="a">начальная точка интевала</param>
        /// <param name="b">конечная точка интервала</param>
        /// <param name="xopt">точка экстремума</param>
        /// <param name="f1d">производная функции оптимизации</param>
        /// <returns>true - успешно, при ошибке - false</returns>
        static bool MeanPoint(double a, double b, ref double xopt, opt_fun f1d)
        {
            if (a >= b) return false;
            double d = (b - a) * 0.01;
            double a1 = a;
            double b1 = b;
            // поиск на границах которрого производная меняет знак
            while (f1d(a1)*f1d(b1) > 0.0)
            {
                a1 += d; b1 -= d;
            }
            if (f1d(a1) * f1d(b1) > 0.0) return false; // интервал не найден
            // производная в окрестности нуля
            if (Math.Abs(f1d(a1)) <= eps * 0.1) { xopt = a1; return true; }
            if (Math.Abs(f1d(b1)) <= eps * 0.1) { xopt = b1; return true; }
            double x = 0.0;
            while(true)
            {
                x = (b1 + a1) * 0.5;
                if (Math.Abs(f1d(x)) <= eps && Math.Abs(b1 - a1) <= eps) break;
                if (f1d(x) > 0.0) b1 = x;
                else a1 = x;
            }
            xopt = x;
            return true;
        }
        /// <summary>
        /// Метод Ньютона. Ищется корень производной от функции
        /// </summary>
        /// <param name="x0">Начальное приближение</param>
        /// <param name="f1">Производная функции</param>
        /// <param name="f1d">Вторая производная функции</param>
        /// <returns>true - успешно, при ошибке - false</returns>
        static bool Newton(double x0, ref double xopt, opt_fun f1, opt_fun f1d)
        {
            double x1 = x0;
            int n = 3200, i = 0;
            while(true)
            {
                x1 = x0 - f1(x0) / f1d(x0);
                if (Math.Abs(x1 - x0) <= eps || i >= n) break;
                x0 = x1;
                i++;
            }
            xopt = x1;
            return i >= n;
        }

        /// <summary>
        /// Вещественная функция вещественного переменного
        /// </summary>
        /// <param name="x">вещественный аргумент</param>
        /// <returns>вещественное значение</returns>
        static double functionForOptimize(double x)
        {
            return (1.0 + x) * x + 1.0 / (1 + x * x);
        }
        /// <summary>
        /// Производная вещественной функция вещественного переменного
        /// </summary>
        /// <param name="x">вещественный аргумент</param>
        /// <returns>вещественное значение</returns>
        static double derivativefunctionForOptimize(double x)
        {
            return 1.0 + 2.0 * x - 2.0 * x / Math.Pow(1 + x * x, 2.0);
        }
        /// <summary>
        /// Вторая производная вещественной функция вещественного переменного
        /// </summary>
        /// <param name="x">вещественный аргумент</param>
        /// <returns>вещественное значение</returns>
        static double derivative2functionForOptimize(double x)
        {
            return 2.0 - 2.0 / Math.Pow(1 + x * x, 2.0) + 8.0*x*x / Math.Pow(1 + x * x, 3.0);
        }

    }
}
