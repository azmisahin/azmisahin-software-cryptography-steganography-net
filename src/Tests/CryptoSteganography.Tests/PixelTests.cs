using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography;
using CryptoSteganography.Extensions.Picture.Tests.Mock;
using CryptoSteganography.Extensions.Char.Tests.Mock;
using System.Drawing;

namespace CryptoSteganography.Tests
{
    [TestClass()]
    public class PixelTests
    {
        [TestMethod()]
        public void PixelTest()
        {
            // Instance
            var instance = new Pixel(0, 0, PictureMock.SampleColor);

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(Pixel));
        }

        [TestMethod()]
        public void MergeTest()
        {
            // Instance
            var instance = new Pixel(0, 0, PictureMock.SampleColor);

            // Test Modul
            Color expected = PictureMock.SampleMergedColor;
            Color actual = instance.Merge(CharMock.CharItem);

            // Test Condination
            Assert.AreEqual(expected, actual);

            // Test Condination
            Assert.AreEqual(CharMock.CharItem, instance.MergedCharItem);
        }
    }
}