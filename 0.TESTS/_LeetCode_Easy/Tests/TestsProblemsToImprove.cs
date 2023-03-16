using _0.Tests._LeetCode_Easy;
using _2.Printer.Concrete;
using _LeetCode_Easy.Concrete;
using _LeetCode_Easy.Interfaces;

namespace _0.Tests.Tests._LeetCode_Easy
{
    public class TestsProblemsToImprove : _TestsCases
    {
        private readonly DisplayTypeInstantiator _display;
        private readonly IToImprove _toImprove;

        public TestsProblemsToImprove(DisplayTypeInstantiator display)
        {
            _display = display;
            _toImprove = new ToImprove();
        }

        public void CommonChars_Test()
        {
            _display.DisplayString.DisplayResult(_toImprove.CommonChars(CommonChars_TestCase1));
        }

        public void FindWords_Test()
        {
            _display.DisplayString.DisplayResult(_toImprove.FindWords(FindWords_TestCase1));
        }
    }
}