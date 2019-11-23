using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoSteganography.Extensions.Json;

namespace CryptoSteganography.Extensions.Json.Tests
{
    [TestClass()]
    public class AttributeTests
    {
        [TestMethod()]
        public void ToStringArrayTest()
        {
            string JsonString = "['anarchic','anopheles','anti-federalist','aspirated','autocratship']";

            // Test Modul
            string[] expected = new string[] { "anarchic", "anopheles", "anti-federalist", "aspirated", "autocratship" };
            string[] actual = JsonString.ToStringArray();

            // Test Condination
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}