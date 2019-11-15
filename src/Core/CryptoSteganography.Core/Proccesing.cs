namespace CryptoSteganography.Core
{
    /// <summary>
    /// Core Proccesing
    /// </summary>
    public class Proccesing
    {
        /// <summary>
        /// Matrix function used in concatenation and separation operations.
        /// </summary>
        /// <param name="row">byte row</param>
        /// <param name="col">bit col</param>
        /// <returns></returns>
        public int F(int row, int col)
        {
            if (col < 2) throw new System.Exception(" 'col' must be greater than one.");
            int area = row / col;
            int fx = row - area;
            if (fx == row) fx--;
            return fx;
        }
    }
}