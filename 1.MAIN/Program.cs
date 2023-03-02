
using _1.Main.StaticCalls.SlidingWindow;
using _1.Main.StaticCalls.SortingAlgorithms;
using _1.Main.StaticCalls.Trees;
using _LeetCode_Easy.Concrete;
using _LeetCode_Easy.Concrete.LowAcceptanceRate;

var quickSortTests = new QuickSortTestsRunner();
// quickSortTests.RunQuickSortTests();

var slidingWindowTests = new SlidingWindowTestsRunner();
// slidingWindowTests.RunSlidingWindowTests();

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

var binaryTreeTets = new BinaryTreesTestRunner();
binaryTreeTets.RunBinaryTreesTests();

var low = new LowAcceptanceRate();
// System.Console.WriteLine(low.Reverse(321));
