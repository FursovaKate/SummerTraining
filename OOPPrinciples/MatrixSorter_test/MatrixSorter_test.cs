using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixSorter;

namespace MatrixSorter_test
{
    [TestClass]
    public class MatrixSortBySumTest
    {
        [TestMethod]
        public void SortInputMatrixBySumAscending()
        {
            var sortingStrategy = new SortingStrategy();
            sortingStrategy.MatrixSortStrategy = new MatrixSortBySum();
            bool descending = false;

            int[,] inputMatrix = { { 75, 19, 45 }, { 49, 52, 78 }, { 81, 6, 40 } };
            int[,] actual = inputMatrix;
            int row = 3;
            int column = 3;
            int[] indexes = MatrixHelper.MatrixIndexes(inputMatrix, row, column);
            actual = sortingStrategy.ExecuteSort(inputMatrix, row, column, indexes, descending);
            int[,] expected = { { 81, 6, 40 }, { 75, 19, 45 }, { 49, 52, 78 } };
            CollectionAssert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void SortInputMatrixBySumDescending()
        {
            var sortingStrategy = new SortingStrategy();
            sortingStrategy.MatrixSortStrategy = new MatrixSortBySum();
            bool descending = true;

            int[,] inputMatrix = { { 75, 19, 45 }, { 49, 52, 78 }, { 81, 6, 40 } };
            int[,] actual = inputMatrix;
            int row = 3;
            int column = 3;
            int[] indexes = MatrixHelper.MatrixIndexes(inputMatrix, row, column);
            actual = sortingStrategy.ExecuteSort(inputMatrix, row, column, indexes, descending);
            int[,] expected = { { 49, 52, 78 }, { 75, 19, 45 }, { 81, 6, 40 } };
            CollectionAssert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }

    [TestClass]
    public class MatrixSortByMaxElementTest
    {
        [TestMethod]
        public void SortInputMatrixByGreatestElementAscending()
        {
            var sortingStrategy = new SortingStrategy();
            sortingStrategy.MatrixSortStrategy = new MatrixSortByMaxElement();
            bool descending = false;

            int[,] inputMatrix = { { 75, 19, 45 }, { 49, 52, 78 }, { 81, 6, 40 } };
            int[,] actual = inputMatrix;
            int row = 3;
            int column = 3;
            int[] indexes = MatrixHelper.MatrixIndexes(inputMatrix, row, column);
            actual = sortingStrategy.ExecuteSort(inputMatrix, row, column, indexes, descending);
            int[,] expected = { { 75, 19, 45 }, { 49, 52, 78 }, { 81, 6, 40 } };
            CollectionAssert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void SortInputMatrixByGreatestElementDescending()
        {
            var sortingStrategy = new SortingStrategy();
            sortingStrategy.MatrixSortStrategy = new MatrixSortByMaxElement();
            bool descending = true;

            int[,] inputMatrix = { { 75, 19, 45 }, { 49, 52, 78 }, { 81, 6, 40 } };
            int[,] actual = inputMatrix;
            int row = 3;
            int column = 3;
            int[] indexes = MatrixHelper.MatrixIndexes(inputMatrix, row, column);
            actual = sortingStrategy.ExecuteSort(inputMatrix, row, column, indexes, descending);
            int[,] expected = { { 81, 6, 40 }, { 49, 52, 78 }, { 75, 19, 45 } };
            CollectionAssert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
 
    [TestClass]
    public class MatrixSortByMinElementTest
    {
        [TestMethod]
        public void SortInputMatrixBySmallestElementAscending()
        {
            var sortingStrategy = new SortingStrategy();
            sortingStrategy.MatrixSortStrategy = new MatrixSortByMinElement();
            bool descending = false;

            int[,] inputMatrix = { { 75, 19, 45 }, { 49, 52, 78 }, { 81, 6, 40 } };
            int[,] actual = inputMatrix;
            int row = 3;
            int column = 3;
            int[] indexes = MatrixHelper.MatrixIndexes(inputMatrix, row, column);
            actual = sortingStrategy.ExecuteSort(inputMatrix, row, column, indexes, descending);
            int[,] expected = { { 81, 6, 40 }, { 75, 19, 45 }, { 49, 52, 78 } };
            CollectionAssert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }

    [TestClass]
    public class MatrixSortByMinElementDescTest
    {
        [TestMethod]
        public void SortInputMatrixBySmallestElementDescending()
        {
            var sortingStrategy = new SortingStrategy();
            sortingStrategy.MatrixSortStrategy = new MatrixSortByMinElement();
            bool descending = true;

            int[,] inputMatrix = { { 75, 19, 45 }, { 49, 52, 78 }, { 81, 6, 40 } };
            int[,] actual = inputMatrix;
            int row = 3;
            int column = 3;
            int[] indexes = MatrixHelper.MatrixIndexes(inputMatrix, row, column);
            actual = sortingStrategy.ExecuteSort(inputMatrix, row, column, indexes, descending);
            int[,] expected = { { 49, 52, 78 }, { 75, 19, 45 }, { 81, 6, 40 } };
            CollectionAssert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
