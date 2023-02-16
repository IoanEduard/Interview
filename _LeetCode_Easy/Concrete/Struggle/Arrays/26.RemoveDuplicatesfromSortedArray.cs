namespace _LeetCode_Easy.Concrete.Struggle.Arrays
{
    public class RemoveDuplicatesfromSortedArray
    {
         // Failed attempt

        public static int RemoveDuplicates2(int[] nums)
        {
            var j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                // I tried to increase the i index till I find the element to replace in j 
                // while loop condition must be wrong 
                nums[j++] = nums[i];
                while (i < nums.Length - 1 && nums[i] == nums[i + 1])
                {
                    i++;
                }
            }

            return j;
        }

        public static int RemoveDuplicates(int[] nums)
        {
            var j = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                // Here I just check if prev number is lower than next one while I keep checking by i 
                // If such an element is found we have a pointer j pointing to the last lower element and we place the new element next to it
                if (nums[j] < nums[i])
                {
                    j++;
                    nums[j] = nums[i];
                }
            }

            return j + 1;
        }
    }
}