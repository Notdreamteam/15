using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._21
{
    class ArraySorter
    {
        public void SortBySecondaryDiagonal(int[,] array)
        {
            int n = array.GetLength(0);
            int[] diagonal = new int[n];

            for (int i = 0; i < n; i++)
            {
                diagonal[i] = array[i, n - 1 - i];
            }

            Array.Sort(diagonal);

            for (int i = 0; i < n; i++)
            {
                array[i, n - 1 - i] = diagonal[i];
            }
        }

        public void PrintArray(int[,] array)
        {
            int n = array.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array[i, j],3}");
                }
                Console.WriteLine();
            }
        }
    }
}
