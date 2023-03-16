using _2.Printer.Concrete;

namespace _0.Tests._LeetCode_Easy.Tests.Struggle.BitManipulation
{
    public class TestsStruggleBitManipulation : TestCases
    {
        private readonly TestsStruggleBitManipulationClassFactory _tests;
        private readonly DisplayTypeInstantiator _display;

        public TestsStruggleBitManipulation(DisplayTypeInstantiator display)
        {
            _display = display;
            _tests = new TestsStruggleBitManipulationClassFactory();
        }

        public void MinBitFlips_Test()
        {
            _display.DisplayInteger.DisplayResult(_tests.MinimumBitFlipsToConvertNumber.MinBitFlips(RemoveDuplicatesfromSortedArray_TestCase1_param1, RemoveDuplicatesfromSortedArray_TestCase1_param2));
            _display.DisplayInteger.DisplayResult(_tests.MinimumBitFlipsToConvertNumber.MinBitFlips2(RemoveDuplicatesfromSortedArray_TestCase2_param1, RemoveDuplicatesfromSortedArray_TestCase2_param2));
            _display.DisplayInteger.DisplayResult(_tests.MinimumBitFlipsToConvertNumber.MinBitFlips3(RemoveDuplicatesfromSortedArray_TestCase1_param1, RemoveDuplicatesfromSortedArray_TestCase1_param1));
        }

    }
}