﻿using System;
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
        /// <param name="_sourceFile"></param>
        public CryptoText(FileInfo _sourceFile)
        {
            this._sourceFile = _sourceFile;
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
