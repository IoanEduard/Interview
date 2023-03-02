using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11.MultidimensionalArrays.Concrete.LeetCode
{
    public class LeetCodeMatrices : LeetCodeCodeMatricesPrivateMethods
    {
        public static int[][] LargestLocal(int[][] grid)
        {
            int[][] result = new int[grid.Length - 2][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new int[grid.Length - 2];
            };

            for (int i = 0; i < grid.Length - 2; ++i)
            {
                for (int j = 0; j < grid.Length - 2; ++j)
                {
                    for (int k = i; k < i + 3; ++k)
                    {
                        for (int l = j; l < j + 3; ++l)
                        {
                            result[i][j] = Math.Max(result[i][j], grid[k][l]);
                        }
                    }
                }
            }

            return result;
        }

        public static int DiagonalSum0(int[][] mat)
        {
            var sum = 0;

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat.Length; j++)
                {
                    if (i == j)
                    {
                        sum += mat[i][j];
                    }
                }
            }

            for (int n = 0; n < mat.Length; n++)
            {
                sum += mat[n][mat[0].Length - n - 1];
            }

            if (mat[0].Length % 2 != 0)
                sum -= mat[mat.Length / 2][mat[0].Length / 2];

            return sum;
        }

        public static int DiagonalSum(int[][] mat)
        {
            var sum = 0;

            for (int n = 0; n < mat.Length; n++)
            {
                sum += mat[n][n];
                sum += mat[n][mat[0].Length - n - 1];
            }

            if (mat[0].Length % 2 != 0)
                sum -= mat[mat.Length / 2][mat[0].Length / 2];

            return sum;
        }

        public static int CountNegatives(int[][] grid)
        {
            var count = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = grid[i].Length - 1; j >= 0; j--)
                {
                    if (grid[i][j] < 0)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return count;
        }

        public static int MaximumWealth(int[][] accounts)
        {
            var max = int.MinValue;

            for (int i = 0; i < accounts.Length; i++)
            {
                var sum = accounts[i].Sum();
                if (sum > max) max = sum;
            }

            return max;
        }

        public static int MaximumWealth2(int[][] accounts)
        {
            var max = int.MinValue;

            for (int i = 0; i < accounts.Length; i++)
            {
                var sum = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    sum += accounts[accounts.Length - i - 1][j];
                }
                if (sum > max) max = sum;
            }

            return max;
        }

        public static bool IsToeplitzMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length - 1; i++)
                for (int j = 0; j < matrix[i].Length - 1; j++)
                    if (matrix[i][j] != matrix[i + 1][j + 1]) return false;

            return true;
        }

        public static int[][] Transpose(int[][] matrix)
        {
            var result = new int[matrix[0].Length][];

            for (int i = 0; i < matrix[0].Length; i++)
            {
                result[i] = new int[matrix.Length];
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    result[j][i] = matrix[i][j];
                }
            }

            return result;
        }

        public static int[][] Construct2DArray(int[] original, int m, int n)
        {
            if (original.Length != m * n) return Array.Empty<int[]>();

            var result = new int[m][];
            for (int i = 0; i < m; i++)
            {
                result[i] = new int[n];
            }
            var k = 0;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[0].Length; j++)
                {
                    result[i][j] = original[k++];
                }
            }

            return result;
        }

        public static int DeleteGreatestValue(int[][] grid)
        {
            var max = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                Array.Sort(grid[i]);
            }

            /*
                1 2 4
                1 3 3
             */

            // row length is the number of columns for a 2x3 matrix
            for (int i = 0; i < grid[0].Length; i++)
            {
                var columnMax = 0;
                for (int j = 0; j < grid.Length; j++)
                {
                    columnMax = Math.Max(columnMax, grid[j][i]);
                }

                max += columnMax;
            }

            return max;
        }

        public static int[][] Reverse(int[][] image)
        {
            for (int i = 0; i < image.Length; i++)
            {
                var temp = image[i];
                image[i] = image[image.Length - i - 1];
                image[image.Length - i - 1] = temp;
            }

            return image;
        }
        public static int[][] ReverseRowsInMatrix(int[][] image)
        {
            for (int i = 0; i < image.Length / 2; i++)
            {
                for (int j = 0; j < image.Length; j++)
                {
                    var temp = image[i][j];
                    image[i][j] = image[image.Length - i - 1][j];
                    image[image.Length - i - 1][j] = temp;
                }
            }

            return image;
        }

        /*
            1 2 3    Transpose   1 4 7
            4 5 6    ----------> 2 5 8 Reverse rows  
            7 8 9                3 6 9
        
        */

        public void Rotate(int[][] matrix)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = i; j < matrix[0].Length; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = i; j < matrix[0].Length; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[i][matrix.Length - 1 - j];
                    matrix[i][matrix.Length - 1 - j] = temp;
                }
            }
        }

        // Rotate matrix 360 and check after each rotation if matches the target
        public bool FindRotation(int[][] matrix, int[][] target)
        {
            if (MatrixIsEqual(matrix, target))
                return true;

            var count = 0;
            while (count < 4)
            {
                TransposeMatrix(matrix);
                base.ReverseMatrix(matrix);

                if (MatrixIsEqual(matrix, target))
                    return true;

                count++;
            }

            return false;
        }


    }
}