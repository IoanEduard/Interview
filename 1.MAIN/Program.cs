
using _1.Main.StaticCalls._LeetCode_Easy;
using _1.Main.StaticCalls.SlidingWindow;
using _1.Main.StaticCalls.SortingAlgorithms;
using _1.Main.StaticCalls.Trees;
using _15.DynamicProgramming.FreeCodeCamp.Concrete.Documentation;
using _6.Recursion.Concrete.freeCodeCamp;

// var dailyWork = new DailyWorkFileTestRunner();

var binaryTreeTets = new BinaryTreesTestRunner();
// binaryTreeTets.RunBinaryTreesTests();

var slidingWindowTests = new SlidingWindowTestsRunner();
// slidingWindowTests.RunSlidingWindowTests();

var quickSortTests = new QuickSortTestsRunner();
// quickSortTests.RunQuickSortTests();

var oopLeetCode = new OOPQuestionsTestRunner();
// oopLeetCode.RunLeetcodeOOPQuestions();

var lowAcceptanceRate = new LowAcceptanceRateTestRunner();
// lowAcceptanceRate.RunLeetcodeOOPQuestions();

var badProblems = new BadProblemsTestRunner();
// badProblems.RunTests();

var toImprove = new ProblemsToImproveTestRunner();
// toImprove.RunTests();

// Algorithms are easy straight forward, no testcases documented.
var easy = new EasyProblemsTestRunner();

// Untested
var struggle = new StruggleProblemsTestRunner();
// struggle.RunTests_Arrays();
// struggle.RunTests_BitManipulation();
// struggle.RunTests_Strings();
// struggle.RunTests_PrefixSum();


// Todo: remove static usings and do inheritance with protected
// Keep doing interfaces for all tests just like Sliding Window and inject them
// LeetCode medium tests
// Below stuff

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

// var easy = new _Easy();
// System.Console.WriteLine(easy.IsAnagram("anagram", "nagaram"));
// System.Console.WriteLine(easy.IsAnagram("aacc", "ccac"));
// System.Console.WriteLine(easy.AlternateDigitSum(886996));


var dp = new FreecodeCampDP();
// System.Console.WriteLine(dp.FibRecursive(48));
// System.Console.WriteLine(dp.FibDP(48));
// System.Console.WriteLine(dp.FibInefficient(48));

// System.Console.WriteLine(dp.CanSumTabulation(7, new int[] { 5, 3, 4, 7 }));
// System.Console.WriteLine(dp.CanSumTabulation(7, new int[] { 2, 4 }));


// foreach (var item in dp.HowSumTab2(8, new int[] { 2, 3, 5, 7 })!)
// {
//     System.Console.WriteLine(item);
// }

// foreach (var item in dp.BestSumTabulation(8, new int[] { 2, 3, 5 }))
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine(dp.CanSumTabulation(300, new int[] { 7, 14 }));

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

// System.Console.WriteLine(dp.CountConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl" }));
// var result = dp.AllCounstructTabulation("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd", "ef", "c" });
// foreach (var item in result) {
//     System.Console.WriteLine(item);
// }
// System.Console.WriteLine(dp.CountConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }));
// System.Console.WriteLine(dp.CountConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }));
// System.Console.WriteLine(dp.CountConstruct("eeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }));

// var result = dp.AllConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" });
// var result2 = dp.AllConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl" });
// var result3 = dp.AllConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }, new() { });

// foreach (var item in result3!)
// {
//     foreach (var it in item)
//     {
//         System.Console.Write($"{it} ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine(dp.AllConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }));
// System.Console.WriteLine(dp.AllConstruct("abcdef", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }));
// System.Console.WriteLine(dp.AllConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }));

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


// Recursion
var rec = new FreeCodeCampRecursion();
System.Console.WriteLine(rec.ReverseString("avion"));
System.Console.WriteLine(rec.IsPalindrome("racecar"));
