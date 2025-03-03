using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._22
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите размер массива (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            ArrayFiller filler = new ArrayFiller();

            int[,] array = filler.FillArray(n);

            filler.PrintArray(array, n);
        }
    }
}
