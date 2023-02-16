namespace _LeetCode_Medium.Concrete.Struggle
{
    public class NumberOfWaysToBuyPensAndPencils
    {
         public static long WaysToBuyPensPencils(int total, int cost1, int cost2)
        {
            if (cost1 + cost2 > total) return 1;

            var pens = 0;
            var sum = 0L;

            while (cost1 * pens <= total)
            {
                sum++;
                sum += (total - cost1 * pens) / cost2;
                pens++;
            }

            return sum;
        }
    }
}