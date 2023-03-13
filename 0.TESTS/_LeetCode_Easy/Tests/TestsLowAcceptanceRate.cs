using _2.Printer.Concrete;
using _LeetCode_Easy.Concrete.LowAcceptanceRate;
using _LeetCode_Easy.Interfaces;
using static _0.Tests._LeetCode_Easy._TestsCases;

namespace _0.Tests.Tests._LeetCode_Easy.Interfaces
{
    public class TestsLowAcceptanceRate
    {
        private readonly DisplayTypeInstantiator _display;
        private readonly ILowAcceptanceRate _lowAcceptanceRate;

        public TestsLowAcceptanceRate(DisplayTypeInstantiator display)
        {
            _display = display;
            _lowAcceptanceRate = new LowAcceptanceRate();
        }

        public void Reverse_Test()
        {
            _display.DisplayInteger.DisplayResult(_lowAcceptanceRate.Reverse(Reverse_Test_TestCase1));
        }

    }
}