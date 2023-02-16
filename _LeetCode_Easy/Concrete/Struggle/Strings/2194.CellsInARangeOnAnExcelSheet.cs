namespace _LeetCode_Easy.Concrete.Struggle.Strings
{
    public class CellsInARangeOnAnExcelSheet
    {
        public static IList<string> CellsInRange(string s)
        {
            char leftLetter = s[0];
            char rightLetter = s[3];
            var leftRange = int.Parse(s.Substring(1, 1));
            var rightRange = int.Parse(s.Substring(s.Length - 1, 1));

            var result = new List<string>();
            for (char i = leftLetter; i <= rightLetter; i++)
            {
                for (int j = leftRange; j <= rightRange; j++)
                {
                    result.Add((i.ToString() + j).ToString());
                }
            }

            return result;
        }
    }
}