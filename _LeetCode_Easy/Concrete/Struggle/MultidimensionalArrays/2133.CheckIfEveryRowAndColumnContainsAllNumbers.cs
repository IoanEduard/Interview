namespace _LeetCode_Easy.Concrete.Struggle.MultidimensionalArrays
{
    public class CheckIfEveryRowAndColumnContainsAllNumbers
    {
        // First Attempt, didn't passed all testcases
        public static bool CheckValid(int[][] matrix)
        {
            var desiredSum = matrix[0].Length * (matrix[0].Length + 1) / 2;
            var colSum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                var rowSum = 0;

                for (int j = 0; j < matrix.Length; j++)
                {
                    colSum += matrix[i][j];
                    rowSum += matrix[j][i];
                }

                if (colSum != desiredSum) return false;
                if (rowSum != desiredSum) return false;

                colSum = 0;
            }

            return true;
        }

         public static bool CheckValid2(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                var hashsetCol = new HashSet<int>();
                var hashsetRow = new HashSet<int>();

                for (int j = 0; j < matrix.Length; j++)
                {
                    if (!hashsetCol.Add(matrix[i][j]) || !hashsetRow.Add(matrix[j][i])) return false;
                }
            }

            return true;
        }
    }
}