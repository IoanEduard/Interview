using System.Collections;

namespace _LeetCode_Easy.Concrete.Struggle.Strings
{
    public class WordPattern
    {
        public bool WordPattern0(string pattern, string s)
        {
            var words = s.Split(' '); ;
            var dictionary = new Dictionary<char, string>();

            for (int i = 0; i < pattern.Length; i++)
            {
                if (!dictionary.ContainsKey(pattern[i]))
                {
                    dictionary.Add(pattern[i], words[i]);
                }
                else
                {
                    if (dictionary[pattern[i]] != words[i]) return false;
                }
            }

            return true;
        }

        public bool WordPattern1(string pattern, string s)
        {
            var words = s.Split(' ');
            if (words.Length != pattern.Length)
                return false;

            var hashtable = new Hashtable();

            for (int i = 0; i < pattern.Length; i++)
            {
                if (!hashtable.ContainsKey(pattern[i]))
                {
                    hashtable.Add(pattern[i], i);
                }

                if (!hashtable.ContainsKey(words[i]))
                {
                    hashtable.Add(words[i], i);
                }

                if ((int)hashtable[words[i]]! != (int)hashtable[pattern[i]]!)
                    return false;
            }

            return true;
        }
    }
}