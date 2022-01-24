using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization
{

        partial class Program
        {
            static void SolveSimplex()
            {
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
        }
}
