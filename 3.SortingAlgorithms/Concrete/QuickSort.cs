
using _3.SortingAlgorithms.Interfaces.Abstract;

namespace _3.SortingAlgorithms.Concrete
{
    public class QuickSort : SortingStrategy<int>
    {
        public override int[] Sort(int[] collection)
        {
             return QuickSortAlgorithm(collection, 0, collection.Length - 1);
        }

        private int[] QuickSortAlgorithm(int[] array, int start, int end)
        {
            if (start < end)
            {
                var partitionIndex = Partition(array, start, end);
                QuickSortAlgorithm(array, start, partitionIndex - 1);
                QuickSortAlgorithm(array, partitionIndex + 1, end);
            }

            return array;
        }

        private static int Partition(int[] array, int start, int end)
        {
            var pivot = array[end];

            var i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (array[j] < pivot)
                {
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