using System;

namespace MatrixSorter
{
    public static class MatrixHelper
    {
        public static int[,] CreateMatrix(int row, int column)
        {
            int i, j;
            int[,] inputMatrix = new int[row, column];
            Random elements = new Random();

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
            int[] indexes = new int[row];
            for (int i = 0; i < row; i++)
            {
                indexes[i] = i;
            }
            return indexes;
        }

        public static int[] RowsSum(int[,] inputMatrix, int row, int column)
        {
            int[] rowSum = new int[row];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    rowSum[i] += inputMatrix[i, j];
                }
            }
            return rowSum;
        }

        public static int[] BiggestRowValue(int[,] inputMatrix, int row, int column)
        {
            int temp = 0;

            int[] biggestValues = new int[row];
            for (int i = 0; i < row; i++)
            {

                for (int j = 0; j < column - 1; j++)
                {
                    for (int k = 0; k < column - 1; k++)
                    {
                        temp = inputMatrix[i, j];

                        if (temp > inputMatrix[i, j + 1])
                        {
                            biggestValues[i] = temp;

                        }
                        if (temp < inputMatrix[i, j + 1])
                        {
                            temp = inputMatrix[i, j + 1];
                            biggestValues[i] = temp;
                        }
                        else
                        {
                            biggestValues[i] = temp;
                        }
                    }

                    for (int k = column - 1; k > 0; k--)
                    {
                        int tempReverse = inputMatrix[i, k];
                        if (tempReverse < inputMatrix[i, k - 1])
                        {
                            tempReverse = inputMatrix[i, k - 1];
                            biggestValues[i] = tempReverse;
                        }
                    }
                }
            }

            return biggestValues;
        }

        public static int[] MinimumRowValue(int[,] inputMatrix, int row, int column)
        {
            int[] minimumValues = new int[row];
            int temp = 0;
            for (int i = 0; i < row; i++)
            {

                for (int j = 0; j < column - 1; j++)
                {
                    for (int k = 0; k < column - 1; k++)
                    {
                        temp = inputMatrix[i, j];

                        if (temp < inputMatrix[i, j + 1])
                        {
                            minimumValues[i] = temp;

                        }
                        if (temp > inputMatrix[i, j + 1])
                        {
                            temp = inputMatrix[i, j + 1];
                            minimumValues[i] = temp;
                        }
                        else
                        {
                            minimumValues[i] = temp;
                        }
                    }

                    for (int k = column - 1; k > 0; k--)
                    {
                        int tempReverse = inputMatrix[i, k];
                        if (tempReverse > inputMatrix[i, k - 1])
                        {
                            tempReverse = inputMatrix[i, k - 1];
                            minimumValues[i] = tempReverse;
                        }
                        if (tempReverse < inputMatrix[i, k - 1])
                        {
                            minimumValues[i] = tempReverse;
                        }
                    }
                }
            }
            return minimumValues;
        }
    }
}
