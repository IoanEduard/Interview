using _0.Tests.SlidingWindow;
using _2.Printer.Concrete;
using _4.SlidingWindow.Concrete;

namespace _1.Main.StaticCalls.SlidingWindow
{
    public class SlidingWindowTestsRunner
    {
        private readonly SlidingWindowProblems _slidingWindowProblems;
        private Display<int> _display;
        private Display<string> _displayString;

        public SlidingWindowTestsRunner()
        {
            _slidingWindowProblems = new SlidingWindowProblems();
            _display = new Display<int>();
            _displayString = new Display<string>();
        }

        public void RunSlidingWindowTests()
        {
            var slidingWindowTests = new Tests(_display, _displayString, _slidingWindowProblems);
            slidingWindowTests.CountGoodSubstrings_v1_Test();
            slidingWindowTests.CountGoodSubstrings_v2_Test();
            slidingWindowTests.PairThatContainsMinimumElementInArray_Test();
            slidingWindowTests.MaximumSumOfConsecutiveNumbersBruteForce_Test_1();
            slidingWindowTests.MaximumSumOfConsecutiveNumbersBruteForce_Test_2();
            slidingWindowTests.MaximumSumOfConsecutiveNumbers_v1_Test_1();
            slidingWindowTests.MaximumSumOfConsecutiveNumbers_v1_Test_2();
            slidingWindowTests.MaximumSumOfConsecutiveNumbers_v2_Test_1();
            slidingWindowTests.MaximumSumOfConsecutiveNumbers_v2_Test_2();
            slidingWindowTests.MaximumSumOfConsecutiveNumbers_v1_Test_2();
            slidingWindowTests.DisplayWindow_v3_Test_1();
            slidingWindowTests.MatrixFromWindows_Test_1();
            slidingWindowTests.SumOfEachWindow_Test_1();
            slidingWindowTests.MinimumOfEachSubarraySlidingWindow_Test_1();
        }
    }
}