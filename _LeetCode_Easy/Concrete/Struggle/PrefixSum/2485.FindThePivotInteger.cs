namespace _LeetCode_Easy.Concrete.Struggle.PrefixSum
{
    public class FindThePivotInteger
    {
        public static int PivotInteger(int n)
        {
            var prefixSumOfN = new int[n];
            var sum = 0;
            var res = 0;

            if (n == 1) return 1;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
                prefixSumOfN[i - 1] = sum;
            }

            for (int i = prefixSumOfN.Length - 1; i > 0; i--)
            {
                if (prefixSumOfN[i] + prefixSumOfN[i - 1] == prefixSumOfN[prefixSumOfN.Length - 1])
                {
                    res = prefixSumOfN[i] - prefixSumOfN[i - 1];
                }
            }

            return res == 0 ? -1 : res;
        }     
    }
}