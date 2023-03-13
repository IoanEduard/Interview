using System.Text;

namespace _LeetCode_Easy.Concrete.Struggle.Strings
{
    public class CalculateDigitSumOfAString
    {
        public string DigitSum(string s, int k)
        {
            var stringBuilder = new StringBuilder();
            var substring = string.Empty;

            while (s.Length > k)
            {
                for (int i = 0; i < s.Length; i += k)
                {
                    if (i < s.Length - k)
                        substring = s.Substring(i, k);
                    else
                        substring = s.Substring(i, s.Length - i);

                    var currentSum = 0;
                    for (int j = 0; j < substring.Length; j++)
                    {
                        currentSum += substring[j] - '0';
                    }
                    stringBuilder.Append(currentSum.ToString());
                }
                s = new string(stringBuilder.ToString());
                stringBuilder.Clear();
            }

            return s;
        }
    }
}