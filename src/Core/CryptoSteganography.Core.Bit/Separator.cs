namespace CryptoSteganography.Core.Bit
{
    /// <summary>
    /// Bit separator.
    /// </summary>
    public class Separator
    {
        /// <summary>
        /// Bit Proccesing.
        /// </summary>
        private Proccesing proccesing { get; set; }

        /// <summary>
        /// Separator
        /// </summary>
        public Separator()
        {
            proccesing = new Proccesing();
        }

        /// <summary>
        /// Separates the bit array from the bit matrix.
        /// </summary>
        /// <param name="bitMatrix">Merged Bit Matrix</param>
        /// <returns>int[] Separated Bit Array</returns>
        public int[] Separate(int[,] bitMatrix)
        {
            int[] result;

            // Matrix Row.
            int byteCount = bitMatrix.GetLength(0);

            // Matrix Col.
            int bitCount = bitMatrix.GetLength(1);

            // Automatic Define.
            result = new int[bitCount];

            // f(x,y) 
            // Bit function used in concatenation and separation operations.
            int fx = proccesing.F(byteCount, bitCount);

            // Bit allocation.
            int index = 0;

            // Row Count
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
                    // Row and Col Separate from bitMatrix.
                    result[index] = bitMatrix[r, c];
                    index++;
                }
            }

            // Separated Bit Array
            return result;
        }
    }
}