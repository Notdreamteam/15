using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._27
{
    class MatrixAnalyzer
    {
        public int CountSimilarRows(int[,] matrix, int n, int m)
        {
            HashSet<int> firstRowSet = new HashSet<int>();
            for (int j = 0; j < m; j++)
            {
                firstRowSet.Add(matrix[0, j]);
            }

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                HashSet<int> currentRowSet = new HashSet<int>();
                for (int j = 0; j < m; j++)
                {
                    currentRowSet.Add(matrix[i, j]);
                }

                if (currentRowSet.SetEquals(firstRowSet))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
