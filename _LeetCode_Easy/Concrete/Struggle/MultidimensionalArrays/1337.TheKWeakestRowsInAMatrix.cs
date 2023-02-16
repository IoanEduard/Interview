namespace _LeetCode_Easy.Concrete.Struggle.MultidimensionalArrays
{
    public class TheKWeakestRowsInAMatrix
    {
        public static int[] KWeakestRows(int[][] mat, int k)
        {
            var dictionaryRowSoldierCount = new Dictionary<int, int>();

            for (int i = 0; i < mat.Length; i++)
            {
                dictionaryRowSoldierCount.Add(i, 0);

                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        dictionaryRowSoldierCount[i]++;
                    }
                }
            }

            return dictionaryRowSoldierCount.OrderBy(x => x.Value).Take(k).Select(x => x.Key).ToArray();
        }
    }
}