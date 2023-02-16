using System.Text;
using _4.SlidingWindow.Interfaces;

namespace _4.SlidingWindow.Concrete
{
    public class SlidingWindowProblems : ISlidingWindowProblems
    {
        public int MaximumSumOfConsecutiveNumbersBruteForce(int[] nums, int k)
        {
            var maxSum = 0;
            for (int i = 0; i <= nums.Length - k; i++)
            {
                var currentSum = 0;

                for (int j = i; j < k + i; j++)
                {
                    currentSum += nums[j];
                }

                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }

        public int MaximumSumOfConsecutiveNumbers_v1(int[] nums, int k)
        {
            var maxSum = int.MinValue;
            var currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];
                if (i >= k - 1) // We increment i and do the sum till we reach the end of our window
                {
                    maxSum = Math.Max(maxSum, currentSum); // We check if the sum is higher than the maximum sum
                    currentSum -= nums[i - (k - 1)]; // We substract the element at the start of the window 
                                                     // i is the current index where we are at and we need to do k-1 because of the index window.
                }
            }

            return maxSum;
        }

        public int MaximumSumOfConsecutiveNumbers_v2(int[] nums, int k)
        {
            var maxSum = int.MinValue;
            var currentSum = 0;

            // First window sum
            for (int i = 0; i < k; i++)
            {
                currentSum += nums[i];
            }

            for (int i = k; i < nums.Length; i++)
            {
                currentSum += nums[i] - nums[i - k];
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }

        // BAD LOOP 
        public string DisplayWindow_v1(int[] arr, int k)
        {
            var stringBuilder = new StringBuilder();

            // Won't work this way because the loop will stop too son
            for (int i = 0; i < arr.Length - k; i++)
            {
                if (i >= k - 1)
                {
                    i += k;
                    stringBuilder.AppendLine();
                }

                stringBuilder.Append($"{arr[i]}");
            }

            return stringBuilder.ToString();
        }

        public string DisplayWindow_v2(int[] arr, int k)
        {
            var stringBuilder = new StringBuilder();

            var j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                // This is more like a two pointer solution
                if (j > k - 1)
                {
                    stringBuilder.AppendLine();
                    j = 0;
                }
                stringBuilder.Append($"{arr[i]} ");

                j++;
            }

            return stringBuilder.ToString();
        }

        public string DisplayWindow_v3(int[] arr, int k)
        {
            var queue = new Queue<int>();
            var whiteSpaceIndent = 0;

            for (int i = 0; i < k; i++)
            {
                queue.Enqueue(arr[i]);
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                queue.Dequeue();
                queue.Enqueue(arr[i + 1]);

                if (i + k <= arr.Length)
                    PrintTheWindowWithPointers_v1(arr, i, i + k, whiteSpaceIndent);

                whiteSpaceIndent++;
            }

            return string.Empty;
        }

