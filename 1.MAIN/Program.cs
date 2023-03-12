
using _1.Main.StaticCalls._LeetCode_Easy;
using _1.Main.StaticCalls.SlidingWindow;
using _1.Main.StaticCalls.SortingAlgorithms;
using _1.Main.StaticCalls.Trees;
using _15.DynamicProgramming.FreeCodeCamp.Concrete.Documentation;
using _LeetCode_Easy.Concrete;
using _LeetCode_Easy.Concrete.LowAcceptanceRate;

var binaryTreeTets = new BinaryTreesTestRunner();
// binaryTreeTets.RunBinaryTreesTests();

var slidingWindowTests = new SlidingWindowTestsRunner();
// slidingWindowTests.RunSlidingWindowTests();

var quickSortTests = new QuickSortTestsRunner();
// quickSortTests.RunQuickSortTests();

var oopLeetCode = new LeetcodeOOPQuestionsTestRunner();
oopLeetCode.RunLeetcodeOOPQuestions();


// var easyLeetCode = new EasyLeetcodeQuestionsTestRunner();



// var mediumLeetCode = new EasyLeetcodeQuestionsTestRunner();


// var hardLeetCode = new EasyLeetcodeQuestionsTestRunner();



// System.Console.WriteLine(class1.SumOfUnique(new int[] { 1, 2, 3, 2 }));
// System.Console.WriteLine(class1.IsStrictlyPalindromic(9));
// System.Console.WriteLine(class1.FindArray(new int[] { 5, 2, 0, 3, 1 }));
// System.Console.WriteLine(class1.SortTheStudents(new int[][] {
//     new int[] {10,6,9,1},
//     new int[] {7,5,11,2},
//     new int[] {4,8,3,15}
//  }, 2));

// Migrate everything on this project

var easy = new _Easy();
// System.Console.WriteLine(easy.IsAnagram("anagram", "nagaram"));
// System.Console.WriteLine(easy.IsAnagram("aacc", "ccac"));
// System.Console.WriteLine(easy.AlternateDigitSum(886996));



var low = new LowAcceptanceRate();
// System.Console.WriteLine(low.Reverse(321));

var dp = new FreecodeCampDP();
// System.Console.WriteLine(dp.FibRecursive(48));
// System.Console.WriteLine(dp.FibDP(48));
// System.Console.WriteLine(dp.FibInefficient(48));

// System.Console.WriteLine(dp.CanSum(7, new int[] { 5, 3, 4, 7 }, new() { }));
// System.Console.WriteLine(dp.CanSum(7, new int[] { 2, 4 }, new() { }));
// System.Console.WriteLine(dp.CanSum(300, new int[] { 7, 14 }, new() { }));
// System.Console.WriteLine(dp.CanSum(300, new int[] { 7, 14 }));
// System.Console.WriteLine(dp.CanSum(300, new int[] { 7, 14 }));

// var res = dp.HowSum(7, new int[] { 5, 3, 4, 7 });
// for (var i = 0; i < res.Count; i++)
// {
//     System.Console.WriteLine(res[i]);
// }

// var res2 = dp.HowSum(300, new int[] { 7, 14, 2 });
// for (var i = 0; i < res2.Count; i++)
// {
//     System.Console.WriteLine(res2[i]);
// }

// var res3 = dp.HowSum(7, new int[] { 2, 4, 1,8, 9 });
// for (var i = 0; i < res.Count; i++)
// {
//     System.Console.WriteLine(res[i]);
// }

// System.Console.WriteLine(dp.HowSum(7, new int[] { 2, 4 }));
// System.Console.WriteLine(dp.HowSum());
// System.Console.WriteLine(dp.HowSum();

// System.Console.WriteLine(dp.ShortestPathInefficient(3, 2));
// System.Console.WriteLine(dp.ShortestPathInefficient(13, 12));
// System.Console.WriteLine(dp.ShortestPathInefficient(18, 18));

// var res = dp.BestSum(300, new int[] { 2, 3, 5, 295 }, new() {});
// for (var i = 0; i < res.Count; i++)
// {
//     System.Console.WriteLine(res[i]);
// }

// System.Console.WriteLine(dp.CanConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }, new() {}));
// System.Console.WriteLine(dp.CanConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }, new() {}));
// System.Console.WriteLine(dp.CanConstruct("abcdef", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }, new() {}));
// System.Console.WriteLine(dp.CanConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }, new() {}));

// System.Console.WriteLine(dp.CountConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }, new() {}));
// System.Console.WriteLine(dp.CountConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }, new() {}));
// System.Console.WriteLine(dp.CountConstruct("abcdef", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }, new() {}));
// System.Console.WriteLine(dp.CountConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }, new() {}));
// System.Console.WriteLine(dp.CountConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }, new() {}));

// var l1 = new ListNode();
// l1 = new ListNode(2);
// l1.next = new ListNode(4);
// l1.next.next = new ListNode(3);

// var l2 = new ListNode();
// l2 = new ListNode(5);
// l2.next = new ListNode(6);
// l2.next.next = new ListNode(4);

// var list = new LinkedListsProblems();
// list.AddTwoNumbers2(l1, l2);