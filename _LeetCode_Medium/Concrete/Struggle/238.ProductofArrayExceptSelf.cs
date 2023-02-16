using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _LeetCode_Medium.Concrete.Struggle
{
    public class ProductofArrayExceptSelf
    {
        // https://leetcode.com/problems/product-of-array-except-self/
        /* Analysys 
             I got that I need to make a prefix sum for each element, but I had the misconcenption I have to do arr[i] + arr[i+1]
             Question states: ````is equal to the product of all the elements of nums except nums[i]```` which I was confused
             Solution was confusing because I have to go backwards with products and I didn't knew why.
         */

        // Solution nr 1
        // This solution is O(1) space because temp is not considered extra space
        public static int[] ProductExceptSelf(int[] nums)
        {
            var temp = new int[nums.Length];

            var product = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                temp[i] = product;
                product *= nums[i];
            }

            product = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                temp[i] *= product;
                product *= nums[i];
            }

            return temp;
        }

        // Solution nr 2
        // O(n) space using two arrays
        // So we do product from left to right and right to left of all elements except nums[i] 
        // then we do the product between elements and we get the final result.
        public static int[] ProductExceptSelf2(int[] nums)
        {
            var n = nums.Length;

            var left = new int[n];
            var right = new int[n];
            var result = new int[n];

            var product = 1;
            for (int i = 0; i < n; i++)
            {
                left[i] = product;
                product = left[i] * nums[i];
            }

            product = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                right[i] = product;
                product = right[i] * nums[i];
            }

            for (int i = 0; i < n; i++)
            {
                result[i] = right[i] * left[i];
            }

            return result;

        }

        // More explanations 
        // https://leetcode.com/problems/product-of-array-except-self/solutions/1342916/3-minute-read-mimicking-an-interview/

        // Solution 3 Brute Force Approach: if i != j we skip the current element
        public static int[] ProductExceptSelfBruteForce(int[] nums)
        {
            var n = nums.Length;
            var result = new int[n];

            for (int i = 0; i < n; i++)
            {
                var product = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i == j) continue;

                    product = product * nums[j];
                }

                result[i] = product;
            }

            return result;
        }

        // Things I didn't know before approaching the problem: Suffix and Prefix of an array.
        // The confusion was made because I didn't know about suffix and prefix 
        // https://cp-algorithms.com/string/suffix-array.html#number-of-different-substrings
        // https://www.enjoyalgorithms.com/blog/product-of-array-except-self
    }
}