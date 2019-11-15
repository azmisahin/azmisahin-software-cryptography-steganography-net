using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography.Core.Bit;
using CryptoSteganography.Extensions.Bit.Tests.Mock;

namespace CryptoSteganography.Core.Bit.Tests
{
    [TestClass()]
    public class MergerTests
    {
        [TestMethod()]
        public void MergerTest()
        {
            // instance
            var instance = new Merger(BitMock.BitMatrix);

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(Merger));
        }

        [TestMethod()]
        public void MergeTest()
        {
            // instance
            var instance = new Merger(BitMock.BitMatrix);

            // Test Modul
            int[,] expected = BitMock.MergedBitMatrix;
            int[,] actual = instance.Merge(BitMock.BitArray);

            // Test Condination
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}