using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography.Extensions.Bit.Tests.Mock;
using CryptoSteganography.Core;
using CryptoSteganography.Core.Bit;

namespace CryptoSteganography.Core.Bit.Tests
{
    [TestClass()]
    public class SeparatorTests
    {
        [TestMethod()]
        public void SeparatorTest()
        {
            // instance
            var instance = new Separator();

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(Separator));
        }

        [TestMethod()]
        public void SeparateTest()
        {
            // instance
            var instance = new Separator();

            // Test Modul
            int[] expected = BitMock.BitArray;
            int[] actual = instance.Separate(BitMock.MergedBitMatrix);

            // Test Condination
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}