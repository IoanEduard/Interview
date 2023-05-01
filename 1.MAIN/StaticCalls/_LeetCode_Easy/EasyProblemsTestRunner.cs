using _0.Tests.Tests._LeetCode_Easy;
using _2.Printer.Concrete;

namespace _1.Main.StaticCalls._LeetCode_Easy
{
    public class EasyProblemsTestRunner
    {
        private readonly TestsEasyQuestions _tests;

        public EasyProblemsTestRunner()
        {
            _tests = new TestsEasyQuestions(new DisplayTypeInstantiator());
        }
        public void RunTests()
        {
        }
    }
}