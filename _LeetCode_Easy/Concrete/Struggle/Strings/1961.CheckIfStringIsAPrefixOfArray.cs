using System.Text;

namespace _LeetCode_Easy.Concrete.Struggle.Strings
{
    public class CheckIfStringIsAPrefixOfArray
    {
        // Almost
        public bool IsPrefixString0(string s, string[] words)
        {
            var arr = new char[s.Length];

            var k = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (k > s.Length - 1) break;
                    if (char.IsWhiteSpace(words[i][j])) continue;
                    arr[k++] = words[i][j];
                }
            }

            return new string(arr).Equals(s);
        }
        public bool IsPrefixString(string s, string[] words)
        {
            var stringbuilder = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                stringbuilder.Append(words[i]);
                if (stringbuilder.ToString().Equals(s)) return true;
            }

            return false;
        }
    }
}