using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._26
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            SpiralArrayGenerator generator = new SpiralArrayGenerator();

            int size = 2 * n + 1;
            int[,] array = generator.GenerateSpiralArray(n);

            generator.PrintArray(array, size);
        }
    }
}
