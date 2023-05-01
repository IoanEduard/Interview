using _0.Tests._LeetCode_Hard;
using _2.Printer.Concrete;

namespace _1.Main.StaticCalls._LeetCode_Hard
{
    public class HardProblemsTestRunner
    {
        private readonly Tests _tests;

        public HardProblemsTestRunner()
        {
            _tests = new Tests(new DisplayTypeInstantiator());
        }
        public void RunTests()
        {
            _tests.NumWays_Test();
        }
    }
}