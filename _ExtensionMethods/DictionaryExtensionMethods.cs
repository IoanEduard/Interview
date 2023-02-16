namespace _ExtensionMethods
{
    public static class DictionaryExtensionMethods
    {
        public static void InsertOrIncrement<TKey>(this Dictionary<TKey, int> dictionary, TKey key)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key]++;
            }
            else
            {
                dictionary.Add(key, 1);
            }
        }

        public static void RemoveOrDecrement<TKey>(this Dictionary<TKey, int> dictionary, TKey key)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key]--;
            }

            if (dictionary[key] < 1)
                dictionary.Remove(key);

        }
    }
}