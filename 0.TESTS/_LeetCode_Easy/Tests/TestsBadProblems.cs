using _2.Printer.Concrete;
using _LeetCode_Easy.Concrete;
using _LeetCode_Easy.Interfaces;
using static _0.Tests._LeetCode_Easy._TestsCases;

namespace _0.Tests.Tests._LeetCode_Easy
{
    public class TestsBadProblems
    {
         private readonly DisplayTypeInstantiator _display;
         private readonly IBadEasyProblem _badProblems;

        public TestsBadProblems(DisplayTypeInstantiator display)
        {
            _display = display;
            _badProblems = new BadEasyProblem();
        }

        public void Reverse_Test()
        {
            _display.DisplayInteger.DisplayResult(_badProblems.NextGreaterElement(NextGreaterElement_TestCase1_param1, NextGreaterElement_TestCase1_param2));
        }
    }
}