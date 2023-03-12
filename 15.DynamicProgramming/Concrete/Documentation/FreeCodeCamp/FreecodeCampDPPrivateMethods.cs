namespace _15.DynamicProgramming.FreeCodeCamp.Concrete.Documentation
{
    public class FreecodeCampDPPrivateMethods
    {
        protected int Fibbonaci(int n, Dictionary<int, int> memo)
        {
            if (memo.ContainsKey(n))
                return memo[n];

            if (n <= 2) return 1;

            var fib = Fibbonaci(n - 1, memo) + Fibbonaci(n - 2, memo);
            if (!memo.ContainsKey(fib))
            {
                memo.Add(n, fib);
            }

            return fib;
        }

        protected int ShortestPathRecursive(int m, int n, Dictionary<Tuple<int, int>, int> memo)
        {
            var t = new Tuple<int, int>(m, n);

            if (memo.ContainsKey(t))
                return memo[t];

            if (m == 1 && n == 1) return 1;
            if (m == 0 || n == 0) return 0;

            var path = ShortestPathRecursive(m - 1, n, memo) + ShortestPathRecursive(m, n - 1, memo);

            if (!memo.ContainsKey(t))
            {
                memo.Add(t, path);
            }

            return path;
        }
    }
}