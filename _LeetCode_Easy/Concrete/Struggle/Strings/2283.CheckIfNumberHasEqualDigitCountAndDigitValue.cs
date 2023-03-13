namespace _LeetCode_Easy.Concrete.Struggle.Strings
{
    public class CheckIfNumberHasEqualDigitCountAndDigitValue
    {
        public bool DigitCount1(string num)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < num.Length; i++)
            {
                var n = num[i] - '0';
                if (dict.ContainsKey(n))
                {
                    dict[n]++;
                }
                else
                {
                    dict.Add(n, 1);
                }
            }

            for (int i = 0; i < num.Length; i++)
            {
                var n = num[i] - '0';

                if (dict[i] != n)
                    return false;
            }

            return true;
        }

        public bool DigitCount(string num)
        {
            var arr = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                arr[num[i] - '0']++;
            }

            for (int i = 0; i < num.Length; i++)
            {
                if (arr[i] != num[i] - '0')
                    return false;
            }

            return true;
        }
    }
}