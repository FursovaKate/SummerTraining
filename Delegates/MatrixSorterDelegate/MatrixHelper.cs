using System;

namespace MatrixSorterDelegate
{
    public static class MatrixHelper
    {
        public static int[,] CreateMatrix(int row, int column)
        {
            int i, j;
            var inputMatrix = new int[row, column];
            var elements = new Random();

            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    inputMatrix[i, j] = elements.Next(0, 100);
                }
            }

            return inputMatrix;
        }

        public static void PrintMatrix(int[,] inputMatrix, int row, int column)
        {
            Console.WriteLine("Given matrix:");
            int i, j;
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    Console.Write(inputMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[] MatrixIndexes(int[,] inputMatrix, int row, int column)
        {
            var indexes = new int[row];
            for (var i = 0; i < row; i++)
            {
                indexes[i] = i;
            }
            return indexes;
        }

        public static int[,] BubbleSortByRow(int[,] inputMatrix, int rows, int columns)
        {
            for (var row = 0; row < inputMatrix.GetLength(0); row++)
            {
                for (var column = inputMatrix.GetLength(1) - 1; column > 0; column--)
                {
                    for (var k = 0; k < column; k++)
                    {
                        if (inputMatrix[row, k] > inputMatrix[row, k + 1])
                        {
                            var temp = inputMatrix[row, k];
                            inputMatrix[row, k] = inputMatrix[row, k + 1];
                            inputMatrix[row, k + 1] = temp;
                        }
                    }
                }
                Console.WriteLine();
            }
            return inputMatrix;
        }

        public static int[] RowsSum(int[,] inputMatrix, int row, int column)
        {
            var rowSum = new int[row];
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < column; j++)
                {
                    rowSum[i] += inputMatrix[i, j];
                }
            }
            return rowSum;
        }

        public static int[] BiggestRowValue(int[,] inputMatrix, int row, int column)
        {
            var biggestValues = new int[row];
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < column; j++)
                {
                    biggestValues[i] = inputMatrix[i, row - 1];
                }
            }
            return biggestValues;
        }

        public static int[] MinimumRowValue(int[,] inputMatrix, int row, int column)
        {
            var minimumValues = new int[row];
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < column; j++)
                {
                    minimumValues[i] = inputMatrix[i, 0];
                }
            }
            return minimumValues;
        }
    }
}
