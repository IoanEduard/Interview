using _2.Printer.Concrete;

namespace _0.Tests._LeetCode_Easy.Tests.Struggle.PrefixSum
{
    public class TestsStrugglePrefixSum : TestCases
    {
        private readonly TestsStruggleClassFactory _tests;
        private readonly DisplayTypeInstantiator _display;

        public TestsStrugglePrefixSum(DisplayTypeInstantiator display)
        {
            _display = display;
            _tests = new TestsStruggleClassFactory();
        }

        public void PivotInteger_Tests()
        {
            _display.DisplayInteger.DisplayResult(_tests.FindThePivotInteger.PivotInteger(PivotInteger_TestCase1));
            _display.DisplayInteger.DisplayResult(_tests.FindThePivotInteger.PivotInteger(PivotInteger_TestCase2));
            _display.DisplayInteger.DisplayResult(_tests.FindThePivotInteger.PivotInteger(PivotInteger_TestCase3));
        }
    }
}