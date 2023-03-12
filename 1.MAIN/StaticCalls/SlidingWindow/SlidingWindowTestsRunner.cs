using _0.Tests.SlidingWindow;
using _2.Printer.Concrete;
using _4.SlidingWindow.Concrete;

namespace _1.Main.StaticCalls.SlidingWindow
{
    public class SlidingWindowTestsRunner
    {
        private readonly Tests _tests;

        public SlidingWindowTestsRunner()
        {
            _tests = new Tests(new DisplayTypeInstantiator(),  new SlidingWindowProblems());
        }

        public void RunSlidingWindowTests()
        {
            _tests.CountGoodSubstrings_v1_Test();
            _tests.CountGoodSubstrings_v2_Test();
            _tests.PairThatContainsMinimumElementInArray_Test();
            _tests.MaximumSumOfConsecutiveNumbersBruteForce_Test_1();
            _tests.MaximumSumOfConsecutiveNumbersBruteForce_Test_2();
            _tests.MaximumSumOfConsecutiveNumbers_v1_Test_1();
            _tests.MaximumSumOfConsecutiveNumbers_v1_Test_2();
            _tests.MaximumSumOfConsecutiveNumbers_v2_Test_1();
            _tests.MaximumSumOfConsecutiveNumbers_v2_Test_2();
            _tests.MaximumSumOfConsecutiveNumbers_v1_Test_2();
            _tests.DisplayWindow_v3_Test_1();
            _tests.MatrixFromWindows_Test_1();
            _tests.SumOfEachWindow_Test_1();
            _tests.MinimumOfEachSubarraySlidingWindow_Test_1();
        }
    }
}