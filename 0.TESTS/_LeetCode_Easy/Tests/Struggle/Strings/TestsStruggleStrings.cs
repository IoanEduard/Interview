using _2.Printer.Concrete;
using static _0.Tests._LeetCode_Easy.Tests.Struggle.Strings.TestCases;

namespace _0.Tests._LeetCode_Easy.Tests.Struggle.Strings
{
    public class TestsStruggleStrings
    {
        private readonly TestsStruggleStringsClassFactory _tests;
        private readonly DisplayTypeInstantiator _display;

        public TestsStruggleStrings(DisplayTypeInstantiator display)
        {
            _display = display;
            _tests = new TestsStruggleStringsClassFactory();
        }

        public void IsomorphicStrings_Tests()
        {
            _display.DisplayBoolean.DisplayResult(_tests.IsomorphicStrings.IsIsomorphic(IsomorphicStrings_Test1_param1, IsomorphicStrings_Test1_param2));
            _display.DisplayBoolean.DisplayResult(_tests.IsomorphicStrings.IsIsomorphic(IsomorphicStrings_Test2_param1, IsomorphicStrings_Test2_param2));
            _display.DisplayBoolean.DisplayResult(_tests.IsomorphicStrings.IsIsomorphic(IsomorphicStrings_Test3_param1, IsomorphicStrings_Test3_param2));

            _display.DisplayBoolean.DisplayResult(_tests.IsomorphicStrings.IsIsomorphic2(IsomorphicStrings_Test1_param1, IsomorphicStrings_Test1_param2));
            _display.DisplayBoolean.DisplayResult(_tests.IsomorphicStrings.IsIsomorphic2(IsomorphicStrings_Test2_param1, IsomorphicStrings_Test2_param2));
            _display.DisplayBoolean.DisplayResult(_tests.IsomorphicStrings.IsIsomorphic2(IsomorphicStrings_Test3_param1, IsomorphicStrings_Test3_param2));

            _display.DisplayBoolean.DisplayResult(_tests.IsomorphicStrings.IsIsomorphic3(IsomorphicStrings_Test1_param1, IsomorphicStrings_Test1_param2));
            _display.DisplayBoolean.DisplayResult(_tests.IsomorphicStrings.IsIsomorphic3(IsomorphicStrings_Test2_param1, IsomorphicStrings_Test2_param2));
            _display.DisplayBoolean.DisplayResult(_tests.IsomorphicStrings.IsIsomorphic3(IsomorphicStrings_Test3_param1, IsomorphicStrings_Test3_param2));

            _display.DisplayBoolean.DisplayResult(_tests.IsomorphicStrings.IsIsomorphic4(IsomorphicStrings_Test1_param1, IsomorphicStrings_Test1_param2));
            _display.DisplayBoolean.DisplayResult(_tests.IsomorphicStrings.IsIsomorphic4(IsomorphicStrings_Test2_param1, IsomorphicStrings_Test2_param2));
            _display.DisplayBoolean.DisplayResult(_tests.IsomorphicStrings.IsIsomorphic4(IsomorphicStrings_Test3_param1, IsomorphicStrings_Test3_param2));
        }
        public void WordPattern_Tests()
        {
            _display.DisplayBoolean.DisplayResult(_tests.WordPattern.WordPattern0(WordPattern_Test1_param1, WordPattern_Test1_param2));
            _display.DisplayBoolean.DisplayResult(_tests.WordPattern.WordPattern0(WordPattern_Test2_param1, WordPattern_Test2_param2));
            _display.DisplayBoolean.DisplayResult(_tests.WordPattern.WordPattern0(WordPattern_Test3_param1, WordPattern_Test3_param2));

            _display.DisplayBoolean.DisplayResult(_tests.WordPattern.WordPattern1(WordPattern_Test1_param1, WordPattern_Test1_param2));
            _display.DisplayBoolean.DisplayResult(_tests.WordPattern.WordPattern1(WordPattern_Test2_param1, WordPattern_Test2_param2));
            _display.DisplayBoolean.DisplayResult(_tests.WordPattern.WordPattern1(WordPattern_Test3_param1, WordPattern_Test3_param2));

        }
        public void ReverseVowelsofaString_Tests()
        {
            _display.DisplayString.DisplayResult(_tests.ReverseVowelsofaString.ReverseVowels(ReverseVowelsofaString_TestCase1));
            _display.DisplayString.DisplayResult(_tests.ReverseVowelsofaString.ReverseVowels(ReverseVowelsofaString_TestCase2));

        }
        public void CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_Tests()
        {
            _display.DisplayInteger.DisplayResult(
                _tests.CheckIfAWordOccursAsAPrefixOfAnyWordInASentence.IsPrefixOfWord(
                    CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_TestCase1_param1,
                    CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_TestCase1_param2
                ));

            _display.DisplayInteger.DisplayResult(
                _tests.CheckIfAWordOccursAsAPrefixOfAnyWordInASentence.IsPrefixOfWord(
                    CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_TestCase2_param1,
                    CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_TestCase2_param2
                ));

            _display.DisplayInteger.DisplayResult(
                _tests.CheckIfAWordOccursAsAPrefixOfAnyWordInASentence.IsPrefixOfWord(
                    CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_TestCase3_param1,
                    CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_TestCase3_param2
                ));

            _display.DisplayInteger.DisplayResult(
                _tests.CheckIfAWordOccursAsAPrefixOfAnyWordInASentence.IsPrefixOfWord0(
                    CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_TestCase1_param1,
                    CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_TestCase1_param2
                ));

            _display.DisplayInteger.DisplayResult(
                _tests.CheckIfAWordOccursAsAPrefixOfAnyWordInASentence.IsPrefixOfWord0(
                    CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_TestCase2_param1,
                    CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_TestCase2_param2
                ));

            _display.DisplayInteger.DisplayResult(
                _tests.CheckIfAWordOccursAsAPrefixOfAnyWordInASentence.IsPrefixOfWord0(
                    CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_TestCase3_param1,
                    CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_TestCase3_param2
                ));

        }
        public void CheckIfStringIsAPrefixOfArray_Tests()
        {
            _display.DisplayBoolean.DisplayResult(
                _tests.CheckIfStringIsAPrefixOfArray.IsPrefixString(
                    CheckIfStringIsAPrefixOfArray_TestCase1_param1,
                    CheckIfStringIsAPrefixOfArray_TestCase1_param2
                ));

            _display.DisplayBoolean.DisplayResult(
                _tests.CheckIfStringIsAPrefixOfArray.IsPrefixString(
                    CheckIfStringIsAPrefixOfArray_TestCase2_param1,
                    CheckIfStringIsAPrefixOfArray_TestCase2_param2
                ));

            _display.DisplayBoolean.DisplayResult(
                _tests.CheckIfStringIsAPrefixOfArray.IsPrefixString0(
                    CheckIfStringIsAPrefixOfArray_TestCase1_param1,
                    CheckIfStringIsAPrefixOfArray_TestCase1_param2
                ));

            _display.DisplayBoolean.DisplayResult(
                _tests.CheckIfStringIsAPrefixOfArray.IsPrefixString0(
                    CheckIfStringIsAPrefixOfArray_TestCase2_param1,
                    CheckIfStringIsAPrefixOfArray_TestCase2_param2
                ));

        }
        public void CellsInARangeOnAnExcelSheet_Tests()
        {
            _display.DisplayString.DisplayResult(_tests.CellsInARangeOnAnExcelSheet.CellsInRange(CellsInARangeOnAnExcelSheet_TestCase1));
            _display.DisplayString.DisplayResult(_tests.CellsInARangeOnAnExcelSheet.CellsInRange(CellsInARangeOnAnExcelSheet_TestCase2));

        }
        public void CalculateDigitSumOfAString_Tests()
        {
            _display.DisplayString.DisplayResult(
                _tests.CalculateDigitSumOfAString.DigitSum(
                    CalculateDigitSumOfAString_TestCase1_param1,
                    CalculateDigitSumOfAString_TestCase1_param2
                ));

            _display.DisplayString.DisplayResult(
                _tests.CalculateDigitSumOfAString.DigitSum(
                    CalculateDigitSumOfAString_TestCase2_param1,
                    CalculateDigitSumOfAString_TestCase2_param2
                ));

        }
        public void CountPrefixesOfAGivenString_Tests()
        {
            _display.DisplayInteger.DisplayResult(
                _tests.CountPrefixesOfAGivenString.CountPrefixes(
                    CountPrefixesOfAGivenString_TestCase1_param1,
                    CountPrefixesOfAGivenString_TestCase1_param2
                ));

            _display.DisplayInteger.DisplayResult(
                _tests.CountPrefixesOfAGivenString.CountPrefixes(
                    CountPrefixesOfAGivenString_TestCase2_param1,
                    CountPrefixesOfAGivenString_TestCase2_param2
                ));

            _display.DisplayInteger.DisplayResult(
                _tests.CountPrefixesOfAGivenString.CountPrefixes1(
                    CountPrefixesOfAGivenString_TestCase2_param1,
                    CountPrefixesOfAGivenString_TestCase2_param2
                ));

            _display.DisplayInteger.DisplayResult(
                _tests.CountPrefixesOfAGivenString.CountPrefixes1(
                    CountPrefixesOfAGivenString_TestCase2_param1,
                    CountPrefixesOfAGivenString_TestCase2_param2
                ));

            _display.DisplayInteger.DisplayResult(
                _tests.CountPrefixesOfAGivenString.CountPrefixes2(
                    CountPrefixesOfAGivenString_TestCase2_param1,
                    CountPrefixesOfAGivenString_TestCase2_param2
                ));

            _display.DisplayInteger.DisplayResult(
                _tests.CountPrefixesOfAGivenString.CountPrefixes2(
                    CountPrefixesOfAGivenString_TestCase2_param1,
                    CountPrefixesOfAGivenString_TestCase2_param2
                ));

            _display.DisplayInteger.DisplayResult(
                _tests.CountPrefixesOfAGivenString.CountPrefixes3(
                    CountPrefixesOfAGivenString_TestCase2_param1,
                    CountPrefixesOfAGivenString_TestCase2_param2
                ));

            _display.DisplayInteger.DisplayResult(
                _tests.CountPrefixesOfAGivenString.CountPrefixes3(
                    CountPrefixesOfAGivenString_TestCase2_param1,
                    CountPrefixesOfAGivenString_TestCase2_param2
                ));

        }
        public void CheckIfNumberHasEqualDigitCountAndDigitValue_Tests()
        {
            _display.DisplayBoolean.DisplayResult(_tests.CheckIfNumberHasEqualDigitCountAndDigitValue.DigitCount(CheckIfNumberHasEqualDigitCountAndDigitValue_TestCase1));
            _display.DisplayBoolean.DisplayResult(_tests.CheckIfNumberHasEqualDigitCountAndDigitValue.DigitCount(CheckIfNumberHasEqualDigitCountAndDigitValue_TestCase2));

            _display.DisplayBoolean.DisplayResult(_tests.CheckIfNumberHasEqualDigitCountAndDigitValue.DigitCount1(CheckIfNumberHasEqualDigitCountAndDigitValue_TestCase1));
            _display.DisplayBoolean.DisplayResult(_tests.CheckIfNumberHasEqualDigitCountAndDigitValue.DigitCount1(CheckIfNumberHasEqualDigitCountAndDigitValue_TestCase2));
        }
    }
}