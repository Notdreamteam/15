using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._19
{
    class ArrayGenerator
    {
        public int[,] GenerateArray(int n, int m)
        {
            int[,] array = new int[n, m];
            int value = 0;

            for (int diag = 0; diag < n + m - 1; diag++)
            {
                int rowStart = Math.Max(0, diag - m + 1);
                int rowEnd = Math.Min(diag, n - 1);

                if (diag % 2 == 0)
                {
                    for (int i = rowEnd; i >= rowStart; i--)
                    {
                        array[i, diag - i] = value++;
                    }
                }
                else
                {
                    for (int i = rowStart; i <= rowEnd; i++)
                    {
                        array[i, diag - i] = value++;
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
