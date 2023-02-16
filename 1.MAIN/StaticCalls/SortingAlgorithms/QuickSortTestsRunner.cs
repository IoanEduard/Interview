using _2.Printer.Concrete;
using System.Text;
using _3.SortingAlgorithms.Concrete;
using _0.Tests.SortingAlgorithms;

namespace _1.Main.StaticCalls.SortingAlgorithms
{
    public class QuickSortTestsRunner
    {
        private readonly QuickSort _quickSort;
        private Display<int> _display;

        public QuickSortTestsRunner()
        {
            _quickSort = new QuickSort();
            _display = new Display<int>();
        }

        public void RunQuickSortTests()
        {
            var quickSortTests = new Tests(_display, _quickSort);
            quickSortTests.QuickSort_Test1();
            quickSortTests.QuickSort_Test2();
            quickSortTests.QuickSort_Test3();
            quickSortTests.QuickSort_Test4();
        }
    }
}