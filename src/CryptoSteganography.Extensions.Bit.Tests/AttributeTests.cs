using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography.Extensions.Bit.Tests.Mock;

namespace CryptoSteganography.Extensions.Bit.Tests
{
    [TestClass()]
    public class AttributeTests
    {
        [TestMethod()]
        public void ToIntArrayTest()
        {
            // Test Module
            int[] expected = BitMock.BitArray;
            int[] actual = BitMock.BoolArray.ToIntArray();

            // Test Condition
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}