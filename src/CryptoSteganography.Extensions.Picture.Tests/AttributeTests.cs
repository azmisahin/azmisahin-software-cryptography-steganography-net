using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography.Extensions.Picture;
using CryptoSteganography.Extensions.Picture.Tests.Mock;

namespace CryptoSteganography.Extensions.Picture.Tests
{
    [TestClass()]
    public class AttributeTests
    {
        [TestMethod()]
        public void ToByteArrayTest()
        {
            // Test Module
            byte[] actual = PictureMock.SampleColor.ToByteArray();
            byte[] expected = PictureMock.SampleColorByteArray;

            // Test Condition
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}