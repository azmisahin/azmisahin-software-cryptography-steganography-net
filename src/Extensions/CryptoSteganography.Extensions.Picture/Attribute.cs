using CryptoSteganography.Extensions;
using System.Drawing;

namespace CryptoSteganography.Extensions.Picture
{
    /// <summary>
    /// Picture Extension
    /// </summary>
    public static class Attribute
    {
        /// <summary>
        /// Converts Color to byte.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(this Color value)
        {
            byte[] result = new byte[4];
            result[0] = value.A;
            result[1] = value.R;
            result[2] = value.G;
            result[3] = value.B;

            return result;
        }
    }
}
