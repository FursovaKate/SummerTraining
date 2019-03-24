using System.Linq;

namespace GCDDelegate
{
    public static class GreatestCommonDivisorBinary
    {
        public static int GetGreatestCommonDivisorBinary(this int[] numbersArray)
        {
            return numbersArray.Aggregate(GetGreatestCommonDivisorBinary);
        }

        private static int GetGreatestCommonDivisorBinary(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            if (b == 0)
            {
                return a;
            }
            if (a == b)
            {
                return a;
            }
            if ((a & 1u) == 0)
            {
                return (b & 1u) == 0
                    ? GetGreatestCommonDivisorBinary(a >> 1, b >> 1) << 1
                    : GetGreatestCommonDivisorBinary(a >> 1, b);
            }
            if ((b & 1u) == 0)
            {
                return GetGreatestCommonDivisorBinary(a, b >> 1);
            }

            return (a > b)
                ? GetGreatestCommonDivisorBinary((a - b) >> 1, b)
                : GetGreatestCommonDivisorBinary(a, (b - a) >> 1);
        }
    }
}
