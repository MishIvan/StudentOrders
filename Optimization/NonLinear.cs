using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization
{
	partial class Program
	{
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
		static double nFunc(double x1, double x2, double n, double m)
        {
			return (x1 - n) * (x1 - n) + (x2 - m) * (x2 - m);

		}
		static double [] Solve2(double [,] a, double[] c)
        {
			double[] x = new double[2];
			x[1] = (c[1] - a[1, 0] * c[0] / a[0, 0]) / (a[1, 1] - a[1, 0] * a[0, 1] / a[0, 0]);
			x[0] = c[0] / a[0, 0] - a[0, 1] * x[1] / a[0, 0];
			return x;
        }
	}
}
