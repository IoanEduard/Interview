using System.Text;
using _14.N_ary___Trees.Concrete;
using _14.Trees.Concrete;

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
    }
}

public class HeapComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return y - x;
    }
}