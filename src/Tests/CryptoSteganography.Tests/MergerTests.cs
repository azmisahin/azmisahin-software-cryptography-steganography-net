using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography;
using CryptoSteganography.Extensions.String.Tests.Mock;

namespace CryptoSteganography.Tests
{
    [TestClass()]
    public class MergerTests
    {
        [TestMethod()]
        public void MergerTest()
        {
            // Instance
            var instance = new Merger();

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(IMerger));
        }

        [TestMethod()]
        public void SourceTypeTest()
        {
            // Instance
            var instance = new Merger();

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(IMerger));

            // Test Modul
            var actual = instance
                .SourceType(SteganographyType.Image);

            // Test Condination
            Assert.IsInstanceOfType(actual, typeof(Merger));
        }

        [TestMethod()]
        public void SourceTest()
        {
            // Instance
            var instance = new Merger();

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(IMerger));

            // Test Modul
            var actual = instance
                .Source(new System.IO.FileInfo("sample/square.bmp"));

            // Test Condination
            Assert.IsInstanceOfType(actual, typeof(Merger));
        }

        [TestMethod()]
        public void MergeTypeTest()
        {
            // Instance
            var instance = new Merger();

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(IMerger));

            // Test Modul
            var actual = instance
                .MergeType(SteganographyType.Text);

            // Test Condination
            Assert.IsInstanceOfType(actual, typeof(Merger));
        }

        [TestMethod()]
        public void ContentTest()
        {
            // Instance
            var instance = new Merger();

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(IMerger));

            // Test Modul
            var actual = instance
                .Content(StringMock.StringItem);

            // Test Condination
            Assert.IsInstanceOfType(actual, typeof(Merger));
        }

        [TestMethod()]
        public void MergeTest()
        {
            // Instance
            var instance = new Merger();

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(IMerger));

            // Test Modul
            var actual = instance
                .SourceType(SteganographyType.Image)
                .Source(new System.IO.FileInfo("sample/square.bmp"))
                .MergeType(SteganographyType.Text)
                .Content(StringMock.StringItem)
                .Merge(new System.IO.FileInfo("sample/merged/square.text.bmp"));

            // Test Condination
            Assert.IsInstanceOfType(actual, typeof(CryptoImage));
        }
    }
}