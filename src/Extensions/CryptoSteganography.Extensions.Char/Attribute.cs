using CryptoSteganography.Extensions;
using System;

namespace CryptoSteganography.Extensions.Char
{
    /// <summary>
    /// Char Extension
    /// </summary>
    public static class Attribute
    {
        /// <summary>
        /// Converts an char to a byte type.
        /// </summary>
        /// <param name="charItem"></param>
        /// <returns></returns>
        public static byte ToByte(this char charItem)
        {
            return Convert.ToByte(charItem);
        }
    }
}
