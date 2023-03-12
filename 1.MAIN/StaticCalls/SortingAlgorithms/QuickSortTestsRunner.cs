using _2.Printer.Concrete;
using _3.SortingAlgorithms.Concrete;
using _0.Tests.SortingAlgorithms;

namespace _1.Main.StaticCalls.SortingAlgorithms
{
    public class QuickSortTestsRunner
    {
        private readonly Tests _tests;

        public QuickSortTestsRunner()
        {
            _tests = new Tests(new DisplayTypeInstantiator(), new QuickSort());
        }

        public void RunQuickSortTests()
        {
            _tests.QuickSort_Test1();
            _tests.QuickSort_Test2();
            _tests.QuickSort_Test3();
            _tests.QuickSort_Test4();
        }
    }
}