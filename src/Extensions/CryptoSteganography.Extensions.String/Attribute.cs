using CryptoSteganography.Extensions;

namespace CryptoSteganography.Extensions.String
{
    /// <summary>
    /// String Extension
    /// </summary>
    public static class Attribute
    {
        /// <summary>
        /// Converts string to byte array.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(this string value)
        {
            return System.Text.Encoding.UTF8.GetBytes(value);
        }
    }
}
