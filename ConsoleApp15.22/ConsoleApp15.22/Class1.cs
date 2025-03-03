using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._22
{
    class ArrayFiller
    {
        public int[,] FillArray(int n)
        {
            int[,] array = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        array[i, j] = 1;
                    }
                    else if (i < j)
                    {
                        array[i, j] = 0;
                    }
                    else
                    {
                        array[i, j] = 2;
                    }
                }
            }

            return array;
        }

        public void PrintArray(int[,] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
