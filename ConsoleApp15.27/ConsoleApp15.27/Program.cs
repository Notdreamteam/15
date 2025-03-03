using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._27
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = {
            { 1, 2, 3 },
            { 3, 2, 1 },
            { 4, 5, 6 },
            { 2, 1, 3 }
        };

            int n = 4;
            int m = 3;

            MatrixAnalyzer analyzer = new MatrixAnalyzer();

            int similarRowsCount = analyzer.CountSimilarRows(matrix, n, m);

            Console.WriteLine($"Количество строк, похожих на первую: {similarRowsCount}");
        }
    }
}
