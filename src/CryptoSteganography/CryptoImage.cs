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
        /// Crypto Image From Bitmap Image
        /// </summary>
        public CryptoImage(Bitmap bitmapImage)
        {
            _BitmapImage = bitmapImage;
        }

        /// <summary>
        /// Crypto Image From File
        /// </summary>
        /// <param name="fileName"></param>
        public CryptoImage(string fileName)
        {
            _FileName = fileName;
            _BitmapImage = new Bitmap(fileName);
        }

        /// <summary>
        /// Crypto Image from File Info
        /// </summary>
        /// <param name="fileInfo"></param>
        public CryptoImage(FileInfo fileInfo)
        {
            _FileName = fileInfo.FullName;
            _BitmapImage = new Bitmap(_FileName);
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

            _Length = _Pixels[0].MergedByteItem;
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
        /// Set Lenth Header
        /// </summary>
        /// <param name="length"></param>
        private void setLength(int length)
        {
            _Length = length;
            _Pixels[0].Merge(length);
            _BitmapImage.SetPixel(_Pixels[0].X, _Pixels[0].Y, _Pixels[0].MERGED_COLOR);
        }
    }
}