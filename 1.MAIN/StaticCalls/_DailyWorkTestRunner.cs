using _0.Tests._LeetCode_Easy.Tests;
using _2.Printer.Concrete;

namespace _1.Main.StaticCalls
{
    public class _DailyWorkTestRunner
    {
        private readonly TestsDailyWork _tests;

        public _DailyWorkTestRunner()
        {
            _tests = new TestsDailyWork(new DisplayTypeInstantiator());
        }
        public void RunTests()
        {
            // _tests.MaxSatisfaction_Test();
            // _tests.SimplifyPath_Test();
            // _tests.IsSubsequence_Test();
            // _tests.ValidateStackSequences_Test();
            // _tests.NrryTreePreorder_Test();
            // _tests.MergeAlternately_Test();
            // _tests.GetHint_Test();
            // _tests.DecodeString_Test();
            // _tests.BackspaceCompare_Test();
            // _tests.TopKFrequent_Test();
            // _tests.LastStoneWeight_Test();
            // _tests.FindDifference_Test();
            // _tests.SummaryRanges_Test();
            // _tests.EqualPairs_Test();
            // _tests.GetMinimumDifference_Test();
            // _tests.MergeTrees_Test();
            // _tests.MaxLevelSum_Test();
            // _tests.MoveZeroes_Test();
            // _tests.PlusOne_Test();
            // _tests.RomanToInt3_Test();
            // _tests.Tictactoe_Test();
            // _tests.AddBinary_Test();
            // _tests.CheckStraightLine_Test();
            // _tests.MyPow_Test();
            // _tests.ReverseLinkedList_Test();
            // _tests.AddTwoNumbers_Test();
            // _tests.MergeTwoLists_Test();
            // _tests.AddTwoNumbers2_Test();
            // _tests.Multiply_Test();
            _tests.SetZeroes_Test();
        }
    }
}