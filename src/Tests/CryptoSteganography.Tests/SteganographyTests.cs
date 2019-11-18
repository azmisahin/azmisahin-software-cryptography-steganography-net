using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography;
using System.IO;

namespace CryptoSteganography.Tests
{
    [TestClass()]
    public class SteganographyTests
    {
        [TestMethod()]
        public void SteganographyTest()
        {
            // Instance
            var instance = Steganography.Merger;

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(IMerger));
        }

        [TestMethod()]
        public void SteganographySeparatorTest()
        {
            // Instance
            var instance = Steganography.Separator;

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(ISeparator));
        }
    }
}