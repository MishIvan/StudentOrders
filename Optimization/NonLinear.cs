using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization
{
	partial class Program
	{
		/// <summary>
		/// Метод множителей Лагранжа для задачи нелинейной оптимизации
		/// </summary>
		/// <param name="n">Параметр функции</param>
		/// <param name="m">Параметр функции</param>
		/// <param name="n1">Параментр-ограничения</param>
		/// <param name="m1">Параментр-ограничения</param>
		/// <param name="res">Условный экстремум функции</param>
		static void NonLinear(double n, double m, double n1, double m1, Result res)
		{
			double[,] mas = new double[2,2];
			double[] mas2 = new double[2];

			mas[0,0] = 1;
			mas[0,1] = n;
			mas2[0] = n1;

			mas[1,0] = m;
			mas[1,1] = 1;
			mas2[1] = m1;
			// нахождение значений множителей
			double[] lambda = Solve2(mas, mas2);
			// нахождение значений 						
			res.x = n - lambda[0]*0.5+lambda[1]*m*0.5;
			res.y = m - lambda[0]*m*0.5+lambda[1]*0.5;
			res.iter = 1;
		}
		/// <summary>
		/// Функция оптимизации
		/// </summary>
		/// <param name="x1">первый аргумент</param>
		/// <param name="x2">второй аргумент</param>
		/// <param name="n">параметр</param>
		/// <param name="m">параметр</param>
		/// <returns>значение функции</returns>
		static double nFunc(double x1, double x2, double n, double m)
        {
			return (x1 - n) * (x1 - n) + (x2 - m) * (x2 - m);

		}
		/// <summary>
		/// Решение системы a*x = с
		/// </summary>
		/// <param name="a">матрица системы</param>
		/// <param name="c">вектор правой части системы</param>
		/// <returns>вектор решений</returns>
		static double [] Solve2(double [,] a, double[] c)
        {
			double[] x = new double[2];
			x[1] = (c[1] - a[1, 0] * c[0] / a[0, 0]) / (a[1, 1] - a[1, 0] * a[0, 1] / a[0, 0]);
			x[0] = c[0] / a[0, 0] - a[0, 1] * x[1] / a[0, 0];
			return x;
        }
	}
}
