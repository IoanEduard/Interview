using _2.Printer.Interfaces;
using DynamicProgramming.Interfaces;

namespace _0.Tests.DP
{
    public class Tests : TestCases
    {
        private readonly IDisplay<int> _display;
        private readonly IDisplay<string> _displayString;
        private readonly IFreecodeCampDP _freecodeCampDP;

        public Tests(IDisplay<int> display,IDisplay<string> displayString, IFreecodeCampDP freecodeCampDP)
        {
            _display = display;
            _displayString = displayString;
            _freecodeCampDP = freecodeCampDP;
        }
    }
}