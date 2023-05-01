namespace _LeetCode_Medium.Concrete.Struggle
{
    public class MinimizeMaximumOfArray
    {
        public int MinimizeArrayValue(int[] nums)
        {
            double result = int.MinValue;
            double prefixSum = 0;

            for (var i = 0; i < nums.Length - 1; i++)
            {
                prefixSum += nums[i];
                result = Math.Max(result, Math.Ceiling(prefixSum / (i + 1)));
            }

            return (int)result;
        }

        // https://leetcode.com/problems/minimize-maximum-of-array/solutions/3381834/c-binary-search-average-method-easy-to-understand-dry-run/
        // https://leetcode.com/problems/minimize-maximum-of-array/solutions/2706361/c-binary-search/
        public int MinimizeArrayValueBinarySearch(int[] nums)
        {
            double left = 0;
            double right = nums.Max();

            while (left < right)
            {
                double mid = left + (right - left) / 2;

                if (IsValid(nums, mid))
                    right = mid;
                else
                    left = mid + 1;
            }

            return (int)right;
        }

        private bool IsValid(int[] nums, double mid)
        {
            if (nums[0] > mid) return false;

            double previous = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                double diff = mid - previous;
                previous = nums[i] - diff;

                if (previous > mid) return false;
            }

            return true;
        }
    }
}