namespace DynamicProgramming.Interfaces
{
    public interface IFreecodeCampDP
    {
        /// <summary>
        /// Description
        /// <para>Lacks efficiency</para>
        /// n = 7
        ///                                     7
        ///                               /           \
        ///                        (n-1) 6             5 (n-2)
        ///                             /  \            / \
        ///                            5    4          4   3
        ///                        /         \          ... Fib base case: 0, 1, 2        
        ///                       4           3
        ///                   /     \        / \
        ///                  3       2      2   1
        ///                /   \    / \    / \   \
        ///               2     1  1   0  1   0   0
        ///              / \     \         
        ///             1   0     0
        /// 
        /// The point of this structure like is that we repeating a lot of work, most obvious are the base cases, but parent subtrees are also repeating.
        /// Base cases will return to the caller and add up values 
        /// Time complexity 2^n 
        /// e.g 
        /// const foo = (n) => {
        ///     if(n <= 1) return;
        ///     foo(n-1);        
        /// }
        /// 
        /// This O(n) time
        /// Space complexity is the call stack is also O(n)
        /// 
        /// const bar ...
        ///     bar(n-2);
        ///  
        /// 0 2 4 6 
        /// This is O(n) time complexity
        /// O(n) space complexity
        /// 
        /// Both are O(n) time and space complexity 
        /// 
        /// const dib = (n) => {
        ///     if(n<=1) return;
        ///     dib(n-1);
        ///     dib(n-1);        
        /// }
        ///                                           5
        ///                                         /   \
        ///                                       4      ... 
        ///                                     /           identical   
        ///                                   3             
        ///                                /    \           
        ///                               2      2           
        ///                              / \    / \
        ///                             1   1  1   1
        ///                            / \ /\ / \ / \
        ///                           0  00  00  00  0 
        /// Left path: 5 4 3 2 1 0
        /// Height: n 
        /// Levels: n  
        /// Level nodes grow exponentials: 
        ///     O(2^n) time complexity  
        ///     O(n) space complexity, Is the height of the tree because we pop when we get back in the tree
        /// 
        /// 
        /// const dib = (n) => {
        ///     if(n<=1) return;
        ///     dib(n-2);
        ///     dib(n-2);        
        /// }
        /// 
        /// Both have an exponential time complexity and liniar space complexity
        /// 
        /// fib(50) would be taking 2^50 = 1.12e+15, 16 digit number
        /// In tree example above we can see repeating subtrees
        /// DP is when we have a larger problem, in this case fib(n) and we can decompose it into smaller instances of the same problem, also we have a repeating structure for this problem
        /// 
        /// For fib problem we can use memoization
        /// We do not repeat the entire tree structure, we memoize each result so the time complexity becomes 2n and can be represented as O(n) and O(n) space
        /// 
        /// /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        int FibRecursive(int n);

        /// <summary>
        /// You are a traveler on a 2D grid. You begin in the top-left corner
        /// and your goal is to travel to the bottom-right corner. You may only move down or right
        /// 
        /// In how many ways can you travel to the goal on a grid with dimensions m*n
        /// 
        /// GridTraveler(2, 3) -> 3
        /// 2 rows
        /// 3 columns
        /// a) right right down 
        /// b) right down right
        /// c) down right right
        /// GridTraveler(1, 1) -> 1 is a base cases
        /// GridTraveler(0, 1) -> 0 also a base case, One of the dimension is empty or both there is no grid
        /// 
        /// GridTraveler(3,3) becomes GridTraveler(2,3), becomes GridTraveler(2,2), GridTraveler(1,2), GridTraveler(1,1)
        /// Grid becomes smaller till you get the base case 1,1
        /// 
        ///                                                     2,3
        ///                                          / Down           Right \
        ///                                        1,3                      2,2 
        ///                                       /   \                   /    \
        ///                        base case -> 0,3   1,2               1,2    2,1
        ///                                          /   \              /  \    ...
        ///                                        0,1   1,1          0,1  1,1
        /// 
        /// Similar to fibonaci 1,1 base case, 0,x basecase
        /// Time complexity is O(2 ^ n+m) and O(n+m) space
        /// Exponential time
        /// We notice we have duplicate subtrees. e.g: 1,2 subtree, we can memoize
        /// /// </summary>
        /// <returns></returns>
        int ShortestPathInefficient(int m, int n);

