using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography;
using System.IO;
using System.Drawing;

namespace CryptoSteganography.Tests
{
    [TestClass()]
    public class CryptoImageTests
    {
        [TestMethod()]
        public void CryptoImageTest()
        {
            // Instance
            var instance = new CryptoImage(new FileInfo("sample/square.bmp"));

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(CryptoImage));
        }

        [TestMethod()]
        public void CryptoImageTest_Bitmap()
        {
            // Instance
            var instance = new CryptoImage(new Bitmap("sample/square.bmp"));

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(CryptoImage));
        }

        [TestMethod()]
        public void CryptoImageTest_FileName()
        {
            // Instance
            var instance = new CryptoImage("sample/square.bmp");

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(CryptoImage));
        }

        [TestMethod()]
        public void CryptoImageTest_FileInfo()
        {
            // Instance
            var instance = new CryptoImage(new FileInfo("sample/square.bmp"));

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(CryptoImage));
        }
    }
}