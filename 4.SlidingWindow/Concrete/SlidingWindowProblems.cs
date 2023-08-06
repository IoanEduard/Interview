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

        public int MinimumRecolors0(string blocks, int k)
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

        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var hash = new HashSet<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (i > k) hash.Remove(nums[i - k - 1]);

                if (hash.Contains(nums[i])) return true;
                else hash.Add(nums[i]);
            }

            return false;
        }

        public double FindMaxAverage(int[] nums, int k)
        {
            double maxAvg = double.MinValue;
            double sum = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (i > k)
                {
                    sum -= nums[i - k - 1];
                    double avg = sum / (double)k;
                    if (avg > maxAvg) maxAvg = avg;
                }

                sum += nums[i];
            }

            return maxAvg;
        }

        public int CountGoodSubstrings(string s)
        {
            var count = 0;
            var k = 3;

            for (var i = k - 1; i < s.Length - 1; i++)
            {
                if (s[i] != s[i - 1] &&
                    s[i - k + 1] != s[i] &&
                    s[i - k + 1] != s[i - 1])

                    count++;
            }

            return count;
        }

        public int CountGoodSubstrings2(string s)
        {
            var count = 0;
            var k = 3;

            for (var i = 0; i < s.Length - 1; i++)
            {
                if (s.Substring(i, k).ToHashSet().Count == 3)
                    count++;
            }

            return count;
        }

        public int MinimumDifference(int[] nums, int k)
        {
            Array.Sort(nums);

            var result = int.MaxValue;
            var currentDifference = 0;

            for (var i = k - 1; i < nums.Length; i++)
            {
                currentDifference = nums[i] - nums[i - k + 1];
                result = Math.Min(result, currentDifference);
            }

            return result;
        }

        public int DivisorSubstrings(int num, int k)
        {
            var n = num.ToString();
            var count = 0;

            for (var i = k - 1; i < n.Length; i++)
            {
                var number = int.Parse(n.Substring(i - k + 1, k));
                if (number != 0 && num % number == 0) count++;
            }

            return count;
        }

        public int NumOfSubarrays(int[] arr, int k, int threshold)
        {
            var sum = 0;
            var count = 0;

            for (var i = 0; i < k; i++) sum += arr[i];
            if (sum / k >= threshold) count++;

            for (var i = k; i < arr.Length; i++)
            {
                sum += arr[i];
                sum -= arr[i - k];

                if (sum / k >= threshold)
                    count++;
            }

            return count;
        }

        public int MinimumRecolors(string blocks, int k)
        {
            var minimum = int.MaxValue;
            var currentMinimum = 0;

            for (var i = 0; i < blocks.Length; i++)
            {
                if (blocks[i] == 'W') currentMinimum++;

                if (i >= k - 1)
                {
                    minimum = Math.Min(currentMinimum, minimum);

                    if (blocks[i - k - 1] == 'W')
                        currentMinimum--;
                }
            }

            return minimum;
        }

        public int NumberOfSubstrings(string s)
        {
            var count = 0;

            var abc = new int[] { 0, 0, 0 };
            var k = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a') abc[0]++;
                if (s[i] == 'b') abc[1]++;
                if (s[i] == 'c') abc[2]++;

                while (abc[0] > 0 && abc[1] > 0 && abc[2] > 0)
                {
                    count += s.Length - i;

                    if (s[k] == 'a') abc[0]--;
                    if (s[k] == 'b') abc[1]--;
                    if (s[k] == 'c') abc[2]--;
                    k++;
                }
            }

            return count;
        }

        public int LongestOnes(int[] nums, int k)
        {
            var resultCount = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                var count = 0;
                var zeroCount = nums[i] == 0 ? 1 : 0;

                var j = i;
                while (zeroCount <= k && j < nums.Length)
                {
                    if (nums[j] == 0)
                        zeroCount++;

                    count++;
                    j++;
                }

                resultCount = Math.Max(count, resultCount);
            }

            return resultCount;
        }

        public int LongestSubarray(int[] nums)
        {
            var zeroCount = 0;
            var longestWindow = 0;
            var left = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    zeroCount++;

                while (zeroCount > 1)
                {
                    if (nums[left] == 0)
                        zeroCount--;

                    left++;
                }

                longestWindow = Math.Max(longestWindow, i - left);
            }

            return longestWindow;
        }

        public int NumberOfSubarrays(int[] nums, int k)
        {
            var countOdd = 0;
            var left = 0;
            var countSubarrays = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                    countOdd++;

                if (countOdd == k)
                {
                    countSubarrays++;

                    left++;
                    i = left;
                }
            }

            return countSubarrays;
        }

        // https://leetcode.com/problems/maximum-points-you-can-obtain-from-cards/solutions/2198002/c-solution-using-sliding-window/
        public int MaxScore2(int[] cardPoints, int k)
        {
            var count = 0;

            for (var i = 0; i < k; i++)
                count += cardPoints[i];

            var current = count;
            for (var i = k - 1; i >= 0; i--)
            {
                current -= cardPoints[i];
                current += cardPoints[cardPoints.Length - k + i];

                count = Math.Max(current, count);
            }

            return count;
        }

        public int MinimumCardPickup(int[] cards)
        {
            var dict = new Dictionary<int, int>();
            var toReturn = int.MaxValue;

            for (var i = 0; i < cards.Length; i++)
            {
                if (dict.ContainsKey(cards[i]))
                {
                    var distance = i - dict[cards[i]] + 1;
                    toReturn = Math.Min(distance, toReturn);
                    dict[cards[i]] = i;
                }
                else dict.Add(cards[i], i);
            }

            return toReturn == int.MaxValue ? -1 : toReturn;
        }

        public IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();

            var s_frequency = new int[26];
            var p_frequency = new int[26];

            foreach (var c in p)
                p_frequency[c - 'a']++;

            for (var i = 0; i < s.Length; i++)
            {
                s_frequency[s[i] - 'a']++;
                if (i - p.Length >= 0)
                    s_frequency[s[i] - 'a']--;

                if (i >= p.Length - 1 && isAnagram(s_frequency, p_frequency))
                    result.Add(i - (p.Length - 1));
            }
            return result;
        }

        private bool isAnagram(int[] s_frequency, int[] p_frequency)
        {
            for (int i = 0; i < s_frequency.Length; i++)
                if (s_frequency[i] != p_frequency[i])
                    return false;

            return true;
        }

        public int MaxVowels(string s, int k)
        {
            var vowels = new HashSet<char> {
            'a', 'e', 'i', 'o', 'u'
        };

            var count = 0;

            for (var i = 0; i < k; i++)
                if (vowels.Contains(s[i]))
                    count++;

            var maxVowel = count;

            for (var i = k; i < s.Length; i++)
            {
                if (vowels.Contains(s[i - k])) count--;
                if (vowels.Contains(s[i])) count++;

                maxVowel = Math.Max(count, maxVowel);
            }

            return maxVowel;
        }
    }

    /* GOAL 25-28 JULY - SLIDING WINDOW
  😉 1 https://leetcode.com/problems/contains-duplicate-ii/
  😉 2 https://leetcode.com/problems/maximum-average-subarray-i/
  ❌ 3 https://leetcode.com/problems/longest-nice-substring/
  😉 4 https://leetcode.com/problems/substrings-of-size-three-with-distinct-characters/
  🤡 5 https://leetcode.com/problems/minimum-difference-between-highest-and-lowest-of-k-scores/
  😉 6 https://leetcode.com/problems/find-the-k-beauty-of-a-number/
  😉 7 https://leetcode.com/problems/minimum-recolors-to-get-k-consecutive-black-blocks/
  🤡 9 https://leetcode.com/problems/number-of-sub-arrays-of-size-k-and-average-greater-than-or-equal-to-threshold/
  10 https://leetcode.com/problems/maximize-the-confusion-of-an-exam/
  🤡 11 https://leetcode.com/problems/longest-subarray-of-1s-after-deleting-one-element/
  🤡 12 https://leetcode.com/problems/number-of-substrings-containing-all-three-characters/
  ❌ 13 https://leetcode.com/problems/max-consecutive-ones-iii/
  ❌ 14 https://leetcode.com/problems/count-number-of-nice-subarrays/
  ❌ 15 https://leetcode.com/problems/maximum-sum-of-two-non-overlapping-subarrays/
  😉 16 https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/
   17 https://leetcode.com/problems/maximum-erasure-value/
  ❌ DON'T UNDERSTAND THE TEXT !! 18 https://leetcode.com/problems/grumpy-bookstore-owner/
  ❌FUCK❌ 20 https://leetcode.com/problems/longest-repeating-character-replacement/
  🤡 21 https://leetcode.com/problems/maximum-points-you-can-obtain-from-cards/
  ❌ 22 https://leetcode.com/problems/maximum-number-of-occurrences-of-a-substring/
  ❌ 23 https://leetcode.com/problems/minimum-swaps-to-group-all-1s-together-ii/
  😉 25 https://leetcode.com/problems/minimum-consecutive-cards-to-pick-up/
  🤡 26 https://leetcode.com/problems/find-all-anagrams-in-a-string/

    Binary search problem ❌ 8 https://leetcode.com/problems/peak-index-in-a-mountain-array/
    DP problem ❌ 24 https://leetcode.com/problems/maximum-length-of-repeated-subarray/
    Prefix Sum ❌19 https://leetcode.com/problems/binary-subarrays-with-sum/

Explain code on paper afterwards, each o
    end with this: https://leetcode.com/discuss/study-guide/3722472/mastering-sliding-window-technique-a-comprehensive-guide
    
    AND SQL 2h a day
    7-26 reach 15th question
    Do SQL beginner part till JOIN
    */


}