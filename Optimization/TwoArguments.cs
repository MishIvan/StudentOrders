using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization
{
    delegate double fun_opt2(double x1, double x2);
    delegate double[] grad2(double x1, double x2);
    /// <summary>
    /// Результаты точка экстремума и число итераций
    /// </summary>
    internal class Result
    {
        public double x { get; set; }
        public double y { get; set; }
        public int iter { get; set; }
    }
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
        /// <summary>
        /// Метод градиентного спуска
        /// </summary>
        /// <param name="x0">Вектор начального приближения</param>
        /// <param name="f2">Функция двух переменных</param>
        /// <param name="gradf2">Градиент функции двух переменных</param>
        /// <param name="res">Результаты: точка экстремума и число итераций</param>
        /// <returns></returns>
        static bool GradientDescent(double [] x0, fun_opt2 f2, grad2 gradf2, grad2 flambda, Result res)
        {
            int i = 1, n = 32000, j = 0;
            double[] x1 = new double[2];
            for (j = 0; j < 2; j++) x1[j] = x0[j];
            double [] lambda = new double[] { 0.5, 0.5 };
            double nrm = 1.0;
            while(i <= n)
            {
                // вычисление градиента
                double[] grad = gradf2(x0[0], x0[1]);
                // вычисление параметра спуска
                if (flambda != null)
                    lambda = flambda(x0[0], x0[1]);
                else
                    for (j = 0; j < 2; j++) lambda[j] /= nrm;
                // приближение xi+1 = xi + lambda*grad(f)
                for (j=0;j<2;j++) x1[j] = x0[j] - lambda[j] * grad[j];
                nrm = Math.Sqrt((x1[0] - x0[0])*(x1[0] - x0[0]) + (x1[1] - x0[1])* (x1[1] - x0[1]));
                // условие остановки итерации
                if (nrm <= eps)
                {
                    res.x = x1[0]; res.y = x1[1]; res.iter = i;
                    break;
                }
                for (j = 0; j < 2; j++) x0[j] = x1[j]; 
                i++;
            }
            return i < n;
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
        static double minusfun1(double x1, double x2)
        {
            return -1.0 * fun1(x1, x2);
        }
        static double [] gradfun1(double x1, double x2)
        {
            double[] gvect = new double[2] { 0.0, 0.0 };
            gvect[0] = a + 2.0 * c * x1;
            gvect[1] = b + 2.0 * d * x2;
            return gvect;

        }
        static double [] minusgradfun1(double x1, double x2)
        {
            double[] gvect = gradfun1(x1, x2);
            gvect[0] *= -1.0;
            gvect[1] *= -1.0;
            return gvect;
        }
        static double [] getlambdafun1(double x1, double x2)
        {
            double[] lambda = new double[2];
            double[] grad = minusgradfun1(x1, x2);
            lambda[0] = (x1 + a / (2.0 * c)) / grad[0];
            lambda[1] = (x2 + b / (2.0 * d)) / grad[1];
            return lambda;
        }

        static double fun2(double x1, double x2)
        {
            return a * x1 + b * x2 + Math.Pow(e, c * x1 * x1 + d * x2 * x2);
        }
        static double [] gradfun2(double x1, double x2)
        {
            double[] gvect = new double[2] { 0.0, 0.0 };
            gvect[0] = a + Math.Pow(e, c * x1 * x1 + d * x2 * x2)*Math.Log(e)*2.0*c*x1;
            gvect[1] = b + Math.Pow(e, c * x1 * x1 + d * x2 * x2) * Math.Log(e) * 2.0 * d * x2;
            return gvect;

        }
    }
}
