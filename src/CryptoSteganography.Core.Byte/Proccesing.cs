namespace CryptoSteganography.Core.Byte
{
    /// <summary>
    /// Byte Proccesing
    /// </summary>
    public class Proccesing
    {
        /// <summary>
        /// Internal Byte Array
        /// </summary>
        private byte[] _ByteArray { get; set; }

        /// <summary>
        /// Returns a Byte Array in Memory.
        /// </summary>
        public byte[] ByteArray { get { return _ByteArray; } }

        /// <summary>
        /// 
        /// </summary>
        public Proccesing()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="byteArray"></param>
        /// <returns></returns>
        public byte[] SetSource(byte[] byteArray)
        {
            this._ByteArray = byteArray;

            return ByteArray;
        }
    }
}
