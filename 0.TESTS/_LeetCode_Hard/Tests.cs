using _2.Printer.Concrete;
using _LeetCode_Hard.NumberOfWaysToFormATargetStringGivenADictionary;

namespace _0.Tests._LeetCode_Hard
{
    public class Tests
    {
        private readonly DisplayTypeInstantiator _display;
        private readonly Editorial _testsEditorial;

        public Tests(DisplayTypeInstantiator display)
        {
            _display = display;
            _testsEditorial = new Editorial();
        }

        public void NumWays_Test()
        {
            _display.DisplayInteger.DisplayResult(_testsEditorial.NumWays(new string[] { "acca", "bbbb", "caca" }, "aba"));
            _display.DisplayInteger.DisplayResult(_testsEditorial.NumWays(new string[] { "abba","baab" }, "bab"));
        }
    }
}