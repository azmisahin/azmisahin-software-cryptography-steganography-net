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
            int defaultCol = 8;

            // Define
            var instance = new Proccesing();

            // Test Modul
            int expected = 4;
            int actual = instance.F(row: 2, col: defaultCol);

            // Test Condition
            Assert.AreEqual(expected, actual);

            // Test Modul
            expected = 6;
            actual = instance.F(row: 4, col: defaultCol);
            
            // Test Condition
            Assert.AreEqual(expected, actual);

            // Test Modul
            expected = 7;
            actual = instance.F(row: 8, col: defaultCol);
            
            // Test Condition
            Assert.AreEqual(expected, actual);

            // Test Modul
            expected = 7;
            actual = instance.F(row: 16, col: defaultCol);
            
            // Test Condition
            Assert.AreEqual(expected, actual);

            // Test Modul
            expected = 7;
            actual = instance.F(row: 32, col: defaultCol);
            
            // Test Condition
            Assert.AreEqual(expected, actual);
        }
    }
}