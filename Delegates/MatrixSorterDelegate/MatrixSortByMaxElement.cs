using System;

namespace MatrixSorterDelegate
{
    public class MatrixSortByMaxElement : IMatrixSort
    {
        private int[,] inputMatrix;
        private int rows;
        private int columns;
        private int[] indexes;

        public MatrixSortByMaxElement(int[,] inputMatrix, int rows, int columns, int[] indexes)
        {
            this.inputMatrix = inputMatrix;
            this.rows = rows;
            this.columns = columns;
            this.indexes = indexes;
        }

        int[,] IMatrixSort.SortMatrix(bool descending)
        {
            var bubbleSortedMatrix = MatrixHelper.BubbleSortByRow(inputMatrix, rows, columns);
            var biggestValues = MatrixHelper.BiggestRowValue(bubbleSortedMatrix, rows, columns);
            var tempRows = new int[rows];

            biggestValues.CopyTo(tempRows, 0);

            Array.Sort(biggestValues, indexes);
            if (descending)
            {
                Array.Reverse(indexes);
            }

            var sortedMatrix = new int[rows, columns];
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    sortedMatrix[i, j] = bubbleSortedMatrix[indexes[i], j];
                }
            }
            return sortedMatrix;
        }
    }
}
