using System;

namespace MatrixSorter
{
    public class MatrixSortBySum : IMatrixSort
    {
        int[,] IMatrixSort.SortMatrix(int[,] inputMatrix, int row, int column, int[] indexes, bool descending)
        {
            int[] rowSum = MatrixHelper.RowsSum(inputMatrix, row, column);
            int[] tempRows = new int[row];
            rowSum.CopyTo(tempRows, 0);
            Array.Sort(rowSum, indexes);
            if (descending)
            {
                Array.Reverse(indexes);
            }
            int[,] sortedMatrix = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    sortedMatrix[i, j] = inputMatrix[indexes[i], j];
                }
            }
            return sortedMatrix;
        }
    }
}
