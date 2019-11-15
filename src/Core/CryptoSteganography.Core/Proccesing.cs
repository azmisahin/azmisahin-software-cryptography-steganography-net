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
            if (row < 2) throw new System.Exception(" 'row' must be greater than one.");
            if (col < 8) throw new System.Exception(" 'col' must be greater than eight.");

            int fx = 0;

            switch (row)
            {
                case 2: fx = 4; break;
                case 4: fx = 6; break;
                case 8: fx = 7; break;
                case 16: fx = 7; break;
                case 32: fx = 7; break;
                default:fx = 7;break;
            }
            return fx;
        }
    }
}