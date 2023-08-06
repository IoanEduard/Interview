using _14.N_ary___Trees.Concrete;
using _14.Trees.Concrete;
using _2.Printer.Concrete;
using _7.LinkedLists.Concrete;
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
            _display.DisplayInteger.DisplayResult(_dailyWork.LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 }));
        }

        public void FindDifference_Test()
        {
            var result = _dailyWork.FindDifference(new int[] { 1, 2, 3 }, new int[] { 2, 4, 6 });

            foreach (var item in result)
            {
                _display.DisplayInteger.DisplayResult(item);
            }
        }

        public void SummaryRanges_Test()
        {
            var result = _dailyWork.SummaryRanges(new int[] { 0, 1, 2, 4, 5, 7 });
            // var result = _dailyWork.SummaryRanges(new int[] { 0, 2, 3, 4, 6, 8, 9 });
            foreach (var item in result)
            {
                _display.DisplayString.DisplayResult(item);
            }
        }

        public void EqualPairs_Test()
        {
            // var result = _dailyWork.EqualPairs(new int[][] {
            //     new int[] {3,1,2,2},
            //     new int[] {1,4,4,5},
            //     new int[] {2,4,2,2},
            //     new int[] {2,4,2,2}
            //  });

            var result = _dailyWork.EqualPairs(new int[][] {
                new int[] {13,13},
                new int[] {13,13}
             });

            _display.DisplayInteger.DisplayResult(result);
        }

        public void GetMinimumDifference_Test()
        {
            var root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.right = new TreeNode(6);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);

            var result = _dailyWork.GetMinimumDifference(root);
            _display.DisplayInteger.DisplayResult(result);
        }

        public void MergeTrees_Test()
        {
            TreeNode root1 = new TreeNode(1);
            root1.left = new TreeNode(3);
            root1.right = new TreeNode(2);
            root1.left.left = new TreeNode(5);

            TreeNode root2 = new TreeNode(2);
            root2.left = new TreeNode(1);
            root2.right = new TreeNode(3);
            root2.left.right = new TreeNode(4);
            root2.right.right = new TreeNode(7);

            var result = _dailyWork.MergeTrees(root1, root2);
        }

        public void MaxLevelSum_Test()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(7);
            root.right = new TreeNode(0);
            root.left.left = new TreeNode(7);
            root.left.right = new TreeNode(-8);

            var result = _dailyWork.MaxLevelSum(root);
        }

        public void MoveZeroes_Test()
        {
            _display.DisplayInteger.DisplayResult(_dailyWork.MoveZeroes(new int[] { 0, 1, 0, 3, 12 }));
        }

        public void PlusOne_Test()
        {
            _display.DisplayInteger.DisplayResult(_dailyWork.PlusOne(new int[] { 9, 9 }));
        }

        public void RomanToInt3_Test()
        {
            _display.DisplayInteger.DisplayResult(_dailyWork.RomanToInt3("MCMXCIV"));
        }

        public void Tictactoe_Test()
        {
            _display.DisplayString.DisplayResult(_dailyWork.Tictactoe(new int[][] {
                new int[] {0,0},
                new int[] {2,0},
                new int[] {1,1},
                new int[] {2,1},
                new int[] {2,2},
            }));

            // _display.DisplayString.DisplayResult(_dailyWork.Tictactoe(new int[][] {
            //     new int[] {0,0},
            //     new int[] {1,1},
            //     new int[] {0,1},
            //     new int[] {0,2},
            //     new int[] {1,0},
            //     new int[] {2,0},
            // }));
        }

        public void AddBinary_Test()
        {
            _display.DisplayString.DisplayResult(_dailyWork.AddBinary("1010", "1011"));
        }

        public void CheckStraightLine_Test()
        {
            // _display.DisplayBoolean.DisplayResult(_dailyWork.CheckStraightLine(new int[][] {
            //     new int[] {1,2},
            //     new int[] {2,3},
            //     new int[] {3,4},
            //     new int[] {4,5},
            //     new int[] {5,6},
            //     new int[] {6,7},
            // }));

            _display.DisplayBoolean.DisplayResult(_dailyWork.CheckStraightLine(new int[][] {
                new int[] {0,0},
                new int[] {0,1},
                new int[] {0,-1},
            }));
        }

        public void MyPow_Test()
        {
            _display.DisplayDouble.DisplayResult(_dailyWork.MyPow(2.00000, 2));
        }

        public void ReverseLinkedList_Test()
        {
            ListNode head = new ListNode(10);
            ListNode node1 = new ListNode(20);
            ListNode node2 = new ListNode(30);
            ListNode node3 = new ListNode(40);
            ListNode node4 = new ListNode(50);
            ListNode node5 = new ListNode(60);

            head.next = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            _display.DisplayListNode.DisplayResult(head);
            _display.DisplayString.DisplayResult("Reversing linked list");
            _display.DisplayListNode.DisplayResult(_dailyWork.ReverseList(head));
        }


        public void AddTwoNumbers_Test()
        {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            _display.DisplayListNode.DisplayResult(_dailyWork.AddTwoNumbers(l1, l2));
        }

        public void MergeTwoLists_Test()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            _display.DisplayListNode.DisplayResult(_dailyWork.MergeTwoLists(l1, l2));
        }

        public void AddTwoNumbers2_Test()
        {
            ListNode l1 = new ListNode(7);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);
            l1.next.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            _display.DisplayListNode.DisplayResult(_dailyWork.AddTwoNumbers2(l1, l2));
        }

        public void Multiply_Test()
        {
            // _display.DisplayString.DisplayResult(_dailyWork.Multiply("123", "456"));
            // _display.DisplayString.DisplayResult(_dailyWork.Multiply("9", "9"));
            // _display.DisplayString.DisplayResult(_dailyWork.Multiply("9", "99"));
            // _display.DisplayString.DisplayResult(_dailyWork.Multiply("9999", "9999"));
            // _display.DisplayString.DisplayResult(_dailyWork.Multiply("237", "284"));
            // _display.DisplayString.DisplayResult(_dailyWork.Multiply("3", "38"));
            // _display.DisplayString.DisplayResult(_dailyWork.Multiply("65539", "83314"));
            _display.DisplayString.DisplayResult(_dailyWork.Multiply("123456789", "987654321"));
        }

        public void SetZeroes_Test()
        {
            // int[][] matrix = new int[][]
            // {
            //     new int[] { 1, 1, 1 },
            //     new int[] { 1, 0, 1 },
            //     new int[] { 1, 1, 1 }
            // };

            int[][] matrix = new int[][]
            {
                new int[] { 0, 1 },
                // new int[] { 0, 1 },
            };

            _dailyWork.SetZeroes(matrix);
        }
    }
}