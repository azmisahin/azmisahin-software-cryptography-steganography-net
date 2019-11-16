using CryptoSteganography.Extensions.Byte;
using CryptoSteganography.Extensions.Int;

namespace CryptoSteganography.Core.Byte
{
    /// <summary>
    /// Byte Separator
    /// </summary>
    public class Separator
    {
        /// <summary>
        /// Bit Separator
        /// </summary>
        private Bit.Separator BitSeparator { get; set; }

        /// <summary>
        /// Internal Byte Array
        /// </summary>
        private byte[] _MergedByteArray { get; set; }

        /// <summary>
        /// Get Merged Byte Array
        /// </summary>
        public byte[] MergedByteArray { get { return _MergedByteArray; } }

        /// <summary>
        /// Internal Byte Item
        /// </summary>
        private byte _byteItem { get; set; }

        /// <summary>
        /// Byte Item
        /// </summary>
        public byte ByteItem { get { return _byteItem; } }

        /// <summary>
        /// Separator
        /// </summary>
        /// <param name="byteArray">Merged Byte Array</param>
        public Separator(byte[] byteArray)
        {
            BitSeparator = new Bit.Separator();
            _MergedByteArray = byteArray;
        }

        /// <summary>
        /// Separate
        /// </summary>
        /// <returns>Separate Byte</returns>
        public byte Separate()
        {
            byte result;

            int[] bitArray = BitSeparator.Separate(MergedByteArray.ToBitMatrix(8));

            _byteItem = bitArray.ToByte();

            result = ByteItem;

            return result;
        }
    }
}
