namespace _ExtensionMethods
{
    public static class ConvertToBaseExtension
    {
        public static IList<int> ConvertToBase(this int s, int baseNumber)
        {
            var list = new List<int>();

            while (s > 0)
            {
                list.Add(s % baseNumber);
                s = s / baseNumber;
            }

            return list;
        }
    }
}