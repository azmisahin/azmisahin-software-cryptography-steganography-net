using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CryptoSteganography.Tests
{
    [TestClass()]
    public class SeparatorTests
    {
        [TestMethod()]
        public void SeparatorTest()
        {
            var instance = new Separator();

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(Separator));
        }

        [TestMethod()]
        public void SourceTypeTest()
        {
            var instance = new Separator()
                .SourceType(SteganographyType.Image);

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(Separator));
        }

        [TestMethod()]
        public void SourceTest()
        {
            var instance = new Separator()
                .Source(new FileInfo("sample/merged/square.text.bmp"));

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(Separator));
        }

        [TestMethod()]
        public void SeparateTypeTest()
        {
            var instance = new Separator()
                .SeparateType(SteganographyType.Text);

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(Separator));
        }

        [TestMethod()]
        public void SeparateTest()
        {
            var instance = new Separator()
                .SourceType(SteganographyType.Image)
                .Source(new FileInfo("sample/merged/square.text.bmp"))
                .SeparateType(SteganographyType.Text)
                .Separate();

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(CryptoImage));

            // Test Modul
            CryptoImage actual = (CryptoImage)instance;

            // Test Condination
            Assert.IsInstanceOfType(actual.String, typeof(string));
        }

        [TestMethod()]
        public void SeparateUTF8Test()
        {
            var instance = new Separator()
                .SourceType(SteganographyType.Image)
                .Source(new FileInfo("sample/merged/square.UTF8.text.bmp"))
                .SeparateType(SteganographyType.Text)
                .Separate();

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(CryptoImage));

            // Test Modul
            CryptoImage actual = (CryptoImage)instance;

            // Test Condination
            Assert.IsInstanceOfType(actual.String, typeof(string));
        }

        [TestMethod()]
        public void SeparateTextTest()
        {
            var instance = new Separator()
                .SourceType(SteganographyType.Text)
                .Source(new FileInfo("sample/merged/steganongraphy.en.txt"))
                .SeparateType(SteganographyType.Text)
                .Separate();

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(CryptoText));

            // Test Modul
            CryptoText actual = (CryptoText)instance;

            // Test Condination
            Assert.IsInstanceOfType(actual.String, typeof(string));
        }
    }
}