using _0.Tests._LeetCode_Easy.Tests.BinarySearch.Interfaces;
using _2.Printer.Concrete;
using _5.SearchingAlgorithms.Interfaces;

namespace _0.Tests._LeetCode_Easy.Tests.BinarySearch
{
    public class Tests : TestCases, IBinarySearch_Tests
    {
        private readonly IBinarySearchProblems _problems;
        private readonly DisplayTypeInstantiator _display;

        public Tests(DisplayTypeInstantiator display, IBinarySearchProblems problems)
        {
            _problems = problems;
            _display = display;
        }

        public void BinarySearchCountNegatives_Test()
        {
            var result = _problems.CountNegatives(BinarySearchCountNegatives_TestCase);
            _display.DisplayInteger.DisplayResult(result);
        }

        public void SearchRange_Test()
        {
            var result = _problems.SearchRange(SearchRange_TestCase_Param1, SearchRange_TestCase_Param2);
            _display.DisplayInteger.DisplayResult(result);
        }

    }
}