namespace _4.SlidingWindow.Interfaces
{
    public interface ISlidingWindowProblems
    {
        int CountGoodSubstrings_v1(string s);

        int CountGoodSubstrings_v2(string s);

        int[] PairThatContainsMinimumElementInArray(int[] arr, int k);

        int MaximumSumOfConsecutiveNumbersBruteForce(int[] nums, int k);

        int MaximumSumOfConsecutiveNumbers_v1(int[] nums, int k);

        int MaximumSumOfConsecutiveNumbers_v2(int[] nums, int k);

        /// <summary>
        /// Failed Attempt 1
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        string DisplayWindow_v1(int[] arr, int k);

        /// <summary>
        /// Failed Attempt 2
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        string DisplayWindow_v2(int[] arr, int k);

        string DisplayWindow_v3(int[] arr, int k);

        /// <summary>
        /// Create a 2d array from each window 
        /*
         arr = [2,3,5,2,6,7,3,4,7,9,7,5] k = 4

        2dArray
            (a) [2,3,5,2]
                [6,7,3,4]
                [7,9,7,5]
        More like a two pointer approach.

            (b) [2,3,5,2]
                [3,5,2,6]
                [5,2,6,7]
                [2,6,7,3]
                [6,7,3,4]
                [7,3,4,7]
                [3,4,7,9]
                [4,7,9,7]
                [7,9,7,5]
                    
        arr.length = 12 => 4x9 matrix 
                        => row = arr.length / (k-1)
                        => col = arr.length - (k-1)

        As I add i to k in a queue
            i >= k-1
                Convert queue to array and add it as a row
                Dequeue value
                Enqueue next value
         */
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        int[][] MatrixFromWindows(int[] arr, int k);

        /// <summary>
        /// Create an array with sum of each window
        /*arr = [2,3,5,2,6,7,3,1,7,9,7,5] k = 3

                   2+3+5 = 10
                   3+5+2 = 10
                   5+2+6 = 13
                   2+6+7 = 15
                   6+7+3 = 16
                   7+3+4 = 14
                   3+4+7 = 14
                   4+7+9 = 20
                   7+9+7 = 23
                   9+7+5 = 21
        */
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        int[] SumOfEachWindow(int[] arr, int k);
        int MinimumOfEachSubarraySlidingWindow(int[] arr, int k);
        int MaxScore(int[] cardPoints, int k);
        int MaxScoreLeetCodeSolution(int[] cardPoints, int k);
        int MinimumRecolors(string blocks, int k);
        bool ContainsNearbyDuplicate(int[] array, int k);
        double FindMaxAverage(int[] array, int k);
        int CountGoodSubstrings(string s);
        int MinimumDifference(int[] nums, int k);
         int DivisorSubstrings(int num, int k);
         int NumOfSubarrays(int[] arr, int k, int threshold);
         int NumberOfSubstrings(string s);
         int LongestOnes(int[] nums, int k);
    }
}