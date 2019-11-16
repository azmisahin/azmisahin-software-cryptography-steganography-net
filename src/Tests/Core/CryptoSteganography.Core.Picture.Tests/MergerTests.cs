using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography.Core.Picture;
using CryptoSteganography.Extensions.Picture.Tests.Mock;
using CryptoSteganography.Extensions.Byte.Tests.Mock;
using System.Drawing;

namespace CryptoSteganography.Core.Picture.Tests
{
    [TestClass()]
    public class MergerTests
    {
        [TestMethod()]
        public void MergerTest()
        {
            // Instance
            var instance = new Merger(PictureMock.SampleColor);

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(Merger));
        }

        [TestMethod()]
        public void MergeTest()
        {
            // Instance
            var instance = new Merger(PictureMock.SampleColor);

            // Test Modul
            Color expected = PictureMock.SampleMergedColor;
            Color actual = instance.Merge(ByteMock.ByteItem);

            // Test Condination
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MergeTest_Char()
        {
            // Instance
            var instance = new Merger(PictureMock.SampleColor);

            // Test Modul
            Color expected = PictureMock.SampleMergedColor;
            Color actual = instance.Merge(ByteMock.CharItem);

            // Test Condination
            Assert.AreEqual(expected, actual);
        }
    }
}