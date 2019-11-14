using CryptoSteganography.Extensions;
using System;

namespace CryptoSteganography.Extensions.Int
{
    /// <summary>
    /// Int Extension
    /// </summary>
    public static class Attribute
    {
        /// <summary>
        /// Converts an int array to a byte type.
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns></returns>
        public static byte ToByte(this int[] intArray)
        {
            string bitString = "";
            foreach (var item in intArray)
            {
                bitString += item;
            }
            if (string.IsNullOrEmpty(bitString))
                throw new Exception("Int Array Required");
            else
                return Convert.ToByte(bitString, 2);
        }

        /// <summary>
        /// Converts an int array to a byte array type.
        /// </summary>
        /// <param name="bitMatrix"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(this int[,] bitMatrix)
        {
            byte[] result;

            // Matrix Row
            int byteCount = bitMatrix.GetLength(0);

            // Matrix Col
            int bitCount = bitMatrix.GetLength(1);

            // Byte Array Re Initalize
            result = new byte[byteCount];

            // Operation
            for (int r = 0; r < byteCount; r++)
            {
                int[] bitArray = new int[bitCount];

                for (int c = 0; c < bitCount; c++)
                {
                    int item = bitMatrix[r, c];
                    bitArray[c] = item;
                }
                result[r] = bitArray.ToByte();
            }
            return result;
        }
    }
}