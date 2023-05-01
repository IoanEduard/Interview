namespace _LeetCode_Medium.Concrete.Struggle
{
    public class NumberOfClosedIslands
    {
        // GRAPH PROBLEM
        public int ClosedIsland(int[][] grid)
        {
            var count = 0;

            for (var i = 1; i < grid.Length - 1; i++)
            {
                for (var j = 1; j < grid[i].Length - 1; j++)
                {
                    if (grid[i][j] == 1)
                        continue;

                    var isClosedIsland = IsClosedIsland(grid[i][j - 1],
                                              grid[i][j + 1],
                                              grid[i - 1][j],
                                              grid[i + 1][j]);

                    if (isClosedIsland)
                        count++;
                }
            }

            return count;
        }

        public int ClosedIsland0(int[][] grid)
        {
            var count = 0;

            for (var i = 1; i < grid.Length - 1; i++)
            {
                if (grid[i][i] == 1)
                    continue;

                var isClosedIsland = IsClosedIsland(grid[i - 1][i - 1],
                                          grid[i + 1][i + 1],
                                          grid[i][i - 1],
                                          grid[i - 1][i]);

                if (isClosedIsland)
                    count++;
            }

            return count;
        }

        private bool IsClosedIsland(int top, int bottom, int left, int right)
        {
            return left + right + top + bottom == 4;
        }
    }
}