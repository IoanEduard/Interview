using _0.Tests.Tests._LeetCode_Easy;
using _2.Printer.Concrete;

namespace _1.Main.StaticCalls._LeetCode_Easy
{
    public class BadProblemsTestRunner
    {
        private readonly TestsBadProblems _tests;

        public BadProblemsTestRunner()
        {
            _tests = new TestsBadProblems(new DisplayTypeInstantiator());
        }
        public void RunTests()
        {
            _tests.Reverse_Test();
        }
    }
}