using System;
using System.Collections;
using System.Text;

namespace DoubleConverter
{
    public static class DoubleConverter
    {
        public static string ConvertToIEEE754(this double number)
        {
            var currentBitArray = new BitArray(BitConverter.GetBytes(number));

            var bitArray = new StringBuilder(64);

            for (var i = currentBitArray.Length - 1; i >= 0; i--)
            {
                bitArray.Append(currentBitArray[i] ? '1' : '0');
            }
            return bitArray.ToString();
        }
    }
}