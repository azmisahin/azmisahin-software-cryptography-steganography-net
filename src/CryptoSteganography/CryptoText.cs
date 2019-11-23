﻿using CryptoSteganography.Extensions.Json;
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
        private int _position = 2;

        /// <summary>
        /// 
        /// </summary>
        private string _sentence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private string getWordsStartsWith(char item)
        {
            string word = item.ToString() + " ";
            foreach (string str in words)
            {
                try
                {
                    char chr = str.Substring(_position - 1, 1)[0];

                    bool IsLower = char.IsLower(item);

                    char lower = char.ToLower(item);

                    if (lower == chr)
                    {
                        if (!IsLower)
                        {
                            word = str.ToUpper() + " ";
                        }
                        else
                        {
                            word = str + " ";
                        }
                        return word;
                    }
                }
                finally { }
            }
            return word;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Sentence { get { return _sentence; } }
        
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
        public string Merge(string _mergeContent)
        {
            foreach (char item in _mergeContent)
            {
                string word = getWordsStartsWith(item);
                _sentence += word;
            }
            return Sentence;
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