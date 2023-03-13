using _0.Tests.Tests._LeetCode_Easy.Interfaces;
using _2.Printer.Concrete;

namespace _1.Main.StaticCalls._LeetCode_Easy
{
    public class LowAcceptanceRateTestRunner
    {
        private readonly TestsLowAcceptanceRate _tests;

        public LowAcceptanceRateTestRunner()
        {
            _tests = new TestsLowAcceptanceRate(new DisplayTypeInstantiator());
        }
        public void RunTests()
        { 
            _tests.Reverse_Test();
        }
    }
}