namespace _3.SortingAlgorithms.Concrete.LeetCode
{
    public class SortingProblems
    {
         public static string[] SortPeople(string[] names, int[] heights)
        {
            Quicksort(heights, names, 0, heights.Length - 1);

            return names;
        }

        public static string[] Quicksort(int[] array, string[] names, int start, int end)
        {
            if (start < end)
            {
                var partitionIndex = Partition(array, names, start, end);
                Quicksort(array, names, start, partitionIndex - 1);
                Quicksort(array, names, partitionIndex + 1, end);
            }

            return names;
        }

        private static int Partition(int[] array, string[] names, int start, int end)
        {
            var pivot = array[end];

            var i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (array[j] > pivot)
                {
                    i++;
                    Swap(array, i, j);
                    Swap(names, i, j);
                }
            }
            Swap(array, i + 1, end);
            Swap(names, i + 1, end);

            return i + 1;
        }

        private static void Swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private static void Swap(string[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}