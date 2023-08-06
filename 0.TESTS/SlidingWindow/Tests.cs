using _0.Tests.SlidingWindow.Interfaces;
using _2.Printer.Concrete;
using _4.SlidingWindow.Interfaces;

namespace _0.Tests.SlidingWindow
{
    public class Tests : TestCases, ISlidingWindow_Tests
    {
        private readonly ISlidingWindowProblems _problems;
        private readonly DisplayTypeInstantiator _display;

        public Tests(DisplayTypeInstantiator display, ISlidingWindowProblems problems)
        {
            _problems = problems;
            _display = display;
        }

        public void CountGoodSubstrings_v1_Test()
        {
            var result = _problems.CountGoodSubstrings_v1(CountGoodSubstrings_v1_TestCase);
            _display.DisplayInteger.DisplayResult(result);
        }

        public void CountGoodSubstrings_v2_Test()
        {

            var result = _problems.CountGoodSubstrings_v1(CountGoodSubstrings_v2_TestCase);
            _display.DisplayInteger.DisplayResult(result);
        }

        public void DisplayWindow_v3_Test_1()
        {
            var result = _problems.DisplayWindow_v3(DisplayWindow_v3_TestCase1, DisplayWindow_v3_TestCase1_param);
            _display.DisplayString.DisplayResult(result);
        }

        public void MatrixFromWindows_Test_1()
        {
            var result = _problems.MatrixFromWindows(MatrixFromWindows_TestCase1, MatrixFromWindows_TestCase1_param);
            _display.DisplayInteger.DisplayResult(result);
        }

        public void MaximumSumOfConsecutiveNumbersBruteForce_Test_1()
        {
            var result = _problems.MaximumSumOfConsecutiveNumbersBruteForce(SumOfConsecutiveNumbers_TestCase1, SumOfConsecutiveNumbers_TestCase1_param);
            _display.DisplayInteger.DisplayResult(result);
        }

        public void MaximumSumOfConsecutiveNumbersBruteForce_Test_2()
        {
            var result = _problems.MaximumSumOfConsecutiveNumbersBruteForce(SumOfConsecutiveNumbers_TestCase2, SumOfConsecutiveNumbers_TestCase2_param);
            _display.DisplayInteger.DisplayResult(result);
        }

        public void MaximumSumOfConsecutiveNumbers_v1_Test_1()
        {
            var result = _problems.MaximumSumOfConsecutiveNumbers_v1(SumOfConsecutiveNumbers_TestCase1, SumOfConsecutiveNumbers_TestCase1_param);
            _display.DisplayInteger.DisplayResult(result);
        }

        public void MaximumSumOfConsecutiveNumbers_v1_Test_2()
        {
            var result = _problems.MaximumSumOfConsecutiveNumbers_v1(SumOfConsecutiveNumbers_TestCase2, SumOfConsecutiveNumbers_TestCase2_param);
            _display.DisplayInteger.DisplayResult(result);
        }

        public void MaximumSumOfConsecutiveNumbers_v2_Test_1()
        {
            var result = _problems.MaximumSumOfConsecutiveNumbers_v2(SumOfConsecutiveNumbers_TestCase1, SumOfConsecutiveNumbers_TestCase1_param);
            _display.DisplayInteger.DisplayResult(result);
        }

        public void MaximumSumOfConsecutiveNumbers_v2_Test_2()
        {
            var result = _problems.MaximumSumOfConsecutiveNumbers_v2(SumOfConsecutiveNumbers_TestCase2, SumOfConsecutiveNumbers_TestCase2_param);
            _display.DisplayInteger.DisplayResult(result);
        }

        public void MinimumOfEachSubarraySlidingWindow_Test_1()
        {
            var result = _problems.MinimumOfEachSubarraySlidingWindow(MinimumOfEachSubarraySlidingWindow_TestCase1, MinimumOfEachSubarraySlidingWindow_TestCase1_param);
            _display.DisplayInteger.DisplayResult(result);
        }

        public void PairThatContainsMinimumElementInArray_Test()
        {
            var result = _problems.PairThatContainsMinimumElementInArray(PairThatContainsMinimumElementInArray_TestCase, PairThatContainsMinimumElementInArray_TestCase_param);
            _display.DisplayInteger.DisplayResult(result);
        }

        public void SumOfEachWindow_Test_1()
        {
            var result = _problems.SumOfEachWindow(SumOfEachWindow_TestCase1, SumOfEachWindow_TestCase1_param);
            _display.DisplayInteger.DisplayResult(result);
        }
        public void MaxScore_Test()
        {
            var result = _problems.MaxScore(MaxScore_TestCase1, MaxScore_TestCase1_param);
            _display.DisplayInteger.DisplayResult(result);
        }

        public void MaxScoreLeetCodeSolution_Test()
        {
            var result = _problems.MaxScoreLeetCodeSolution(MaxScore_TestCase1, MaxScore_TestCase1_param);
            _display.DisplayInteger.DisplayResult(result);
        }

        public void MinimumRecolors_Test()
        {
            // var result = _problems.MinimumRecolors(MinimumRecolors_TestCase1, MinimumRecolors_TestCase1_param);
            var result2 = _problems.MinimumRecolors("BWWWBB", 6);
            _display.DisplayInteger.DisplayResult(result2);
        }
        public void ContainsNearbyDuplicate_Test()
        {
            var result = _problems.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3);
            var result1 = _problems.ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1);
            var result2 = _problems.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2);
            var result3 = _problems.ContainsNearbyDuplicate(new int[] { 99, 99 }, 2);

            _display.DisplayBoolean.DisplayResult(result3);
        }

        public void FindMaxAverage_Test()
        {
            var result3 = _problems.FindMaxAverage(new int[] { 1, 12, -5, -6, 50, 3 }, 4);

            _display.DisplayDouble.DisplayResult(result3);
        }

        public void CountGoodSubstrings_Test()
        {
            // var result1 = _problems.CountGoodSubstrings("xyzzaz");
            var result = _problems.CountGoodSubstrings("aababcabc");

            _display.DisplayInteger.DisplayResult(result);
        }

        public void MinimumDifference_Test()
        {
            var result = _problems.MinimumDifference(new int[] { 9, 4, 1, 7 }, 2);

            _display.DisplayInteger.DisplayResult(result);
        }

        public void DivisorSubstrings_Test()
        {
            var result = _problems.DivisorSubstrings(430043, 2);

            _display.DisplayInteger.DisplayResult(result);
        }

        public void NumOfSubarrays_Test()
        {
            var result = _problems.NumOfSubarrays(new int[] { 1, 1, 1, 1, 1 }, 1, 0);

            _display.DisplayInteger.DisplayResult(result);
        }

        public void NumberOfSubstrings_Test()
        {
            var result = _problems.NumberOfSubstrings("abcabc");

            _display.DisplayInteger.DisplayResult(result);
        }

        public void LongestOnes_Test()
        {
            var result = _problems.LongestOnes(new int[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }, 3);

            _display.DisplayInteger.DisplayResult(result);
        }
    }
}