using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography.Extensions.Bit.Tests.Mock;
using CryptoSteganography.Core;
using CryptoSteganography.Core.Bit;

namespace CryptoSteganography.Core.Bit.Tests
{
    [TestClass()]
    public class ProccesingTests
    {
        [TestMethod()]
        public void ProccesingTest()
        {
            // instance
            var instance = new Proccesing();

            // Test Condition
            Assert.IsInstanceOfType(instance, typeof(Proccesing));
        }

        [TestMethod()]
        public void ProccesingTest_Parameter()
        {
            // instance
            var instance = new Proccesing(8);

            // Test Condition
            Assert.IsInstanceOfType(instance, typeof(Proccesing));
        }

        [TestMethod()]
        public void SetSourceTest()
        {
            // instance
            var instance = new Proccesing();

            // Test Module
            int[,] expected = BitMock.BitMatrix;
            int[,] actual = instance.SetSource(BitMock.BitMatrix);

            // Test Condition
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}