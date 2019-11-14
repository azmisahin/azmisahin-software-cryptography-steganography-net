using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography.Extensions.Char;
using CryptoSteganography.Extensions.Char.Tests.Mock;

namespace CryptoSteganography.Extensions.Char.Tests
{
    [TestClass()]
    public class AttributeTests
    {
        [TestMethod()]
        public void ToByteTest()
        {
            // Test Module
            byte actual = CharMock.CharItem.ToByte();
            byte expected = CharMock.ByteItem;

            // Test Condition
            Assert.AreEqual(expected, actual);
        }
    }
}