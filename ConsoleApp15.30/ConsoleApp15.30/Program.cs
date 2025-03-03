using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._30
{
    internal class Program
    {
        static void Main()
        {
            int size = 5;

            PatternArrayGenerator generator = new PatternArrayGenerator();

            int[,] array = generator.GeneratePatternArray(size);

            generator.PrintArray(array, size);
        }
    }
}
