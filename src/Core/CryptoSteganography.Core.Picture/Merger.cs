using CryptoSteganography.Extensions.Char;
using CryptoSteganography.Extensions.Picture;
using System;
using System.Drawing;

namespace CryptoSteganography.Core.Picture
{
    /// <summary>
    /// Picture Merger
    /// </summary>
    public class Merger
    {
        /// <summary>
        /// Internal Color Item
        /// </summary>
        private Color _ColorItem { get; set; }

        /// <summary>
        /// Merged Color
        /// </summary>
        public Color ColorItem { get { return _ColorItem; } }

        /// <summary>
        /// Byte Merger
        /// </summary>
        private Byte.Merger ByteMerger { get; set; }

        /// <summary>
        /// Merger Color.
        /// </summary>
        /// <param name="colorItem">Source Color</param>
        public Merger(Color colorItem)
        {
            _ColorItem = colorItem;

            ByteMerger = new Byte.Merger(colorItem.ToByteArray());
        }

        /// <summary>
        /// Merge From Byte Item
        /// </summary>
        /// <param name="byteItem"></param>
        /// <returns></returns>
        public Color Merge(byte byteItem)
        {
            Color result;

            byte[] byteArray = ByteMerger.Merge(byteItem);

            int A, R, G, B;

            A = byteArray[0];
            R = byteArray[1];
            G = byteArray[2];
            B = byteArray[3];

            result = Color.FromArgb(alpha: A, red: R, green: G, blue: B);

            return result;
        }

        /// <summary>
        /// Merge From Char Item
        /// </summary>
        /// <param name="charItem"></param>
        /// <returns></returns>
        public Color Merge(char charItem)
        {
            byte byteItem = charItem.ToByte();

            Color result = Merge(byteItem);

            return result;
        }

        /// <summary>
        /// Merge From Int
        /// </summary>
        /// <param name="intItem"></param>
        /// <returns></returns>
        public Color Merge(int intItem)
        {
            byte byteItem = Convert.ToByte(intItem);

            Color result = Merge(byteItem);

            return result;
        }
    }
}
