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

        public ISeparator SourceType(SteganographyType type)
        {
            _sourceType = type;
            return this;
        }

        public ISeparator Source(FileInfo file)
        {
            _sourceFile = file;
            return this;
        }

        public ISeparator SeparateType(SteganographyType type)
        {
            _separateType = type;
            return this;
        }

        public object Separate()
        {
            CryptoImage cryptoImage = new CryptoImage(_sourceFile);

            return cryptoImage;
        }
    }
}