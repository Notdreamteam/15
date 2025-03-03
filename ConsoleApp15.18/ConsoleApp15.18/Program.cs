using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._18
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите количество строк (n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            SnakeArrayGenerator generator = new SnakeArrayGenerator();

            int[,] array = generator.GenerateSnakeArray(n, m);

            generator.PrintArray(array, n, m);
        }
    }
}
