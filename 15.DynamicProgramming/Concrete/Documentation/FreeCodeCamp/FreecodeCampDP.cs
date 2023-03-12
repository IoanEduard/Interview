using DynamicProgramming.Interfaces;

namespace _15.DynamicProgramming.FreeCodeCamp.Concrete.Documentation
{
    public class FreecodeCampDP : FreecodeCampDPPrivateMethods, IFreecodeCampDP
    {
        public int FibInefficient(int n)
        {
            if (n <= 2) return 1;

            return FibInefficient(n - 1) + FibInefficient(n - 2);
        }

        public int FibRecursive(int n)
        {
            return Fibbonaci(n, new Dictionary<int, int>());
        }

        public int FibDP(int n)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;

            var arrFib = new int[n + 1];

            arrFib[0] = 0;
            arrFib[1] = 1;
            arrFib[2] = 1;

            for (var i = 3; i <= n; i++)
            {
                arrFib[i] = arrFib[i - 1] + arrFib[i - 2];
            }

            return arrFib[n];
        }

        public int ShortestPathInefficient(int m, int n)
        {
            if (m == 1 && n == 1) return 1;
            if (m == 0 || n == 0) return 0;

            return ShortestPathInefficient(m - 1, n) + ShortestPathInefficient(m, n - 1);
        }

        public int ShortestPathMemoization(int m, int n)
        {
            return ShortestPathRecursive(n, m, new Dictionary<Tuple<int, int>, int>());
        }

        public int ShortestPathIterativeLeetCode1(int m, int n)
        {
            var result = new int[m, n];

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (j == 0 || i == 0)
                        result[i, j] = 1;
                    else
                        result[i, j] = result[i - 1, j] + result[i, j - 1];
                }
            }

            return result[m - 1, n - 1];
        }

        public int ShortestPathIterativeLeetCode2(int m, int n)
        {
            if (m < 2 || n < 2)
                return 1;

            var result = new int[n];
            result[0] = 1;

            for (var i = 0; i < m; i++)
            {
                for (var j = 1; j < n; j++)
                {
                    result[j] += result[j - 1];
                }
            }

            return result[n - 1];
        }

        public bool CanSum(int n, int[] numbers, Dictionary<int, bool> memo)
        {
            if (memo.ContainsKey(n))
                return memo[n];

            if (n == 0) return true;
            if (n < 0) return false;

            for (var i = 0; i < numbers.Length; i++)
            {
                var sum = n - numbers[i];

                if (CanSum(sum, numbers, memo))
                {
                    memo[n] = true;
                    return true;
                }
            }

            memo[n] = false;

            return false;
        }

        public bool CanSum(int targetSum, int[] numbers)
        {
            if (targetSum == 0) return true;
            if (targetSum < 0) return false;

            for (var i = 0; i < numbers.Length; i++)
            {
                var remainder = targetSum - numbers[i];
                if (CanSum(remainder, numbers))
                {
                    return true;
                }
            }

            return false;
        }

        public List<int>? HowSum(int n, int[] numbers)
        {
            var result = new List<int>();

            if (n == 0)
                return new List<int>();
            if (n < 1)
                return null;

            for (var i = 0; i < numbers.Length; i++)
            {
                var sum = n - numbers[i];
                var res = HowSum(sum, numbers);

                if (res != null)
                {
                    result.AddRange(res!);
                    result.Add(numbers[i]);
                    return result;
                }
            }

            return null;
        }

        public List<int>? HowSum(int n, int[] numbers, Dictionary<int, List<int>?> memo)
        {
            var result = new List<int>();

            if (memo.ContainsKey(n))
                return memo[n];

            if (n == 0)
                return new List<int>();
            if (n < 1)
                return null;

            for (var i = 0; i < numbers.Length; i++)
            {
                var sum = n - numbers[i];
                var res = HowSum(sum, numbers, memo);

                if (res != null)
                {
                    result.AddRange(res!);
                    result.Add(numbers[i]);

                    memo.Add(n, result);

                    return result;
                }
            }

            memo.Add(n, null);

            return null;
        }

        public List<int>? BestSum(int n, int[] numbers)
        {
            if (n == 0) return new List<int>();
            if (n < 0) return new List<int>();

            var shortestCombination = new List<int>();

            for (var i = 0; i < numbers.Length; i++)
            {
                var sum = n - numbers[i];
                var res = BestSum(sum, numbers);

                if (res != null)
                {
                    var latestCombination = new List<int>();

                    latestCombination.AddRange(res!);
                    latestCombination.Add(numbers[i]);

                    if (shortestCombination.Count == 0
                        || latestCombination.Count < shortestCombination.Count)
                    {
                        shortestCombination = latestCombination;
                    }
                }
            }

            return shortestCombination;
        }

        public List<int>? BestSum(int n, int[] numbers, Dictionary<int, List<int>?> memo)
        {
            if (memo.ContainsKey(n))
                return memo[n];

            if (n == 0) return new List<int>();
            if (n < 0) return new List<int>();

            var shortestCombination = new List<int>();

            for (var i = 0; i < numbers.Length; i++)
            {
                var sum = n - numbers[i];
                var res = BestSum(sum, numbers, memo);

                if (res != null)
                {
                    var latestCombination = new List<int>();

                    latestCombination.AddRange(res!);
                    latestCombination.Add(numbers[i]);

                    if (shortestCombination.Count == 0
                        || latestCombination.Count < shortestCombination.Count)
                    {
                        shortestCombination = latestCombination;
                    }
                }
            }

            memo.Add(n, shortestCombination);

            return shortestCombination;
        }

        public bool CanConstruct(string word, string[] words)
        {
            if (string.IsNullOrEmpty(word))
                return true;

            foreach (var w in words)
            {
                if (word.IndexOf(w) == 0)
                {
                    var suffix = word.Substring(w.Length);
                    if (CanConstruct(suffix, words))
                        return true;
                }
            }

            return false;
        }

        public bool CanConstruct(string word, string[] words, Dictionary<string, bool> memo)
        {
            if (memo.ContainsKey(word))
                return memo[word];

            if (string.IsNullOrEmpty(word))
                return true;

            foreach (var w in words)
            {
                if (word.IndexOf(w) == 0)
                {
                    var suffix = word.Substring(w.Length);
                    if (CanConstruct(suffix, words, memo))
                    {
                        memo[word] = true;
                        return true;
                    }

                }
            }
            memo[word] = false;

            return false;
        }

        public int CountConstruct(string word, string[] words)
        {
            if (string.IsNullOrEmpty(word))
                return 1;

            var totalCount = 0;

            foreach (var w in words)
            {
                if (word.IndexOf(w) == 0)
                {
                    var count = CountConstruct(word.Substring(w.Length), words);
                    totalCount += count;
                }
            }

            return totalCount;
        }

        public int CountConstruct(string word, string[] words, Dictionary<string, int> memo)
        {
            if (memo.ContainsKey(word))
                return memo[word];

            if (string.IsNullOrEmpty(word))
                return 1;

            var totalCount = 0;

            foreach (var w in words)
            {
                if (word.IndexOf(w) == 0)
                {
                    var count = CountConstruct(word.Substring(w.Length), words, memo);
                    totalCount += count;
                }
            }

            memo[word] = totalCount;

            return totalCount;
        }

        public List<string>? AllConstruct(string word, string[] words)
        {
            throw new NotImplementedException();
        }

        public List<string>? AllConstruct(string word, string[] words, Dictionary<string, List<string>>? memo)
        {
            throw new NotImplementedException();
        }
    }
}