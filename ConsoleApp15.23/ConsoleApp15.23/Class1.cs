using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._23
{
    class CrossArrayGenerator
    {
        public int[,] GenerateCrossArray(int size)
        {
            int[,] array = new int[size, size];
            int center = size / 2;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == center || j == center)
                    {
                        array[i, j] = 1; 
                    }
                    else
                    {
                        array[i, j] = 0; 
                    }
                }
            }

            return array;
        }

        public void PrintArray(int[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }

}
