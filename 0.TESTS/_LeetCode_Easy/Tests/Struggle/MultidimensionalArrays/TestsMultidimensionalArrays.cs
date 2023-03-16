using _2.Printer.Concrete;

namespace _0.Tests._LeetCode_Easy.Tests.Struggle.MultidimensionalArrays
{
    public class TestsMultidimensionalArrays : TestCases
    {
        private readonly TestsMultidimensionalArraysClassFactory _tests;
        private readonly DisplayTypeInstantiator _display;

        public TestsMultidimensionalArrays(DisplayTypeInstantiator display)
        {
            _display = display;
            _tests = new TestsMultidimensionalArraysClassFactory();
        }

        public void FlippingAnImage_Tests()
        {
            _display.DisplayInteger.DisplayResult(_tests.FlippingAnImage.FlipAndInvertImage(FlippingAnImage_TestCase1));
            _display.DisplayInteger.DisplayResult(_tests.FlippingAnImage.FlipAndInvertImage(FlippingAnImage_TestCase2));
        }

        public void CellsWithOddValuesInAMatrix_Tests()
        {
            _display.DisplayInteger.DisplayResult(_tests.CellsWithOddValuesInAMatrix.OddCells(
                CellsWithOddValuesInAMatrix_TestCase1_param1,
                CellsWithOddValuesInAMatrix_TestCase1_param2,
                CellsWithOddValuesInAMatrix_TestCase1_param3
            ));

            _display.DisplayInteger.DisplayResult(_tests.CellsWithOddValuesInAMatrix.OddCells(
                CellsWithOddValuesInAMatrix_TestCase2_param1,
                CellsWithOddValuesInAMatrix_TestCase2_param2,
                CellsWithOddValuesInAMatrix_TestCase2_param3
            ));
        }

        public void MinimumTimeVisitingAllPoints_Tests()
        {
            _display.DisplayInteger.DisplayResult(_tests.MinimumTimeVisitingAllPoints.MinTimeToVisitAllPoints(
                MinimumTimeVisitingAllPoints_TestCase1
            ));

            _display.DisplayInteger.DisplayResult(_tests.MinimumTimeVisitingAllPoints.MinTimeToVisitAllPoints(
                MinimumTimeVisitingAllPoints_TestCase2
            ));
        }

        public void TheKWeakestRowsInAMatrix_Tests()
        {
            _display.DisplayInteger.DisplayResult(_tests.TheKWeakestRowsInAMatrix.KWeakestRows(
                TheKWeakestRowsInAMatrix_TestCase1_param1,
                TheKWeakestRowsInAMatrix_TestCase1_param2
            ));

            _display.DisplayInteger.DisplayResult(_tests.TheKWeakestRowsInAMatrix.KWeakestRows(
                TheKWeakestRowsInAMatrix_TestCase2_param1,
                TheKWeakestRowsInAMatrix_TestCase2_param2
            ));
        }

        public void CheckIfEveryRowAndColumnContainsAllNumbers_Tests()
        {
            _display.DisplayBoolean.DisplayResult(_tests.CheckIfEveryRowAndColumnContainsAllNumbers.CheckValid(
                CheckIfEveryRowAndColumnContainsAllNumbers_TestCase1
            ));

            _display.DisplayBoolean.DisplayResult(_tests.CheckIfEveryRowAndColumnContainsAllNumbers.CheckValid2(
                CheckIfEveryRowAndColumnContainsAllNumbers_TestCase2
            ));
        }
    }
}