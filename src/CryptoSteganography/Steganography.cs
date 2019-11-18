using System;

namespace CryptoSteganography
{
    /// <summary>
    /// Steganography
    /// </summary>
    public class Steganography
    {
        /// <summary>
        /// 
        /// </summary>
        public Steganography()
        {

        }

        /// <summary>
        /// Merger
        /// </summary>
        public static IMerger Merger
        {
            get
            {
                return new Merger();
            }
        }

        /// <summary>
        /// Separator
        /// </summary>
        public static ISeparator Separator
        {
            get
            {
                return new Separator();
            }
        }
    }
}