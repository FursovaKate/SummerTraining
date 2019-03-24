namespace MatrixSorter
{
    public class SortingStrategy
    {
        public IMatrixSort MatrixSortStrategy;

        public SortingStrategy()
        {

        }
        public SortingStrategy(IMatrixSort matrixSort)
        {
            MatrixSortStrategy = matrixSort;
        }

        public int[,] ExecuteSort(int[,] inputMatrix, int row, int column, int[] indexes, bool descending)
        {
            return MatrixSortStrategy.SortMatrix(inputMatrix, row, column, indexes, descending);
        }
    }
}
