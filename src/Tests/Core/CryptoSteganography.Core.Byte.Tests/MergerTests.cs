using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography.Core.Byte;
using CryptoSteganography.Extensions.Byte.Tests.Mock;

namespace CryptoSteganography.Core.Byte.Tests
{
    [TestClass()]
    public class MergerTests
    {
        [TestMethod()]
        public void MergerTest()
        {
            // Instance
            var instance = new Merger(ByteMock.ByteArray);

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(Merger));
        }

        [TestMethod()]
        public void MergeTest()
        {
            // Instance
            var instance = new Merger(ByteMock.ByteArray);

            // Test Modul
            byte[] expected = ByteMock.MergedByteArray;
            byte[] actual = instance.Merge(ByteMock.ByteItem);

            // Test Condination
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}