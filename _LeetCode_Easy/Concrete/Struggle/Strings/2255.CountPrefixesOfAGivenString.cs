using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _LeetCode_Easy.Concrete.Struggle.Strings
{
    public class CountPrefixesOfAGivenString
    {
        // First Attempt. Its fine, I got wrong the requirements
        public static int CountPrefixes2(string[] words, string s)
        {
            var count = 0;
            var j = 1;

            for (int i = 0; i < words.Length; i++)
            {
                if (j > s.Length)
                {
                    j = 1;
                    continue;
                }

                var sub1 = words[i].Substring(0, j);
                var sub2 = s.Substring(0, j);

                if (sub1.Equals(sub2))
                {
                    count++;
                    j = 1;
                    continue;
                }

                if (words[i].Length < j)
                    j++;
            }

            return count;
        }

        public static int CountPrefixes(string[] words, string s)
        {
            var count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                var j = 0;
                while (j < s.Length && j < words[i].Length)
                {
                    if (words[i][j] != s[j])
                        break;
                    else j++;
                }

                if (j == words[i].Length)
                    count++;
            }

            return count;
        }

        public static int CountPrefixes1(string[] words, string s)
        {
            var count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (s.Length >= words[i].Length)
                {
                    if (words[i] == s.Substring(0, words[i].Length)) count++;
                }
            }

            return count;
        }

        public static int CountPrefixes3(string[] words, string s)
        {
            var hashSet = new HashSet<string>();
            var count = 0;

            for (int i = 1; i <= s.Length; i++)
            {
                hashSet.Add(s.Substring(0, i));
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (hashSet.Contains(words[i])) count++;
            }
            return count;
        }
    }
}