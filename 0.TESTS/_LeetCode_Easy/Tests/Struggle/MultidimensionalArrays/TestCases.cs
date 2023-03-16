namespace _0.Tests._LeetCode_Easy.Tests.Struggle.MultidimensionalArrays
{
    public class TestCases
    {
        protected static readonly int[][] FlippingAnImage_TestCase1 = new int[][] {
            new int[] {1,1,0},
            new int[] {1,0,1},
            new int[] {0,0,0}
        };

        protected static readonly int[][] FlippingAnImage_TestCase2 = new int[][] {
            new int[] {1,1,0,0},
            new int[] {1,0,0,1},
            new int[] {0,1,1,1},
            new int[] {1,0,1,0}
        };

        protected static readonly int CellsWithOddValuesInAMatrix_TestCase1_param1 = 2;
        protected static readonly int CellsWithOddValuesInAMatrix_TestCase1_param2 = 3;
        protected static readonly int[][] CellsWithOddValuesInAMatrix_TestCase1_param3 = new int[][] {
            new int[] {0,1},
            new int[] {1,1},
        };
        protected static readonly int CellsWithOddValuesInAMatrix_TestCase2_param1 = 2;
        protected static readonly int CellsWithOddValuesInAMatrix_TestCase2_param2 = 2;
        protected static readonly int[][] CellsWithOddValuesInAMatrix_TestCase2_param3 = new int[][] {
            new int[] {1,1},
            new int[] {0,0},
        };
        protected static readonly int[][] MinimumTimeVisitingAllPoints_TestCase1 = new int[][] {
            new int[] {1,1},
            new int[] {3,4},
            new int[] {-1,0}
        };
        protected static readonly int[][] MinimumTimeVisitingAllPoints_TestCase2 = new int[][] {
            new int[] {3,2},
            new int[] {-2,2},
        };
        protected static readonly int[][] TheKWeakestRowsInAMatrix_TestCase1_param1 = new int[][] {
            new int[] {1,1,0,0,0},
            new int[] {1,1,1,1,0},
            new int[] {1,0,0,0,0},
            new int[] {1,1,0,0,0},
            new int[] {1,1,1,1,1}
        };
        protected static readonly int TheKWeakestRowsInAMatrix_TestCase1_param2 = 3;
        protected static readonly int[][] TheKWeakestRowsInAMatrix_TestCase2_param1 = new int[][] {
            new int[] {1,0,0,0},
            new int[] {1,1,1,1},
            new int[] {1,0,0,0},
            new int[] {1,0,0,0},
        };
        protected static readonly int TheKWeakestRowsInAMatrix_TestCase2_param2 = 2;

        protected static readonly int[][] CheckIfEveryRowAndColumnContainsAllNumbers_TestCase1 = new int[][] {
            new int[] {1,2,3},
            new int[] {13,1,2},
            new int[] {2,3,1},
        };
        protected static readonly int[][] CheckIfEveryRowAndColumnContainsAllNumbers_TestCase2 = new int[][] {
            new int[] {1,1,1},
            new int[] {1,2,3},
            new int[] {1,2,3},
        };
    }
}