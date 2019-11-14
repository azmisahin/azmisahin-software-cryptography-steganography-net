using CryptoSteganography.Extensions;
using System;
using System.Collections;

namespace CryptoSteganography.Extensions.Byte
{
    /// <summary>
    /// Byte Extension
    /// </summary>
    public static class Attribute
    {
        /// <summary>
        /// Converts byte to bit.
        /// </summary>
        /// <param name="byteVaue"></param>
        /// <returns></returns>
        public static BitArray ToBitCollection(this byte byteVaue)
        {
            return new BitArray(new byte[] { (byte)byteVaue });
        }

        /// <summary>
        /// Reverses the byte value to the bit value.
        /// </summary>
        /// <param name="byteVaue"></param>
        /// <param name="bitLength"></param>
        /// <returns></returns>
        public static int[] ToBitArray(this byte byteVaue, int bitLength)
        {
            int bit = bitLength - 1;

            int[] result = new int[bitLength];
            var collection = byteVaue.ToBitCollection();
            foreach (bool item in collection)
            {
                result[bit] = item == true ? 1 : 0;

                // Reverse Bit
                bit -= 1;
            }
            return result;
        }

        /// <summary>
        /// Configures the byte array to the bit matrix by the bit length.
        /// </summary>
        /// <param name="byteArray"></param>
        /// <param name="bitLength"></param>
        /// <returns></returns>
        public static int[,] ToBitMatrix(this byte[] byteArray, int bitLength)
        {
            int[,] result = new int[byteArray.Length, bitLength];

            for (int i = 0; i < byteArray.Length; i++)
            {
                byte byteVlue = byteArray[i];
                var bitArray = byteVlue.ToBitArray(bitLength);
                for (int b = 0; b < bitArray.Length; b++)
                {
                    int item = bitArray[b];
                    result[i, b] = item;
                }
            }
            return result;
        }

        /// <summary>
        /// Converts byte to int.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToInt(this byte value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>
        /// Converts byte data to char.
        /// </summary>
        /// <param name="byteItem"></param>
        /// <returns></returns>
        public static char ToChar(this byte byteItem)
        {
            char result = Convert.ToChar(byteItem);
            return result;
        }
    }
}
