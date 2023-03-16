using _0.Tests._LeetCode_Easy.Tests.Struggle.BitManipulation;
using _0.Tests._LeetCode_Easy.Tests.Struggle.Misc;
using _0.Tests._LeetCode_Easy.Tests.Struggle.MultidimensionalArrays;
using _0.Tests._LeetCode_Easy.Tests.Struggle.PrefixSum;
using _0.Tests._LeetCode_Easy.Tests.Struggle.Strings;
using _0.Tests.Tests.Struggle.Arrays;
using _1.Main.StaticCalls._LeetCode_Easy.Helper;
using _2.Printer.Concrete;
namespace _1.Main.StaticCalls._LeetCode_Easy.Helper
{
    public class StruggleProblemsTestRunnerInitializer
    {
        protected readonly TestsStruggleArrays _testsArrays;
        protected readonly TestsStruggleBitManipulation _testsBitManipulation;
        protected readonly TestsStruggleStrings _testsStruggleStrings;
        protected readonly TestsStrugglePrefixSum _testsStrugglePrefixSum;
        protected readonly TestsMultidimensionalArrays _testsMultidimensionalArrays;
        protected readonly TestsStruggleMisc _testsStruggleMisc;

        public StruggleProblemsTestRunnerInitializer()
        {
            _testsArrays = new TestsStruggleArrays(new DisplayTypeInstantiator());
            _testsBitManipulation = new TestsStruggleBitManipulation(new DisplayTypeInstantiator());
            _testsStruggleMisc = new TestsStruggleMisc(new DisplayTypeInstantiator());
            _testsStruggleStrings = new TestsStruggleStrings(new DisplayTypeInstantiator());
            _testsStrugglePrefixSum = new TestsStrugglePrefixSum(new DisplayTypeInstantiator());
            _testsMultidimensionalArrays = new TestsMultidimensionalArrays(new DisplayTypeInstantiator());
        }
    }
}