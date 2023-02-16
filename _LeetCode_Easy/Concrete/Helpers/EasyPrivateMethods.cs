/*
    Straight to the point easy problems
*/

namespace _LeetCode_Easy.Concrete
{
    public class EasyPrivateMethods
    {
        internal static bool WordIsPalindrome(string word)
        {
            for (int i = 0, j = word.Length - 1; i < word.Length / 2; i++, j--)
            {
                if (word[i] != word[j])
                    return false;
            }

            return true;
        }

        internal static bool CheckSubstring(string element, string word)
        {
            var elementLength = element.Length;
            var wordLength = word.Length;

            for (int i = 0; i <= wordLength - elementLength; i++)
            {
                var count = 0;
                for (int j = 0; j < elementLength; j++)
                {
                    if (word[i + j] != element[j])
                        break;

                    count++;
                }
                if (count == elementLength)
                    return true;
            }

            return false;
        }
    }
}