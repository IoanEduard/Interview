using _0.Tests.Tests._LeetCode_Easy;
using _2.Printer.Concrete;

namespace _1.Main.StaticCalls._LeetCode_Easy
{
    public class ProblemsToImproveTestRunner
    {
        private readonly TestsProblemsToImprove _tests;

        public ProblemsToImproveTestRunner()
        {
            _tests = new TestsProblemsToImprove(new DisplayTypeInstantiator());
        }
        public void RunTests()
        {
            _tests.CommonChars_Test();
            _tests.FindWords_Test();
        }
    }
}