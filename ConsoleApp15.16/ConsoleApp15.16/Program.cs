using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._16
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = {
            { 0, 1, 2 },
            { 1, 2, 3 },
            { 2, 3, 4 }
        };

            int n = 3;

            MatrixChecker checker = new MatrixChecker();

            bool isSymmetric = checker.IsSymmetric(matrix, n);

            if (isSymmetric)
            {
                Console.WriteLine("Массив симметричен относительно главной диагонали.");
            }
            else
            {
                Console.WriteLine("Массив не симметричен относительно главной диагонали.");
            }
        }
    }
}
