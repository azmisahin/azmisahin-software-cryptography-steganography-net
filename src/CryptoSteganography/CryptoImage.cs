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
    }
}