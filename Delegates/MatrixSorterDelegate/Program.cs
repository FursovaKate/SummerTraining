using System;

namespace MatrixSorterDelegate
{
    class Program
    {
        public delegate int[,] SortingStrategy(bool descending);
        static void Main()
        {
            Console.WriteLine("Enter number of elements in row:\n");
            var row = InputHelper.ParseInput();

            Console.WriteLine("Enter number of elements in column:\n");
            var column = InputHelper.ParseInput();

            var matrix = MatrixHelper.CreateMatrix(row, column);
            var indexes = MatrixHelper.MatrixIndexes(matrix, row, column);
            var result = matrix;
            Console.WriteLine("Choose sorting type\n1 - sort by row sum (ascending);\n2 - sort by row sum (descending);\n3 - sort by max element in row (ascending);\n4 - sort by max element in row (descending)\n5 - sort by min element in row (ascending)\n6 - sort by min element in row(descending)\n");
            var sortingType = InputHelper.ParseInput();

            MatrixHelper.PrintMatrix(matrix, row, column);

            var descending = false;
            SortingStrategy chooseSortingStrategy = null;

            MatrixSortBySum sortBySum = new MatrixSortBySum(result, row, column, indexes);
            if (sortingType == 1)
            {
                 chooseSortingStrategy = new SortingStrategy(((IMatrixSort)sortBySum).SortMatrix);
            }

            if (sortingType == 2)
            {
                descending = true;
                 chooseSortingStrategy = new SortingStrategy(((IMatrixSort)sortBySum).SortMatrix);
            }

            MatrixSortByMaxElement sortByMaxElement = new MatrixSortByMaxElement(result, row, column, indexes);
            if (sortingType == 3)
            {
                 chooseSortingStrategy = new SortingStrategy(((IMatrixSort)sortByMaxElement).SortMatrix);
            }

            if (sortingType == 4)
            {
                descending = true;
                 chooseSortingStrategy = new SortingStrategy(((IMatrixSort)sortByMaxElement).SortMatrix);
            }

            MatrixSortByMinElement sortByMinElement = new MatrixSortByMinElement(result, row, column, indexes);
            if (sortingType == 5)
            {
                 chooseSortingStrategy = new SortingStrategy(((IMatrixSort)sortByMinElement).SortMatrix);
            }

            if (sortingType == 6)
            {
                descending = true;
                 chooseSortingStrategy = new SortingStrategy(((IMatrixSort)sortByMinElement).SortMatrix);
            }

            result = chooseSortingStrategy.Invoke(descending);

            Console.WriteLine("Sorted matrix:");
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < column; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}