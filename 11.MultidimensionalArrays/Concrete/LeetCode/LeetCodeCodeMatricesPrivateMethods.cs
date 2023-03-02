namespace _11.MultidimensionalArrays.Concrete.LeetCode
{
    public class LeetCodeCodeMatricesPrivateMethods
    {
        protected void TransposeMatrix(int[][] matrix)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = i + 1; j < matrix[0].Length; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            return;
        }

        protected bool MatrixIsEqual(int[][] matrix, int[][] target)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] != target[i][j])
                        return false;
                }
            }

            return true;
        }

        protected void ReverseMatrix(int[][] matrix)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = i; j < matrix.Length / 2; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[i][matrix.Length - 1 - j];
                    matrix[i][matrix.Length - 1 - j] = temp;
                }
            }

            return;
        }
    }
}