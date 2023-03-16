namespace _6.Recursion.Concrete.freeCodeCamp
{
    public class FreeCodeCampRecursion
    {
        public string ReverseString(string s)
        {
            if (s == string.Empty)
                return string.Empty;

            return ReverseString(s.Substring(1)) + s[0];
        }

        public bool IsPalindrome(string s)
        {
            if (s.Length == 0 || s.Length == 1) return true;

            if (s[0] == s[s.Length - 1])
                return IsPalindrome(s.Substring(1, s.Length - 2));

            return false;
        }
    }
}