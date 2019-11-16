using CryptoSteganography.Extensions.Byte;
using CryptoSteganography.Extensions.Int;

namespace CryptoSteganography.Core.Byte
{
    /// <summary>
    /// Byte Mergers
    /// </summary>
    public class Merger
    {
        /// <summary>
        /// Internal Byte Array
        /// </summary>
        private byte[] _ByteArray { get; set; }

        /// <summary>
        /// Byte Array
        /// </summary>
        public byte[] ByteArray { get { return _ByteArray; } }

        /// <summary>
        /// Byte Proccesing
        /// </summary>
        public Proccesing proccesing { get; set; }

        /// <summary>
        /// Bit Merger
        /// </summary>
        public Bit.Merger BitMerger { get; set; }

        /// <summary>
        /// Byte Array Set Source.
        /// </summary>
        /// <param name="byteArray">Source Byte Array</param>
        public Merger(byte[] byteArray)
        {
            proccesing = new Proccesing();
            BitMerger = new Bit.Merger(byteArray.ToBitMatrix(8));
            _ByteArray = proccesing.SetSource(byteArray);
        }

        /// <summary>
        /// Merge Byte Item with Byte Array
        /// </summary>
        /// <param name="byteItem"></param>
        /// <returns></returns>
        public byte[] Merge(byte byteItem)
        {
            byte[] result = ByteArray;

            var bitMatrix = BitMerger.Merge(byteItem.ToBitArray(8));

            result = bitMatrix.ToByteArray();

            return result;
        }
    }
}