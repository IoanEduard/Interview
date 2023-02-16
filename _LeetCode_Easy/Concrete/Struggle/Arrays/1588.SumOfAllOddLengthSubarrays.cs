namespace _LeetCode_Easy.Concrete.Struggle.Arrays
{
    public class SumOfAllOddLengthSubarrays
    {
        public static int SumOddLengthSubarrays2(int[] arr)
        {
            var k = 1;
            var sum = 0;

            while (k <= arr.Length)
            {
                for (int j = 0; j + k - 1 < arr.Length; j++)
                {
                    for (int i = j; i < j + k; i++)
                    {
                        sum += arr[i];
                    }
                }

                k += 2;
            }

            return sum;
        }

        public static int SumOddLengthSubarrays(int[] arr)
        {
            var sum = 0;

            for (int i = 1; i <= arr.Length; i += 2)
            {
                for (int j = 0; j + i - 1 < arr.Length; j++)
                {
                    for (int k = j; k < j + i; k++)
                    {
                        sum += arr[k];
                    }
                }
            }

            return sum;
        }
    }
}