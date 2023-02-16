namespace _LeetCode_Easy.Concrete.Struggle.Strings
{
    public class RingsAndRods
    {
        public static int CountPoints1(string rings)
        {
            var dict = new Dictionary<int, HashSet<int>>();
            var res = 0;

            if (rings.Length / 2 < 3) return 0;

            for (int i = 1; i < rings.Length; i += 2)
            {
                if (dict.ContainsKey(rings[i]))
                {
                    dict[rings[i]].Add(rings[i - 1]);
                }
                else
                {
                    dict.Add(rings[i], new HashSet<int>() { rings[i - 1] });
                }
            }

            foreach (var item in dict)
            {
                if (item.Value.Count() == 3)
                    res++;
            }

            return res;
        }
        public static int CountPoints(string rings)
        {
            var r = new bool[10];
            var b = new bool[10];
            var g = new bool[10];

            for (int i = 0; i < rings.Length - 1; i++)
            {
                var position = rings[i + 1] - '0';
                var color = rings[i];

                if (color == 'R') r[position] = true;
                else if (color == 'B') b[position] = true;
                else if (color == 'G') g[position] = true;
            }

            var result = 0;
            for (int i = 0; i < 10; i++)
            {
                if (r[i] && b[i] && g[i])
                    result++;
            }

            return result;
        }
    }
}