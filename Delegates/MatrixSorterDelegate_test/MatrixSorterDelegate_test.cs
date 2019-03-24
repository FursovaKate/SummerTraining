using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixSorterDelegate;

namespace MatrixSorterDelegate_test
{
    public delegate int[,] SortingStrategy(bool descending);

    [TestClass]
    public class MatrixSortBySumAscTest
    {
        [TestMethod]
        public void SortInputMatrixBySumAscending()
        {
            int[,] inputMatrix = { { 75, 19, 45 }, { 49, 52, 78 }, { 81, 6, 40 } };
            int[,] actual = inputMatrix;
            int row = 3;
            int column = 3;
            var descending = false;
            int[] indexes = MatrixHelper.MatrixIndexes(inputMatrix, row, column);
            MatrixSortBySum sortBySum = new MatrixSortBySum(inputMatrix, row, column, indexes);
            var chooseSortingStrategy = new SortingStrategy(((IMatrixSort)sortBySum).SortMatrix);
            actual = chooseSortingStrategy.Invoke(descending);
            int[,] expected = { { 81, 6, 40 }, { 75, 19, 45 }, { 49, 52, 78 } };
            CollectionAssert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }


    [TestClass]
    public class MatrixSortBySumDescTest
    {
        [TestMethod]
        public void SortInputMatrixBySumDescending()
        {
            int[,] inputMatrix = { { 75, 19, 45 }, { 49, 52, 78 }, { 81, 6, 40 } };
            int[,] actual = inputMatrix;
            int row = 3;
            int column = 3;
            var descending = true;
            int[] indexes = MatrixHelper.MatrixIndexes(inputMatrix, row, column);
            MatrixSortBySum sortBySumAsc = new MatrixSortBySum(inputMatrix, row, column, indexes);
            var chooseSortingStrategy = new SortingStrategy(((IMatrixSort)sortBySumAsc).SortMatrix);
            actual = chooseSortingStrategy.Invoke(descending);
            int[,] expected = { { 49, 52, 78 }, { 75, 19, 45 }, { 81, 6, 40 } };
            CollectionAssert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }

    [TestClass]
    public class MatrixSortByMaxElementAscTest
    {
        [TestMethod]
        public void SortInputMatrixByGreatestElementAscending()
        {
            int[,] inputMatrix = { { 75, 19, 45 }, { 49, 52, 78 }, { 81, 6, 40 } };
            int[,] actual = inputMatrix;
            int row = 3;
            int column = 3;
            var descending = false;
            int[] indexes = MatrixHelper.MatrixIndexes(inputMatrix, row, column);
            MatrixSortByMaxElement sortBySumAsc = new MatrixSortByMaxElement(inputMatrix, row, column, indexes);
            var chooseSortingStrategy = new SortingStrategy(((IMatrixSort)sortBySumAsc).SortMatrix);
            actual = chooseSortingStrategy.Invoke(descending);
            int[,] expected = { { 19, 45, 75 }, { 49, 52, 78 }, { 6, 40, 81 } };
            CollectionAssert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
    [TestClass]
    public class MatrixSortByMaxElementDescTest
    {
        [TestMethod]
        public void SortInputMatrixByGreatestElementDescending()
        {
            int[,] inputMatrix = { { 75, 19, 45 }, { 49, 52, 78 }, { 81, 6, 40 } };
            int[,] actual = inputMatrix;
            int row = 3;
            int column = 3;
            var descending = true;
            int[] indexes = MatrixHelper.MatrixIndexes(inputMatrix, row, column);
            MatrixSortByMaxElement sortBySumAsc = new MatrixSortByMaxElement(inputMatrix, row, column, indexes);
            var chooseSortingStrategy = new SortingStrategy(((IMatrixSort)sortBySumAsc).SortMatrix);
            actual = chooseSortingStrategy.Invoke(descending);
            int[,] expected = { { 6, 40, 81 }, { 49, 52, 78 }, { 19, 45, 75 } };
            CollectionAssert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
    [TestClass]
    public class MatrixSortByMinElementAscTest
    {
        [TestMethod]
        public void SortInputMatrixBySmallestElementAscending()
        {
            int[,] inputMatrix = { { 75, 19, 45 }, { 49, 52, 78 }, { 81, 6, 40 } };
            int[,] actual = inputMatrix;
            int row = 3;
            int column = 3;
            var descending = false;
            int[] indexes = MatrixHelper.MatrixIndexes(inputMatrix, row, column);
            MatrixSortByMinElement sortBySumAsc = new MatrixSortByMinElement(inputMatrix, row, column, indexes);
            var chooseSortingStrategy = new SortingStrategy(((IMatrixSort)sortBySumAsc).SortMatrix);
            actual = chooseSortingStrategy.Invoke(descending);
            int[,] expected = { { 6, 40, 81 }, { 19, 45, 75 }, { 49, 52, 78 } };
            CollectionAssert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
    [TestClass]
    public class MatrixSortByMinElementDescTest
    {
        [TestMethod]
        public void SortInputMatrixBySmallestElementDescending()
        {
            int[,] inputMatrix = { { 75, 19, 45 }, { 49, 52, 78 }, { 81, 6, 40 } };
            int[,] actual = inputMatrix;
            int row = 3;
            int column = 3;
            var descending = true;
            int[] indexes = MatrixHelper.MatrixIndexes(inputMatrix, row, column);
            MatrixSortByMinElement sortBySumAsc = new MatrixSortByMinElement(inputMatrix, row, column, indexes);
            var chooseSortingStrategy = new SortingStrategy(((IMatrixSort)sortBySumAsc).SortMatrix);
            actual = chooseSortingStrategy.Invoke(descending);
            int[,] expected = { { 49, 52, 78 }, { 19, 45, 75 }, { 6, 40, 81 } };
            CollectionAssert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
