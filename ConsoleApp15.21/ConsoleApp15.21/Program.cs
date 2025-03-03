using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._21
{
    internal class Program
    {
        static void Main()
        {
            int[,] array = {
            { 5, 3, 8, 2, 7, 1, 9, 4 },
            { 1, 7, 3, 9, 6, 4, 2, 8 },
            { 9, 2, 6, 5, 8, 3, 7, 1 },
            { 4, 8, 1, 7, 2, 9, 5, 6 },
            { 6, 5, 9, 4, 1, 7, 3, 2 },
            { 2, 4, 7, 8, 3, 5, 6, 9 },
            { 8, 1, 4, 3, 9, 2, 1, 7 },
            { 3, 6, 2, 1, 5, 8, 4, 5 }
        };

            ArraySorter sorter = new ArraySorter();

            Console.WriteLine("Исходный массив:");
            sorter.PrintArray(array);

            sorter.SortBySecondaryDiagonal(array);

            Console.WriteLine("\nМассив после сортировки по побочной диагонали:");
            sorter.PrintArray(array);
        }
    }
}
