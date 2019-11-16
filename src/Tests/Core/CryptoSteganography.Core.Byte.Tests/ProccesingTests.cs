using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography.Core.Byte;
using CryptoSteganography.Extensions.Byte.Tests.Mock;

namespace CryptoSteganography.Core.Byte.Tests
{
    [TestClass()]
    public class ProccesingTests
    {
        [TestMethod()]
        public void ProccesingTest()
        {
            // Instance
            var instance = new Proccesing();

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(Proccesing));
        }

        [TestMethod()]
        public void SetSourceTest()
        {
            // Instance
            var instance = new Proccesing();

            // Test Modul
            byte[] expected = ByteMock.ByteArray;
            byte[] actual = instance.SetSource(ByteMock.ByteArray);

            // Test Condination
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}