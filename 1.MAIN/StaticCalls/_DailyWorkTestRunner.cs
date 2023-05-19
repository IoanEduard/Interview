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
            _tests.FindDifference_Test();
        }
    }
}