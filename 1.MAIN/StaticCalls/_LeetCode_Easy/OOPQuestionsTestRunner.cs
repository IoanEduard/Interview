
using _0.Tests.Tests._LeetCode_Easy;
using _2.Printer.Concrete;

namespace _1.Main.StaticCalls._LeetCode_Easy
{
    public class OOPQuestionsTestRunner
    {
        private readonly TestsOOP _tests;

        public OOPQuestionsTestRunner()
        {
            _tests = new TestsOOP(new DisplayTypeInstantiator());
        }

        public void RunTests()
        { 
            _tests.Codec_Test();
            _tests.OrderedStream_Test();
            _tests.ParkingSystem_Test();
        }
    }
}