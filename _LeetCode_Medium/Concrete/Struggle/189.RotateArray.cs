namespace _LeetCode_Medium.Concrete.Struggle
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
		{
			k = k % nums.Length;
			if (k < 0) k += nums.Length;

			ReverseArray(nums, 0, nums.Length - k - 1);
			ReverseArray(nums, nums.Length - k, nums.Length - 1);
			ReverseArray(nums, 0, nums.Length - 1);
		}

		private static void ReverseArray(int[] nums, int left, int right)
		{
			while (left < right)
			{
				var temp = nums[left];
				nums[left] = nums[right];
				nums[right] = temp;
				left++;
				right--;
			}
		}

		// Why did it I struggle with this?
		// Here is my failed attempt.
		public static int[] RotateFail(int[] nums, int k)
		{
			var startRotationPointer = nums.Length < k ? k % nums.Length : nums.Length - k;

			for (int i = 0; i < nums.Length; i++)
			{
				if (startRotationPointer > nums.Length - 1) break;

				var temp = nums[startRotationPointer];
				nums[startRotationPointer] = nums[i];
				nums[i] = temp;
				startRotationPointer++;
			}

			return nums;
		}

		// I tried to split the array in half where the remainder % would be, it passed most of the testcases except the arrays with odd length 
		// I tried to switch the left with right elements between the middle index but it only worked for even length 

		// What is the new thing I did learn:
		// Problem can be approached by spliting the array in two subarrays, reverse them then reverse the entire array, such as:
		/*
		 Let the array be - 123456789 and k = 4
			Step 1 - 12345 6789 ---> 54321 6789
			Step 2 - 54321 6789 ---> 54321 9876
			Step 3 - 543219876 ---> 678912345
		 */
		// We apply two pointers, left to center, center to right and we can split the problem in two subproblems that reverse the subarrays.

		// Other approaches to this problem:
		// 1. https://leetcode.com/problems/rotate-array/solutions/253052/c-solution/
		// 2. https://leetcode.com/problems/rotate-array/solutions/557491/c-solutions/
    }
}