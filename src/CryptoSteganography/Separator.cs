using System;
using System.IO;

namespace CryptoSteganography
{
    /// <summary>
    /// Separator Interfaces
    /// </summary>
    public interface ISeparator
    {
        ISeparator SourceType(SteganographyType type);
        ISeparator Source(System.IO.FileInfo file);
        ISeparator SeparateType(SteganographyType type);
        object Separate();
    }

    /// <summary>
    /// Stegnanograpy Separator
    /// </summary>
    public class Separator : ISeparator
    {
        private SteganographyType _sourceType;
        private FileInfo _sourceFile;
        private SteganographyType _separateType;

        /// <summary>
        /// Separator
        /// </summary>
        public Separator()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public ISeparator SourceType(SteganographyType type)
        {
            _sourceType = type;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public ISeparator Source(FileInfo file)
        {
            _sourceFile = file;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public ISeparator SeparateType(SteganographyType type)
        {
            _separateType = type;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object Separate()
        {
            object result = null;

            switch (_sourceType)
            {
                case SteganographyType.Text:
                    result = separateText();
                    break;
                case SteganographyType.Image:
                    result = separateImage();
                    break;
                case SteganographyType.Binary:
                    break;
                case SteganographyType.Audio:
                    break;
                case SteganographyType.Video:
                    break;
                default:
                    break;
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private CryptoImage separateImage()
        {
            CryptoImage result = new CryptoImage(_sourceFile);

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private CryptoText separateText()
        {
            CryptoText result = new CryptoText(_sourceFile);

            return result;
        }
    }
}