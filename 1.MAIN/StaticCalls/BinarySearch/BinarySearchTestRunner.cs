using _0.Tests._LeetCode_Easy.Tests.BinarySearch;
using _2.Printer.Concrete;
using _5.SearchingAlgorithms.Concrete.LeetCode;

namespace _1.Main.StaticCalls.BinarySearch
{
    public class BinarySearchTestRunner
    {
        private readonly Tests _tests;

        public BinarySearchTestRunner()
        {
            _tests = new Tests(new DisplayTypeInstantiator(), new LeetCodeBinarySearch());
        }

        public void RunTests()
        {
            // _tests.BinarySearchCountNegatives_Test();
            _tests.SearchRange_Test();
        }

    }
}