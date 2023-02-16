using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
    /// Binary Search
    ///     - Searching in a sorted array /watch?v=v9IWor4n0Ys
    ///     Steps:
    ///         1. Define start and end pointers
    ///         2. Find the middle pointer of the array
    ///         3. if arr[mid] < element, search to the right of the middle element 
    ///                 left = middle + 1, rightPointer
    ///         4. if arr[mid] > element, search to the right of the middle element 
    ///                 right = right, middle - 1
    ///         5, if arr[mid] == target, then return mid
    /// </summary>
namespace _ExtensionMethods
{
    public static class BinarySearch
    {
        /// <summary>
        /// Recursive version of Binary Search 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target">Value you search for</param>
        /// <param name="leftPointer">Left pointer in Array</param>
        /// <param name="rightPointer">Right pointer in Array</param>
        /// <returns></returns>
        public static int BinarySearch_Version1(this int[] arr, int target, int leftPointer, int rightPointer)
        {
            if (leftPointer > rightPointer)
                return -1;

            var middle = (int)Math.Floor((double)(leftPointer + rightPointer) / 2);

            if (arr[middle] == target)
                return middle;

            if (arr[middle] > target)
            {
                return BinarySearch_Version1(arr, target, leftPointer, middle - 1);
            }
            else
            {
                return BinarySearch_Version1(arr, target, middle + 1, rightPointer);
            }
        }

        /// <summary>
        /// Recursive version of Binary Search 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target">Value you search for</param>
        /// <param name="leftPointer">Left pointer in Array</param>
        /// <param name="rightPointer">Right pointer in Array</param>
        /// <returns></returns>
        public static int BinarySearch_Version2(this int[] arr, int target, int leftPointer, int rightPointer)
        {
            if (leftPointer >= rightPointer)
            {
                var middle = (int)Math.Floor((double)(leftPointer + rightPointer) / 2);

                if (arr[middle] > target)
                {
                    return BinarySearch_Version1(arr, target, leftPointer, middle - 1);
                }
                else if (arr[middle] < target)
                {
                    return BinarySearch_Version1(arr, target, middle + 1, rightPointer);
                }
                else
                {
                    return middle;
                }
            }

            return -1;
        }
        /// <summary>
        /// Not recursive
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target">Value you search for</param>
        /// <param name="leftPointer">Left pointer in Array</param>
        /// <param name="rightPointer">Right pointer in Array</param>
        /// <returns></returns>
        public static int BinarySearch_Version3(this int[] arr, int target)
        {
            int low = 0;
            int hight = arr.Length - 1;

            while (low <= hight)
            {
                var mid = low + (hight - low) / 2;

                if (target < arr[mid]) 
                    hight = mid - 1;
                else if (target > arr[mid]) 
                    low = mid + 1;
                else return mid;
            }
            return -1;
        }
    }
}
        