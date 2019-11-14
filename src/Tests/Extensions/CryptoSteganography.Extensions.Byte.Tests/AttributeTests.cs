using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography.Extensions.Bit.Tests.Mock;
using CryptoSteganography.Extensions.Byte.Tests.Mock;
using CryptoSteganography.Extensions.Byte;
using System.Collections;

namespace CryptoSteganography.Extensions.Byte.Tests
{
    [TestClass()]
    public class AttributeTests
    {
        [TestMethod()]
        public void ToBitCollectionTest()
        {
            // Test Module
            BitArray actual = ByteMock.ByteItem.ToBitCollection();

            // Test Condition
            Assert.IsNotNull(actual);
        }

        [TestMethod()]
        public void ToBitArrayTest()
        {
            // Test Module
            int[] actual = ByteMock.ByteItem.ToBitArray(BitMock.BitLength);
            int[] expected = BitMock.BitArray;

            // Test Condition
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToBitMatrixTest()
        {
            // Test Module
            int[,] actual = ByteMock.ByteArray.ToBitMatrix(BitMock.BitLength);
            int[,] expected = BitMock.BitMatrix;

            // Test Condition
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToIntTest()
        {
            // Test Module
            int actual = ByteMock.ByteItem.ToInt();
            int expected = ByteMock.IntItem;

            // Test Condition
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToCharTest()
        {
            // Test Module
            char actual = ByteMock.ByteItem.ToChar();
            char expected = ByteMock.CharItem;

            // Test Condition
            Assert.AreEqual(expected, actual);
        }
    }
}