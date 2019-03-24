using System;

namespace MatrixSorter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number of elements in row:\n");
            int row = InputHelper.ParseInput();

            Console.WriteLine("Enter number of elements in column:\n");
            int column = InputHelper.ParseInput();

            var matrix = MatrixHelper.CreateMatrix(row, column);
            int[] indexes = MatrixHelper.MatrixIndexes(matrix, row, column);
            int[,] result = matrix;
            Console.WriteLine("Choose sorting type\n1 - sort by row sum (ascending);\n2 - sort by row sum (descending);\n3 - sort by max element in row (ascending);\n4 - sort by max element in row (descending)\n5 - sort by min element in row (ascending)\n6 - sort by min element in row(descending)\n");
            int sortingType = InputHelper.ParseInput();

            MatrixHelper.PrintMatrix(matrix, row, column);
            var sortingStrategy = new SortingStrategy();
            bool descending = false;
            if (sortingType == 1)
            {
                sortingStrategy.MatrixSortStrategy = new MatrixSortBySum();
            }
            if (sortingType == 2)
            {
                sortingStrategy.MatrixSortStrategy = new MatrixSortBySum();
                descending = true;
            }
            if (sortingType == 3)
            {
                sortingStrategy.MatrixSortStrategy = new MatrixSortByMaxElement();
            }
            if (sortingType == 4)
            {
                sortingStrategy.MatrixSortStrategy = new MatrixSortByMaxElement();
                descending = true;
            }
            if (sortingType == 5)
            {
                sortingStrategy.MatrixSortStrategy = new MatrixSortByMinElement();
            }
            if (sortingType == 6)
            {
                sortingStrategy.MatrixSortStrategy = new MatrixSortByMinElement();
                descending = true;
            }

            result = sortingStrategy.ExecuteSort(matrix, row, column, indexes, descending);

            Console.WriteLine("Sorted matrix:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}