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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IMerger SourceType(SteganographyType type)
        {
            _sourceType = type;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public IMerger Source(FileInfo file)
        {
            _sourceFile = file;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IMerger MergeType(SteganographyType type)
        {
            _mergeType = type;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public IMerger Content(string content)
        {
            _mergeContent = content;
            return this;
        }

        /// <summary>
        /// Merge Swicher
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public object Merge(FileInfo file)
        {
            _targetFile = file;

            object result = null;

            switch (_sourceType)
            {
                case SteganographyType.Text:
                    result = mergeText();
                    break;
                case SteganographyType.Image:
                    result = mergeImage();
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
        /// Merge Image
        /// </summary>
        /// <returns></returns>
        private CryptoImage mergeImage()
        {

            CryptoImage result = new CryptoImage(_sourceFile);

            result.Merge(_mergeContent);

            result.Save(_targetFile);

            return result;
        }

        /// <summary>
        /// Merge Text
        /// </summary>
        /// <returns></returns>
        private object mergeText()
        {
            CryptoText result = new CryptoText(_sourceFile);

            result.Merge(_mergeContent);

            result.Save(_targetFile);

            return result;
        }
    }
}