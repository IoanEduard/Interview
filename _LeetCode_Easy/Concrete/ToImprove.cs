
using _LeetCode_Easy.Interfaces;

namespace _LeetCode_Easy.Concrete
{
    public class ToImprove : IToImprove
    {
        public IList<string> CommonChars(string[] words)
        {
            var dict = new Dictionary<char, int>();
            var tempDictionary = new Dictionary<char, int>();

            foreach (char character in words[0])
            {
                if (dict.ContainsKey(character))
                {
                    dict[character]++;
                }
                else
                {
                    dict.Add(character, 1);
                }
            }

            for (var i = 0; i < words.Length; i++)
            {
                var dict2 = new Dictionary<char, int>();

                for (int j = 0; j < words[i].Length; j++)
                {
                    if (dict2.ContainsKey(words[i][j]))
                    {
                        dict2[words[i][j]]++;
                    }
                    else
                    {
                        dict2.Add(words[i][j], 1);
                    }
                }

                foreach (var key in dict.Keys)
                {
                    if (dict2.ContainsKey(key))
                    {
                        tempDictionary.Add(key, Math.Min(dict[key], dict2[key]));
                    }
                }

                dict = tempDictionary;
                tempDictionary = new Dictionary<char, int>();
            }

            var list = new List<string>();

            foreach (var item in dict)
            {
                list.AddRange(Enumerable.Repeat(item.Key.ToString(), item.Value));
            }

            return list;
        }

        public string[] FindWords(string[] words)
        {
            var hash1 = new HashSet<char> { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            var hash2 = new HashSet<char> { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            var hash3 = new HashSet<char> { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

            var result = new List<string>();

            var flag = true;
            for (int i = 0; i < words.Length; i++)
            {
                if (hash1.Contains(char.ToLower(words[i][0])))
                {
                    foreach (var character in words[i].ToLower())
                    {
                        if (!hash1.Contains(character))
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag == true)
                        result.Add(words[i]);
                }

                else if (hash2.Contains(char.ToLower(words[i][0])))
                {
                    foreach (var character in words[i].ToLower())
                    {
                        if (!hash2.Contains(character))
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag == true)
                        result.Add(words[i]);
                }

                else if (hash3.Contains(char.ToLower(words[i][0])))
                {
                    foreach (var character in words[i].ToLower())
                    {
                        if (!hash3.Contains(character))
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag == true)
                        result.Add(words[i]);
                }
                flag = true;
            }

            return result.ToArray();
        }
    }
}