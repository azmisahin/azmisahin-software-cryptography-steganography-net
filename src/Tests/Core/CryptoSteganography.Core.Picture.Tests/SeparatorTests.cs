using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography.Core.Picture;
using CryptoSteganography.Extensions.Picture.Tests.Mock;
using CryptoSteganography.Extensions.Byte.Tests.Mock;

namespace CryptoSteganography.Core.Picture.Tests
{
    [TestClass()]
    public class SeparatorTests
    {
        [TestMethod()]
        public void SeparatorTest()
        {
            // Instance
            var instance = new Separator(PictureMock.SampleMergedColor);

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(Separator));
        }

        [TestMethod()]
        public void SeparateByteTest()
        {
            // Instance
            var instance = new Separator(PictureMock.SampleMergedColor);

            // Test Modul
            byte expected = ByteMock.ByteItem;
            byte actual = instance.SeparateByte();

            // Test Condination
            Assert.AreEqual(expected, actual);
        }
    }
}