using CryptoSteganography.Extensions.Picture;
using System.Drawing;

namespace CryptoSteganography.Core.Picture
{
    /// <summary>
    /// Picture Separator
    /// </summary>
    public class Separator
    {
        /// <summary>
        /// Internal Color Item
        /// </summary>
        private Color _ColorItem { get; set; }
        
        /// <summary>
        /// Color Item
        /// </summary>
        public Color ColorItem {  get { return _ColorItem; } }

        /// <summary>
        /// Byte Separator
        /// </summary>
        public Byte.Separator ByteSeparator { get; set; }

        /// <summary>
        /// Separator
        /// </summary>
        /// <param name="colorItem"></param>
        public Separator(Color colorItem)
        {
            _ColorItem = colorItem;
            byte[] byteArray = colorItem.ToByteArray();
            ByteSeparator = new Byte.Separator(byteArray);
        }

        /// <summary>
        /// Separate
        /// </summary>
        /// <returns></returns>
        public byte SeparateByte()
        {
            return ByteSeparator.Separate();
        }
    }
}
