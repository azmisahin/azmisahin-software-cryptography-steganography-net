using System;
using System.Drawing;
using CryptoSteganography.Core.Picture;
using CryptoSteganography.Extensions.Byte;
using CryptoSteganography.Extensions.Char;
using CryptoSteganography.Extensions.Int;

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

        /// <summary>
        /// Byte Item
        /// Separate From Color
        /// </summary>
        public byte Byte
        {
            get
            {
                var instance = new Core.Picture.Separator(COLOR);

                byte actual = instance.SeparateByte();

                return actual;
            }
        }

        /// <summary>
        /// Char Item
        /// Separate From Color
        /// </summary>
        public char Char
        {
            get
            {
                return Byte.ToChar();
            }
        }

        /// <summary>
        /// Int Item
        /// Separate From Color
        /// </summary>
        public int Int
        {
            get
            {
                return Byte.ToInt();
            }
        }

        /// <summary>
        /// Merge Byte Item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private Color mergeByte(byte item)
        {
            var merger = new Core.Picture.Merger(COLOR);

            COLOR = merger.Merge(item);

            return COLOR;
        }

        /// <summary>
        /// Merge Pixel
        /// </summary>
        /// <param name="item"></param>
        public Color Merge(byte item)
        {
            return mergeByte(item);
        }

        /// <summary>
        /// Merge Pixel
        /// </summary>
        /// <param name="item"></param>
        public Color Merge(char item)
        {
            return mergeByte(item.ToByte());
        }

        /// <summary>
        /// Merge Pixel Int Item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Color Merge(int item)
        {
            return mergeByte(item.ToByte());
        }
    }
}