using System.Linq;

namespace EuclideanAlgorithm
{
    public static class GreatestCommonDivisor
    {
        public static int GetGreatestCommonDivisor(this int[] numbersArray)
        {
            return numbersArray.Aggregate(GetGreatestCommonDivisor);
        }

        private static int GetGreatestCommonDivisor(int a, int b)
        {
            return b == 0 ? a : GetGreatestCommonDivisor(b, a % b);
        }
    }
}
