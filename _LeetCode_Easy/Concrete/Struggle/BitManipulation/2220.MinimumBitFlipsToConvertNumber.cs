using System.Numerics;

namespace _LeetCode_Easy.Concrete.Struggle.BitManipulation
{
    public class MinimumBitFlipsToConvertNumber
    {
        public int MinBitFlips(int start, int goal)
        {
            // start = 10, goal = 7, in binary representation are 1010 and 0111 respectively
            // 1101 is a result of XOR operation - result = start^goal. Answer is a count of "1" bits in result.
            var result = start ^ goal;
            var output = 0;

            while (result > 0)
            {
                //	Binary AND Operator copies a bit to the result if it exists in both operands.
                if ((result & 1) == 1)
                    output++;

                // Binary Right Shift Operator. The left operands value is moved right by the number of bits specified by the right operand.
                result = result >> 1;
            }

            return output;
        }

        public int MinBitFlips2(int start, int goal)
        {
            return BitOperations.PopCount((uint)(start ^ goal));
        }

        public int MinBitFlips3(int start, int goal)
        {
            var result = start ^ goal;
            var count = 0;

            while (result > 0)
            {
                count += result & 1;
                result >>= 1;
            }

            return count;
        }
    }
}