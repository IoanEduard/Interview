namespace _LeetCode_Easy.Concrete.Struggle.MultidimensionalArrays
{
    public class CellsWithOddValuesInAMatrix
    {
        public int OddCells(int m, int n, int[][] indices)
        {
            int[][] matrix = new int[m][];
            var count = 0;

            for (int i = 0; i < m; i++)
            {
                matrix[i] = new int[n];
            }

            for (int i = 0; i < indices.Length; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[indices[i][0]][j]++;
                }

                for (int k = 0; k < m; k++)
                {
                    matrix[k][indices[i][1]]++;
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] % 2 != 0) count++;
                }
            }

            return count;
        }
    }
}