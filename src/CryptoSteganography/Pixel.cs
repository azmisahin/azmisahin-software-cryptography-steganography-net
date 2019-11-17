using System.Drawing;

namespace CryptoSteganography
{
    /// <summary>
    /// Image Pixel
    /// </summary>
    public class Pixel
    {
        /// <summary>
        /// Pixel ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Pixel X Horizontal Coordinate
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Pixel Y Vertical Coordinate
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Pixel Color
        /// </summary>
        public Color COLOR { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">Horizontal Coordinate</param>
        /// <param name="y">Vertical Coordinate</param>
        /// <param name="color">ARGB Color</param>
        public Pixel(int x, int y, Color color)
        {
            X = x;
            Y = y;
            COLOR = color;
        }
    }
}