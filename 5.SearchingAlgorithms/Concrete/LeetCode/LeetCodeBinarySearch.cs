namespace _5.SearchingAlgorithms.Concrete.LeetCode
{
    public class LeetCodeBinarySearch : BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            var result = BinarySearchLoop(nums, target, 0, nums.Length - 1);

            return result;
        }

        // Helpful information 
        // https://leetcode.com/problems/search-insert-position/solutions/423166/binary-search-101/?orderBy=most_votes
        public static int SearchInsert(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            var middle = 0;

            while (left <= right)
            {
                middle = (int)Math.Floor((double)(left + right) / 2);

                if (nums[middle] > target)
                {
                    right = middle - 1;
                }
                else if (nums[middle] < target)
                {
                    left = middle + 1;
                }
                else return middle;
            }
            // After you are done with binary search and you do not find your target,
            //      left would be the first index at which value is just greater than the target value and this is what we want as our answer,
            //      as you would insert your target variable right over here to keep the array sorted. 
            return left;
        }

        public static int FirstBadVersion(int n)
        {
            var left = 1;
            var right = n;

            while (left <= right)
            {
                // this way 
                var middle = left + (right - left) / 2;

                if (IsBadVersion(middle))
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return left;
        }

        private static bool IsBadVersion(int middle)
        {
            return false;
        }

        public static int GuessNumber(int n)
        {
            var left = 0;
            var right = n;

            while (left <= right)
            {
                var middle = left + (right - left) / 2;
                var g = Guess(middle);

                if (g == -1)
                {
                    right = middle - 1;
                }
                else if (g == 1)
                {
                    left = middle + 1;
                }
                else return middle;
            }

            return left;
        }

        private static int Guess(int n)
        {
            return 0;
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            // We try to find the most rightside element first and get the pointer
            // We try to find the most leftside element because middle would be same as rightside when target found first.

            var rightSide = GetRightSide(nums, 0, nums.Length - 1, target);
            var leftSide = GetLefttSide(nums, 0, nums.Length - 1, target);

            return new int[] { rightSide, leftSide };
        }

        private static int GetRightSide(int[] nums, int left, int right, int target)
        {
            var rightResult = -1;

            while (left <= right)
            {
                var middle = left + (right - left) / 2;

                if (nums[middle] == target)
                {
                    rightResult = middle;
                    right = middle - 1;
                }
                else if (nums[middle] > target)
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return rightResult;
        }

        private static int GetLefttSide(int[] nums, int left, int right, int target)
        {
            var leftResult = -1;

            while (left <= right)
            {
                var middle = left + (right - left) / 2;

                if (nums[middle] == target)
                {
                    leftResult = middle;
                    left = middle + 1;
                }
                else if (nums[middle] > target)
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return leftResult;
        }

        public static int[] SearchRange2(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            var middle = 0;
            var result = new int[] { -1, -1 };

            while (left <= right)
            {
                middle = left + (right - left) / 2;

                if (nums[middle] == target)
                {
                    result[0] = middle;
                    right = middle - 1;
                }
                else if (nums[middle] > target)
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            left = 0;
            right = nums.Length - 1;
            while (left <= right)
            {
                middle = left + (right - left) / 2;

                if (nums[middle] == target)
                {
                    result[1] = middle;
                    left = middle + 1;
                }
                else if (nums[middle] > target)
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return result;
        }

        public static IList<int> TargetIndices(int[] nums, int target)
        {
            Array.Sort(nums);

            var result = new List<int>();
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var middle = left + (right - left) / 2;

                if (nums[middle] > target)
                    right = middle - 1;
                else if (nums[middle] < target)
                    left = middle + 1;
                else
                {
                    // Here we find the left most middle that is equal with the target 
                    while (middle - 1 >= 0 && nums[middle - 1] == target)
                        --middle;

                    for (int i = middle; i < nums.Length; i++)
                    {
                        if (nums[i] == target) 
                            result.Add(i);
                        else break;
                    }
                    break;
                }
            }

            return result;
        }
    }
}