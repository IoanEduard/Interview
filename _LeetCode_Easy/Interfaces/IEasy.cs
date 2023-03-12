namespace _LeetCode_Easy.Interfaces
{
    public interface IEasy
    {
        int AlternateDigitSum(int n);
        int[] FindArray(int[] pref);
        bool IsAnagram(string word1, string word2);
        bool IsStrictlyPalindromic(int n);
        int[] LeftRigthDifference(int[] nums);
        IList<string> RemoveAnagrams(string[] words);
        IList<string> RemoveAnagrams2(string[] words);
        IList<string> RemoveAnagrams3(string[] words);
        char RepeatedCharacter(string s);
        int[] SeparateDigits(int[] nums);
        int[][] SortTheStudents(int[][] score, int k);
        int[][] SortTheStudents2(int[][] score, int k);
        int[][] SortTheStudents3(int[][] score, int k);
        bool SquareIsWhite(string coordinates);
        int SumOfUnique(int[] nums);
    }
}