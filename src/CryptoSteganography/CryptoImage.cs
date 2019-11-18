using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace CryptoSteganography
{
    /// <summary>
    /// Crypto Image
    /// </summary>
    public class CryptoImage
    {
        /// <summary>
        /// Start Position
        /// </summary>
        private readonly ushort _StartPosition = 10;
         
        /// <summary>
        /// Internal Image
        /// </summary>
        private Bitmap _BitmapImage { get; set; }

        /// <summary>
        /// Internal File Name
        /// </summary>
        private string _FileName { get; set; }

        /// <summary>
        /// Image
        /// </summary>
        public Bitmap BitmapImage { get { return _BitmapImage; } }

        /// <summary>
        /// File Name
        /// </summary>
        public string FileName { get { return _FileName; } }

        /// <summary>
        /// 32 Bit ARGB
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        private Bitmap ReInitalize(Bitmap bitmap)
        {
            Bitmap sourceBitmap = bitmap;
            Bitmap targetBitmap = new Bitmap(bitmap);
            return targetBitmap;
        }

        /// <summary>
        /// Crypto Image From Bitmap Image
        /// </summary>
        public CryptoImage(Bitmap bitmapImage)
        {
            _BitmapImage = ReInitalize(bitmapImage);
        }

        /// <summary>
        /// Crypto Image From File
        /// </summary>
        /// <param name="fileName"></param>
        public CryptoImage(string fileName)
        {
            _FileName = fileName;
            _BitmapImage = ReInitalize(new Bitmap(fileName));
        }

        /// <summary>
        /// Crypto Image from File Info
        /// </summary>
        /// <param name="fileInfo"></param>
        public CryptoImage(FileInfo fileInfo)
        {
            _FileName = fileInfo.FullName;
            _BitmapImage = ReInitalize(new Bitmap(_FileName));
        }

        /// <summary>
        /// Internal Pixels
        /// </summary>
        private List<Pixel> _Pixels { get; set; }

        /// <summary>
        /// Image Pixels
        /// </summary>
        public List<Pixel> Pixels
        {
            get
            {
                if (_Pixels == null)
                    return getPixels();
                else
                    return _Pixels;
            }
        }

        /// <summary>
        /// Content Length
        /// </summary>
        public int Length { get { return _Length; } }

        /// <summary>
        /// Internal Content Length
        /// </summary>
        public int _Length { get; set; }

        /// <summary>
        /// Get Pixels
        /// </summary>
        /// <returns></returns>
        private List<Pixel> getPixels()
        {
            _Pixels = new List<Pixel>();
            int id = 0;
            for (int x = 0; x < _BitmapImage.Width; x++)
            {
                for (int y = 0; y < _BitmapImage.Height; y++)
                {
                    id++;
                    Color color = _BitmapImage.GetPixel(x, y);
                    Pixel pixel = new Pixel(x, y, color);
                    pixel.ID = id;
                    _Pixels.Add(pixel);
                }
            }

            _Length = _Pixels[0].SeparateByteItem;
            return _Pixels;
        }

        /// <summary>
        /// Merge String
        /// </summary>
        /// <param name="value"></param>
        public void Merge(string value)
        {
            getPixels();

            int length = value.Length;

            setLength(length);

            for (int i = _StartPosition; i < length + _StartPosition; i++)
            {
                int position = i - _StartPosition;
                var item = value[position];
                _Pixels[i].Merge(item);
                _BitmapImage.SetPixel(_Pixels[i].X, _Pixels[i].Y, _Pixels[i].MERGED_COLOR);
            }
        }

        /// <summary>
        /// Get Merged String
        /// </summary>
        /// <returns></returns>
        public string GetMergedString()
        {
            string result = "";
            for (int i = _StartPosition; i < Length + _StartPosition; i++)
            {
                result += Pixels[i].MergedCharItem;
            }
            return result;
        }

        /// <summary>
        /// Get Separate String
        /// </summary>
        /// <returns></returns>
        public string GetSeparateString()
        {
            string result = "";
            for (int i = _StartPosition; i < Length + _StartPosition; i++)
            {
                result += Pixels[i].SeparateByteItem;
            }
            return result;
        }

        /// <summary>
        /// Set Lenth Header
        /// </summary>
        /// <param name="length"></param>
        private void setLength(int length)
        {
            _Length = length;
            _Pixels[0].Merge(length);
            _BitmapImage.SetPixel(_Pixels[0].X, _Pixels[0].Y, _Pixels[0].MERGED_COLOR);
        }

        /// <summary>
        /// Save Merged Image
        /// </summary>
        /// <param name="fileName"></param>
        public void Save(string fileName)
        {
            BitmapImage.Save(fileName);
        }
    }
}