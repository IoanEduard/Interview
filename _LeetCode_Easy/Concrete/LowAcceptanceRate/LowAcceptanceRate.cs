using _LeetCode_Easy.Interfaces;

namespace _LeetCode_Easy.Concrete.LowAcceptanceRate
{
    public class LowAcceptanceRate : ILowAcceptanceRate
    {
        public int Reverse(int x)
        {
            var result = 0;
            var isNegative = false;

            var minimumBound = int.MinValue / 10;
            var maximumBound = int.MaxValue / 10;

            if (x < 0)
            {
                isNegative = true;
                x *= -1;
            }

            while (x > 0)
            {
                var remainder = x % 10;

                if (result > maximumBound || result < minimumBound)
                    return 0;

                result = result * 10 + remainder;
                x /= 10;
            }

            if (isNegative)
                return result * -1;

            return result;
        }
    }
}