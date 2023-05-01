namespace _LeetCode_Medium.Concrete.Struggle
{
    public class SuccessfulPairsOfSpellsAndPotions
    {
        // https://leetcode.com/problems/successful-pairs-of-spells-and-potions/editorial/
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            var pairs = new int[spells.Length];

            for (var i = 0; i < spells.Length; i++)
            {
                var count = 0;
                for (var j = 0; j < potions.Length; j++)
                {
                    if (spells[i] * potions[j] > success)
                    {
                        count++;
                    }
                }
                pairs[i] = count;
            }

            return pairs;
        }

        public int[] SuccessfulPairsBinarySearch(int[] spells, int[] potions, long success)
        {
            Array.Sort(potions);

            var pairs = new int[spells.Length];

            for (int i = 0; i < spells.Length; i++)
            {
                var left = 0;
                var right = potions.Length;
                long spell = spells[i];

                while (left < right)
                {
                    var middle = left + (right - left) / 2;

                    if (spell * potions[middle] >= success)
                        right = middle;
                    else left = middle + 1;
                }

                pairs[i] = potions.Length - left;
            }

            return pairs;
        }

        //https://leetcode.com/problems/successful-pairs-of-spells-and-potions/editorial/
        public int[] SuccessfulPairs2(int[] spells, int[] potions, long success)
        {
            Array.Sort(potions);

            int[] res = new int[spells.Length];

            for (int i = 0; i < spells.Length; i++)
            {
                int left = 0, right = potions.Length;
                long spell = spells[i];

                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    if (spell * potions[mid] >= success)
                        right = mid;
                    else
                        left = mid + 1;
                }

                res[i] = potions.Length - left;
            }

            return res;
        }
    }
}