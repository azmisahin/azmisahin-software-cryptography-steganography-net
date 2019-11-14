using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography.Extensions.Int;
using CryptoSteganography.Extensions.Int.Tests.Mock;

namespace CryptoSteganography.Extensions.Int.Tests
{
    [TestClass()]
    public class AttributeTests
    {
        [TestMethod()]
        public void ToByteTest()
        {
            // Test Module
            byte actual = IntMock.IntArray.ToByte();
            byte expected = IntMock.ByteItem;

            // Test Condition
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToByteArrayTest()
        {

            // Test Module
            byte[] actual = IntMock.IntMatrix.ToByteArray();
            byte[] expected = IntMock.ByteArray;

            // Test Condition
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}