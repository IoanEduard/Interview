namespace _LeetCode_Easy.Concrete
{
    public class _DailyWorkFile
    {
        public string RemoveDigit(string number, char digit)
        {
            var arrIndexes = new bool[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == digit)
                {

                }
            }

            return "";
        }

        //public static int[] ArrayRankTransform(int[] arr)
        //{
        //    var temp = arr;
        //    Array.Sort(temp);


        //}

        public int ClimbStairs(int n)
        {
            return ClimbStairsRecursive(n, new() { });
        }

        private int ClimbStairsRecursive(int n, Dictionary<int, int> memo)
        {
            if (memo.ContainsKey(n))
                return memo[n];

            if (n < 4)
                return n;

            memo[n] = ClimbStairsRecursive(n - 1, memo) + ClimbStairsRecursive(n - 2, memo);

            return memo[n];
        }

        public int ClimbStairsIterative(int n)
        {
            if (n == 1)
                return 1;

            var first = 1;
            var second = 2;
            var result = second;

            for (var i = 3; i <= n; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }

            return result;
        }

        // public int[] ProcessQueries(int[] queries, int m)
        // {
        //     for (var i = 0; i < queries.Length; i++)
        //     {

        //     }
        // }

        public int TriangularSum(int[] nums)
        {
            var numsLength = nums.Length;
            var triangleLength = nums.Length - 1;

            if (nums.Length == 1)
                return nums[0];

            while (numsLength > 1)
            {
                var temp = new int[triangleLength];
                for (var i = 0; i < triangleLength; i++)
                {
                    temp[i] = (nums[i] + nums[i + 1]) % 10;
                    nums[i] = temp[i];
                }

                triangleLength--;
                numsLength--;
            }

            return nums[0];
        }

    }
}