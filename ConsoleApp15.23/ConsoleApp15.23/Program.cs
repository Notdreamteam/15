using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._23
{
    internal class Program
    {
        static void Main()
        {
            int size = 5;

            CrossArrayGenerator generator = new CrossArrayGenerator();

            int[,] array = generator.GenerateCrossArray(size);

            generator.PrintArray(array, size);
        }
    }
}
