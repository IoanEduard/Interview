using _0.Tests.SlidingWindow.Interfaces;
using _2.Printer.Interfaces;
using _4.SlidingWindow.Interfaces;
using static _0.Tests.SlidingWindow.TestCases;

namespace _0.Tests.SlidingWindow
{
    public class Tests : ISlidingWindow_Tests
    {
        private readonly IDisplay<int> _display;
        private readonly IDisplay<string> _displayString;
        private readonly ISlidingWindowProblems _problems;

        public Tests(IDisplay<int> display,IDisplay<string> displayString, ISlidingWindowProblems problems)
        {
            _display = display;
            _displayString = displayString;
            _problems = problems;
        }

        public void CountGoodSubstrings_v1_Test()
        {
            var result = _problems.CountGoodSubstrings_v1(CountGoodSubstrings_v1_TestCase);
            _display.DisplayResult(result);
        }

        public void CountGoodSubstrings_v2_Test()
        {

            var result = _problems.CountGoodSubstrings_v1(CountGoodSubstrings_v2_TestCase);
            _display.DisplayResult(result);
        }

        public void DisplayWindow_v3_Test_1()
        {
            var result = _problems.DisplayWindow_v3(DisplayWindow_v3_TestCase1, DisplayWindow_v3_TestCase1_param);
            _displayString.DisplayResult(result);
        }

        public void MatrixFromWindows_Test_1()
        {
            var result = _problems.MatrixFromWindows(MatrixFromWindows_TestCase1, MatrixFromWindows_TestCase1_param);
            _display.DisplayResult(result);
        }

        public void MaximumSumOfConsecutiveNumbersBruteForce_Test_1()
        {
            var result = _problems.MaximumSumOfConsecutiveNumbersBruteForce(SumOfConsecutiveNumbers_TestCase1, SumOfConsecutiveNumbers_TestCase1_param);
            _display.DisplayResult(result);
        }

        public void MaximumSumOfConsecutiveNumbersBruteForce_Test_2()
        {
            var result = _problems.MaximumSumOfConsecutiveNumbersBruteForce(SumOfConsecutiveNumbers_TestCase2, SumOfConsecutiveNumbers_TestCase2_param);
            _display.DisplayResult(result);
        }

        public void MaximumSumOfConsecutiveNumbers_v1_Test_1()
        {
            var result = _problems.MaximumSumOfConsecutiveNumbers_v1(SumOfConsecutiveNumbers_TestCase1, SumOfConsecutiveNumbers_TestCase1_param);
            _display.DisplayResult(result);
        }

        public void MaximumSumOfConsecutiveNumbers_v1_Test_2()
        {
            var result = _problems.MaximumSumOfConsecutiveNumbers_v1(SumOfConsecutiveNumbers_TestCase2, SumOfConsecutiveNumbers_TestCase2_param);
            _display.DisplayResult(result);
        }

        public void MaximumSumOfConsecutiveNumbers_v2_Test_1()
        {
            var result = _problems.MaximumSumOfConsecutiveNumbers_v2(SumOfConsecutiveNumbers_TestCase1, SumOfConsecutiveNumbers_TestCase1_param);
            _display.DisplayResult(result);
        }

        public void MaximumSumOfConsecutiveNumbers_v2_Test_2()
        {
            var result = _problems.MaximumSumOfConsecutiveNumbers_v2(SumOfConsecutiveNumbers_TestCase2, SumOfConsecutiveNumbers_TestCase2_param);
            _display.DisplayResult(result);
        }

        public void MinimumOfEachSubarraySlidingWindow_Test_1()
        {
            var result = _problems.MinimumOfEachSubarraySlidingWindow(MinimumOfEachSubarraySlidingWindow_TestCase1, MinimumOfEachSubarraySlidingWindow_TestCase1_param);
            _display.DisplayResult(result);
        }

        public void PairThatContainsMinimumElementInArray_Test()
        {
            var result = _problems.PairThatContainsMinimumElementInArray(PairThatContainsMinimumElementInArray_TestCase, PairThatContainsMinimumElementInArray_TestCase_param);
            _display.DisplayResult(result);
        }

        public void SumOfEachWindow_Test_1()
        {
            var result = _problems.SumOfEachWindow(SumOfEachWindow_TestCase1, SumOfEachWindow_TestCase1_param);
            _display.DisplayResult(result);
        }
        public void MaxScore_Test()
        {
            var result = _problems.MaxScore(MaxScore_TestCase1, MaxScore_TestCase1_param);
            _display.DisplayResult(result);
        }

        public void MaxScoreLeetCodeSolution_Test()
        {
            var result = _problems.MaxScoreLeetCodeSolution(MaxScore_TestCase1, MaxScore_TestCase1_param);
            _display.DisplayResult(result);
        }

        public void MinimumRecolors_Test()
        {
            var result = _problems.MinimumRecolors(MinimumRecolors_TestCase1, MinimumRecolors_TestCase1_param);
            _display.DisplayResult(result);
        }
    }
}