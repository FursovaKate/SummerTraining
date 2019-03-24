namespace MatrixSorter
{
    public interface IMatrixSort
    {
        int[,] SortMatrix(int[,] inputMatrix, int row, int column, int[] indexes, bool descending);
    }
}
