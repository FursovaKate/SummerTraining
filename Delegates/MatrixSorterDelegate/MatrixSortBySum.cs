using System;

namespace MatrixSorterDelegate
{
    public class MatrixSortBySum : IMatrixSort
    {
        private int[,] inputMatrix;
        private int row;
        private int column;
        private int[] indexes;

        public MatrixSortBySum(int[,] inputMatrix, int row, int column, int[] indexes)
        {
            this.inputMatrix = inputMatrix;
            this.row = row;
            this.column = column;
            this.indexes = indexes;
        }

        int[,] IMatrixSort.SortMatrix(bool descending)
        {
            var rowSum = MatrixHelper.RowsSum(inputMatrix, row, column);
            var tempRows = new int[row];
            rowSum.CopyTo(tempRows, 0);

            Array.Sort(rowSum, indexes);
            if (descending)
            {
                Array.Reverse(indexes);
            }
            var sortedMatrix = new int[row, column];
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < column; j++)
                {
                    sortedMatrix[i, j] = inputMatrix[indexes[i], j];
                }
            }
            return sortedMatrix;
        }
    }
}