        /// <summary>
        /// <para>We reduced the time complexity to m+n rather than 2^n+n</para>
        /// <para>Take away: Try to think about your recursive call in terms of a tree, from there we implement a brute force solution then we can optimize</para>
        /// <para>Memoization Recipe:</para>
        /// <para>1. Have a recursive solution that works</para>
        /// <para>    - visualize the problem as a tree, if we have a bigger problem, break it into smaller problems. As we go through the tree subproblems, the problem will shrink</para>
        /// <para>    - implement that tree using recursion (brute force)</para>
        /// <para>    - test it</para>
        /// <para>1. Make it efficient</para>
        /// <para>Take steps separetely to just work at first.</para>
        /// <para>    - add a memo object</para>
        /// <para>    - add a new base case to return memo values</para>
        /// <para>    - store return values into the memo before returning</para>
        /// 
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        int ShortestPathMemoization(int m, int n);
        int ShortestPathIterativeLeetCode1(int m, int n);
        /// <summary>
        /// SOURCE:
        /// <para>General explanations and versions of this problem</para>
        /// <para>https://leetcode.com/problems/unique-paths/solutions/1581998/c-python-5-simple-solutions-w-explanation-optimization-from-brute-force-to-dp-to-math/</para>
        /// 
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        int ShortestPathIterativeLeetCode2(int m, int n);

        /// <summary>
        /// The fn should return a boolean indicating if is possible to generate the targetSum from the given array
        /// e.g: canSum(7, [5 3 4 7])
        /// 
        /// 
        ///                                        7
        ///                                   /    |    \       \
        ///                                  /     |     \       \
        ///                              -5 /   -3 |   -4 \    -7 \
        ///                                2       4       3       0
        ///                                   -4 / -3 \ -3 |
        ///                                     0      1   0
        /// 
        /// 0 is the base sum for finding the sum, below 0 is no good 
        /// We move boolean values from leaf to parent and get if we can sum or not. 
        ///     I mean by this returning call stack calls, returning true always has priority
        /// 
        /// e.g: canSum(7, [2, 4]) All leaves are 1, we have no valid base case
        /// O(n^m) time complexity
        /// O(m) space complexity
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        bool CanSum(int n, int[] numbers);

        /// <summary>
        /// Using memoization
        /// m = target sum
        /// n = array length
        /// O(m*n) time complexity
        /// O(m) space complexity
        /// </summary>
        /// <param name="n"></param>
        /// <param name="numbers"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        bool CanSum(int n, int[] numbers, Dictionary<int, bool> memo);

        /// <summary>
        /// Write a fn `howSum(targetSum, numbers)` that takes in a targetSum and an array of numbers as arguments
        ///     The function should return an array containing any combination of elements that add up exactly to the targetSum.
        ///     If there is no combination that adds up to the targetSum, then return null
        ///     If there are multiple combinations possible, you may return any single one
        /// 
        /// n = target sum
        /// m = numbers.length
        /// O(n^m * m) time complexity
        /// O(m) space complexity
        /// </summary>
        /// <param name="n"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        List<int>? HowSum(int n, int[] numbers);

        /// <summary>
        /// O(n*m*m) time complexity
        /// O(m*m) space complexity   
        /// </summary>
        /// <param name="n"></param>
        /// <param name="numbers"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        List<int>? HowSum(int n, int[] numbers, Dictionary<int, List<int>?> memo);

        /// <summary>
        ///  The fn should return an array containing the shortest combination of numbers that add up to targetSum
        /// If there is a tie for shortest combination, you may return any of the shortest
        /// O(n ^ m*m) time complexity
        /// O(m^2) space complexity
        /// </summary>
        /// <param name="n"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        List<int>? BestSum(int n, int[] numbers);

        /// <summary>
        /// O(m^2*n) time complexity
        /// O(m^2) space complexity
        /// </summary>
        /// <param name="n"></param>
        /// <param name="numbers"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        List<int>? BestSum(int n, int[] numbers, Dictionary<int, List<int>?> memo);

        /// <summary>
        /// m = target.length 
        /// n = words.length
        /// O((n^m)*m) time complexity, m*m vecause of susbtring 
        /// O(m^2) height of the tree
        /// </summary>
        /// <param name="word"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        bool CanConstruct(string word, string[] words);

        /// <summary>
        /// m = target.length 
        /// n = words.length
        /// O(n*m^2) time complexity, not exponential
        /// O(m^2) space complexity (^2 substring call)
        /// </summary>
        /// <param name="word"></param>
        /// <param name="words"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        bool CanConstruct(string word, string[] words, Dictionary<string, bool> memo);

        /// <summary>
        /// Return the number of ways that the target can be constructed concatenating elements of the word array
        /// </summary>
        /// <param name="word"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        int CountConstruct(string word, string[] words);

        /// <summary>
        /// O(n*m^2) time complexity, not exponential
        /// O(m^2) space complexity (^2 substring call)
        /// </summary>
        /// <param name="word"></param>
        /// <param name="words"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        int CountConstruct(string word, string[] words, Dictionary<string, int> memo);

        /// <summary>
        /// Return a 2d array containging all of the ways that the target can be constructed by concatenating elements
        /// of the words array. Each element of the 2d array should represent one combination that constructs the target
        /// </summary>
        /// <param name="word"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        List<string>? AllConstruct(string word, string[] words);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <param name="words"></param>
        /// <param name="memo)"></param>
        /// <returns></returns>
        List<string>? AllConstruct(string word, string[] words, Dictionary<string, List<string>>? memo);
    }
}