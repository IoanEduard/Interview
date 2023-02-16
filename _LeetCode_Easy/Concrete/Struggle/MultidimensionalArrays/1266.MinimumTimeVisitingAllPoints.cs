namespace _LeetCode_Easy.Concrete.Struggle.MultidimensionalArrays
{
    public class MinimumTimeVisitingAllPoints
    {
        public static int MinTimeToVisitAllPoints(int[][] points)
        {
            var sum = 0;

            for (int i = 0; i < points.Length; i++)
            {
                var x0 = points[i][0];
                var x1 = points[i + 1][0];

                var y0 = points[i][1];
                var y1 = points[i + 1][1];

                sum += Math.Max(Math.Abs(x0 - x1), Math.Abs(y0 - y1));
            }

            return sum;
        }
    }
}