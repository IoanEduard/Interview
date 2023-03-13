namespace _LeetCode_Easy.Concrete.Struggle.Strings
{
    public class CheckIfAWordOccursAsAPrefixOfAnyWordInASentence
    {
        public int IsPrefixOfWord0(string sentence, string searchWord)
        {
            var words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                var cnt = 0;
                var j = 0;
                if (words[i].Length < searchWord.Length) continue;

                while (j < searchWord.Length)
                {
                    if (searchWord[j] == words[i][j])
                    {
                        cnt++;
                        if (cnt == searchWord.Length)
                            return i;
                    }
                    j++;
                }
            }

            return -1;
        }

        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            var words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length < searchWord.Length) continue;
                var substring = words[i].Substring(0, searchWord.Length);
                if (substring == searchWord) return i + 1;
            }

            return -1;
        }
    }
}