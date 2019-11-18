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
        /// Internal Pixels
        /// </summary>
        private List<Pixel> _Pixels { get; set; }

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
            return _Pixels;
        }

        /// <summary>
        /// 32 Bit ARGB
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        private Bitmap ReInitalize(Bitmap bitmap)
        {
            // Bitmap Image 32 Bit Re Initalize Procces
            //

            return bitmap;
        }
        
        /// <summary>
        /// Internal Content Length
        /// </summary>
        public int _Length { get; set; }

        /// <summary>
        /// Initalize Constractor
        /// </summary>
        private void init()
        {
            _Pixels = getPixels();

            // String Length
            _Length = getStringLength();
        }

        /// <summary>
        /// if there is string return string length
        /// </summary>
        /// <returns></returns>
        private int getStringLength() {

            return _Pixels[0].Int;
        }

        /// <summary>
        /// String Length set pixel color bitmap
        /// </summary>
        /// <param name="length"></param>
        private void setStringLength(int length)
        {
            _Length = length;
            _Pixels[0].Merge(length);
            _BitmapImage.SetPixel(_Pixels[0].X, _Pixels[0].Y, _Pixels[0].COLOR);
        }

        /// <summary>
        /// Crypto Image From Bitmap Image
        /// </summary>
        public CryptoImage(Bitmap bitmapImage)
        {
            _BitmapImage = ReInitalize(bitmapImage);
            init();
        }

        /// <summary>
        /// Crypto Image From File
        /// </summary>
        /// <param name="fileName"></param>
        public CryptoImage(string fileName)
        {
            _FileName = fileName;
            _BitmapImage = ReInitalize(new Bitmap(fileName));
            init();
        }

        /// <summary>
        /// Crypto Image from File Info
        /// </summary>
        /// <param name="fileInfo"></param>
        public CryptoImage(FileInfo fileInfo)
        {
            _FileName = fileInfo.FullName;
            _BitmapImage = ReInitalize(new Bitmap(_FileName));
            init();
        }

        /// <summary>
        /// Image Pixels
        /// </summary>
        public List<Pixel> Pixels
        {
            get
            {
                return _Pixels;
            }
        }

        /// <summary>
        /// Content Length
        /// </summary>
        public int Length { get { return _Length; } }

        /// <summary>
        /// Merge String
        /// </summary>
        /// <param name="value"></param>
        public void Merge(string value)
        {
            byte[] utf8Value = System.Text.Encoding.UTF8.GetBytes(value);
            int stringLength = utf8Value.Length;
            int endPosition = _StartPosition + stringLength;
            
            for (int i = _StartPosition; i < endPosition; i++)
            {
                int charPosition = i - _StartPosition;
                var item = utf8Value[charPosition];
                _Pixels[i].Merge(item);
                _BitmapImage.SetPixel(_Pixels[i].X, _Pixels[i].Y, _Pixels[i].COLOR);
            }
            setStringLength(stringLength);
        }

        /// <summary>
        /// Get Merged String
        /// Separate From Color
        /// </summary>
        /// <returns></returns>
        public string String
        {
            get
            {
                string result = "";
                int endPosition = _StartPosition + Length;
                byte[] buffer = new byte[Length];
                for (int i = _StartPosition; i < endPosition; i++)
                {
                    char item = _Pixels[i].Char;
                    buffer[i - _StartPosition] = _Pixels[i].Byte;
                    result += item;
                }
                result = System.Text.Encoding.UTF8.GetString(buffer, 0, buffer.Length);

                return result;
            }
        }
        
        /// <summary>
        /// Merged Bitmap Save
        /// </summary>
        /// <param name="file"></param>
        public void Save(FileInfo file)
        {
            try
            {
                BitmapImage.Save(file.FullName);
            }
            catch (System.Exception ex)
            {
                // Save Error
                System.Console.WriteLine(ex);
            }

        }
    }
}