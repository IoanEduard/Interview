using System.Collections;

namespace _LeetCode_Easy.Concrete.Struggle.Arrays
{
    public class DestinationCity
    {
        public string DestCity(IList<IList<string>> paths)
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
    }
}