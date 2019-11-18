using System.IO;

namespace CryptoSteganography
{
    /// <summary>
    /// Merger Interfaces
    /// </summary>
    public interface IMerger
    {
        IMerger SourceType(SteganographyType type);
        IMerger Source(System.IO.FileInfo file);
        IMerger MergeType(SteganographyType type);
        IMerger Content(string content);
        object Merge(System.IO.FileInfo file);
    }

    /// <summary>
    /// Stegnanograpy Merger
    /// </summary>
    public class Merger : IMerger
    {
        private SteganographyType _sourceType;
        private FileInfo _sourceFile;
        private SteganographyType _mergeType;
        private string _mergeContent;
        private FileInfo _targetFile;

        /// <summary>
        /// Merger
        /// </summary>
        public Merger()
        {
        }

        public IMerger SourceType(SteganographyType type)
        {
            _sourceType = type;
            return this;
        }

        public IMerger Source(FileInfo file)
        {
            _sourceFile = file;
            return this;
        }

        public IMerger MergeType(SteganographyType type)
        {
            _mergeType = type;
            return this;
        }

        public IMerger Content(string content)
        {
            _mergeContent = content;
            return this;
        }

        public object Merge(FileInfo file)
        {
            _targetFile = file;

            CryptoImage cryptoImage = new CryptoImage(_sourceFile);
            
            cryptoImage.Merge(_mergeContent);

            cryptoImage.Save(_targetFile);

            return cryptoImage;
        }
    }
}