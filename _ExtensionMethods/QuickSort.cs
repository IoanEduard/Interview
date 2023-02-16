using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _ExtensionMethods
{
    public static class QuickSort
    {
        public static int[] Quicksort(this int[] array, int start, int end)
        {
            if (start < end)
            {
                var partitionIndex = Partition(array, start, end);
                array.Quicksort(start, partitionIndex - 1);
                array.Quicksort(partitionIndex + 1, end);
            }

            return array;
        }

        private static int Partition(int[] array, int start, int end)
        {
            // right most element in the array as the pivot
            var pivot = array[end];

            // Index of smaller element 
            // Indicates the right position of pivot found so far
            var i = start - 1;

            for (int j = start; j < end; j++)
            {
                // If current element is smaller than the pivot
                if (array[j] < pivot)
                {
                    // Increment the index of smaller element
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, end);

            return i + 1;
        }

        private static void Swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}