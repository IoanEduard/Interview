using System.Collections;

namespace _LeetCode_Easy.Concrete.DesignOOP
{
    public class Codec
    {
        private Hashtable _hashTable;

        public Codec()
        {
            _hashTable = new Hashtable();
        }

        // Encodes a URL to a shortened URL
        public string Encode(string longUrl)
        {
            var shortner = longUrl.GetHashCode();
            var shortUrl = "http://tinyurl.com/" + shortner;

            if (_hashTable.ContainsKey(shortUrl))
            {
                return (string)_hashTable[shortUrl]!;
            }
            else
            {
                _hashTable.Add(shortUrl, longUrl);
                return shortUrl;
            }
        }

        // Decodes a shortened URL to its original URL.
        public string Decode(string shortUrl)
        {
            return (string)_hashTable[shortUrl]!;
        }
    }
}