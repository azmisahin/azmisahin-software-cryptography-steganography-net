using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography.Extensions.String;
using CryptoSteganography.Extensions.String.Tests.Mock;

namespace CryptoSteganography.Extensions.String.Tests
{
    [TestClass()]
    public class AttributeTests
    {
        [TestMethod()]
        public void ToByteArrayTest()
        {
            // Test Module
            byte[] actual = StringMock.StringItem.ToByteArray();
            byte[] expected = StringMock.StringByteArray;

            // Test Condition
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}