        private void PrintTheWindowWithPointers_v1(int[] arr, int leftPointer, int rightPointer, int indent)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append(' ', indent);

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == leftPointer)
                    stringBuilder.Append("[ ");

                if (i == rightPointer)
                    stringBuilder.Append(" ]");

                stringBuilder.Append($"{arr[i]}");
            }

            if (rightPointer == arr.Length)
                stringBuilder.Append(" ]");

            Console.WriteLine(stringBuilder.ToString());
        }

        // Just a try
        private void PrintTheWindow_v1(Queue<int> window)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append('[');
            foreach (var element in window)
            {
                stringBuilder.Append(element).Append(' ');
            }
            stringBuilder.Append(']');

            Console.WriteLine(stringBuilder.ToString());
        }

        public int[][] MatrixFromWindows(int[] arr, int k)
        {
            var res = Enumerable
                    .Range(0, arr.Length - (k - 1))
                    .Select(i => new int[arr.Length / (k - 1)])
                    .ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < k; i++)
            {
                queue.Enqueue(arr[i]);
            }

            Array.Copy(queue.ToArray(), res[0], 4);
            for (int i = k; i < arr.Length; i++)
            {
                queue.Enqueue(arr[i]);
                queue.Dequeue();
                Array.Copy(queue.ToArray(), res[Math.Abs(i - k + 1)], 4);
            }

            return res;
        }

        public int[] SumOfEachWindow(int[] arr, int k)
        {
            var res = new int[arr.Length - 2];
            var sum = 0;

            for (int i = 0; i < k; i++)
            {
                sum += arr[i];
            }

            res[0] = sum;
            for (int i = k - 1; i < arr.Length; i++)
            {
                if (i >= k)
                {
                    sum += arr[k + (i - k)];
                    sum -= arr[i - k];
                }

                res[i - 2] = sum;
            }

            return res;
        }

        public int MinimumOfEachSubarraySlidingWindow(int[] arr, int k)
        {
            var minSum = 0;

            for (int i = 0; i < k; i++)
            {
                minSum += arr[i];
            }

            var currentSum = minSum;
            for (int i = k - 1; i < arr.Length - 1; i++)
            {
                currentSum += arr[i + 1];
                currentSum -= arr[i - k + 1];

                if (currentSum < minSum) minSum = currentSum;
            }

            return minSum;
        }

        public int[] PairThatContainsMinimumElementInArray(int[] arr, int k)
        {
            var res = new int[2];
            var min = int.MaxValue;
            res[0] = arr[0];
            res[1] = arr[1];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (i >= k)
                {
                    Console.WriteLine($"Pair n1: {arr[i]} n2: {arr[i + (k - 1)]}");
                    if (min > arr[i] || min > arr[i + (k - 1)])
                    {
                        res[0] = arr[i];
                        res[1] = arr[i + (k - 1)];
                        if (min > arr[i]) min = arr[i];
                        else min = arr[i + (k - 1)];
                    }
                }
            }

            return res;
        }

        public int CountGoodSubstrings_v1(string s)
        {
            var k = 3;
            var count = 0;

            for (int i = 0; i < s.Length - k + 1; i++)
            {
                if (s.Substring(i, k).ToHashSet().Count == 3) count++;
            }

            return count;
        }

        public int CountGoodSubstrings_v2(string s)
        {
            var charArray = s.ToCharArray();
            var k = 1;
            var count = 0;

            for (int i = k - 1; i < s.Length; i++)
            {
                if (charArray[i - k + 1] != charArray[i - 1] &&
                    charArray[i - k + 1] != charArray[i] &&
                    charArray[i - 1] != charArray[i])
                    count++;
            }

            return count;
        }

        public int MaxScore(int[] cardPoints, int k)
        {
            var currentSum = 0;
            var maxScore = int.MinValue;
            var pointerRight = 0;

            for (int i = 0; i < k; i++)
            {
                currentSum += cardPoints[i];
            }

            maxScore = currentSum;
            for (var i = 0; i < k; i++)
            {
                currentSum += cardPoints[cardPoints.Length - pointerRight - 1];
                currentSum -= cardPoints[k - i - 1];

                maxScore = Math.Max(maxScore, currentSum);
                pointerRight++;
            }

            return maxScore;
        }

        public int MaxScoreLeetCodeSolution(int[] cardPoints, int k)
        {
            var n = cardPoints.Length;
            var res = 0;

            // n - k makes more sense, in my solution I started from the left prefix sum
            for (int i = n - k; i < n; i++) res += cardPoints[i];

            for (int i = 0, s = res; i < k; i++)
            {
                s -= cardPoints[n - k + i];
                s += cardPoints[i];
                res = Math.Max(res, s);
            }

            return res;
        }

        public int MinimumRecolors(string blocks, int k)
        {
            var recolorCount = 0;
            var minimumRecolorCount = int.MaxValue;
            var len = blocks.Length;

            for (int i = 0; i < len; i++)
            {
                if (blocks[i] == 'W') recolorCount++;

                if (i >= k - 1)
                {
                    if (recolorCount < minimumRecolorCount)
                        minimumRecolorCount = recolorCount;

                    if (blocks[i - (k - 1)] == 'W')
                    {
                        recolorCount--;
                    }
                }
            }

            return minimumRecolorCount;
        }
  
        
   }
}