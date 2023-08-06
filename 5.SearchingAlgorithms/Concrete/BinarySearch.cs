namespace _5.SearchingAlgorithms.Concrete
{
    /*
       works on sorted array
       searching a word in a dictionary
       Regular loop goes in Linear Time Complexity O(N)

       Implementation:
       We start from the middle
           if elem is greater than the target then the element must be somewhere in the left
           we pick middle again

       O(log N) time complexity because we divide and conquer

    */

    public class BinarySearch
    {
        // Fireship version: /watch?v=MFhxShGxHWc
        protected int BinarySearch0(int[] arr, int target, int left, int right)
        {
            if (left > right)
                return -1;

            var middle = (int)Math.Floor((double)(left + right) / 2);

            if (arr[middle] == target)
                return middle;

            if (arr[middle] > target)
            {
                return BinarySearch0(arr, target, left, middle - 1);
            }
            else
            {
                return BinarySearch0(arr, target, middle + 1, right);
            }
        }

        protected int BinarySearch1(int[] nums, int target, int left, int right)
        {
            if (left >= right)
            {
                return -1;
            }
            else
            {
                var mid = (left + right) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    return BinarySearch1(nums, target, mid + 1, right);
                }
                else
                {
                    return BinarySearch1(nums, target, left, mid + 1);
                }
            }
        }

        protected int BinarySearchLoop(int[] nums, int target, int left, int right)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return -1;
        }

        public int SearchInsert(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return left;
        }

        public char NextGreatestLetter(char[] letters, char target)
        {
            var left = 0;
            var right = letters.Length - 1;
            char answer = letters[0];

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (letters[mid] > target)
                {
                    right = mid - 1;
                    answer = letters[mid];
                }
                else
                    left = mid + 1;
            }

            return answer;
        }

    }
    /* 28.07 - 31-07
        Entire Study Plan: https://leetcode.com/studyplan/binary-search/
        Solved List:

        Other Problems:
        1. https://leetcode.com/problems/longest-subsequence-with-limited-sum/
        2. https://leetcode.com/problems/find-the-distance-value-between-two-arrays/
        3. https://leetcode.com/problems/fair-candy-swap/
        4. https://leetcode.com/problems/special-array-with-x-elements-greater-than-or-equal-x/
        5. https://leetcode.com/problems/kth-missing-positive-number/
        6. https://leetcode.com/problems/intersection-of-two-arrays-ii/
        7. https://leetcode.com/problems/minimum-common-value/
        8. https://leetcode.com/problems/arranging-coins/
        9. https://leetcode.com/problems/valid-perfect-square/
        10. https://leetcode.com/problems/find-positive-integer-solution-for-a-given-equation/
        11. https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/
        12. https://leetcode.com/problems/maximum-number-of-groups-entering-a-competition/
        13. https://leetcode.com/problems/maximum-tastiness-of-candy-basket/
        14. https://leetcode.com/problems/kth-smallest-element-in-a-sorted-matrix/
        15. https://leetcode.com/problems/compare-strings-by-frequency-of-the-smallest-character/
        16. https://leetcode.com/problems/minimum-limit-of-balls-in-a-bag/
        17. https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
        18. https://leetcode.com/problems/magnetic-force-between-two-balls/
        19. https://leetcode.com/problems/binary-search/description/?envType=study-plan-v2&envId=binary-search
    */
}