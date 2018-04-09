using System;
using System.Linq;

namespace Solution.Solutions
{
    public class MatrixPath
    {
        public int GetNumberOfPaths(int[][] matrix)
        {
            var length = matrix.Length;
            var width = matrix[0].Length;

            var pathStorage = Enumerable
                .Range(0, length)
                .Select(x => Enumerable
                    .Range(0, width)
                    .Select(y => -1)
                    .ToArray())
                .ToArray();

            return GetPathsToTheEnd(0, 0, matrix, pathStorage);
        }

        private int GetPathsToTheEnd(int i, int j, int[][] matrix, int[][] pathStorage)
        {
            // To avoid duplicated work
            if (pathStorage[i][j] != -1)
            {
                return pathStorage[i][j];
            }

            var iMax = matrix.Length - 1;
            var jMax = matrix[0].Length - 1;

            if (matrix[i][j] == 0)
            {
                pathStorage[i][j] = 0;
            }
            else if (i == iMax && j == jMax)
            {
                pathStorage[i][j] = 1;
            }
            else
            {
                pathStorage[i][j] = (
                    (i < iMax ? GetPathsToTheEnd(i + 1, j, matrix, pathStorage) : 0)
                    + (j < jMax ? GetPathsToTheEnd(i, j + 1, matrix, pathStorage) : 0)
                ) % ((int)Math.Pow(10, 9) + 7);
            }

            return pathStorage[i][j];
        }
    }
}