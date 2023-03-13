namespace _LeetCode_Easy.Interfaces
{
    public interface IToImprove
    {
        /// <summary>
        /// https://leetcode.com/problems/find-common-characters/description/
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
         IList<string> CommonChars(string[] words);

         /// <summary>
         /// https://leetcode.com/problems/keyboard-row/description/
         /// </summary>
         /// <param name="words"></param>
         /// <returns></returns>
         string[] FindWords(string[] words);
    }
}