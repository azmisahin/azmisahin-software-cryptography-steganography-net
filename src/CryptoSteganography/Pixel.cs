using System;
using System.Drawing;
using CryptoSteganography.Extensions.Picture;
using CryptoSteganography.Core.Picture;
using CryptoSteganography.Extensions.Byte;

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
        /// </summary>
        internal byte SeparateByteItem 
        {
            get
            {
                var instance = new Separator(COLOR);

                byte actual = instance.SeparateByte();

                return actual;
            }
        }

        /// <summary>
        /// Char Item
        /// </summary>
        public char CharItem
        {
            get
            {
                return SeparateByteItem.ToChar();
            }
        }

        /// <summary>
        /// Merged Color
        /// </summary>
        public Color MERGED_COLOR { get { return _MERGED_COLOR; } }

        /// <summary>
        /// Internal Merged Color
        /// </summary>
        private Color _MERGED_COLOR { get; set; }

        /// <summary>
        /// Merged Byte Item
        /// </summary>
        internal byte MergedByteItem
        {
            get
            {
                var instance = new Separator(MERGED_COLOR);

                byte actual = instance.SeparateByte();

                return actual;
            }
        }

        /// <summary>
        /// Merged Char Item
        /// </summary>
        public char MergedCharItem
        {
            get
            {
                return MergedByteItem.ToChar();
            }
        }

        /// <summary>
        /// Merge Pixel
        /// </summary>
        /// <param name="item"></param>
        public Color Merge(char item)
        {
            var merger = new Core.Picture.Merger(COLOR);

            _MERGED_COLOR = merger.Merge(item);

            return MERGED_COLOR;
        }
    }
}