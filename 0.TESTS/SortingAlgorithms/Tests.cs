using _2.Printer.Concrete;
using _3.SortingAlgorithms.Interfaces.Abstract;

namespace _0.Tests.SortingAlgorithms
{
    public class Tests : TestCases, IQuickSortTests
    {
        private readonly DisplayTypeInstantiator _display;
        private readonly SortingStrategy<int> _sortingStrategy;

        public Tests(DisplayTypeInstantiator display, SortingStrategy<int> sortingStrategy)
        {
            _display = display;
            _sortingStrategy = sortingStrategy;
        }

        public void QuickSort_Test1()
        {
            var quickSort = _sortingStrategy.Sort(QuickSort_TestCase1);
            _display.DisplayInteger.DisplayResult(quickSort);
        }

        public void QuickSort_Test2()
        {
            var quickSort = _sortingStrategy.Sort(QuickSort_TestCase2);
            _display.DisplayInteger.DisplayResult(quickSort);
        }

        public void QuickSort_Test3()
        {
            var quickSort = _sortingStrategy.Sort(QuickSort_TestCase3);
            _display.DisplayInteger.DisplayResult(quickSort);
        }

        public void QuickSort_Test4()
        {
            var quickSort = _sortingStrategy.Sort(QuickSort_TestCase4);
            _display.DisplayInteger.DisplayResult(quickSort);
        }
    }
}