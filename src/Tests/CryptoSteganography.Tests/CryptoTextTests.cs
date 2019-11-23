using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography;
using System.IO;
using CryptoSteganography.Extensions.String.Tests.Mock;
using System;

namespace CryptoSteganography.Tests
{
    [TestClass()]
    public class CryptoTextTests
    {
        [TestMethod()]
        public void CryptoTextTest()
        {
            // Instance
            var instance = new CryptoText(new FileInfo("sample/dictionary.en.json"));

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(CryptoText));
        }

        [TestMethod()]
        public void MergeTest()
        {
            // Instance
            var instance = new CryptoText(new FileInfo("sample/dictionary.en.json"));

            // Test Modul
            instance.Merge(StringMock.StringItem);
            string expected = StringMock.StringItem;
            string actual = instance.String;

            // Test Condination
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SaveTest()
        {
            // Instance
            var instance = new CryptoText(new FileInfo("sample/dictionary.en.json"));

            // Test Modul
            instance.Merge(StringMock.StringItem);
            string expected = StringMock.StringItem;
            string actual = instance.String;

            // Test Condination
            Assert.AreEqual(expected, actual);

            // Save
            instance.Save(new FileInfo("sample/merged/dictionary.text" + ".en" + ".txt"));
        }

        [TestMethod()]
        public void SaveTest2()
        {
            // Instance
            var instance = new CryptoText(new FileInfo("sample/dictionary.tr.json"));

            // Test Modul
            instance.Merge(StringMock.StringItem);
            string expected = StringMock.StringItem;
            string actual = instance.String;

            // Test Condination
            Assert.AreEqual(expected, actual);

            // Save
            instance.Save(new FileInfo("sample/merged/dictionary.text" + ".tr" + ".txt"));
        }
    }
}