using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using CryptoSteganography.Extensions.String.Tests.Mock;

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

        [TestMethod()]
        public void CryptoImageTest_GetPixels()
        {
            // Instance
            var instance = new CryptoImage(new FileInfo("sample/square.bmp"));

            // Test Modul
            var actual = instance.Pixels;

            // Test Condination
            Assert.IsInstanceOfType(actual, typeof(List<Pixel>));

            // Test Condination
            Assert.IsTrue(actual.Count > 0);
        }

        [TestMethod()]
        public void MergeTest()
        {
            // Instance
            var instance = new CryptoImage(new FileInfo("sample/square.bmp"));

            // Test Modul
            instance.Merge(StringMock.StringItem);
            string expected = StringMock.StringItem;
            string actual = instance.GetMergedString();

            // Test Condination
            Assert.AreEqual(expected, actual);            

            // Test Modul
            instance.Save("sample/merged/square.text.bmp");
        }
        public readonly static int SampleInt = 19;
        public readonly static Color SampleIntMerger = Color.FromArgb(252, 253, 252, 255);
        [TestMethod()]
        public void SeparateTest()
        {
            // Instance
            var instance = new CryptoImage(new FileInfo("sample/merged/square.text.bmp"));

            // Test Modul
            string expected = StringMock.StringItem;
            string actual = instance.GetSeparateString();
            string actual2 = instance.GetMergedString();

            // Test Condination
            Assert.AreEqual(expected, actual);
        }
    }
}