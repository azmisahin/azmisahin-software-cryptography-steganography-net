namespace CryptoSteganography.Core.Bit
{
    /// <summary>
    /// Bit combiner.
    /// </summary>
    public class Merger
    {
        /// <summary>
        /// Internal Bit Matrix.
        /// </summary>
        private int[,] _BitMatrix { get; set; }

        /// <summary>
        /// Bit Matrix.
        /// </summary>
        public int[,] BitMatrix { get { return _BitMatrix; } }

        /// <summary>
        /// Bit Proccesing.
        /// </summary>
        private Proccesing proccesing { get; set; }
        
        /// <summary>
        /// Bit Matrix Set Source.
        /// </summary>
        /// <param name="bitMatrix">Source Bit Matrix</param>
        public Merger(int[,] bitMatrix)
        {
            proccesing = new Proccesing();
            _BitMatrix = proccesing.SetSource(bitMatrix);
        }

        /// <summary>
        /// Combines the bit matrix with the bit sequence.
        /// </summary>
        /// <param name="bitArray"></param>
        /// <returns>int[,] Merged Bit Matrix.</returns>
        public int[,] Merge(int[] bitArray)
        {
            // Matrix Row.
            int byteCount = BitMatrix.GetLength(0);

            // Matrix Col.
            int bitCount = BitMatrix.GetLength(1);

            // Automatic Merge.
            int[,] result = BitMatrix;

            // F(x,y) 
            // Bit function used in concatenation and separation operations.
            int fx = proccesing.F(byteCount, bitCount);

            // Bit allocation.
            int index = 0;

            // Row count
            int step = byteCount;

            // Recalculating steps.
            if (byteCount > bitCount) step = ((bitCount - fx) * fx) + 1;

            // Operation
            // Row
            for (int r = 0; r < step; r++)
            {
                // Col
                for (int c = fx; c < bitCount; c++)
                {
                    // Row and Col Merge from bitArray.
                    result[r, c] = bitArray[index];
                    index++;
                }
            }

            // Merged Bit Matrix.
            return result;
        }
    }
}