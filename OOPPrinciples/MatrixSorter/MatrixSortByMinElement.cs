using System;

namespace MatrixSorter
{
    public class MatrixSortByMinElement : IMatrixSort
    {
        int[,] IMatrixSort.SortMatrix(int[,] inputMatrix, int rows, int columns, int[] indexes, bool descending)
        {
            int[] minimumValues = MatrixHelper.MinimumRowValue(inputMatrix, rows, columns);
            int[] tempRows = new int[rows];
            minimumValues.CopyTo(tempRows, 0);
            Array.Sort(minimumValues, indexes);
            if (descending)
            {
                Array.Reverse(indexes);
            }
            int[,] sortedMatrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sortedMatrix[i, j] = inputMatrix[indexes[i], j];
                }
            }
            return sortedMatrix;
        }
    }
}
