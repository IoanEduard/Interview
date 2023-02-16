namespace _LeetCode_Easy.Concrete.Struggle.Arrays
{
    public class CreateTargetArrayInTheGivenOrder
    {
        // bad solution
        public static int[] CreateTargetArray0(int[] nums, int[] index)
        {
            var res = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                res.Insert(nums[i], index[i]);
            }

            return res.ToArray();
        }

        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            var res = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == index[i])
                {
                    res[index[i]] = nums[i];
                }
                else
                {
                    var temp = 0;
                    for (int j = index[i]; j < i + 1; j++)
                    {
                        temp = res[j];
                        res[j] = nums[i];
                        nums[i] = temp;
                    }
                }
            }

            return res;
        }
    }
}