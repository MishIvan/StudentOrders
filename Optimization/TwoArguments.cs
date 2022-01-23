using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization
{
    delegate double fun_opt2(double x1, double x2);
    delegate double[] grad2(double x1, double x2);
    partial class Program
    {
        /// <summary>
        /// Оптимизация функций двух агрументов
        /// </summary>
        static double a = 1.0;
        static double b = 26.0;
        static double c= 5.0;
        static double d = -6.0;
        static double e= 4.0;
        static double[] x0 = new double[2] { 5.0, 10.0 };
        static bool GradientDescent(double [] x0, fun_opt2 f2, grad2 gradf2)
        {
            int i = 0, n = 6400;
            double[] x1 = new double[2];
            x1[0] = x0[0]; x1[1] = x0[1];
            while(true)
            {
                double[] grad = gradf2(x0[0], x1[1]);

            }
            return true;
        }
        /// <summary>
        /// функции, которые нужно оптимизировать
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <returns></returns>
        static double fun1(double x1, double x2)
        {
            return a * x1 + b * x2 + c * x1 * x1 + d * x2 * x2 + e;
        }
        static double [] gradfun1(double x1, double x2)
        {
            double[] gvect = new double[2] { 0.0, 0.0 };
            gvect[0] = a + 2.0 * b * x1;
            gvect[1] = b + 2.0 * d * x2;
            return gvect;

        }
    }
}
