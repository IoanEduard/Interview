using _0.Tests._LeetCode_Easy.Tests.Struggle.Arrays;
using _0.Tests._LeetCode_Easy.Tests.Struggle.Arrays.TestCases;
using _2.Printer.Concrete;

namespace _0.Tests.Tests.Struggle.Arrays
{
    public class TestsStruggleArrays : TestCases
    {
        private readonly TestArraysStruggleClassFactory _tests;
        private readonly DisplayTypeInstantiator _display;

        public TestsStruggleArrays(DisplayTypeInstantiator display)
        {
            _display = display;
            _tests = new TestArraysStruggleClassFactory();
        }

        public void RemoveDuplicatesfromSortedArray_Test()
        {
            _display.DisplayInteger.DisplayResult(_tests.RemoveDuplicatesfromSortedArray.RemoveDuplicates(RemoveDuplicatesfromSortedArray_TestCase1));
            _display.DisplayInteger.DisplayResult(_tests.RemoveDuplicatesfromSortedArray.RemoveDuplicates2(RemoveDuplicatesfromSortedArray_TestCase2));
        }

        public void CreateTargetArrayInTheGivenOrder_Test()
        {
            _display.DisplayInteger.DisplayResult(_tests.CreateTargetArrayInTheGivenOrder.CreateTargetArray(CreateTargetArray_TestCase1_param1, CreateTargetArray_TestCase1_param2));
            _display.DisplayInteger.DisplayResult(_tests.CreateTargetArrayInTheGivenOrder.CreateTargetArray0(CreateTargetArray_TestCase2_param1, CreateTargetArray_TestCase2_param2));
        }

        public void DestinationCity_Test()
        {
            _display.DisplayString.DisplayResult(_tests.DestinationCity.DestCity(DestinationCity_TestCase1));
            _display.DisplayString.DisplayResult(_tests.DestinationCity.DestCity(DestinationCity_TestCase2));
        }

        public void SumOfAllOddLengthSubarrays_Test()
        {
            _display.DisplayInteger.DisplayResult(_tests.SumOfAllOddLengthSubarrays.SumOddLengthSubarrays(SumOfAllOddLengthSubarrays_TestCase1));
            _display.DisplayInteger.DisplayResult(_tests.SumOfAllOddLengthSubarrays.SumOddLengthSubarrays2(SumOfAllOddLengthSubarrays_TestCase1));

            _display.DisplayInteger.DisplayResult(_tests.SumOfAllOddLengthSubarrays.SumOddLengthSubarrays(SumOfAllOddLengthSubarrays_TestCase2));
            _display.DisplayInteger.DisplayResult(_tests.SumOfAllOddLengthSubarrays.SumOddLengthSubarrays2(SumOfAllOddLengthSubarrays_TestCase2));

            _display.DisplayInteger.DisplayResult(_tests.SumOfAllOddLengthSubarrays.SumOddLengthSubarrays(SumOfAllOddLengthSubarrays_TestCase3));
            _display.DisplayInteger.DisplayResult(_tests.SumOfAllOddLengthSubarrays.SumOddLengthSubarrays2(SumOfAllOddLengthSubarrays_TestCase3));
        }
    }
}