namespace CryptoSteganography.Core.Bit
{
    /// <summary>
    /// Bit Proccesing
    /// </summary>
    public class Proccesing : Core.Proccesing
    {
        /// <summary>
        /// The default bit length for bit operations.
        /// 8, 16, 24, 32, .., 32768
        /// </summary>
        private ushort defaultBitLength { get; set; }

        /// <summary>
        /// Bits in memory.
        /// </summary>
        private int[,] bits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Proccesing()
        {
            defaultBitLength = 8;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bitLength"></param>
        public Proccesing(ushort bitLength)
        {
            defaultBitLength = bitLength;
        }

        /// <summary>
        /// Returns the bit length.
        /// </summary>
        public ushort BitLength { get { return defaultBitLength; } }

        /// <summary>
        /// Returns a matrix in memory.
        /// </summary>
        public int[,] BitMatrix { get { return bits; } }

        /// <summary>
        ///  Set Bit Matrix With Bit Matrix
        /// </summary>
        /// <param name="bitMatrix"></param>
        /// <returns></returns>
        public int[,] SetSource(int[,] bitMatrix)
        {
            this.bits = bitMatrix;
            return bits;
        }
    }
}