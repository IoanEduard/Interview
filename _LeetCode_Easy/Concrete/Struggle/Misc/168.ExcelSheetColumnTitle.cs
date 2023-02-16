using System.Text;

namespace _LeetCode_Easy.Concrete.Struggle.Misc
{
    public class ExcelSheetColumnTitle
    {
        // My Failed attempt
        public static string ConvertToTitle(int columnNumber)
        {
            var dictionary = new Dictionary<int, char>();
            var i = 1;
            var division = 0;
            var remainder = 0;

            for (char c = 'A'; c <= 'Z'; c++)
            {
                dictionary.Add(i++, c);
            }

            if (columnNumber <= 26) return dictionary[columnNumber].ToString();

            while (division > 26)
            {
                division = columnNumber / 26;
                remainder = columnNumber - (division * 26);
            }

            //division = columnNumber / 26;
            //remainder = columnNumber - (division * 26);

            return new string(new char[] { dictionary[division], dictionary[remainder] });
        }

        // Optimal solution
        public static string ConvertToBase26(int columnNumber)
        {
            var temp = columnNumber;
            var stack = new Stack<char>();

            while (temp > 0)
            {
                temp--;
                stack.Push((char)(temp % 26 + 'A'));
                temp = temp / 26;
            }

            return string.Join("", stack);
        }

        // My second try
        public static string ConvertToBase26FirstTry(int columnNumber)
        {
            var temp = columnNumber;
            var stringBuilder = new StringBuilder();

            var dictionary = new Dictionary<int, char>();
            var i = 1;

            for (char c = 'A'; c <= 'Z'; c++)
            {
                dictionary.Add(i++, c);
            }

            if (columnNumber <= 26) return dictionary[columnNumber].ToString();

            while (temp > 0)
            {
                temp--;
                var character = (dictionary[temp % 26 + 1]);
                stringBuilder.Append(character);
                temp = temp / 26;
            }

            var result = stringBuilder.ToString().ToCharArray();
            Array.Reverse(result);

            return new string(result);
        }
    }
}