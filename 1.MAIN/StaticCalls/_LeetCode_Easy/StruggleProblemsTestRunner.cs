
using _1.Main.StaticCalls._LeetCode_Easy.Helper;

namespace _1.Main.StaticCalls._LeetCode_Easy
{
    public class StruggleProblemsTestRunner : StruggleProblemsTestRunnerInitializer
    {
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
        public void RunTests_PrefixSum()
        {
            _testsStrugglePrefixSum.PivotInteger_Tests();
        }

        public void RunTests_MultidimensionalArrays()
        {
            _testsMultidimensionalArrays.CellsWithOddValuesInAMatrix_Tests();
            _testsMultidimensionalArrays.CheckIfEveryRowAndColumnContainsAllNumbers_Tests();
            _testsMultidimensionalArrays.FlippingAnImage_Tests();
            _testsMultidimensionalArrays.MinimumTimeVisitingAllPoints_Tests();
            _testsMultidimensionalArrays.TheKWeakestRowsInAMatrix_Tests();
        }
    }
}