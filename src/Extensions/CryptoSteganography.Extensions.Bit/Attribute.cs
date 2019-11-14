using CryptoSteganography.Extensions;

namespace CryptoSteganography.Extensions.Bit
{
    /// <summary>
    /// Bit Extension
    /// </summary>
    public static class Attribute
    {
        /// <summary>
        /// Convert the bit block to an int array.
        /// </summary>
        /// <param name="bitBlock"></param>
        /// <returns></returns>
        public static int[] ToIntArray (this bool[] bitBlock)
        {
            var result = new int[bitBlock.Length];

            for (int i = 0; i < bitBlock.Length; i++)
            {
                var item = bitBlock[i];

                result[i] = item == true ? 1 : 0;

            }

            return result;
        }
    }
}
