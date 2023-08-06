using System.Collections;
using System.Numerics;
using System.Text;
using _14.N_ary___Trees.Concrete;
using _14.Trees.Concrete;
using _7.LinkedLists.Concrete;

namespace _LeetCode_Easy.Concrete
{
    public class _DailyWorkFile
    {
        public string RemoveDigit(string number, char digit)
        {
            var arrIndexes = new bool[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == digit)
                {

                }
            }

            return "";
        }

        //public static int[] ArrayRankTransform(int[] arr)
        //{
        //    var temp = arr;
        //    Array.Sort(temp);


        //}

        public int ClimbStairs(int n)
        {
            return ClimbStairsRecursive(n, new() { });
        }

        private int ClimbStairsRecursive(int n, Dictionary<int, int> memo)
        {
            if (memo.ContainsKey(n))
                return memo[n];

            if (n < 4)
                return n;

            memo[n] = ClimbStairsRecursive(n - 1, memo) + ClimbStairsRecursive(n - 2, memo);

            return memo[n];
        }

        public int ClimbStairsIterative(int n)
        {
            if (n == 1)
                return 1;

            var first = 1;
            var second = 2;
            var result = second;

            for (var i = 3; i <= n; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }

            return result;
        }

        // public int[] ProcessQueries(int[] queries, int m)
        // {
        //     for (var i = 0; i < queries.Length; i++)
        //     {

        //     }
        // }

        public int TriangularSum(int[] nums)
        {
            var numsLength = nums.Length;
            var triangleLength = nums.Length - 1;

            if (nums.Length == 1)
                return nums[0];

            while (numsLength > 1)
            {
                var temp = new int[triangleLength];
                for (var i = 0; i < triangleLength; i++)
                {
                    temp[i] = (nums[i] + nums[i + 1]) % 10;
                    nums[i] = temp[i];
                }

                triangleLength--;
                numsLength--;
            }

            return nums[0];
        }

        //https://leetcode.com/problems/reducing-dishes/
        // https://leetcode.com/problems/reducing-dishes/solutions/3354057/day-88-greedy-o-nlogn-time-and-o-1-space-easiest-beginner-friendly-sol/
        public int MaxSatisfaction(int[] satisfaction)
        {
            var result = 0;
            var presum = 0;
            Array.Sort(satisfaction);

            for (var i = satisfaction.Length - 1; i >= 0; i--)
            {
                presum += satisfaction[i];
                if (presum < 0) break;
                result += presum;
            }

            return result;
        }

        // https://leetcode.com/problems/binary-tree-maximum-path-sum/editorial/ Read this
        // https://leetcode.com/problems/binary-tree-maximum-path-sum/solutions/287185/c-dfs/ Another solution 
        public int MaxPathSum(TreeNode root)
        {
            if (root == null) return 0;

            var maxSum = int.MinValue;
            MaxPathSumSolve(root, ref maxSum);

            return maxSum;
        }

        private int MaxPathSumSolve(TreeNode root, ref int maxSum)
        {
            if (root == null) return 0;

            var leftSubtree = Math.Max(MaxPathSumSolve(root.left, ref maxSum), 0);
            var rightSubtree = Math.Max(MaxPathSumSolve(root.right, ref maxSum), 0);

            maxSum = Math.Max(maxSum, leftSubtree + rightSubtree + root.val);

            return Math.Max(leftSubtree + root.val, rightSubtree + root.val);
        }

        // https://leetcode.com/problems/group-the-people-given-the-group-size-they-belong-to/description/
        // strugle like shit
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            IList<IList<int>> result = new List<IList<int>>();
            var dict = new Dictionary<int, List<int>>();

            for (var i = 0; i < groupSizes.Length; i++)
            {
                var group = groupSizes[i];
                if (dict.ContainsKey(group))
                    dict[group].Add(i);
                else
                    dict[group] = new List<int>() { i };

                if (dict[group].Count == group)
                {
                    result.Add(dict[group]);
                    dict[group] = new List<int>();
                }
            }

