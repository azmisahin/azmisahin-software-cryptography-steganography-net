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
        private ushort _BitLength { get; set; }
        
        /// <summary>
        /// Returns the bit length.
        /// </summary>
        public ushort BitLength { get { return _BitLength; } }
        
        /// <summary>
        /// Bits in memory.
        /// </summary>
        private int[,] _BitMatrix { get; set; }

        /// <summary>
        /// Returns a matrix in memory.
        /// </summary>
        public int[,] BitMatrix { get { return _BitMatrix; } }

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
        ///  Set Bit Matrix With Bit Matrix
        /// </summary>
        /// <param name="bitMatrix"></param>
        /// <returns></returns>
        public int[,] SetSource(int[,] bitMatrix)
        {
            this._BitMatrix = bitMatrix;

            return BitMatrix;
        }
    }
}