using _2.Printer.Interfaces;
using _3.SortingAlgorithms.Interfaces.Abstract;
using static _0.Tests.SortingAlgorithms.TestCases;

namespace _0.Tests.SortingAlgorithms
{
    public class Tests : IQuickSortTests
    {
        private readonly IDisplay<int> _display;
        private readonly SortingStrategy<int> _sortingStrategy;

        public Tests(IDisplay<int> display, SortingStrategy<int> sortingStrategy)
        {
            _display = display;
            _sortingStrategy = sortingStrategy;
        }

        public void QuickSort_Test1()
        {
            var quickSort = _sortingStrategy.Sort(QuickSort_TestCase1);
            _display.DisplayResult(quickSort);
        }

        public void QuickSort_Test2()
        {
            var quickSort = _sortingStrategy.Sort(QuickSort_TestCase2);
            _display.DisplayResult(quickSort);
        }

        public void QuickSort_Test3()
        {
            var quickSort = _sortingStrategy.Sort(QuickSort_TestCase3);
            _display.DisplayResult(quickSort);
        }

        public void QuickSort_Test4()
        {
            var quickSort = _sortingStrategy.Sort(QuickSort_TestCase4);
            _display.DisplayResult(quickSort);
        }
    }
}