            return result;
        }

        // https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/description/
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null)
                return null;

            return SortedArrayToBSTSolve(nums, 0, nums.Length - 1);
        }

        private TreeNode SortedArrayToBSTSolve(int[] nums, int left, int right)
        {

            if (left > right)
                return null;

            int mid = left + (right - left) / 2;

            TreeNode node = new TreeNode(nums[mid]);

            node.left = SortedArrayToBSTSolve(nums, left, mid - 1);
            node.right = SortedArrayToBSTSolve(nums, mid + 1, right);

            return node;
        }

        // https://leetcode.com/problems/optimal-partition-of-string/solutions/3376720/image-explanation-set-is-all-you-need-including-hints/
        // https://leetcode.com/problems/optimal-partition-of-string/editorial/
        public int PartitionString(string s)
        {
            var hash = new HashSet<char>();
            var count = 1;

            for (var i = 0; i < s.Length; i++)
            {
                if (hash.Contains(s[i]))
                {
                    count++;
                    hash.Clear();
                    hash.Add(s[i]);
                }
                else
                {
                    hash.Add(s[i]);
                }
            }

            return count;
        }

        public int PartitionStringEditorial(string s)
        {
            var lastSeen = new int[26];
            Array.Fill(lastSeen, -1);
            var count = 0;
            var substringStart = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (lastSeen[s[i] - 'a'] >= substringStart)
                {
                    count++;
                    substringStart = i;
                }

                lastSeen[s[i] - 'a'] = i;
            }

            return count;
        }

        // https://leetcode.com/problems/removing-stars-from-a-string/
        public string RemoveStars0(string s)
        {
            var result = new Stack<char>();

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    if (result.Count > 0)
                        result.Pop();
                }
                else result.Push(s[i]);

            }
            return string.Join("", result);
        }

        public string RemoveStars1(string s)
        {
            int stars = 0;
            var res = new StringBuilder();
            for (var i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '*')
                    stars++;
                else if (stars > 0)
                    stars--;
                else
                    res.Insert(0, s[i]);
            }

            return res.ToString();
        }

        public string SimplifyPath0_Bad(string path)
        {
            var stack = new Stack<char>();

            var j = 0;
            while (j < path.Length)
            {
                if (path[j] != '.' || path[j] != '_')
                {
                    stack.Push(path[j]);
                    break;
                }
                j++;
            }

            for (var i = j; i < path.Length; i++)
            {
                if (path[i] == '_')
                    continue;

                var sr = new StringBuilder();
                if (path[i] == '.')
                {
                    sr.Append(path[i]);
                    if (sr.ToString().Equals("../"))
                    {
                        stack.Pop();
                        stack.Pop();
                        sr.Clear();
                    }
                    continue;
                }

                var peek = stack.Peek();

                if (peek == '/' && path[i] == '/')
                    continue;

                stack.Push(path[i]);
            }

            var peekLast = stack.Peek();
            if (peekLast == '/' && stack.Count > 1)
                stack.Pop();

            return string.Join("", stack.Reverse());
        }

        public string SimplifyPath(string path)
        {
            var pathSplit = path.Split('/');
            var stack = new Stack<string>();

            for (var i = 0; i < pathSplit.Length; i++)
            {
                if (pathSplit[i] == "." || pathSplit[i] == string.Empty)
                    continue;

                if (pathSplit[i] == "..")
                {
                    if (stack.Count > 0)
                        stack.Pop();

                    continue;
                }

                stack.Push(pathSplit[i]);
            }

            return "/" + string.Join("/", stack.Reverse());
        }

        public int PivotIndex(int[] nums)
        {
            var right = nums.Sum();
            var left = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                right -= nums[i];
                left += nums[i];
                if (right == left) return i;
            }

            return -1;
        }

        public bool IsSubsequence_Fail(string s, string t)
        {
            if (t.Length < s.Length)
                return false;

            var sr = new StringBuilder();

            for (var i = 0; i < s.Length; i++)
            {
                for (var j = i; j < t.Length; j++)
                {
                    if (s[i] == t[j])
                    {
                        sr.Append(t[j]);
                        break;
                    }

                    if (j == t.Length - 1)
                        return false;
                }
            }

            return sr.ToString().Equals(s);
        }

        public bool IsSubsequence(string s, string t)
        {
            var i = 0;
            var j = 0;

            while (i < s.Length && j > t.Length)
            {
                if (s[i] == t[j])
                    i++;
                j++;
            }

            return i == s.Length;
        }

        // for reference and explanations: https://leetcode.com/problems/validate-stack-sequences/solutions/1853250/java-c-space-complexity-going-from-o-n-o-1/?q=two+pointer&orderBy=most_relevant
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            var stack = new Stack<int>();

            var pushedIndex = 0;
            var poppedIndex = 0;

            while (pushedIndex < pushed.Length)
            {
                stack.Push(pushed[pushedIndex]);

                while (stack.Count > 0 && stack.Peek() == popped[poppedIndex])
                {
                    stack.Pop();
                    poppedIndex++;
                }

                pushedIndex++;
            }

            return stack.Count == 0;
        }

        public int LongestPalindromeSubseqMemoization(string s)
        {
            var n = s.Length;
            var memo = new int[n][];

            for (var i = 0; i < memo.Length; i++)
            {
                memo[i] = new int[n];
            }

            return LSP(s, 0, n - 1, memo);
        }

        private int LSP(string s, int i, int j, int[][] memo)
        {
            if (memo[i][j] != 0)
                return memo[i][j];

            if (i > j)
                return 0;

            if (i == j)
                return 1;

            if (s[i] == s[j])
                memo[i][j] = LSP(s, i + 1, j - 1, memo) + 2;
            else
                memo[i][j] = Math.Max(LSP(s, i + 1, j, memo), LSP(s, i, j - 1, memo));

            return memo[i][j];
        }
        public int LongestPalindromeSubseq(string s)
        {
            var n = s.Length;

            var dp = new int[n][];

            for (var i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[n];
            }

            for (var i = n - 1; i > 0; i--)
            {
                dp[i][i] = 1;
                for (var j = i + 1; j < n - 1; j++)
                {
                    if (s[i] == s[j])
                    {
                        dp[i][j] = dp[i + 1][j - 1] + 2;
                    }
                    else
                    {
                        dp[i][j] = Math.Max(dp[i + 1][j], dp[i][j - 1]);
                    }
                }
            }

            return dp[0][n - 1];
        }

        // https://leetcode.com/problems/longest-palindromic-subsequence/editorial/
        // https://www.youtube.com/watch?v=jOkE4X-PWOI
        // chatgpt explanation is also good
        public int LongestPalindromeSubseqOptimized(string s)
        {
            var n = s.Length;
            var dp = new int[n];
            var dpPrev = new int[n];

            for (var i = n - 1; i > 0; i++)
            {
                dp[i] = 1;
                for (var j = i + 1; j < n; j++)
                {
                    if (s[i] == s[j])
                    {
                        dp[j] = dpPrev[j - 1] + 2;
                    }
                    else
                    {
                        dp[j] = Math.Max(dpPrev[j - 1], dp[j - 1]);
                    }
                }

                dpPrev = (int[])dp.Clone();
            }

            return dp[n - 1];
        }

        // https://dev.to/alisabaj/solving-the-best-time-to-buy-and-sell-stocks-problem-in-one-pass-42in
        public int MaxProfit(int[] prices)
        {
            var minimum = int.MaxValue;
            var maxProfit = 0;

            for (var i = 0; i < prices.Length; i++)
            {
                if (minimum < prices[i])
                    minimum = prices[i];

                var difference = maxProfit - prices[i];
                if (difference > maxProfit)
                {
                    maxProfit = difference;
                }
            }

            return maxProfit;
        }

        // https://leetcode.com/problems/longest-palindrome/editorial/?envType=study-plan&id=level-1
        public int LongestPalindrome(string s)
        {
            var dict = new Dictionary<char, int>();
            var sum = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                    dict[s[i]]++;
                else
                    dict.Add(s[i], 1);
            }

            foreach (var item in dict)
            {
                var count = item.Value;

                if (count % 2 == 0)
                {
                    sum += item.Value;
                    dict.Remove(item.Key);
                }

                else if (count != 0)
                {
                    sum += item.Value - 1;
                    dict[item.Key] = 1;
                }
            }

            return dict.Count > 0 ? sum += 1 : sum;
        }

        // https://leetcode.com/problems/number-of-ways-to-form-a-target-string-given-a-dictionary/editorial/
        // https://www.youtube.com/watch?v=Sa3tEYqLVjg
        /*
            The idea is to use dynamic programming to calculate the number of ways to form the target string using the frequency of each character 
                in each column of the matrix. 
            We can keep track of the frequency of each character in each column of the matrix and then use a dp array 
                to store the number of ways to form the prefix of target with the characters in the first i columns of the matrix. 
            At each step, we can use the frequency array to calculate the number of ways to add the next character of the target
                to the prefix using the ith column of the matrix.

            Calculate the frequency of each character in each column of the matrix using a 2D frequency array.
            Initialize a 2D dp array with dp[i][j] = number of ways to form the prefix of target with length j using the first i columns of the matrix.
            Initialize dp[0][0] = 1 to account for the empty prefix.
            Use a nested loop to iterate over the columns and characters of the matrix and target string respectively.
            Calculate the number of times the current character of the target appears in the current column of the matrix using the frequency array.
            Update the dp array at each step using the recurrence relation dp[i][j] = dp[i-1][j] + charCount * dp[i-1][j-1], where charCount is the number of times the current character appears in the current column.
            Return dp[n][target.length()], where n is the number of columns in the matrix.
        
        */


        // https://leetcode.com/problems/n-ary-tree-preorder-traversal/description/?envType=study-plan&id=level-1
        public IList<int> NrryTreePreorder(Node root)
        {
            var result = new List<int>();
            if (root == null)
                return result;

            return NrryTreePreorderSolve(root, result);
        }
        public IList<int> NrryTreePreorderSolve(Node root, List<int> list)
        {
            if (root == null)
                return list;

            list.Add(root.val);

            if (root.children != null)
                for (var i = 0; i < root.children.Count; i++)
                    NrryTreePreorderSolve(root.children[i], list);

            return list;
        }

        public IList<int> Postorder(Node root)
        {
            var result = new List<int>();
            if (root == null)
                return result;

            return NrryTreePostorderSolve(root, result);
        }
        public IList<int> NrryTreePostorderSolve(Node root, List<int> list)
        {
            if (root == null)
                return list;

            if (root.children != null)
                for (var i = 0; i < root.children.Count; i++)
                    NrryTreePostorderSolve(root.children[i], list);

            list.Add(root.val);

            return list;
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null)
                return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var queueSize = queue.Count;

                var level = new List<int>();
                while (queueSize-- > 0)
                {
                    var deq = queue.Dequeue();
                    level.Add(deq.val);

                    if (deq.left != null)
                        queue.Enqueue(deq.left);

                    if (deq.right != null)
                        queue.Enqueue(deq.right);
                }

                result.Add(level);

            }

            return result;
        }

        // https://leetcode.com/problems/linked-list-cycle-ii/?envType=study-plan&id=level-1
        // NOT DONE WITH THIS
        // public ListNode DetectCycle(ListNode head)
        // {
        //     var set = new HashSet<ListNode>();
        //     for (ListNode i = head; i != null && i.next != null; i = i.next)
        //     {
        //         if (!set.Contains(i))
        //             set.Add(i);
        //         else
        //             return i;
        //     }
        //     return null;
        // }

        // https://leetcode.com/problems/merge-two-sorted-lists/description/?envType=study-plan&id=level-1
        // NOT DONE WITH THIS ALSO
        // public ListNode MergeTwoLists(ListNode a, ListNode b)
        // {
        //     if (a == null) return b;
        //     if (b == null) return a;

        //     if (a.val < b.val)
        //     {
        //         a.next = MergeTwoLists(a.next, b);
        //         return a;
        //     }
        //     else
        //     {
        //         b.next = MergeTwoLists(a, b.next);
        //         return b;
        //     }
        // }

        // https://leetcode.com/problems/reverse-linked-list/?envType=study-plan&id=level-1
        // THIS ALSO NOT DONE
        public IList<IList<int>> LevelOrder(Node root)
        {
            var result = new List<IList<int>>();
            if (root == null)
                return result;

            NrryTreeLevelOrderSolve(root, result);

            return result;
        }

        public void NrryTreeLevelOrderSolve(Node root, List<IList<int>> list)
        {
            if (root == null)
                return;

            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var level = new List<int>();
                var queueSize = queue.Count;

                while (queueSize-- > 0)
                {
                    var deq = queue.Dequeue();
                    level.Add(deq.val);

                    for (var i = 0; i < deq.children.Count; i++)
                        if (deq.children[i] != null)
                            queue.Enqueue(deq.children[i]);
                }

                list.Add(level);
            }
        }

        public string MergeAlternately(string word1, string word2)
        {
            var sr = new StringBuilder();

            var word1Size = word1.Length - 1;
            var w1 = 0;

            var word2Size = word2.Length - 1;
            var w2 = 0;

            while (word1Size >= 0 || word2Size >= 0)
            {
                if (word1Size >= 0)
                    sr.Append(word1[w1]);

                if (word2Size >= 0)
                    sr.Append(word2[w2]);

                w1++;
                w2++;
                word1Size--;
                word2Size--;
            }

            return sr.ToString();
        }

        // public int LongestZigZag(TreeNode root)
        // {

        // }

        public int ClimbStairs2(int n)
        {
            return ClimbStairsSolve(n, new() { });
        }

        public int ClimbStairsSolve(int n, Dictionary<int, int> memo)
        {
            if (n == 1 || n == 0)
                return 1;

            if (memo.ContainsKey(n))
                return memo[n];

            return ClimbStairsSolve(n - 1, memo) + ClimbStairsSolve(n - 2, memo);
        }



        public string GetHint(string secret, string guess)
        {
            var cowsCount = 0;
            var bullsCount = 0;

            var hash = new List<char>();
            var bullsDictionary = new Dictionary<char, int>();

            for (var i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                {
                    bullsCount++;

                    if (!bullsDictionary.ContainsKey(secret[i]))
                        bullsDictionary.Add(secret[i], 1);
                    else bullsDictionary[secret[i]]++;

                    continue;
                }

                hash.Add(secret[i]);
            }

            for (var i = 0; i < guess.Length; i++)
            {
                if (hash.Contains(guess[i]))
                {
                    if (bullsDictionary.ContainsKey(guess[i]))
                    {
                        if (bullsDictionary[guess[i]] > 0)
                            bullsDictionary[guess[i]]--;
                        else
                        {
                            cowsCount++;
                            hash.Remove(guess[i]);
                        }
                    }
                    else
                    {
                        cowsCount++;
                        hash.Remove(guess[i]);
                    }
                }
            }

            return bullsCount + "A" + cowsCount + "B";
        }

        public string DecodeString_Fail(string s)
        {
            var stack = new Stack<string>();
            var openBracketCount = 0;

            var sr = new StringBuilder();
            var srNested = new StringBuilder();

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '[')
                {
                    openBracketCount++;
                    continue;
                }

                if (s[i] == ']')
                {
                    openBracketCount--;
                    continue;
                }

                while (openBracketCount > 0)
                {
                    if (s[i] == '[')
                    {
                        openBracketCount++;
                        i++;
                        continue;
                    }

                    if (char.IsNumber(s[i]))
                    {
                        srNested.Append(s[i]);
                        i++;
                        continue;
                    }

                    while (char.IsLetter(s[i]) || i > s.Length - 1)
                    {
                        srNested.Append(s[i]);
                        i++;
                    }

                    if (srNested.Length >= 2)
                    {
                        // var stackTemp = new Stack<string>();
                        // stackTemp.Push(sr.ToString());

                        stack.Push(srNested.ToString());
                        sr.Clear();
                    }

                    openBracketCount--;
                }

                if (char.IsNumber(s[i]))
                {
                    sr.Append(s[i]);
                    continue;
                }

                while (char.IsLetter(s[i]))
                {
                    sr.Append(s[i]);

                    if (i < s.Length - 1)
                        i++;
                    else break;
                }

                if (sr.Length >= 2)
                {
                    // var stackTemp = new Stack<string>();
                    // stackTemp.Push(sr.ToString());

                    stack.Push(sr.ToString());
                    sr.Clear();
                }
            }

            return string.Empty;
        }

        // public string DecodeString(string s)
        // {
        //     var sr = new StringBuilder();
        //     var countOpenBracket = 0;

        //     for (var i = 0; i < s.Length; i++)
        //     {
        //          if (s[i] == '[')
        //         {
        //             countOpenBracket++;
        //             continue;
        //         }

        //         if (s[i] == ']')
        //         {
        //             countOpenBracket--;
        //             continue;
        //         }

        //         while(countOpenBracket > 1)
        //         {

        //         }
        //     }
        // }
        public bool BackspaceCompare(string s, string t)
        {
            var stackForS = new Stack<char>();
            var stackForT = new Stack<char>();

            var sLength = s.Length - 1;
            var i = 0;

            var tLentgh = t.Length - 1;
            var j = 0;

            while (sLength >= 0 || tLentgh >= 0)
            {
                if (sLength >= 0)
                    StackWork(s[i], ref i, ref sLength, stackForS);

                if (tLentgh >= 0)
                    StackWork(t[j], ref j, ref tLentgh, stackForT);
            }

            return string.Join("", stackForS).Equals(string.Join("", stackForT));
        }

        private void StackWork(char s, ref int i, ref int sLength, Stack<char> stack)
        {
            if (s == '#')
            {
                if (stack.Count > 0)
                    stack.Pop();
            }
            else stack.Push(s);
            sLength--;
            i++;
        }

        public IList<string> TopKFrequent(string[] words, int k)
        {
            var sorted = new Dictionary<string, int>();

            for (var i = 0; i < words.Length; i++)
            {
                if (!sorted.ContainsKey(words[i]))
                    sorted.Add(words[i], 1);
                else sorted[words[i]]++;
            }

            var res = new string[k];

            var j = 0;
            foreach (var key in sorted.OrderByDescending(v => v.Value))
            {
                if (j >= k) break;

                res[j] = key.Key;
                j++;
            }

            return res;
        }

        public int LastStoneWeight(int[] stones)
        {
            if (stones.Length == 1)
                return stones[0];

            var priority = new PriorityQueue<int, int>(new HeapComparer());

            foreach (var stone in stones)
            {
                priority.Enqueue(stone, stone);
            }

            while (priority.Count > 1)
            {
                var pq1 = priority.Dequeue();
                var pq2 = priority.Dequeue();

                var result = pq1 - pq2;
                priority.Enqueue(result, result);
            }

            return priority.Dequeue();
        }

        public int BulbSwitch(int n)
        {
            return (int)Math.Sqrt(n);
        }
        public double Average(int[] salary)
        {
            var min = double.MaxValue;
            var max = double.MinValue;
            var sum = 0;

            for (var i = 0; i < salary.Length; i++)
            {
                if (min > salary[i])
                    min = salary[i];

                if (max < salary[i])
                    max = salary[i];

                sum += salary[i];
            }

            return sum - max - min;

        }

        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var hash1 = new HashSet<int>();
            var hash2 = new HashSet<int>();

            for (var i = 0; i < nums1.Length; i++)
            {
                hash1.Add(nums1[i]);
                hash2.Add(nums2[i]);
            }

            var list1 = new List<int>();
            var list2 = new List<int>();

            for (var i = 0; i < nums2.Length; i++)
            {
                if (!hash1.Contains(nums2[i]))
                {
                    list2.Add(nums2[i]);
                }

                if (!hash2.Contains(nums1[i]))
                {
                    list1.Add(nums1[i]);
                }
            }

            return new List<IList<int>>() { list1.ToArray(), list2.ToArray() };
        }

        public IList<IList<int>> FindDifference2(int[] A, int[] B) =>
            new[] {
                A.Except(B).ToArray(),
                B.Except(A).ToArray(),
            };

        public int NumSubseq(int[] nums, int target)
        {
            var mod = 1_000_000_007;
            var n = nums.Length;
            Array.Sort(nums);

            var powers = new int[n];
            powers[0] = 1;
            for (var i = 1; i < n; ++i)
            {
                powers[i] = (powers[i - 1] * 2) % mod;
            }

            long count = 0;

            for (var left = 0; left < n; left++)
            {
                var difference = target - nums[left];
                var right = BinarySearch(nums, difference) - 1;

                if (right >= left)
                {
                    count += powers[right - left];
                    count %= mod;
                }
            }

            return (int)count;
        }

        private int BinarySearch(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] <= target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return left;
        }

        public int NumSubseqTwoPointer(int[] nums, int target)
        {
            var mod = 1_000_000_007;
            var n = nums.Length;
            Array.Sort(nums);

            var powers = new int[n];
            powers[0] = 1;
            for (var i = 1; i < n; ++i)
            {
                powers[i] = (powers[i - 1] * 2) % mod;
            }

            int count = 0;
            var left = 0;
            var right = n - 1;

            while (left <= right)
            {
                if (nums[left] + nums[right] <= target)
                {
                    count += powers[right - left];
                    count %= mod;
                    left++;
                }
                else
                    right--;
            }

            return count;
        }

        public IList<string> SummaryRanges(int[] nums)
        {
            var result = new List<string>();

            for (var i = 0; i < nums.Length; i++)
            {
                var start = nums[i];

                while (i + 1 < nums.Length && nums[i] + 1 == nums[i + 1])
                    i++;

                if (start != nums[i])
                {
                    result.Add($"{start}->{nums[i]}");
                }
                else
                {
                    result.Add(start.ToString());
                }
            }

            return result;
        }

        public int EqualPairs0(int[][] grid)
        {
            var dictionary = new Dictionary<int, int>();
            var result = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                var rowLen = grid[0].Length;
                var j = 0;

                var entireRowValue = 0;

                while (rowLen > 0)
                {
                    entireRowValue = (entireRowValue + grid[i][j]) * 10;
                    rowLen--;
                    j++;
                }

                entireRowValue /= 10;
                if (dictionary.ContainsKey(entireRowValue))
                    dictionary[entireRowValue]++;
                else
                {
                    dictionary.Add(entireRowValue, 1);
                }
            }

            for (var i = 0; i < grid.Length; i++)
            {
                var entireColumnValue = 0;

                for (var j = 0; j < grid[i].Length; j++)
                {
                    entireColumnValue = (entireColumnValue + grid[j][i]) * 10;
                }
                entireColumnValue /= 10;

                if (dictionary.ContainsKey(entireColumnValue))
                {
                    if (dictionary[entireColumnValue] >= 0)
                        result += dictionary[entireColumnValue];

                    dictionary[entireColumnValue]--;
                }
            }

            return result;
        }
        public int EqualPairs(int[][] grid)
        {
            var dictionary = new Dictionary<int, int>();
            var result = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                var colNumber = 0;
                var rowNumber = 0;
                for (var j = 0; j < grid[i].Length; j++)
                {
                    colNumber = (colNumber + grid[j][i]) * 10;
                    rowNumber = (rowNumber + grid[i][j]) * 10;
                }

                colNumber /= 10;
                rowNumber /= 10;

                if (dictionary.ContainsKey(colNumber))
                {
                    result++;
                    dictionary[colNumber]++;
                }
                else dictionary.Add(colNumber, 1);

                if (dictionary.ContainsKey(rowNumber))
                {
                    result++;
                    dictionary[rowNumber]++;
                }
                else dictionary.Add(rowNumber, 1);
            }

            return result;
        }

        public int GetMinimumDifference(TreeNode root)
        {
            var list = BFS(root);

            list.Sort();
            var min = int.MaxValue;

            for (var i = 0; i < list.Count - 1; i++)
                min = Math.Min(min, Math.Abs(list[i] - list[i + 1]));

            return min;
        }

        private List<int> DFS(TreeNode node, List<int> list)
        {
            if (node == null) return list;

            list.Add(node.val);
            DFS(node.left, list);
            DFS(node.right, list);

            return list;
        }

        private List<int> DFS_Iterative(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var list = new List<int>();

            stack.Push(root);

            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();

                list.Add(currentNode.val);

                if (currentNode.left != null)
                    stack.Push(currentNode.left);

                if (currentNode.right != null)
                    stack.Push(currentNode.right);
            }

            return list;
        }

        private List<int> BFS(TreeNode root)
        {
            var list = new List<int>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();

                list.Add(currentNode.val);

                if (currentNode.left != null)
                    queue.Enqueue(currentNode.left);

                if (currentNode.right != null)
                    queue.Enqueue(currentNode.right);
            }

            return list;
        }
        TreeNode _result;
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            DFS_Recursive(cloned, target);
            return _result;
        }


        private void DFS_Recursive(TreeNode cloned, TreeNode target)
        {
            if (cloned == null)
                return;

            if (cloned.val == target.val)
            {
                _result = cloned;
                return;
            }

            DFS_Recursive(cloned.left, target);
            DFS_Recursive(cloned.right, target);
        }

        private void DFS_Iterative(TreeNode cloned, TreeNode target)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(cloned);

            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();

                if (currentNode.val == target.val)
                {
                    _result = currentNode;
                    return;
                }

                if (currentNode.left != null)
                    stack.Push(currentNode.left);

                if (currentNode.right != null)
                    stack.Push(currentNode.right);
            }
        }

        private void BFS(TreeNode cloned, TreeNode target)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(cloned);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();

                if (currentNode.val == target.val)
                {
                    _result = currentNode;
                    return;
                }

                if (currentNode.left != null)
                    queue.Enqueue(currentNode.left);

                if (currentNode.right != null)
                    queue.Enqueue(currentNode.right);
            }
        }

        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null)
                return root2;

            if (root2 == null)
                return root1;

            root1.val += root2.val;

            root1.left = MergeTrees(root1.left, root2.left);
            root1.right = MergeTrees(root1.right, root2.right);

            return root1;
        }

        public int MaxLevelSum(TreeNode root)
        {
            var quueue = new Queue<TreeNode>();
            quueue.Enqueue(root);

            var level = 0;
            var result = 0;
            var maxSum = int.MinValue;

            while (quueue.Count > 0)
            {
                level++;
                var currentSum = 0;
                var queueCurrentLevel = quueue.Count;

                while (queueCurrentLevel > 0)
                {
                    var currentNode = quueue.Dequeue();
                    currentSum += currentNode.val;

                    if (currentNode.left != null)
                        quueue.Enqueue(currentNode.left);

                    if (currentNode.right != null)
                        quueue.Enqueue(currentNode.right);

                    queueCurrentLevel--;
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    result = level;
                }
            }
            return level;
        }

        // public TreeNode IncreasingBST(TreeNode root)
        // {

        // }

        // private void DFS_IncreasingBST(TreeNode root, List<int> list)
        // {
        //     if (root == null)
        //         return;

        //     list.Add()
        // }

        public string MergeAlternately2(string word1, string word2)
        {
            var word1Length = word1.Length;
            var word1LeftPointer = 0;

            var word2Length = word2.Length;
            var word2LeftPointer = 0;

            var result = new StringBuilder();

            while (word1Length > word1LeftPointer || word2Length > word2LeftPointer)
            {
                if (word1Length > word1LeftPointer)
                {
                    result.Append(word1[word1LeftPointer]);
                    word1LeftPointer++;
                }

                if (word2Length > word2LeftPointer)
                {
                    result.Append(word2[word2LeftPointer]);
                    word2LeftPointer++;
                }
            }

            return result.ToString();
        }

        public char FindTheDifference(string s, string t)
        {
            var count = 0;

            // T because T has s.Length + 1, T contains the extra character
            // Simply sum the ASCII Characters then remove them as we find them in the other string
            foreach (var character in t) count += character;
            foreach (var character in s) count -= character;

            return (char)count;
        }

        public char FindTheDifference0(string s, string t)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (var character in t)
                if (dictionary.ContainsKey(character))
                    dictionary[character]++;
                else
                    dictionary.Add(character, 1);

            foreach (var character in s)
            {
                if (dictionary.ContainsKey(character))
                    if (dictionary[character] > 0)
                        dictionary[character]--;
                    else
                        dictionary.Remove(character);
            }

            return dictionary.Keys.FirstOrDefault();
        }

        // naive approach
        public int StrStr(string haystack, string needle) => haystack.IndexOf(needle);


        // KMP approach
        // https://www.youtube.com/watch?v=JoF0Z7nVSrA 
        // O(m+n)
        // is a hard algorithm
        /*
            Approaches: 
                A B C D E F G
                X Y Z

            1.  O(n*m) 
                we check the size of needle in the haystack
                A B C
                X Y Z

                B C D
                X Y Z
     
                n the size of haystack
                m the size of needle

            2. O(n)
                We check first character in needle with a character in the haystack
                A 
                X

                B 
                X

                C 
                X

                etc
                if it matches then we check next
                
                n is the size of haystack, as we checked each character of the haystack

            3. KMP (Knuth Morris Pratt)
                AAAXAAAX
                AAAA

                AAAX
                AAAA

                AAXA
                AAAA

                O(n*m)
                KMP improves this to O(n+m)
                We do some pre-processing, first 3 characters match except the 4th one
                We move the pointer where it didn't match, as the rest is the prefix of the needle, we can avoid doing the repeated work
                First part of the KMP is LPS (Longest Prefix Suffix)

                We create an array LPS that will be the size of the neddle
                Basically an array of all prefixes of the needle

                For each substring we want to know:
                    the length of the longest prefix of the needle that is also a suffix and cannot be the entire string itself

                needle = AAAA
                LSP = [0, 1, 2, 3]
        */
        public int StrStrKMP(string haystack, string needle)
        {
            if (needle == string.Empty) return 0;
            var lps = LPS(haystack, needle);

            var i = 0;
            var j = 0;

            while (i < haystack.Length)
            {
                if (haystack[i] == needle[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    if (j == 0)
                        i += 1;
                    else
                        j = lps[j - 1];
                }

                if (j == needle.Length)
                    return i - needle.Length;
            }

            return -1;
        }

        private int[] LPS(string haystack, string needle)
        {
            var lps = new int[needle.Length];
            var prevLps = 0;
            var i = 1;

            // LSP Table
            while (i < needle.Length)
            {
                if (needle[i] == needle[prevLps])
                {
                    lps[i] = prevLps + 1;
                    prevLps++;
                    i++;
                }
                else if (prevLps == 0)
                {
                    lps[i] = 0;
                    i++;
                }
                else
                    prevLps = lps[prevLps - 1];
            }

            return lps;
        }

        public bool IsAnagram(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;

            var word1Array = new int[26];
            var word2Array = new int[26];

            for (var i = 0; i < word1.Length; i++)
            {
                word1Array[word1[i] - 'a']++;
                word2Array[word2[i] - 'a']++;
            }

            for (var i = 0; i < 26; i++)
                if (word1[i] != word2[i]) return false;

            return true;
        }

        // revisit
        // public bool RepeatedSubstringPattern(string s)
        // {

        // }

        // is tricky https://leetcode.com/problems/move-zeroes/description/?envType=study-plan-v2&envId=programming-skills
        public int[] MoveZeroes(int[] nums)
        {
            var i = 0;
            var k = 0;

            while (i < nums.Length)
            {
                if (nums[i] != 0)
                {
                    var temp = nums[i];
                    nums[i] = nums[k];
                    nums[k] = temp;
                    k++;
                }
                i++;
            }

            return nums;
        }

        public int[] PlusOne(int[] digits)
        {
            var n = digits.Length - 1;

            for (var i = n; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i]++;
                    return digits;
                }

            }

            var firstDigit = new int[] { 1 };

            return firstDigit.Concat(digits).ToArray();
        }
        // solve again
        public int ArraySign(int[] nums)
        {
            var count = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    return 0;

                if (nums[i] < 0)
                    count++;
            }

            return count % 2 == 0 ? 1 : -1;
        }

        public bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            int diff = arr[1] - arr[0];

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] != diff)
                {
                    return false;
                }
            }

            return true;
        }

        public int ArraySign2(int[] nums)
        {
            var sign = 1;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) return 0;
                if (nums[i] < 0) sign = -1 * sign;
            }

            return sign;
        }


        // WORKABLE BUT GARBAGE
        public int RomanToInt(string s)
        {
            var symbols = new char[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            var number = 0;
            var len = s.Length;

            for (var i = 0; i < len; i++)
            {
                if (s[i] == 'I' && i + 1 < len)
                {
                    if (i + 1 < len && s[i + 1] == 'V')
                    {
                        number += 4;
                        continue;
                    }
                    if (i + 1 < len && s[i + 1] == 'X')
                    {
                        number += 9;
                        continue;
                    }
                    number++;
                    continue;
                }

                if (s[i] == 'V') number += 5;
                if (s[i] == 'X') number += 10;
                if (s[i] == 'L') number += 50;
                if (s[i] == 'C') number += 100;
                if (s[i] == 'D') number += 500;
                if (s[i] == 'M') number += 1000;
            }

            return number;
        }

        public int RomanToInt2(string s)
        {
            var number = 0;
            var romanSymbols = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

            for (var i = 0; i < s.Length - 1; i++)
                if (romanSymbols[s[i]] < romanSymbols[s[i + 1]])
                    number -= romanSymbols[s[i]];
                else
                    number += romanSymbols[s[i]];

            return number + romanSymbols[s[s.Length - 1]];
        }

        public int RomanToInt3(string s)
        {
            var result = 0;
            var romanSymbols = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

            for (var i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == 'I' && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                {
                    result -= 1;
                    continue;
                }
                if (s[i] == 'X' && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                {
                    result -= 10;
                    continue;
                }
                if (s[i] == 'C' && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                {
                    result -= 100;
                    continue;
                }
                result += romanSymbols[s[i]];
            }

            return result + romanSymbols[s[s.Length - 1]];
        }

        public bool IsMonotonic(int[] nums)
        {
            var index = 0;
            var isDecreasing = false;
            var n = nums.Length;

            for (var i = 0; i < n; i++)
            {
                if (nums[i] == nums[i + 1]) continue;
                else
                {
                    index = i;
                    if (nums[i] >= nums[i + 1])
                        isDecreasing = true;
                    break;
                }
            }

            if (index == n) return true;

            if (isDecreasing)
            {
                for (var i = index; i < n - 1; i++)
                {
                    if (nums[i] < nums[i + 1]) return false;
                }
            }
            else
            {
                for (var i = 1; i < n - 1; i++)
                {
                    if (nums[i] > nums[i + 1]) return false;
                }
            }

            return true;
        }

        //     public boolean isMonotonic(int[] A) {
        // boolean increasing = true;
        // boolean decreasing = true;
        // for (int i = 0; i < A.length - 1; ++i) {
        //     if (A[i] > A[i+1])
        //         increasing = false;
        //     if (A[i] < A[i+1])
        //         decreasing = false;+
        // }

        // return increasing || decreasing;

        public string Tictactoe(int[][] moves)
        {
            var table = new char[3][];

            for (var i = 0; i < table.Length; i++)
                table[i] = new char[3];

            for (var i = 0; i < moves.Length; i++)
            {
                var move = moves[i];
                var x = move[0];
                var y = move[1];

                if (i % 2 == 0)
                    table[x][y] = 'X';
                else
                    table[x][y] = 'O';
            }
            if (Check('X', table)) return "A";
            if (Check('O', table)) return "B";
            if (moves.Length == 9) return "Draw";

            return "Pending";
        }

        private bool Check(char c, char[][] table)
        {
            for (var i = 0; i < 3; i++)
            {
                if (table[i][0] == c && table[i][1] == c && table[i][2] == c) return true;
                if (table[0][i] == c && table[1][i] == c && table[2][i] == c) return true;
            }

            if (table[0][0] == c && table[1][1] == c && table[2][2] == c) return true;
            if (table[0][2] == c && table[1][1] == c && table[2][0] == c) return true;

            return false;
        }

        public int CountOdds(int low, int high)
        {
            var count = 0;

            for (var i = low; low <= high; i++)
                if (i % 2 != 0) count++;

            return count;
        }

        public int MaximumWealth(int[][] accounts)
        {
            var maxWealth = 0;
            for (var i = 0; i < accounts.Length; i++)
            {
                var currentWealth = 0;
                for (var j = 0; j < accounts[i].Length; j++)
                {
                    currentWealth += accounts[i][j];
                }

                maxWealth = Math.Max(currentWealth, maxWealth);
            }

            return maxWealth;
        }

        public int DiagonalSum(int[][] mat)
        {
            var sum = 0;

            for (var i = 0; i < mat.Length; i++)
            {
                for (var j = 0; j < mat[i].Length; j++)
                {
                    sum += mat[i][i];
                    sum += mat[mat.Length - i - 1][i];
                }
            }

            if (mat[0].Length % 2 != 0)
                sum -= mat[mat.Length / 2][mat.Length / 2];

            return sum;
        }

        public double Average2(int[] salary)
        {
            var max = int.MinValue;
            var min = int.MaxValue;
            double sum = 0;

            for (var i = 0; i < salary.Length; i++)
            {
                if (salary[i] > max) max = salary[i];
                if (salary[i] < min) min = salary[i];
                sum += salary[i];
            }

            return (sum - max - min) / (salary.Length - 2);
        }

        public string AddBinary(string a, string b)
        {
            var result = new StringBuilder();

            var (newA, newB) = ProcessedBinary(a, b);

            var carry = 0;
            for (var i = newA.Length - 1; i >= 0; i--)
            {
                if (newA[i] == '1' && newB[i] == '1')
                {
                    if (carry == 1)
                        result.Insert(0, 1);
                    else
                    {
                        result.Insert(0, 0);
                    }
                    carry = 1;
                }
                else if (newA[i] == '0' && newB[i] == '0')
                {
                    result.Insert(0, carry);
                    carry = 0;
                }
                else
                {
                    if (carry == 1)
                    {
                        result.Insert(0, 0);
                        carry = 1;
                    }
                    else
                    {
                        result.Insert(0, 1);
                        carry = 0;
                    }
                }
            }

            if (carry == 1) result.Insert(0, 1);

            return result.ToString();
        }

        private (string, string) ProcessedBinary(string a, string b)
        {
            var lenA = a.Length;
            var lenB = b.Length;

            if (lenA > lenB)
            {
                return (a, FixLengthDifference(lenA - lenB, new StringBuilder(b)));
            }

            else if (lenA < lenB)
            {
                return (FixLengthDifference(lenB - lenA, new StringBuilder(a)), b);
            }

            return (a, b);
        }

        private string FixLengthDifference(int difference, StringBuilder stringValue)
        {
            for (var i = 0; i < difference; i++)
                stringValue.Insert(0, "0");

            return stringValue.ToString();
        }

        //fail
        public bool CheckStraightLine(int[][] coordinates)
        {
            var deltaY = Delta(coordinates[1][1], coordinates[0][1]);
            var deltaX = Delta(coordinates[1][0], coordinates[0][0]);

            for (var i = 2; i < coordinates.Length; i++)
            {
                var slopeY = deltaX * Delta(coordinates[i][1], coordinates[i - 1][1]);
                var slopeX = deltaY * Delta(coordinates[i][0], coordinates[i - 1][0]);

                if (slopeY != slopeX) return false;
            }

            return true;
        }

        private int Delta(int coordinate1, int coordinate2) => Math.Abs(coordinate1 - coordinate2);

        // alternative https://leetcode.com/problems/check-if-it-is-a-straight-line/solutions/725124/simple-area-of-a-triangle-solution/
        public bool CheckStraightLine2(int[][] coordinates)
        {
            var dy = coordinates[1][1] - coordinates[0][1];
            var dx = coordinates[1][0] - coordinates[0][0];

            for (var i = 2; i < coordinates.Length; i++)
            {
                if (dx * (coordinates[i][0] - coordinates[1][0]) != dy * (coordinates[i][1] - coordinates[1][1]))
                    return false;
            }

            return true;
        }

        public int LargestPerimeter(int[] nums)
        {
            // a+b>c
            Array.Sort(nums);
            var max = 0;
            for (var i = nums.Length - 3; i >= 0; i--)
            {
                if (nums[i] + nums[i + 1] < nums[i + 2])
                    max = Math.Max(nums[i] + nums[i + 1] + nums[i + 2], max);
            }

            return max;
        }

        public bool LemonadeChange(int[] bills)
        {
            var dictionary = new Dictionary<int, int>();
            dictionary.Add(5, 0);
            dictionary.Add(10, 0);
            dictionary.Add(20, 0);

            for (var i = 0; i < bills.Length; i++)
            {
                if (bills[i] == 5)
                {
                    dictionary[5]++;
                    continue;
                }

                if (bills[i] == 10)
                {
                    if (dictionary[5] > 0)
                    {
                        dictionary[5]--;
                        dictionary[10]++;
                        continue;
                    }
                    else return false;
                }

                if (bills[i] == 20)
                {
                    if (dictionary[5] > 0)
                    {
                        if (dictionary[10] > 0)
                        {
                            dictionary[10]--;
                            dictionary[5]--;
                            continue;
                        }
                        else if (dictionary[5] > 3)
                        {
                            dictionary[5] -= 3;
                        }
                        else return false;
                    }
                    else return false;
                }

            }
            return true;
        }

        // https://leetcode.com/problems/powx-n/editorial/
        public double MyPow(double x, int n) => Pow(x, (long)n);

        private double Pow(double x, long n)
        {
            if (n == 0) return 1;
            if (n < 0)
                return 1.0 / Pow(x, -1 * n);

            if (n % 2 == 1)
                return x * Pow(x * x, (n - 1) / 2);
            else
                return Pow(x * x, n / 2);
        }

        // Draw on paper each iteration
        // basically we change the pointer direction with head.next = prev and prev = head while moving forward with head = next
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode next = null;

            while (head != null)
            {
                next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }

            return prev;
        }

        // https://leetcode.com/problems/add-two-numbers/description/?envType=study-plan-v2&envId=programming-skills
        // Editorial is great, we consider head as the least signifiant digit in a number, the numbers are already reversed 
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var listNode = new ListNode(0);
            var result = listNode;

            var remainder = 0;

            while (l1 != null || l2 != null || remainder > 0)
            {
                var sum = 0;

                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                sum += remainder;
                remainder = sum / 10;

                listNode.next = new ListNode(sum % 10);
                listNode = listNode.next;
            }

            return result.next;
        }

        public ListNode MergeTwoLists(ListNode a, ListNode b)
        {
            var node = new ListNode();
            var result = node;

            while (a != null && b != null)
            {
                if (a.val < b.val)
                {
                    // we move the whole node
                    node.next = a;
                    a = a.next;
                }
                else
                {
                    node.next = b;
                    b = b.next;
                }

                node = node.next;
            }

            // if (a == null) node.next = b;
            // else node.next = a;

            node.next = a ?? b;

            return result.next;
        }

        public ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            ListNode l1Reversed = Reverse(l1);
            ListNode l2Reversed = Reverse(l2);

            ListNode head = new ListNode(0);
            ListNode result = head;

            var remainder = 0;

            while (l1Reversed != null || l2Reversed != null || remainder > 0)
            {
                var sum = 0;

                if (l1Reversed != null)
                {
                    sum += l1Reversed.val;
                    l1Reversed = l1Reversed.next;
                }

                if (l2Reversed != null)
                {
                    sum += l2Reversed.val;
                    l2Reversed = l2Reversed.next;
                }

                sum += remainder;

                head.next = new ListNode(sum % 10);
                head = head.next;

                remainder = sum / 10;
            }

            return Reverse(result.next);
        }

        private ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            ListNode next = null;

            while (head != null)
            {
                next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }

            return prev;
        }

        // https://leetcode.com/problems/multiply-strings/solutions/17605/easiest-java-solution-with-graph-explanation/ yeagh
        public string Multiply(string num1, string num2)
        {
            if (num1[0] == '0' || num2[0] == '0') return 0.ToString();

            var remainder = 0;
            var list = new List<string>();
            var k = 0;

            var num1Pointer = num1.Length - 1;
            var num2Pointer = num2.Length - 1;

            while (num2Pointer >= 0)
            {
                var current = new StringBuilder();
                var temp = 0;

                var innerPointer = num1Pointer;
                while (innerPointer >= 0)
                {
                    temp = (num2[num2Pointer] - '0') * (num1[innerPointer] - '0');
                    temp += remainder;
                    current.Insert(0, temp % 10);
                    remainder = temp / 10;

                    innerPointer--;
                }

                if (remainder > 0) current.Insert(0, remainder);
                for (var i = 0; i < k; i++) current.Append('0');
                list.Add(current.ToString());

                remainder = 0;
                num2Pointer--;
                k++;
            }

            for (var i = 0; i < list.Count - 1; i++)
            {
                var x = list[i];
                var y = list[i + 1];

                var xPointer = x.Length - 1;
                var yPointer = y.Length - 1;

                var temp = 0;
                var current = new StringBuilder();
                remainder = 0;

                while (xPointer >= 0 || yPointer >= 0)
                {
                    if (xPointer >= 0 && yPointer >= 0)
                    {
                        temp = (x[xPointer] - '0') + (y[yPointer] - '0');
                        temp += remainder;
                        current.Insert(0, temp % 10);
                        remainder = temp / 10;

                        xPointer--;
                        yPointer--;
                        continue;
                    }

                    if (xPointer < 0 && yPointer >= 0)
                    {
                        temp = y[yPointer] - '0' + remainder;
                        current.Insert(0, temp % 10);

                        remainder = temp / 10;
                        yPointer--;
                        continue;
                    }

                    if (xPointer >= 0 && yPointer < 0)
                    {
                        temp = x[xPointer] - '0' + remainder;
                        current.Insert(0, temp % 10);

                        remainder = temp / 10;
                        xPointer--;
                    }
                }

                if (remainder > 0) current.Insert(0, remainder);
                list[i + 1] = current.ToString();
            }

            return list[list.Count - 1];
        }

        // https://leetcode.com/problems/single-number-ii/solutions/43295/detailed-explanation-and-generalization-of-the-bitwise-operation-method-for-single-numbers/
        public int SingleNumber(int[] nums)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i])) dict[nums[i]]++;
                else dict.Add(nums[i], 1);
            }

            foreach (var item in dict)
            {
                if (item.Value == 1) return item.Key;
            }

            return -1;

        }

        // https://leetcode.com/problems/robot-bounded-in-circle/solutions/1676710/well-detailed-explaination-java-c-easy-for-mind-to-accept-it/
        public bool IsRobotBounded(string instructions)
        {
            // var directions = new string[] {"N", "W", "S", "E"};
            var currentPosition = 'N';
            var posX = 0;
            var posY = 0;

            for (var i = 0; i < instructions.Length; i++)
            {
                if (instructions[i] == 'G')
                {
                    if (currentPosition == 'N') posY++;
                    if (currentPosition == 'S') posY--;
                    if (currentPosition == 'W') posX++;
                    if (currentPosition == 'E') posX--;
                }
                else if (instructions[i] == 'L')
                {
                    if (currentPosition == 'N') currentPosition = 'W';
                    else if (currentPosition == 'W') currentPosition = 'S';
                    else if (currentPosition == 'S') currentPosition = 'E';
                    else currentPosition = 'N';
                }
                else if (instructions[i] == 'R')
                {
                    if (currentPosition == 'N') currentPosition = 'E';
                    else if (currentPosition == 'E') currentPosition = 'S';
                    else if (currentPosition == 'S') currentPosition = 'W';
                    else currentPosition = 'N';
                }

            }

            if (posX == 0 && posY == 0) return true;
            if (currentPosition == 'N') return false;

            return true;
        }


        // https://leetcode.com/problems/spiral-matrix/solutions/978853/c-0ms-faster-than-100-easy-solution-with-proper-explanation/
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var top = 0;
            var left = 0;
            var bottom = matrix[0].Length - 1;
            var right = matrix.Length - 1;

            var direction = 1;
            var result = new List<int>();

            while (left <= right && top <= bottom)
            {
                switch (direction)
                {
                    case 1:
                        for (var i = left; i <= right; i++)
                            result.Add(matrix[top][i]);

                        direction = 2;
                        top++;
                        break;
                    case 2:
                        for (var i = top; i <= bottom; i++)
                            result.Add(matrix[i][right]);

                        direction = 3;
                        right--;
                        break;
                    case 3:
                        for (var i = right; i >= left; i--)
                            result.Add(matrix[bottom][i]);

                        direction = 4;
                        bottom--;
                        break;
                    case 4:
                        for (var i = bottom; i >= top; i--)
                            result.Add(matrix[i][left]);

                        direction = 1;
                        left++;
                        break;
                }
            }

            return result;
        }

        public void SetZeroes(int[][] matrix)
        {
            var zeroes = new List<(int, int)>();

            for (var i = 0; i < matrix.Length; i++)
                for (var j = 0; j < matrix[0].Length; j++)
                    if (matrix[i][j] == 0) zeroes.Add((i, j));

            foreach (var zero in zeroes)
            {
                for (var i = 0; i < matrix.Length; i++)
                    matrix[i][zero.Item2] = 0;

                for (var i = 0; i < matrix[0].Length; i++)
                    matrix[zero.Item1][i] = 0;
            }
        }
    }

    public class HeapComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }
}