using System.Collections;

namespace _LeetCode_Easy.Concrete.Struggle.Strings
{
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var hashtable = new Hashtable();

            for (int i = 0; i < s.Length; i++)
            {
                if (!hashtable.ContainsKey(s[i]))
                {
                    hashtable.Add(s[i], t[i]);
                }

                if (!hashtable.ContainsKey(t[i]))
                {
                    hashtable.Add(t[i], s[i]);
                }

                if ((int)hashtable[s[i]] != (int)hashtable[t[i]])
                    return false;
            }

            return true;
        }

        public bool IsIsomorphic2(string s, string t)
        {
            var dictionary = new Dictionary<char, char>();
            var hashS = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dictionary.ContainsKey(t[i]))
                {
                    if (hashS.Contains(s[i])) return false;

                    dictionary.Add(t[i], s[i]);
                    hashS.Add(s[i]);
                }
                else
                {
                    if (dictionary[t[i]] != s[i])
                        return false;
                }
            }

            return true;
        }

        public bool IsIsomorphic3(string s, string t)
        {
            var dictionary = new Dictionary<char, char>();
            var hashS = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dictionary.ContainsKey(t[i]))
                {
                    if (hashS.Contains(s[i])) return false;

                    dictionary.Add(t[i], s[i]);
                    hashS.Add(s[i]);
                }
                else
                {
                    if (dictionary[t[i]] != s[i])
                        return false;
                }
            }

            return true;
        }

        public bool IsIsomorphic4(string s, string t)
        {
            var dictionary = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dictionary.ContainsKey(t[i]))
                    if (dictionary.ContainsValue(s[i]))
                        return false;
                    else
                        dictionary.Add(t[i], s[i]);
                else
                    if (dictionary[t[i]] != s[i])
                    return false;
            }

            return true;
        }
    }
}