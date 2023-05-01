using _0.Tests._LeetCode_Medium.Interfaces;
using _2.Printer.Concrete;
using _LeetCode_Medium.Concrete.Struggle;

namespace _0.Tests._LeetCode_Medium.Tests.Struggle
{
    public class TestsLeetCodeMediumStruggle : _TestCases, ITestsStruggle
    {
        private readonly DisplayTypeInstantiator _display;
        private readonly StruggleMedium _leetCodeMediumStruggle;

        public TestsLeetCodeMediumStruggle(DisplayTypeInstantiator display)
        {
            _display = display;
            _leetCodeMediumStruggle = new StruggleMedium();
        }

        public void MaxScore1_Test()
        {
            _display.DisplayInteger.DisplayResult(
                _leetCodeMediumStruggle.MaximumPointsYouCanObtainFromCards.MaxScore1(MaxScore_TestCase1_param1, MaxScore_TestCase1_param2));
        }

        public void MaxScore_Test()
        {
            _display.DisplayInteger.DisplayResult(
                _leetCodeMediumStruggle.MaximumPointsYouCanObtainFromCards.MaxScore1(MaxScore_TestCase1_param1, MaxScore_TestCase1_param2));
        }

        public void ProductExceptSelf2_Test()
        {
            _display.DisplayInteger.DisplayResult(
                _leetCodeMediumStruggle.ProductofArrayExceptSelf.ProductExceptSelf2(ProductExceptSelf_TestCase1));

            _display.DisplayInteger.DisplayResult(
                _leetCodeMediumStruggle.ProductofArrayExceptSelf.ProductExceptSelf2(ProductExceptSelf_TestCase2));
        }

        public void ProductExceptSelfBruteForce_Test()
        {
            _display.DisplayInteger.DisplayResult(
                _leetCodeMediumStruggle.ProductofArrayExceptSelf.ProductExceptSelfBruteForce(ProductExceptSelf_TestCase1));

            _display.DisplayInteger.DisplayResult(
                _leetCodeMediumStruggle.ProductofArrayExceptSelf.ProductExceptSelfBruteForce(ProductExceptSelf_TestCase2));
        }

        public void ProductExceptSelf_Test()
        {
            _display.DisplayInteger.DisplayResult(
                _leetCodeMediumStruggle.ProductofArrayExceptSelf.ProductExceptSelf(ProductExceptSelf_TestCase1));

            _display.DisplayInteger.DisplayResult(
                _leetCodeMediumStruggle.ProductofArrayExceptSelf.ProductExceptSelf(ProductExceptSelf_TestCase2));
        }

        public void RotateFail_Test()
        {
            _display.DisplayInteger.DisplayResult(
                _leetCodeMediumStruggle.RotateArray.RotateFail(RotateArray_TestCase1_param1, RotateArray_TestCase1_param2));

            _display.DisplayInteger.DisplayResult(
                _leetCodeMediumStruggle.RotateArray.RotateFail(RotateArray_TestCase2_param1, RotateArray_TestCase2_param2));
        }

        public void Rotate_Test()
        {
            _leetCodeMediumStruggle.RotateArray.Rotate(RotateArray_TestCase1_param1, RotateArray_TestCase1_param2);
            _leetCodeMediumStruggle.RotateArray.Rotate(RotateArray_TestCase2_param1, RotateArray_TestCase2_param2);
        }

        public void WaysToBuyPensPencils_Test()
        {
            _leetCodeMediumStruggle.NumberOfWaysToBuyPensAndPencils
                .WaysToBuyPensPencils(WaysToBuyPensPencils_TestCase1_param1, WaysToBuyPensPencils_TestCase1_param2, WaysToBuyPensPencils_TestCase1_param3);

            _leetCodeMediumStruggle.NumberOfWaysToBuyPensAndPencils
                .WaysToBuyPensPencils(WaysToBuyPensPencils_TestCase2_param1, WaysToBuyPensPencils_TestCase2_param2, WaysToBuyPensPencils_TestCase2_param3);
        }

        public void NumberOfClosedIslands_Test()
        {
            _display.DisplayInteger.DisplayResult(
                _leetCodeMediumStruggle.NumberOfClosedIslands.ClosedIsland(NumberOfClosedIslands_TestCase1));

            _display.DisplayInteger.DisplayResult(
                _leetCodeMediumStruggle.NumberOfClosedIslands.ClosedIsland(NumberOfClosedIslands_TestCase2));

            _display.DisplayInteger.DisplayResult(
                _leetCodeMediumStruggle.NumberOfClosedIslands.ClosedIsland(NumberOfClosedIslands_TestCase3));
        }
    }
}