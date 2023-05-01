namespace _LeetCode_Medium.Concrete.Struggle
{
    public class MaximumPointsYouCanObtainFromCards
    {
        public int MaxScore(int[] cardPoints, int k)
        {
            var currentSum = 0;
            var maxScore = int.MinValue;
            var pointerRight = 0;

            for (int i = 0; i < k; i++)
            {
                currentSum += cardPoints[i];
            }

            maxScore = currentSum;
            for (var i = 0; i < k; i++)
            {
                currentSum += cardPoints[cardPoints.Length - pointerRight - 1];
                currentSum -= cardPoints[k - i - 1];

                maxScore = Math.Max(maxScore, currentSum);
                pointerRight++;
            }

            return maxScore;
        }

        // Leetcode solution
        public int MaxScore1(int[] cardPoints, int k)
        {
            var n = cardPoints.Length;
            var res = 0;

            // n - k makes more sense, in my solution I started from the left prefix sum
            for (int i = n - k; i < n; i++) res += cardPoints[i];

            for (int i = 0, s = res; i < k; i++)
            {
                s -= cardPoints[n - k + i];
                s += cardPoints[i];
                res = Math.Max(res, s);
            }

            return res;
        }
    }
}