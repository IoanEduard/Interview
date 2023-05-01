namespace _LeetCode_Medium.Concrete.Struggle
{
    public class BoatsToSavePeople
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);

            var left = 0;
            var right = people.Length - 1;
            var count = 0;

            if (people[left] > limit)
                return 0;

            while (left <= right)
            {
                if (people[left] + people[right] > limit)
                {
                    right--;
                }
                else
                {
                    left++;
                    right--;
                }
                count++;
            }

            return count;
        }
        
        public int NumRescueBoats2(int[] people, int limit)
        {
            Array.Sort(people);

            var left = 0;
            var right = people.Length - 1;
            var count = 0;

            while (left <= right)
            {
                if (people[left] + people[right] <= limit)
                {
                    count++;
                    left++;
                    right--;
                    continue;
                }

                right--;
                count++;
            }

            return count;
        }
    }
}

