/*
    Straight to the point easy problems
*/

using System.Collections;
using System.Numerics;
using System.Text;
using _ExtensionMethods;
using _ExtensionMethods.CustomComparer;
using _LeetCode_Easy.Interfaces;

namespace _LeetCode_Easy.Concrete
{
    public class _Easy : EasyPrivateMethods, IEasy
    {
        public static bool UniqueOccurrences(int[] arr)
        {
            var dict = new Dictionary<int, int>();
            var hashset = new HashSet<int>();

            for (var i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], 1);
                }
                else
                {
                    dict[arr[i]]++;
                }
            }

            foreach (var item in dict)
            {
                if (hashset.Contains(item.Value)) return false;

                hashset.Add(item.Value);
            }

            return true;
        }

        public static bool UniqueOccurrences_Linq(int[] arr)
        {
            var result = arr.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            return result.Values.Distinct().Count() == result.Count();
        }

        public static bool UniqueOccurrences_Linq2(int[] arr)
        {
            return !arr.GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count())
                .GroupBy(x => x.Value)
                .Any(x => x.Count() > 1);
        }

        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            return nums1.Intersect(nums2).ToArray();
        }

        public static int[] Intersection_2(int[] nums1, int[] nums2)
        {
            var nums1HashSet = nums1.ToHashSet();
            var result = new HashSet<int>();

            foreach (var item in nums2)
            {
                if (nums1HashSet.Contains(item))
                {
                    nums1HashSet.Remove(item);
                    result.Add(item);
                }
            }

            return result.ToArray();
        }

        public static bool HalvesAreAlike(string s, char[] vowels)
        {
            var middle = (int)Math.Ceiling((decimal)(s.Length - 1) / 2);

            var start = s.Substring(0, middle);
            var startCount = 0;

            var end = s.Substring(middle, Math.Abs(s.Length - middle));
            var endCount = 0;

            for (var i = 0; i < start.Length; i++)
            {
                if (vowels.Contains(start[i])) startCount++;
            }

            for (var i = 0; i < end.Length; i++)
            {
                if (vowels.Contains(end[i])) endCount++;
            }

            return startCount == endCount;
        }

        public static string DefangIPaddr(string address)
        {
            var stringBuilder = new StringBuilder();

            for (var i = 0; i < address.Length; i++)
            {
                if (address[i] != '.')
                {
                    stringBuilder.Append(address[i]);
                    continue;
                }

                stringBuilder.Append("[.]");
            }

            return stringBuilder.ToString();
        }

        public static string ToGoatLatin(string sentence, char[] wovewlsUpperCase)
        {
            var words = sentence.Split(' ');
            var stringBuilder = new StringBuilder();
            var increasingChars = new StringBuilder();

            for (var i = 0; i < words.Length; i++)
            {
                increasingChars.Append(string.Concat(Enumerable.Repeat('a', i + 1)));

                var whiteSpace = i == words.Length - 1 ? "" : " ";

                if (wovewlsUpperCase.Contains(words[i][0]))
                {
                    stringBuilder.Append(words[i] + "ma" + increasingChars.ToString() + whiteSpace);
                }
                else
                {
                    var firstLetter = words[i][0];
                    var wordWitoutFirstChar = words[i].Remove(0, 1);

                    stringBuilder.Append(wordWitoutFirstChar + firstLetter + "ma" + increasingChars.ToString() + whiteSpace);
                }

                increasingChars.Clear();
            }

            return stringBuilder.ToString();
        }

        public static string GenerateTheString(int n)
        {
            return n % 2 == 1 ? new string('a', n) : "a" + new string('b', n - 1);
        }

        public static string[] FindOcurrences(string text, string first, string second)
        {
            var splitText = text.Split(' ');
            var result = new List<string>();

            for (var i = 0; i < splitText.Length - 2; i++)
            {
                if (splitText[i] == first && splitText[i + 1] == second)
                {
                    result.Add(splitText[i + 2]);
                }
            }

            return result.ToArray();
        }

        public static string RemoveOuterParentheses(string s)
        {
            var sr = new StringBuilder();
            var count = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    if (count > 0)
                        sr.Append(s[i]);
                    count++;
                }
                else
                {
                    if (count > 1)
                        sr.Append(s[i]);
                    count--;
                }
            }

            return sr.ToString();
        }

        public static int ArrayPairSum(int[] nums)
        {
            var result = 0;
            Array.Sort(nums);

            for (var i = 0; i < nums.Length; i += 2)
            {
                result += nums[i];
            }

            return result;
        }

        public static int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            var result = 0;

            for (var i = 0; i < timeSeries.Length - 1; i++)
            {
                var sum = timeSeries[i] + duration;
                if (sum <= timeSeries[i + 1])
                {
                    result += sum;
                }

                if (sum > timeSeries[i + 1])
                {
                    result += timeSeries[i + 1] - timeSeries[i];
                }
            }

            result += duration;

            return result;
        }

        public static int[] SortArrayByParityII(int[] nums)
        {
            var result = new int[nums.Length];

            var even = 0;
            var odd = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    result[even] = nums[i];
                    even += 2;
                }

                if (nums[i] % 2 != 0)
                {
                    result[odd] = nums[i];
                    odd += 2;
                }
            }

            return result;
        }

        public static bool IsPalindrome(string s)
        {
            var start = 0;
            var end = s.Length - 1;

            while (start < (s.Length - 1) / 2)
            {
                if (!char.IsLetterOrDigit(s[start]))
                {
                    start++;
                    continue;
                }

                if (!char.IsLetterOrDigit(s[end]))
                {
                    end--;
                    continue;
                }

                if (char.ToLower(s[start]) != char.ToLower(s[end]))
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }

        public static int[] SortedSquares(int[] nums)
        {
            var result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }

            Array.Sort(nums);

            return nums;
        }

        public static int[] SortedSquares2(int[] nums)
        {
            var result = new int[nums.Length];

            var start = 0;
            var end = nums.Length - 1;

            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (Math.Abs(nums[start]) >= Math.Abs(nums[end]))
                {
                    result[i] = nums[start] * nums[start];
                    start++;
                }
                else
                {
                    result[i] = nums[end] * nums[end];
                    end--;
                }
            }

            return result;
        }

        public static int[] SortedSquares3(int[] nums)
        {
            var result = new int[nums.Length];

            var start = 0;
            var end = nums.Length - 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] = Math.Abs(nums[start]) >= Math.Abs(nums[end])
                    ? nums[start] * nums[start++]
                    : nums[end] * nums[end--];
            }

            return result;
        }
        public static int[] SortArrayByParityII2(int[] nums)
        {
            var result = new int[nums.Length];
            var start = 0;
            var startOdd = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    result[start] = nums[i];
                    start += 2;
                }
                else
                {
                    result[startOdd] = nums[i];
                    startOdd += 2;
                }
            }

            return result;
        }

        public static void ReverseString(char[] s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                var temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }
        }

        public static int FirstUniqChar(string s)
        {
            var isDuplicate = false;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (isDuplicate == false && i != j)
                    {
                        if (s[i] == s[j])
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                }

                if (isDuplicate == false)
                    return i;

                isDuplicate = false;
            }

            return -1;
        }

        public static bool JudgeCircle(string moves)
        {
            var upDown = 0;
            var leftRight = 0;

            for (int i = 0; i < moves.Length; i++)
            {
                switch (moves[i])
                {
                    case 'U':
                        upDown++;
                        break;
                    case 'D':
                        upDown--;
                        break;
                    case 'L':
                        leftRight++;
                        break;
                    case 'R':
                        leftRight--;
                        break;
                    default:
                        break;
                }
            }

            return upDown == 0 && leftRight == 0;
        }

        public static int BalancedStringSplit(string s)
        {
            var result = 0;
            var rCounter = 0;
            var lCounter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'R':
                        rCounter++;
                        break;
                    case 'L':
                        lCounter++;
                        break;
                    default:
                        break;
                }
                if (lCounter == rCounter && i > 0) result++;
            }

            return result;
        }

        public static bool IsValid(string s)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                var stackValue = new char();
                stack.TryPeek(out stackValue);

                if ((stackValue == '(' && s[i] == ')')
                    || (stackValue == '[' && s[i] == ']')
                    || (stackValue == '{' && s[i] == '}'))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            return !(stack.Count > 0);
        }



        public static int[] BuildArray(int[] nums)
        {
            var result = new int[nums.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = nums[nums[i]];
            }

            return result;
        }

        public static int[] GetConcatenation(int[] nums)
        {
            //return nums.Concat(nums).ToArray();

            var result = new int[nums.Length * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i];
                result[i + nums.Length] = nums[i];
            }

            return result;
        }

        public static int FinalValueAfterOperations(string[] operations)
        {
            var x = 0;

            for (int i = 0; i < operations.Length; i++)
            {
                switch (operations[i])
                {
                    case "++X":
                    case "X++":
                        x++;
                        break;
                    case "--X":
                    case "X--":
                        x--;
                        break;
                }
            }

            return x;
        }

        public static int[] RunningSum(int[] nums)
        {
            var result = new int[nums.Length];
            result[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = nums[i] + nums[i - 1];
            }

            return result;
        }

        public static int NumIdenticalPairs(int[] nums)
        {
            var count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i < j) count++;
                }
            }

            return count;
        }

        public static int[] Shuffle1(int[] nums, int n)
        {
            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(nums[i]);
                list.Add(nums[n + i]);
            }

            return list.ToArray();
        }

        public static int[] Shuffle(int[] nums, int n)
        {
            var arr = new int[nums.Length];

            var j = 0;
            for (int i = 0; i < n; i++)
            {
                arr[j] = nums[i];
                arr[j + 1] = nums[i + n];
                j += 2;
            }

            return arr;
        }

        public static int MostWordsFound(string[] sentences)
        {
            var max = int.MinValue;
            foreach (var item in sentences)
            {
                var sentencesWords = item.Split(' ');
                if (max < sentencesWords.Length) max = sentencesWords.Length;
            }

            return max;
        }

        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var res = new bool[candies.Length];
            var max = candies.Max();

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= max)
                {
                    res[i] = true;
                }
            }

            return res;
        }

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var res = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                var count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[i] > nums[j])
                        count++;
                }
                res[i] = count;
            }

            return res;
        }

        public static int[] Decode(int[] encoded, int first)
        {
            var res = new int[encoded.Length + 1];

            res[0] = first;
            for (int i = 0; i < encoded.Length; i++)
            {
                res[i + 1] = encoded[i] ^ res[i];
            }

            return res;
        }

        public static int[] DecompressRLElist(int[] nums)
        {
            var list = new List<int>();

            for (int i = 0; i < nums.Length; i += 2)
            {
                for (int j = 0; j < nums[i]; j++)
                {
                    list.Add(nums[i + 1]);
                }
            }

            return list.ToArray();
        }

        public static string RestoreString(string s, int[] indices)
        {
            var charArr = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                charArr[indices[i]] = s[i];
            }

            return new string(charArr);
        }

        public static int MaximumValue(string[] strs)
        {
            var count = 0;
            var max = int.MinValue;
            foreach (var item in strs)
            {
                if (int.TryParse(item, out int value))
                {
                    count = value;
                }
                else
                {
                    count = item.Length;
                }

                if (count > max) max = count;
            }

            return max;
        }

        public static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            var count = 0;
            var indexRuleKey = 0;

            switch (ruleKey)
            {
                case "type":
                    indexRuleKey = 0;
                    break;
                case "color":
                    indexRuleKey = 1;
                    break;
                case "name":
                    indexRuleKey = 2;
                    break;
            }

            for (var i = 0; i < items.Count; i++)
            {
                if (items[i][indexRuleKey] == ruleValue)
                {
                    count++;
                }
            }

            return count;
        }
        public static int ArithmeticTriplets(int[] nums, int diff)
        {
            var count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[j] - nums[i] == diff && nums[k] - nums[j] == diff)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
        public static int[] TwoSumBruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target) return new int[] { i, j };
                }
            }

            return new int[2];
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (dict.ContainsKey(diff))
                {
                    return new int[] { dict[diff], i };
                }
                else
                {
                    dict.Add(diff, i);
                }
            }

            return new int[2];
        }

        public static int CountKDifference(int[] nums, int k)
        {
            var count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static int CountPairs(int[] nums, int k)
        {
            var count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i * j == k)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static string TruncateSentence(string s, int k)
        {
            var split = s.Split(' ');
            return string.Join(' ', split.SkipLast(split.Length - k));
        }

        public static int MinMovesToSeat(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);

            var moves = 0;

            for (int i = 0; i < seats.Length; i++)
            {
                for (int j = 0; j < students.Length; j++)
                {
                    moves += Math.Abs(seats[i] - students[j]);
                }
            }

            return moves;
        }

        public static int CountConsistentStrings(string[] words, string allowed)
        {
            var result = words.Length;

            var hashset = new HashSet<char>(allowed);

            for (int i = 0; i < words.Length; i++)
            {
                foreach (var character in words[i].ToCharArray())
                {
                    if (!allowed.Contains(character))
                    {
                        result--;
                        break;
                    }
                }
            }

            return result;
        }
        public static string Interpret(string command)
        {
            if (command.Length == 1 && char.IsLetter(command[0]))
                return command;

            var sr = new StringBuilder();
            for (int i = 0; i < command.Length - 1; i++)
            {
                if (command[i] == '(' && command[i + 1] == ')')
                {
                    sr.Append('o');
                    i++;
                }

                if (char.IsLetter(command[i]))
                    sr.Append(command[i]);

                if (i + 1 == command.Length - 1 && char.IsLetter(command[i + 1]))
                    sr.Append(command[command.Length - 1]);
            }

            return sr.ToString();
        }

        public static bool IsPalindrome(int x)
        {
            var result = 0;
            var temp = x;

            while (temp > 0)
            {
                var rest = temp % 10;
                result = result * 10 + rest;
                temp /= 10;
            }
            return result == x;
        }

        public static int MajorityElement(int[] nums)
        {
            Array.Sort(nums);

            return nums[nums.Length / 2];
        }

        public static int MostFrequentEven(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0) continue;

                if (!dictionary.ContainsKey(nums[i]))
                    dictionary.Add(nums[i], 0);

                dictionary[nums[i]]++;
            }

            if (dictionary.Count() == 0) return -1;

            var result = 0;
            var maximumCount = int.MinValue;

            foreach (var element in dictionary)
            {
                if (element.Value > maximumCount || element.Value == maximumCount && element.Key < result)
                {
                    result = element.Key;
                    maximumCount = element.Value;
                }
            }

            return result;
        }

        public static int TitleToNumber(string columnTitle)
        {
            var dictionary = new Dictionary<char, int>();
            var j = 1;

            for (char c = 'A'; c <= 'Z'; c++)
            {
                dictionary.Add(c, j++);
            }

            if (columnTitle.Length == 1) return dictionary[columnTitle[0]];

            var res = dictionary[columnTitle[0]] * 26;

            for (int i = 1; i < columnTitle.Length - 1; i++)
            {
                var val = dictionary[columnTitle[i]] * 26;
                res = res * 26 + val;
            }

            return res + dictionary[columnTitle[columnTitle.Length - 1]];
        }

        public static int CountSegments1(string s)
        {
            var sr = new StringBuilder();
            var whitespaceCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsWhiteSpace(s[i]))
                {
                    sr.Append(s[i]);
                    whitespaceCount = 0;
                }

                if (char.IsWhiteSpace(s[i]))
                {
                    whitespaceCount++;
                    if (whitespaceCount == 1)
                    {
                        sr.Append(s[i]);
                    }
                }
            }

            var ss = sr.ToString().Trim();
            if (ss == string.Empty) return 0;

            return ss.Split(' ').Length;
        }

        public static int CountSegments(string s)
        {
            if (s == string.Empty) return 0;
            if (s.Length == 1 && !char.IsWhiteSpace(s[0])) return 1;
            var count = 0;

            if (!char.IsWhiteSpace(s[0])) count++;

            for (int i = 1; i < s.Length; i++)
            {
                if (!char.IsWhiteSpace(s[i]) && char.IsWhiteSpace(s[i - 1]))
                    count++;
            }

            return count;
        }

        public static bool CanBeIncreasing(int[] nums)
        {
            var count = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    count++;
                    if (count > 1) break;
                    if (i > 1 && nums[i] <= nums[i - 2])
                    {
                        nums[i] = nums[i - 1];
                    }
                }
            }

            return count < 2;
        }

        public static double[] ConvertTemperature(double celsius)
        {
            return new double[] { celsius * 1.8 + 32, celsius + 273.15 };
        }

        public static int SmallestEvenMultiple(int n)
        {
            if (n % 2 == 0 && n % n == 0)
                return n;

            return SmallestEvenMultiple(n + n);
        }

        public static int DifferenceOfSum(int[] nums)
        {
            var sum = 0;
            var sumOfDigits = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                while (nums[i] > 0)
                {
                    sumOfDigits += nums[i] % 10;
                    nums[i] /= 10;
                }
            }

            return Math.Abs(sum - sumOfDigits);
        }

        public static int AddDigits(int num)
        {
            if (num % 9 == 0) return 9;

            return num % 9;
        }

        public static int GetLucky(string s, int k)
        {
            BigInteger temp = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int character = s[i] - 'a' + 1;

                if (character < 10 || i < 1)
                {
                    temp = temp * 10 + character;
                }
                else
                {
                    var tempCharacter = character;
                    while (tempCharacter > 0)
                    {
                        tempCharacter /= 10;
                        temp = temp * 10;
                    }

                    temp = temp + character;
                }
            }

            BigInteger res = 0;
            while (k > 0)
            {
                res += temp % 10;
                temp = temp / 10;
                if (temp < 10)
                {
                    res += temp;
                    temp = res;
                    if (k > 1) res = 0;
                    k--;
                }
            }

            return (int)res;
        }

        public static int MinimumSum(int num)
        {
            var arr = new int[4];

            for (int i = 0; i < 4; i++)
            {
                arr[i] = num % 10;
                num /= 10;
            }

            Array.Sort(arr);

            return (arr[0] * 10 + arr[2]) + (arr[1] * 10 + arr[3]);
        }

        public static int CountEven(int num)
        {
            var count = 0;

            for (int i = 0; i < num; i++)
            {
                var sum = 0;
                var nr = i;
                while (nr > 0)
                {
                    var temp = nr % 10;
                    nr /= 10;
                    sum += temp;
                }

                if (sum % 2 == 0) count++;
            }

            return count;
        }

        public static bool IsHappy(int n)
        {
            var temp = n;
            var hashset = new HashSet<int>();

            var sum = 0;
            while (true)
            {
                var remainder = (int)Math.Pow(temp % 10, 2);
                sum += remainder;
                temp /= 10;

                if (temp < 1)
                    if (sum == 1) return true;

                if (temp < 1)
                {
                    if (!hashset.Add(sum)) return false;

                    hashset.Add(sum);
                    temp = sum;
                    sum = 0;
                }
            }
        }

        public static bool IsUgly(int n)
        {
            if (n <= 0) return false;

            var primes = new int[] { 2, 3, 5 };

            while (n > 0)
            {
                for (var i = 0; i < primes.Length; i++)
                {
                    if (n == 1) return true;
                    if (n % primes[i] == 0)
                    {
                        n /= primes[i];
                        break;
                    }

                    if (i == primes.Length - 1)
                        return false;
                }
            }

            return true;
        }

        public static int MinMaxGame(int[] nums)
        {
            var n = nums.Length;

            while (n > 1)
            {
                for (int i = 0; i < nums.Length / 2; i++)
                {
                    if (i % 2 == 0)
                        nums[i] = Math.Min(nums[2 * i], nums[2 * i + 1]);

                    if (i % 2 != 0)
                        nums[i] = Math.Max(nums[2 * i], nums[2 * i + 1]);
                }

                n /= 2;
            }

            return nums[0];
        }

        public static int CountQuadruplets(int[] nums)
        {
            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        for (int k = j; k < nums.Length; k++)
                        {
                            if (nums[j] < nums[k])
                            {
                                for (int l = k; l < nums.Length; l++)
                                {
                                    if (nums[k] < nums[l])
                                    {
                                        if (nums[l] == nums[k] + nums[i] + nums[j]) count++;
                                    }
                                }
                            }
                        }
                    }

                }
            }
            return count;
        }

        public static int MinPartitions(string n)
        {
            var max = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] - '0' > max)
                    max = n[i] - '0';
            }

            return max;
        }

        public static string ReversePrefix(string word, char ch)
        {
            var indexSubstring = word.IndexOf(ch);
            var wordArray = word.ToCharArray();

            if (indexSubstring == -1) return word;

            var l = (int)Math.Floor((double)indexSubstring / 2);
            var len = wordArray.Length % 2 == 0 ? l : l + 1;

            for (int i = 0, j = indexSubstring; i < len; i++, j--)
            {
                var temp = wordArray[i];
                wordArray[i] = wordArray[j];
                wordArray[j] = temp;
            }

            return new string(wordArray);
        }

        public static int XorOperation(int n, int start)
        {
            var res = 0;
            var i = 0;
            while (n > 0)
            {
                res = res ^ (start + 2 * i);
                n--;
                i++;
            }

            return res;
        }

        public static string FreqAlphabets(string s)
        {
            var stack = new Stack<char>();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '#')
                {
                    stack.Push((char)(int.Parse(
                        s.Substring(
                            s.IndexOf(s[i], i) - 2, 2)) + 'a' - 1));

                    i -= 2;
                }
                else
                {
                    stack.Push((char)(s[i] - '0' + 96));
                }

            }
            return new string(stack.ToArray());
        }

        public static int CountDigits(int num)
        {
            var temp = num;
            var count = 0;
            while (temp > 0)
            {
                var remainder = temp % 10;
                if (num % remainder == 0) count++;
                temp /= 10;
            }
            return count;
        }

        public static int MaxProduct(int[] nums)
        {
            Array.Sort(nums);
            return (nums[nums.Length - 1] - 1) * (nums[nums.Length - 2] - 1);
        }

        public static int SubtractProductAndSum(int n)
        {
            var sum = 0;
            var product = 1;

            var temp = n;
            while (temp > 0)
            {
                sum += temp % 10;
                product = product * (temp % 10);
                temp /= 10;
            }

            return product - sum;
        }

        public static bool CheckIfPangram(string sentence)
        {
            var chars = new HashSet<char>();

            for (int i = 0; i < sentence.Length; i++)
            {
                chars.Add(sentence[i]);

                if (chars.Count == 26) return true;
            }

            return false;
        }

        public static bool AreNumbersAscending(string s)
        {
            var array = s.Split(' ');
            var prevVal = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse(array[i], out int val))
                {
                    if (val > prevVal)
                    {
                        prevVal = val;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static string SortSentence(string s)
        {
            var array = s.Split(' ');
            var res = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                res[(array[i][array[i].Length - 1] + '0' - 96) - 1] = array[i].Substring(0, array[i].Length - 1);
            }

            return string.Join(' ', res);
        }

        public static int NumOfStringsBasic(string[] patterns, string word)
        {
            var count = 0;
            for (int i = 0; i < patterns.Length; i++)
            {
                if (word.IndexOf(patterns[i]) != -1) count++;
            }

            return count;
        }
        public static int NumOfStrings(string[] patterns, string word)
        {
            var count = 0;

            for (int i = 0; i < patterns.Length; i++)
            {
                if (CheckSubstring(patterns[i], word))
                {
                    count++;
                }
            }

            return count;
        }

        public static bool CheckString(string s)
        {
            var bFound = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'b') bFound = true;
                if (!bFound) continue;

                if (bFound)
                    if (s[i] == 'a') return false;
            }

            return true;
        }

        public static string DecodeMessage(string key, string message)
        {
            var chiper = message[0];

            var keyHashSet = new HashSet<char>();
            for (int i = 0; i < key.Length; i++)
            {
                if (!char.IsWhiteSpace(key[i]))
                    keyHashSet.Add(key[i]);
            }

            var dictionaryForKey = new Dictionary<char, char>();
            dictionaryForKey.Add(' ', ' ');
            var dictionaryForAlphabet = new Dictionary<char, char>();
            dictionaryForAlphabet.Add(' ', ' ');

            var k = 1;
            foreach (var item in keyHashSet)
            {
                dictionaryForKey.Add(item, (char)('a' - 1 + k));
                dictionaryForAlphabet.Add((char)('a' - 1 + k), item);
                k++;
            }

            var stringBuilder = new StringBuilder();

            var start = dictionaryForKey[message[0]];
            stringBuilder.Append(start);

            for (int i = 1; i < message.Length; i++)
            {
                if (!char.IsWhiteSpace(message[i]))
                {
                    stringBuilder.Append(dictionaryForKey[message[i]]);
                }
                else stringBuilder.Append(message[i]);
            }

            return stringBuilder.ToString();

        }

        public static string ReverseWords(string s)
        {
            var arr = s.Split(' ');
            var sr = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr[i].Length - 1; j >= 0; j--)
                {
                    sr.Append(arr[i][j]);
                }

                if (i < arr.Length - 1) sr.Append(' ');
            }

            return sr.ToString();
        }

        public static string ReverseStr(string s, int k)
        {
            var stringbuilder = new StringBuilder();
            var subArraysToReverse = new List<string>();

            var substring = string.Empty;
            for (int i = 0; i < s.Length; i += k)
            {
                if ((s.Length - 1) - i >= k)
                {
                    substring = s.Substring(i, k);
                    subArraysToReverse.Add(substring);
                }
                else
                {
                    substring = s.Substring(i, s.Length - i);
                    subArraysToReverse.Add(substring);
                }
            }

            for (int i = 0; i < subArraysToReverse.Count; i++)
            {
                if (i % 2 == 0)
                {
                    for (int l = subArraysToReverse[i].Length - 1; l >= 0; l--)
                    {
                        stringbuilder.Append(subArraysToReverse[i][l]);
                    }
                }

                else stringbuilder.Append(subArraysToReverse[i]);
            }

            return stringbuilder.ToString();
        }

        public static void ReverseString3(char[] s)
        {
            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                var temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right++;
            }
        }

        public static int CountAsterisks(string s)
        {
            var countVerticalLine = 0;
            var result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '|') countVerticalLine++;
                if (countVerticalLine % 2 == 0)
                {
                    if (s[i] == '*') result++;
                }
            }

            return result;
        }

        public static int[] SumZero(int n)
        {
            var list = new List<int>();

            if (n == 1)
                return new int[1] { 0 };

            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
                list.Add(i * -1);
            }

            if (n % 2 != 0)
                list.Add(0);

            return list.ToArray();
        }

        public static int MaxVowels(string s, int k)
        {
            var currentCount = 0;
            var max = 0;

            var hashsetVowerls = new HashSet<char>
            {
                'a',
                'e',
                'i',
                'o',
                'u'
            };

            for (int i = 0; i < s.Length; i++)
            {
                if (i >= k && hashsetVowerls.Contains(s[i - k]))
                    currentCount--;

                if (hashsetVowerls.Contains(s[i - k]))
                    currentCount++;

                max = Math.Max(currentCount, max);
            }

            return max;
        }

        public static int LongestOnes(int[] nums, int k)
        {
            var max = 0;
            var countZeroes = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                var leftPointer = i;
                while (countZeroes <= k)
                {
                    if (nums[leftPointer++] == 0)
                        countZeroes++;
                }

                max = Math.Max(leftPointer, max);
                i = leftPointer;
            }

            return max;
        }

        public static bool KLengthApart(int[] nums, int k)
        {
            var countZeroes = k;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    if (countZeroes < k) return false;
                    countZeroes = 0;
                }
                else countZeroes++;
            }

            return true;
        }

        public static string FirstPalindrome(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (WordIsPalindrome(words[i]))
                {
                    return words[i];
                }
            }

            return "";
        }

        public static int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            var count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= a)
                    {
                        for (int k = 0; k < arr.Length; k++)
                        {
                            if (Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                                count++;
                        }
                    }
                }
            }

            return count;
        }

        public static int PercentageLetter(string s, char letter)
        {
            var freq = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == letter)
                    freq++;
            }
            return freq * 100 / s.Length;
        }

        public static string CapitalizeTitle(string title)
        {
            var sr = new StringBuilder();
            var titleArr = title.Split(' ');

            for (int i = 0; i < titleArr.Length; i++)
            {
                if (titleArr[i].Length <= 2)
                {
                    sr.Append(titleArr[i].ToLower());
                    if (i < titleArr.Length - 1)
                        sr.Append(' ');
                    continue;
                }

                if (char.IsLower(titleArr[i][0]))
                    sr.Append(Convert.ToChar(char.ToUpper(titleArr[i][0])));
                else sr.Append(titleArr[i][0]);

                for (int j = 1; j < titleArr[i].Length; j++)
                {
                    if (char.IsUpper(titleArr[i][j]))
                        sr.Append(char.ToLower(titleArr[i][j]));
                    else sr.Append(titleArr[i][j]);
                }

                if (i < titleArr.Length - 1)
                    sr.Append(' ');
            }

            return sr.ToString();
        }

        public static bool DetectCapitalUse(string word)
        {
            if (word.Length == 1) return true;

            if (char.IsLower(word[0]))
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i])) return false;
                }

                return true;
            }

            if (char.IsUpper(word[0]) && char.IsUpper(word[1]))
            {
                for (int i = 2; i < word.Length; i++)
                {
                    if (char.IsLower(word[i])) return false;
                }

                return true;
            }

            if (char.IsUpper(word[0]))
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i])) return false;
                }
            }

            return true;
        }

        public static int MaxDepth(string s)
        {
            var counter = 0;
            var maxParanthesis = int.MinValue;

            foreach (char c in s)
            {
                if (c == '(') counter++;
                if (c == ')') counter--;

                maxParanthesis = Math.Max(maxParanthesis, counter);
            }

            return maxParanthesis;
        }
        public static int DistinctIntegers(int n)
        {
            var hash = new HashSet<int>();
            while (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 1)
                        hash.Add(i);
                }

                n--;
            }

            return hash.Count;
        }

        public static int Maximum69Number(int num)
        {
            var numCharArr = num.ToString().ToCharArray();
            var max = int.MinValue;

            for (var i = 0; i < numCharArr.Length; i++)
            {
                var n = 0;
                if (numCharArr[i] == '6')
                {
                    numCharArr[i] = '9';
                    n = int.Parse(new string(numCharArr));
                }
                else if (numCharArr[i] == '9')
                {
                    numCharArr[i] = '6';
                    n = int.Parse(new string(numCharArr));
                }
                max = Math.Max(max, n);
                numCharArr = num.ToString().ToCharArray();
            }

            return max;
        }

        public static int MaxProductDifference(int[] nums)
        {
            Array.Sort(nums);
            var n = nums.Length;

            return (nums[n - 1] * nums[n - 2]) - (nums[0] * nums[1]);
        }

        public static int CommonFactors(int a, int b)
        {
            var count = 0;
            for (int i = 1; i <= b; i++)
            {
                if (a % i == 0 && b % i == 0)
                    count++;
            }
            return count;
        }

        public static string ReplaceDigits(string s)
        {
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                    stringBuilder.Append(s[i]);
                else
                    stringBuilder.Append(Convert.ToChar(s[i] + s[i + 1] - '0'));
            }

            return stringBuilder.ToString();
        }

        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            // 128: 128 % 1, 128 % 2, 128 % 8
            var list = new List<int>();
            for (int i = left; i <= right; i++)
            {
                var flag = true;
                var temp = i;
                while (true)
                {
                    if (temp == 0) break;

                    var remainder = temp % 10;

                    if (remainder == 0)
                    {
                        flag = false;
                        break;
                    }

                    if (i % remainder != 0)
                    {
                        flag = false;
                        break;
                    }

                    temp /= 10;
                }
                if (flag)
                    list.Add(i);
            }

            return list;
        }

        public static bool CheckPerfectNumber(int num)
        {
            var sum = 0;

            for (int i = 1; i <= num / 2; i++)
            {
                var div = num % i;
                if (div == 0)
                {
                    sum += i;
                }
            }

            return sum == num;
        }

        public static int NumberOfMatches(int n)
        {
            var matches = 0;

            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    matches += n / 2;
                    n = n / 2;
                }
                else
                {
                    matches += (n - 1) / 2;
                    n = (n - 1) / 2 + 1;
                }
            }

            return matches;
        }

        public static int NumberOfSteps(int num)
        {
            var count = 0;

            while (num > 1)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                    count++;
                }

                else if (num % 2 != 0)
                {
                    num = num - 1;
                    count++;
                }
            }

            return count;
        }

        public static int CountOperations(int num1, int num2)
        {
            var count = 0;
            while (num1 > 0 && num2 > 0)
            {
                if (num1 >= num2)
                    num1 -= num2;
                else if (num2 >= num1)
                    num2 -= num1;

                count++;
            }

            return count;
        }

        public static bool AreOccurrencesEqual(string s)
        {
            var dictionary = new Dictionary<char, int>();

            var firstOccurenceCount = 0;
            var firstChar = s[0];

            for (int i = 0; i < s.Length; i++)
            {
                if (dictionary.ContainsKey(s[i]))
                    dictionary[s[i]]++;
                else
                    dictionary.Add(s[i], 1);

                if (s[i] == firstChar)
                    firstOccurenceCount++;
            }

            foreach (var item in dictionary)
            {
                if (item.Value != firstOccurenceCount)
                    return false;
            }

            return true;
        }

        public static int SecondHighest(string s)
        {
            var res = new int[2] { int.MinValue, int.MinValue };

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    if (s[i] > res[0])
                    {
                        res[1] = res[0];
                        res[0] = s[i];
                    }
                    else if (s[i] < res[0] && s[i] > res[1])
                        res[1] = s[i];
                }
            }
            return res[1] >= 0 ? res[1] - '0' : -1;
        }

        public static int MaximumCount(int[] nums)
        {
            var countNegatives = 0;
            var countPositive = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0) countNegatives++;
                if (nums[i] > 0) countPositive++;
            }

            return Math.Max(countNegatives, countPositive);
        }

        public static IList<string> FizzBuzz(int n)
        {
            var list = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("FizzBuzz");
                    continue;
                }

                if (i % 3 == 0)
                {
                    list.Add("Fizz");
                    continue;
                }

                if (i % 5 == 0)
                {
                    list.Add("Buzz");
                    continue;
                }

                list.Add(i.ToString());
            }

            return list;
        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            var dict = new Dictionary<char, int>();

            foreach (var character in magazine)
            {
                if (dict.ContainsKey(character))
                {
                    dict[character]++;
                }
                else
                {
                    dict.Add(character, 1);
                }
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (dict.ContainsKey(ransomNote[i]))
                {
                    if (dict[ransomNote[i]] == 0)
                    {
                        return false;
                    }
                    else
                    {
                        dict[ransomNote[i]]--;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public static int FindMaxConsecutiveOnes_1(int[] nums)
        {
            var resultCount = 0;
            var currentCount = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 0;
                }

                if (currentCount > resultCount) resultCount = currentCount;
            }

            return resultCount;
        }

        public static bool ArrayStringsAreEqualStack(string[] word1, string[] word2)
        {
            return string.Concat(word1).Equals(string.Concat(word2));
        }

        public static int LargestAltitude(int[] gain)
        {
            var max = 0; var prefSum = 0;
            for (int i = 0; i < gain.Length - 1; i++)
            {
                prefSum += gain[i];
                gain[i + 1] = prefSum;

                max = Math.Max(max, gain[i + 1]);
            }

            return max;
        }

        public static string ToLowerCase(string s)
        {
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    stringBuilder.Append(char.ToLower(s[i]));
                    continue;
                }

                stringBuilder.Append(s[i]);
            }

            return stringBuilder.ToString();
        }

        public static string ToLowerCase1(string s)
        {
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > 'A' && s[i] < 'Z')
                {
                    stringBuilder.Append(s[i] + 32);
                    continue;
                }

                stringBuilder.Append(s[i]);
            }

            return stringBuilder.ToString();
        }

        public static int PrefixCount0(string[] words, string pref)
        {
            var count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].StartsWith(pref)) count++;
            }

            return count;
        }

        public static int PrefixCount(string[] words, string pref)
        {
            var count = 0;

            var j = 0;
            for (int i = 0; i < words.Length; i++)
            {
                var hasPrefix = true;
                if (words[i].Length < pref.Length) continue;
                while (j < pref.Length)
                {
                    if (pref[j] != words[i][j])
                    {
                        hasPrefix = false;
                        break;
                    }
                    j++;
                }

                if (hasPrefix) count++;
                j = 0;
            }

            return count;
        }

        public static string DestCity(IList<IList<string>> paths)
        {
            var hashtable = new Hashtable();
            var result = string.Empty;

            for (int i = 0; i < paths.Count; i++)
            {
                hashtable.Add(paths[i][0], paths[i][1]);
            }

            foreach (var path in paths)
            {
                foreach (var item in path)
                {
                    if (!hashtable.ContainsKey(item))
                        result = item;
                }
            }

            return result;
        }

        public static int NumJewelsInStones(string jewels, string stones)
        {
            var dict = new Dictionary<char, int>();

            foreach (var jewel in jewels)
            {
                dict.InsertOrIncrement(jewel);
            }

            for (int i = 0; i < stones.Length; i++)
            {
                if (dict.ContainsKey(stones[i]))
                {
                    dict[stones[i]]++;
                }
            }

            return dict.Values.Sum() - dict.Values.Count();
        }

        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (var word in word1)
            {
                foreach (var character in word)
                {
                    dictionary.InsertOrIncrement<char>(character);
                }
            }

            for (int i = 0; i < word2.Length; i++)
            {
                for (int j = 0; j < word2[i].Length; j++)
                {
                    dictionary.RemoveOrDecrement<char>(word2[i][j]);
                }
            }

            return dictionary.Count() > 0;
        }


        public static int FindLucky(int[] arr)
        {
            var luckyNumbersDictionary = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                luckyNumbersDictionary.InsertOrIncrement(arr[i]);
            }

            foreach (var item in luckyNumbersDictionary)
            {
                if (item.Key != item.Value) luckyNumbersDictionary.Remove(item.Key);
            }

            return luckyNumbersDictionary.Count() > 0 ? luckyNumbersDictionary.Max(item => item.Value) : -1;
        }

        public static int CountWords(string[] words1, string[] words2)
        {
            var dict1 = new Dictionary<string, int>();
            var dict2 = new Dictionary<string, int>();
            var count = 0;

            for (int i = 0; i < words1.Length; i++)
            {
                if (!dict1.ContainsKey(words1[i]))
                {
                    dict1.Add(words1[i], 1);
                }
                else
                {
                    dict1[words1[i]]++;
                }
            }

            for (int i = 0; i < words2.Length; i++)
            {
                if (!dict2.ContainsKey(words2[i]))
                {
                    dict2.Add(words2[i], 1);
                }
                else
                {
                    dict2[words2[i]]++;
                }
            }

            foreach (var item in words1)
            {
                if (dict1.ContainsKey(item) && dict1[item] == 1 && dict2.ContainsKey(item) && dict2[item] == 1)
                    count++;
            }

            return count;
        }

        public int SumOfUnique(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();
            var sum = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], 1);
                    sum += nums[i];
                }
                else
                {
                    dictionary[nums[i]]++;
                    if (dictionary[nums[i]] == 2)
                        sum -= nums[i];
                }
            }

            return sum;
        }

        public char RepeatedCharacter(string s)
        {
            var hash = new HashSet<char>();

            for (var i = 0; i < s.Length; i++)
            {
                if (hash.Contains(s[i]))
                    return s[i];
                else hash.Add(s[i]);
            }

            return ' ';
        }

        public bool IsStrictlyPalindromic(int n)
        {
            for (var i = 2; i <= n - 2; i++)
            {
                var convertN = n.ConvertToBase(n);

                var start = 0;
                var end = convertN.Count - 1;

                while (start < end)
                {
                    if (convertN[start] != convertN[end])
                        return false;

                    start++;
                    end--;
                }
            }

            return true;
        }

        public int[] FindArray(int[] pref)
        {
            var result = new int[pref.Length];
            result[0] = pref[0];

            for (var i = 1; i < pref.Length; i++)
            {
                result[i] = pref[i] ^ pref[i - 1];
            }

            return result;
        }

        public int[][] SortTheStudents(int[][] score, int k)
        {
            var max = int.MinValue;
            var rowMax = 0;

            for (var i = 0; i < score.Length; i++)
            {
                if (score[i][k] > max)
                {
                    max = score[i][k];
                    rowMax = i;
                }
            }

            var temp = score[0];
            score[0] = score[rowMax];
            score[rowMax] = temp;

            return score;
        }

        public int[][] SortTheStudents2(int[][] score, int k)
        {
            Array.Sort(score, (x, y) => x[k].CompareTo(y[k]));

            return score;
        }

        public int[][] SortTheStudents3(int[][] score, int k)
        {
            Array.Sort(score, new CustomComparer(k));
            return score;
        }

        public int[] SeparateDigits(int[] nums)
        {
            var list = new Queue<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var n = nums[i];
                while (n > 0)
                {
                    list.Enqueue(n % 10);
                    n /= 10;
                }
            }

            return list.ToArray();
        }

        public bool SquareIsWhite(string coordinates)
        {
            var row = coordinates[0] - '0';
            var col = coordinates[1];

            if (row == col)
                return false;

            if ((row + col) % 2 == 1)
                return true;

            return false;
        }

        // Failed cause testcases are not same order as leetcode
        public IList<string> RemoveAnagrams(string[] words)
        {
            var hashtable = new Hashtable();

            for (var i = 0; i < words.Length; i++)
            {
                var s = words[i].ToCharArray();
                Array.Sort(s);
                var hashKey = new string(s);

                if (!hashtable.ContainsKey(hashKey))
                    hashtable.Add(hashKey, words[i]);
            }

            return hashtable.Values.Cast<string>().ToList();
        }

        // Consecutive anagrams are not allowed only! We are not looking for unique anagrams
        public IList<string> RemoveAnagrams2(string[] words)
        {
            var dict = new Dictionary<string, string>();

            for (var i = 0; i < words.Length; i++)
            {
                var s = words[i].ToCharArray();
                Array.Sort(s);
                var key = new string(s);

                if (dict.ContainsKey(key)) continue;
                else
                {
                    dict.Add(key, words[i]);
                }
            }

            return dict.Values.ToArray();
        }

        public IList<string> RemoveAnagrams3(string[] words)
        {
            var list = new List<string>();

            for (var i = 0; i < words.Length - 1; i++)
            {
                var temp = words[i];

                while (i + 1 < words.Length && Sort(words[i]) == Sort(words[i + 1]))
                    i++;

                list.Add(temp);
            }

            return list;
        }

        private string Sort(string word)
        {
            var s = word.ToCharArray();
            Array.Sort(s);
            return new string(s);
        }

        public bool IsAnagram(string word1, string word2)
        {
            if (word1.Length != word2.Length) return false;

            var dict = new Dictionary<char, int>();

            for (var i = 0; i < word1.Length; i++)
            {
                if (dict.ContainsKey(word1[i]))
                    dict[word1[i]]++;
                else
                    dict.Add(word1[i], 1);
            }

            for (var i = 0; i < word2.Length; i++)
            {
                if (dict.ContainsKey(word2[i]))
                {
                    if (dict[word2[i]] == 0)
                        return false;
                    else
                        dict[word2[i]]--;
                }
                else return false;
            }

            return true;
        }

        public int AlternateDigitSum(int n)
        {
            var stack = new Stack<int>();
            var sum = 0;

            while (n > 0)
            {
                stack.Push(n % 10);
                n /= 10;
            }
            var flipSign = 1;
            while (stack.Count > 1)
            {
                sum += flipSign * stack.Pop();
                flipSign *= -1;
            }

            return sum;
        }

        public int[] LeftRigthDifference(int[] nums)
        {
            var sumArr = new int[nums.Length];
            var leftSum = 0;
            var rightSum = 0;

            var i = 0;
            var j = nums.Length - 1;

            for (; i < nums.Length; i++, j--)
            {
                leftSum += nums[i + 1];
                rightSum += nums[j - 1];
                sumArr[i] = leftSum - rightSum;
            }

            return sumArr;


        }
    }
}