using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography;
using CryptoSteganography.Extensions.Picture.Tests.Mock;

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
    }
}