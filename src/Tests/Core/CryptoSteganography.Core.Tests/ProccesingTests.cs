using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography.Core;

namespace CryptoSteganography.Core.Tests
{
    [TestClass()]
    public class ProccesingTests
    {
        [TestMethod()]
        public void ProccesingTest()
        {
            // Define
            var instance = new Proccesing();

            // Test Condition
            Assert.IsInstanceOfType(instance, typeof(Proccesing));
        }

        [TestMethod()]
        public void FTest()
        {
            int defaultRow = 8;

            // Define
            var instance = new Proccesing();

            // Test Modul
            int actual = instance.F(row: defaultRow, col: 2);
            int expected = 4;

            // Test Condition
            Assert.AreEqual(expected, actual);

            // Test Modul
            actual = instance.F(row: defaultRow, col: 4);
            expected = 6;

            // Test Condition
            Assert.AreEqual(expected, actual);

            // Test Modul
            actual = instance.F(row: defaultRow, col: 8);
            expected = 7;

            // Test Condition
            Assert.AreEqual(expected, actual);

            // Test Modul
            actual = instance.F(row: defaultRow, col: 16);
            expected = 7;

            // Test Condition
            Assert.AreEqual(expected, actual);

            // Test Modul
            actual = instance.F(row: defaultRow, col: 32);
            expected = 7;

            // Test Condition
            Assert.AreEqual(expected, actual);
        }
    }
}