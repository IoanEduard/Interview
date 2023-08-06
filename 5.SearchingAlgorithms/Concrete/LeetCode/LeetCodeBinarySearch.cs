using _5.SearchingAlgorithms.Interfaces;

namespace _5.SearchingAlgorithms.Concrete.LeetCode
{
    public class LeetCodeBinarySearch : BinarySearch, IBinarySearchProblems
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

        public static int[] SearchRange0(int[] nums, int target)
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

        public int CountNegatives(int[][] grid)
        {
            var count = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                count += BinarySearchCountNegatives(grid[i]);
            }
            return count;
        }

        private int BinarySearchCountNegatives(int[] arr)
        {
            var left = 0;
            var right = arr.Length - 1;
            var mid = 0;

            while (left <= right)
            {
                mid = left + (right - left) / 2;

                // if (arr[mid] < 0)
                //     return arr.Length - mid;

                if (arr[mid] > 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return arr.Length - right;
        }

        public int[] SearchRange(int[] nums, int target)
        {
            var left = GetSide(nums, target, true);
            var right = GetSide(nums, target, false);

            return new int[] { right, left };
        }

        private int GetSide(int[] nums, int target, bool leftDirection)
        {
            var left = 0;
            var right = nums.Length - 1;
            var answer = -1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    answer = leftDirection ? left = mid + 1 : right = mid - 1;
                    answer = mid;
                }
                else if (nums[mid] > target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return answer;
        }

        public bool IsPerfectSquare(int num)
        {
            if (num == 1) return true;

            long left = 1;
            long right = num / 2;

            while (left <= right)
            {
                long mid = left + (right - left) / 2;

                if (mid * mid == num) return true;
                else if (mid * mid < num)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return false;
        }

        public int MySqrt(int num)
        {
            if (num == 0) return num;

            var left = 1;
            var right = num;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (mid == num / mid) return (int)mid;
                else if (num / mid < mid)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return (int)right;
        }

        // mathematics... not really for me
        public int ArrangeCoins(int n)
        {
            long left = 1;
            long right = n;

            while (left <= right)
            {
                long mid = left + (right - left) / 2;
                long current = mid * (mid + 1) / 2;

                if (current == n)
                    return (int)mid;
                else if (current < n)
                    left = current + 1;
                else
                    right = current - 1;
                }

            return (int)right;
        }
    }

    public class TimeMap
    {
        Dictionary<string, List<(string value, int timestamp)>> _values;

        public TimeMap()
        {
            _values = new Dictionary<string, List<(string, int)>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            if (!_values.ContainsKey(key))
                _values.Add(key, new List<(string, int)>());

            _values[key].Add((value, timestamp));
        }

        public string Get(string key, int timestamp)
        {
            if (!_values.ContainsKey(key)) return string.Empty;

            var list = _values[key];

            var left = 0;
            var right = list.Count - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (list[mid].timestamp == timestamp)
                    return list[mid].value;
                else if (list[mid].timestamp <= timestamp)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return left == 0 ? string.Empty : list[left - 1].value;
        }
    }
    public class SnapshotArray
    {
        List<Dictionary<int, int>> _history_records;
        int _snap = 0;

        public SnapshotArray(int length)
        {
            _history_records = new List<Dictionary<int, int>>();
        }

        public void Set(int index, int val)
        {
            if (_history_records[index] == null)
                _history_records[index] = new Dictionary<int, int>();

            _history_records[index][_snap] = val;
        }

        public int Snap()
        {
            return _snap++;
        }

        public int Get(int index, int snap_id)
        {
            if (_history_records[index] == null) return 0;

            while (snap_id >= 0 && !_history_records[index].ContainsKey(snap_id)) snap_id--;

            if (!_history_records[index].ContainsKey(snap_id)) return 0;

            return _history_records[index][snap_id];
        }
    }
}