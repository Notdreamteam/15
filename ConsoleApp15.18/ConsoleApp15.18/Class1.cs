using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._18
{
    class SnakeArrayGenerator
    {
        public int[,] GenerateSnakeArray(int n, int m)
        {
            int[,] array = new int[n, m];
            int value = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j] = value++;
                    }
                }
                else
                {
                    for (int j = m - 1; j >= 0; j--)
                    {
                        array[i, j] = value++;
                    }
                }
            }

            return array;
        }

        public void PrintArray(int[,] array, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{array[i, j],3}");
                }
                Console.WriteLine();
            }
        }
    }
}
