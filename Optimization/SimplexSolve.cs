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
        /// Решение симплекс-методом
        /// </summary>
        static void SolveSimplex()
        {
            // Матрица исходных данных.
            // Первые строки - ограничения,
            // последняя строка - коэффициенты со знаком минус и правая часть функции
            // Правые части ограничений - первый столбец

            double[,] table = { {25, -3,  5},
                                {684, 2,  3},
                                {690,  10,  5},
                                {558, 3, 6},
                                {0, -6, -2} };

                double[] result = new double[2];
                double[,] table_result;
                Simplex.Simplex S = new Simplex.Simplex(table);
                table_result = S.Calculate(result);

                Console.WriteLine("Решенная симплекс-таблица:");
                for (int i = 0; i < table_result.GetLength(0); i++)
                {
                    for (int j = 0; j < table_result.GetLength(1); j++)
                        Console.Write(table_result[i, j] + " ");
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Решение:");
                Console.WriteLine($"X[1] = {result[0]}, X[2] = {result[1]}");
        }

        /// <summary>
        ///  Метод серевро-западного угла транспортой задачи
        /// </summary>
        /// <param name="koef">стоимости</param>
        /// <param name="fund">предложения</param>
        /// <param name="need">потребности</param>
        /// <returns>план перевозок</returns>
        static double [,] SouthWestCorner(double [,] koef, double [] fund, double [] need)
        {
            int n = koef.GetUpperBound(0) + 1;
            int m = koef.GetUpperBound(1) + 1;
            double[,] mas = new double[n, m];
            int i, j;

            for(i=0; i<n;i++) 
                for(j= 0;j<m;j++)   
                if(fund[i] != 0.0 && need[j] != 0.0)
                {
                    if (fund[i] >= need[j])
                    {
                        mas[i, j] = need[j];
                        fund[i] = fund[i] - need[j];
                        need[j] = 0;
                    }
                    else
                    {
                        mas[i, j] = fund[i];
                        need[j] = need[j] - fund[i];
                        fund[i] = 0;
                    }
                }
                else mas[i, j] = 0;
        return mas;
        }
        /// <summary>
        ///  Метод наименьшей стоимости транспортой задачи
        /// </summary>
        /// <param name="koef">стоимости</param>
        /// <param name="fund">предложения</param>
        /// <param name="need">потребности</param>
        /// <returns>план перевозок</returns>
        /*static double [,] MinCost(double[,] koef, double[] fund, double[] need)
        {
            int n = koef.GetUpperBound(0) + 1;
            int m = koef.GetUpperBound(1) + 1;
            double[,] mas = new double[n, m];
            int i, j, ki, kj;
            double k;

            for (i = 0; i <n; i++) 
            {
                ki = 0;
                kj = 0;
                k = koef[ki,kj];
                for (j = 0; j < m; j++) 
                {
                    if (k < koef[i, j])
                    {
                        k = koef[i, j];
                        ki = i;
                        kj = j;
                    }
                    
                }
                mas[i,j] = k;
                koef[ki, kj] = fund[i] - koef[ki, kj];
            }
            return mas;

        }*/
    }
}
