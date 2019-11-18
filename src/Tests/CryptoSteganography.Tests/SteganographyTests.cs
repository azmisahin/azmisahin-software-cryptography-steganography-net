using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography;
using System.IO;

namespace CryptoSteganography.Tests
{
    [TestClass()]
    public class SteganographyTests
    {
        [TestMethod()]
        public void SteganographyTest()
        {
            // Instance
            var instance = Steganography.Merger;

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(IMerger));
        }

        [TestMethod()]
        public void SteganographyMergerTest()
        {
            var instance = Steganography
                .Merger
                .SourceType(SteganographyType.Image)
                .Source(new FileInfo("sample/square.bmp"))
                .MergeType(SteganographyType.Text)
                .Content("CryptoSteganography")
                .Merge(new FileInfo("sample/merged/square.txt.bmp"));

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(CryptoImage));
        }


        [TestMethod()]
        public void SteganographySeparatorTest()
        {
            var instance = Steganography
                .Separator
                .SourceType(SteganographyType.Image)
                .Source(new FileInfo("sample/merged/square.txt.bmp"))
                .SeparateType(SteganographyType.Text)
                .Separate();

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(CryptoImage));

            // Test Modul
            CryptoImage actual = (CryptoImage)instance;

            // Test Condination
            Assert.IsInstanceOfType(actual.String, typeof(string));
        }
    }
}