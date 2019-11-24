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
        /// <summary>
        /// 
        /// </summary>
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
        /// Space
        /// </summary>
        private string _space = "sp";

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
                    int valid = str.Substring(0, 1)[0];

                    if (valid <= 97 || valid >= 122)
                        continue;

                    char chr = str.Substring(_position - 1, 1)[0];

                    bool IsLower = char.IsLower(item);

                    char lower = char.ToLower(item);

                    if (lower == chr)
                    {
                        if (!IsLower)
                        {
                            word = str.ToUpper();
                        }
                        else
                        {
                            word = str;
                        }

                        if (item <= 97 || item >= 122)
                        {
                            if (item == 32)
                            {
                                word = _space;
                            }
                            else
                            {
                                word = item.ToString();
                            }
                        }

                        return word + " ";
                    }
                }
                catch { }
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

            StreamReader streamReader = new StreamReader(_sourceFile.FullName);
            var stringValue = streamReader.ReadToEnd();

            // Merge Time
            if (_sourceFile.Extension == ".json")
            {
                words = stringValue.ToStringArray();
            }

            // Separate Time
            if (_sourceFile.Extension == ".txt")
            {
                _sentence = stringValue;
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
            try
            {
                File.WriteAllText(_targetFile.FullName, Sentence);
            }
            catch (System.Exception ex)
            {
                // Save Error
                System.Console.WriteLine(ex);
            }
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
                string[] collection = _sentence.Split(' ');
                foreach (string word in collection)
                {
                    try
                    {
                        if (word == _space)
                        {
                            result += " ";
                        }
                        else
                        {
                            if (word.Length == 1)
                            {
                                result += word;
                            }
                            else
                            {
                                result += word.Substring(_position - 1, 1);
                            }
                        }
                    }
                    catch { }
                }
                return result;
            }
        }
    }
}
