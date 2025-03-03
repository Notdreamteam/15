using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._17
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите количество строк (n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            ArrayGenerator generator = new ArrayGenerator();

            int[,] array = generator.GenerateArray(n, m);

            generator.PrintArray(array, n, m);
        }
    }
}
