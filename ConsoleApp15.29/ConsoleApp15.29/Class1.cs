using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._29
{
    class MatrixAnalyzer
    {
        public int CountSimilarColumns(int[,] matrix, int n, int m)
        {
            HashSet<int> lastColumnSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                lastColumnSet.Add(matrix[i, m - 1]);
            }

            int count = 0;

            for (int j = 0; j < m; j++)
            {
                HashSet<int> currentColumnSet = new HashSet<int>();
                for (int i = 0; i < n; i++)
                {
                    currentColumnSet.Add(matrix[i, j]);
                }

                if (currentColumnSet.SetEquals(lastColumnSet))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
