using _2.Printer.Concrete;

namespace _0.Tests._LeetCode_Easy.Tests.Struggle.Misc
{
    public class TestsStruggleMisc : TestCases
    {
        private readonly TestsStruggleMiscClassFactory _tests;
        private readonly DisplayTypeInstantiator _display;

        public TestsStruggleMisc(DisplayTypeInstantiator display)
        {
            _display = display;
            _tests = new TestsStruggleMiscClassFactory();
        }

        public void ExcelSheetColumnTitle_Test()
        {
            _display.DisplayString.DisplayResult(_tests.ExcelSheetColumnTitle.ConvertToBase26(ExcelSheetColumnTitle_TestCase1));
            _display.DisplayString.DisplayResult(_tests.ExcelSheetColumnTitle.ConvertToBase26FirstTry(ExcelSheetColumnTitle_TestCase1));
            _display.DisplayString.DisplayResult(_tests.ExcelSheetColumnTitle.ConvertToTitle(ExcelSheetColumnTitle_TestCase1));
        }
    }
}