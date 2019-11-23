using CryptoSteganography.Extensions.Json;
using System;
using System.IO;

namespace CryptoSteganography
{
    /// <summary>
    /// Cryptograpy Text
    /// </summary>
    public class CryptoText
    {
        private FileInfo _sourceFile;

        /// <summary>
        /// 
        /// </summary>
        private string[] words { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_sourceFile"></param>
        public CryptoText(FileInfo _sourceFile)
        {
            this._sourceFile = _sourceFile;

            if (_sourceFile.Extension == ".json")
            {
                StreamReader streamReader = new StreamReader(_sourceFile.FullName);
                var stringJson = streamReader.ReadToEnd();
                words = stringJson.ToStringArray();
            }            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_mergeContent"></param>
        public void Merge(string _mergeContent)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_targetFile"></param>
        public void Save(FileInfo _targetFile)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Merged String
        /// Separate From String
        /// </summary>
        /// <returns></returns>
        public string String
        {
            get
            {
                string result = "";

                return result;
            }
        }
    }
}
