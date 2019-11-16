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
        /// Byte Array Set Source.
        /// </summary>
        /// <param name="byteArray">Source Byte Array</param>
        public Merger(byte[] byteArray)
        {
            proccesing = new Proccesing();
            _ByteArray = proccesing.SetSource(ByteArray);
        }

        /// <summary>
        /// Merge Byte Item with Byte Array
        /// </summary>
        /// <param name="byteItem"></param>
        /// <returns></returns>
        public byte[] Merge(byte byteItem)
        {
            byte[] result = ByteArray;

            return result;
        }
    }
}