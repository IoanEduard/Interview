using System.Collections;
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

        public int FibTabulation(int n)
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

        public int ShortestPathTabulation(int m, int n)
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

        public List<List<string>>? AllConstruct(string word, string[] words)
        {
            var result = new List<List<string>>();

            if (word == "")
                return new List<List<string>>();

            foreach (var w in words)
            {
                if (word.IndexOf(w) == 0)
                {
                    var suffix = word.Substring(w.Length);
                    var suffixWays = AllConstruct(suffix, words);

                    if (suffixWays != null)
                    {
                        var list = new List<string>();
                        list.Add(w);

                        if (suffixWays.Count > 0)
                        {
                            list.AddRange(suffixWays[0]);
                        }
                        result.AddRange(new List<List<string>>() { list });
                    }
                }
            }

            if (result.Count == 0)
                return null;

            return result;
        }

        public List<List<string>>? AllConstruct(string word, string[] words, Dictionary<string, List<List<string>>>? memo)
        {
            if (memo!.ContainsKey(word))
                return memo[word];

            var result = new List<List<string>>();

            if (word == "")
                return new List<List<string>>();

            foreach (var w in words)
            {
                if (word.IndexOf(w) == 0)
                {
                    var suffix = word.Substring(w.Length);
                    var suffixWays = AllConstruct(suffix, words, memo);

                    if (suffixWays != null)
                    {
                        var list = new List<string>();
                        list.Add(w);

                        if (suffixWays.Count > 0)
                        {
                            list.AddRange(suffixWays[0]);
                        }
                        result.AddRange(new List<List<string>>() { list });
                    }
                }
            }

            if (result.Count == 0)
            {
                memo[word] = null!;
                return null;
            }

            memo[word] = result;

            return result;
        }

        public bool CanSumTabulation(int n, int[] numbers)
        {
            var table = new bool[n + 1];
            table[0] = true;

            for (var i = 0; i <= n; i++)
            {
                if (table[i])
                {
                    foreach (var num in numbers)
                    {
                        if (i + num <= n)
                            table[i + num] = true;
                    }
                }
            }

            return table[n];
        }

        public List<int>? HowSumTabulation(int n, int[] numbers)
        {
            if (n == 0) return null;

            var table = new ArrayList[n + 1];

            table[0] = new ArrayList();

            for (int i = 0; i < numbers.Length; i++)
            {
                var al = new ArrayList();
                int nums = numbers[i];
                al.Add(nums);
                table[nums] = al;
            }

            for (int i = 1; i <= n; i++)
            {
                if (table[i] == null)
                    continue;

                for (int j = 0; j < numbers.Length; j++)
                {
                    int num = numbers[j];
                    int ndx = i + num;

                    if (ndx > n)
                        continue;

                    if (table[ndx] == null)
                        table[ndx] = new ArrayList();

                    ArrayList src = table[i];
                    ArrayList dst = table[ndx];

                    dst.Clear();
                    dst.AddRange(src);
                    dst.Add(num);

                    if (ndx == n)
                    {
                        int[] ar = (int[])dst.ToArray(typeof(int));

                        return ar.ToList();
                    }
                }
            }

            if (table[n] == null) return null;

            var lst = table[n];

            int[] arr = (int[])lst.ToArray(typeof(int));

            return arr.ToList();
        }

        public ArrayList HowSumTab2(int target, int[] numbers)
        {
            ArrayList[] tab = new ArrayList[(int)target + 1];
            for (int i = 0; i < numbers.Length; i++)
            {
                var al = new ArrayList();
                int nums = numbers[i];
                al.Add(nums);
                tab[nums] = al;
            }

            tab[0] = new ArrayList();

            for (int i = 0; i <= target; i++)
            {
                if (tab[i] != null)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (i + numbers[j] <= target)
                        {
                            tab[i + (int)numbers[j]] = new ArrayList(tab[i]);
                            tab[i + (int)numbers[j]].Add(numbers[j]);
                        }
                    }
                }
            }

            return tab[(int)target];
        }

        public ArrayList BestSumTabulation(int n, int[] numbers)
        {
            ArrayList[] tab = new ArrayList[(int)n + 1];
            for (int i = 0; i < numbers.Length; i++)
            {
                var al = new ArrayList();
                int nums = numbers[i];
                al.Add(nums);
                tab[nums] = al;
            }

            for (int i = 0; i <= n; i++)
            {
                if (tab[i] != null)
                {
                    foreach (long number in numbers)
                    {
                        if (i + number <= n)
                        {
                            if (tab[i + (int)number] != null)
                            {
                                if (tab[i + (int)number].Count >= tab[i].Count + 1)
                                {
                                    tab[i + (int)number] = new ArrayList(tab[i]);
                                    tab[i + (int)number].Add(number);
                                }
                            }
                            else
                            {
                                tab[i + (int)number] = new ArrayList(tab[i]);
                                tab[i + (int)number].Add(number);
                            }
                        }
                    }
                }
            }

            return tab[(int)n];
        }

        public bool CanConstructTabulation0(string target, string[] words)
        {
            var table = new bool[target.Length + 1];
            table[0] = true;

            for (var i = 0; i < target.Length; i++)
            {
                if (table[i])
                {
                    for (var j = 0; j < words.Length; j++)
                    {
                        var word = words[j];

                        if (i + word.Length >= table.Length)
                            continue;

                        if (target.Substring(i, i + word.Length) == word)
                        {
                            table[i + word.Length] = true;
                        }
                    }

                    if (table[target.Length])
                        return true;
                }
            }

            return table[target.Length];
        }

        public bool CanConstructTabulation(string target, string[] wordBank)
        {
            var dict = new Dictionary<int, bool>();

            for (var i = 0; i < target.Length + 1; i++)
            {
                dict.Add(i, false);
            }

            dict[0] = true;

            for (int i = 0; i < target.Length; i++)
            {
                if (dict[i])
                {
                    foreach (var word in wordBank)
                    {
                        if (target.Substring(i).IndexOf(word) == 0)
                        {
                            dict[i + word.Length] = true;
                        }
                    }
                }
            }

            return dict[target.Length];
        }

        public int CountCounstructTabulation(string target, string[] wordBank)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < target.Length + 1; i++)
            {
                dict.Add(i, 0);
            }

            dict[0] = 1;

            for (int i = 0; i < target.Length; i++)
            {
                foreach (var word in wordBank)
                {
                    if (target.Substring(i).IndexOf(word) == 0)
                    {
                        dict[i + word.Length] += dict[i];
                    }
                }
            }


            return dict[target.Length];
        }

        public List<List<string>> AllCounstructTabulation(string target, string[] wordBank)
        {
            var dict = new Dictionary<int, List<List<string>>>();

            for (var i = 0; i < target.Length + 1; i++)
            {
                dict.Add(i, new List<List<string>>());
            }

            for (int i = 0; i < target.Length; i++)
            {
                foreach (var word in wordBank)
                {
                    if (target.Substring(i).IndexOf(word) == 0)
                    {
                        var suffixWays = dict[word.Length];
                        var newCombinations = new List<List<string>>();
                        var subArray = new List<string>();

                        subArray.Add(word);
                        newCombinations.Add(subArray);

                   
                            newCombinations.AddRange(suffixWays);
                        

                        dict[i + word.Length].AddRange(newCombinations);
                    }
                }
            }

            return dict[target.Length];
        }
    }
}