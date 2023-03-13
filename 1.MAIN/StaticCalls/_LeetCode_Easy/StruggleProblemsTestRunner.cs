using _0.Tests._LeetCode_Easy.Tests.Struggle.BitManipulation;
using _0.Tests._LeetCode_Easy.Tests.Struggle.Misc;
using _0.Tests._LeetCode_Easy.Tests.Struggle.Strings;
using _0.Tests.Tests.Struggle.Arrays;
using _2.Printer.Concrete;

namespace _1.Main.StaticCalls._LeetCode_Easy
{
    public class StruggleProblemsTestRunner
    {
        private readonly TestsStruggleArrays _testsArrays;
        private readonly TestsStruggleBitManipulation _testsBitManipulation;
        private readonly TestsStruggleStrings _testsStruggleStrings;
        private readonly TestsStruggleMisc _testsStruggleMisc;

        public StruggleProblemsTestRunner()
        {
            _testsArrays = new TestsStruggleArrays(new DisplayTypeInstantiator());
            _testsBitManipulation = new TestsStruggleBitManipulation(new DisplayTypeInstantiator());
            _testsStruggleMisc = new TestsStruggleMisc(new DisplayTypeInstantiator());
            _testsStruggleStrings = new TestsStruggleStrings(new DisplayTypeInstantiator());
        }
        public void RunTests_Arrays()
        {
            _testsArrays.RemoveDuplicatesfromSortedArray_Test();
            _testsArrays.CreateTargetArrayInTheGivenOrder_Test();
            _testsArrays.DestinationCity_Test();
            _testsArrays.SumOfAllOddLengthSubarrays_Test();
        }

        public void RunTests_BitManipulation()
        {
            _testsBitManipulation.MinBitFlips_Test();
        }

        public void RunTests_Misc()
        {
            _testsStruggleMisc.ExcelSheetColumnTitle_Test();
        }

        public void RunTests_Strings()
        {
            _testsStruggleStrings.CellsInARangeOnAnExcelSheet_Tests();
            _testsStruggleStrings.CalculateDigitSumOfAString_Tests();
            _testsStruggleStrings.CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_Tests();
            _testsStruggleStrings.CheckIfNumberHasEqualDigitCountAndDigitValue_Tests();
            _testsStruggleStrings.CheckIfStringIsAPrefixOfArray_Tests();
            _testsStruggleStrings.IsomorphicStrings_Tests();
            _testsStruggleStrings.CountPrefixesOfAGivenString_Tests();
            _testsStruggleStrings.ReverseVowelsofaString_Tests();
            _testsStruggleStrings.WordPattern_Tests();
        }
    }
}