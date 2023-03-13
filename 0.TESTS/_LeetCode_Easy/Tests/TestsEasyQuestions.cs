
using _2.Printer.Concrete;
using _LeetCode_Easy.Concrete;
using _LeetCode_Easy.Interfaces;

namespace _0.Tests.Tests._LeetCode_Easy
{
    public class TestsEasyQuestions
    {
        private readonly DisplayTypeInstantiator _display;
        private readonly IEasy _easy;

        public TestsEasyQuestions(DisplayTypeInstantiator display)
        {
            _display = display;
            _easy = new Easy();
        }

        public void CommonChars_Test()
        {
            _display.DisplayString.DisplayResult(_easy.CapitalizeTitle("title"));
        }

        public void FindWords_Test()
        {
            _display.DisplayInteger.DisplayResult(_easy.AddDigits(123));
        }
    }
}