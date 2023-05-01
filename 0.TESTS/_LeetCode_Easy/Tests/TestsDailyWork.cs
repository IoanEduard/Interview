using _14.N_ary___Trees.Concrete;
using _2.Printer.Concrete;
using _LeetCode_Easy.Concrete;

namespace _0.Tests._LeetCode_Easy.Tests
{
    public class TestsDailyWork : _TestsCases
    {
        private readonly DisplayTypeInstantiator _display;
        private readonly _DailyWorkFile _dailyWork;

        public TestsDailyWork(DisplayTypeInstantiator display)
        {
            _display = display;
            _dailyWork = new _DailyWorkFile();
        }

        public void MaxSatisfaction_Test()
        {
            _display.DisplayInteger.DisplayResult(_dailyWork.MaxSatisfaction(new int[] { -1, -8, 0, 5, -9 }));
        }

        public void SimplifyPath_Test()
        {
            _display.DisplayString.DisplayResult(_dailyWork.SimplifyPath("/home/aab/"));
        }

        public void IsSubsequence_Test()
        {
            _display.DisplayBoolean.DisplayResult(_dailyWork.IsSubsequence("acb", "ahbgdc"));
        }

        public void ValidateStackSequences_Test()
        {
            _display.DisplayBoolean.DisplayResult(_dailyWork.ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 2, 1 }));
        }

        public void NrryTreePreorder_Test()
        {
            var root = new Node();
            root.val = 1;

            root.children = new List<Node>()
            {
                new Node(2, new List<Node>()),
                new Node(3, new List<Node>() {
                                new Node(6),
                                new Node(7, new List<Node>() {
                                    new Node(11, new List<Node>() {
                                        new Node(14)
                                    })
                                })
                            }),

                new Node(4, new List<Node>() {
                    new Node(8, new List<Node>() {
                        new Node(12)
                    })
                }),

                new Node(5, new List<Node>() {
                    new Node(9, new List<Node>() {
                        new Node(13)
                    }),
                    new Node(10)
                }),
            };

            _display.DisplayInteger.DisplayResult(_dailyWork.NrryTreePreorder(root));
        }

        public void MergeAlternately_Test()
        {
            _display.DisplayString.DisplayResult(_dailyWork.MergeAlternately("abc", "pqr"));
            _display.DisplayString.DisplayResult(_dailyWork.MergeAlternately("ab", "pqrs"));
            _display.DisplayString.DisplayResult(_dailyWork.MergeAlternately("abcd", "pq"));
        }

        public void GetHint_Test()
        {
            // _display.DisplayString.DisplayResult(_dailyWork.GetHint("1807", "7810"));
            // _display.DisplayString.DisplayResult(_dailyWork.GetHint("1123", "0111"));
            _display.DisplayString.DisplayResult(_dailyWork.GetHint("11", "10"));
        }

        public void DecodeString_Test()
        {
            // _display.DisplayString.DisplayResult(_dailyWork.DecodeString("3[a]2[bc]"));

            // _display.DisplayString.DisplayResult(_dailyWork.DecodeString("3[a2[c]]"));
            // _display.DisplayString.DisplayResult(_dailyWork.DecodeString("3[a2[c]]5[d]"));

            // _display.DisplayString.DisplayResult(_dailyWork.DecodeString("2[abc]3[cd]ef"));
        }

        public void BackspaceCompare_Test()
        {
            _display.DisplayBoolean.DisplayResult(_dailyWork.BackspaceCompare("ab##", "c#d#"));
        }

        public void TopKFrequent_Test()
        {
            _display.DisplayString.DisplayResult(_dailyWork.TopKFrequent(new string[] { "i", "love", "leetcode", "i", "love", "coding" }, 2));
        }

        public void LastStoneWeight_Test()
        {
            _display.DisplayInteger.DisplayResult(_dailyWork.LastStoneWeight(new int[] { 2,7,4,1,8,1 }));
        }
    }
}