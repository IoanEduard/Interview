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
    }
}