using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using CryptoSteganography.Extensions.String.Tests.Mock;
using CryptoSteganography.Extensions.Picture.Tests.Mock;
using System;

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
            string actual = instance.String;

            // Test Condination
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SeparateTest()
        {
            // Instance
            var instance = new CryptoImage(new FileInfo("sample/merged/square.text.bmp"));
            var pixel = instance.BitmapImage.GetPixel(0, 0);

            // Instance
            var separator = new Core.Picture.Separator(pixel);

            // Test Modul
            int expected = PictureMock.SampleInt;
            int actual = separator.SeparateByte();

            // Test Condination
            Assert.AreEqual(expected, actual);

            // Test Condination
            Assert.IsTrue(instance.String.Length == PictureMock.SampleInt);

            // Test Condination
            Assert.AreEqual(StringMock.StringItem, instance.String);
        }

        [TestMethod()]
        public void SaveTest()
        {
            // Instance
            var instance = new CryptoImage(new FileInfo("sample/square.bmp"));

            // Test Modul
            instance.Merge(StringMock.StringItem);
            string expected = StringMock.StringItem;
            string actual = instance.String;

            // Test Condination
            Assert.AreEqual(expected, actual);

            // Thread SAFE
            System.Threading.Thread.Sleep(20);
            instance.Save(new FileInfo("sample/merged/square.text." + DateTime.Now.Ticks + ".bmp"));
        }
    }
}