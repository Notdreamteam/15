using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._28
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = {
            { 1, 2, 3, 3 },
            { 4, 5, 6, 6 },
            { 7, 8, 9, 9 },
            { 3, 2, 1, 3 }
        };

            int n = 4;
            int m = 4; 

            MatrixAnalyzer analyzer = new MatrixAnalyzer();

            int similarColumnsCount = analyzer.CountSimilarColumns(matrix, n, m);

            Console.WriteLine($"Количество столбцов, похожих на последний: {similarColumnsCount}");
        }
    }
}
