namespace _ExtensionMethods.CustomComparer
{
    public class CustomComparer : IComparer<int[]>
    {
        private int _k;

        public CustomComparer(int k)
        {
            _k = k;
        }

        public int Compare(int[] x, int[] y)
        {
            if (x[_k] > y[_k]) return -1;
            if (x[_k] < y[_k]) return 1;
            return 0;
        }
    }
}