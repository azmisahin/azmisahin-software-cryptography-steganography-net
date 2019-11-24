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

        [TestMethod()]
        public void MergeUTF8Test()
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
                .Content(StringMock.StringUTF8Item)
                .Merge(new System.IO.FileInfo("sample/merged/square.UTF8.text.bmp"));

            // Test Condination
            Assert.IsInstanceOfType(actual, typeof(CryptoImage));
        }

        [TestMethod()]
        public void MergeTextTest()
        {
            // Instance
            var instance = new Merger();

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(IMerger));

            // Test Modul
            var actual = instance
                .SourceType(SteganographyType.Text)
                .Source(new System.IO.FileInfo("sample/dictionary.en.json"))
                .MergeType(SteganographyType.Text)
                .Content(@"
Peter Piper picked a peck of pickled peppers;
A peck of pickled peppers Peter Piper picked;
If Peter Piper picked a peck of pickled peppers,
Where’s the peck of pickled peppers Peter Piper picked?")
                .Merge(new System.IO.FileInfo("sample /merged/dictionary.en.txt"));

            // Test Condination
            Assert.IsInstanceOfType(actual, typeof(CryptoText));

            CryptoText ct = (CryptoText)actual;

            System.Console.WriteLine(ct.String);
        }

        [TestMethod()]
        public void MergeTextTest2()
        {
            // Instance
            var instance = new Merger();

            // Test Condination
            Assert.IsInstanceOfType(instance, typeof(IMerger));

            // Test Modul
            var actual = instance
                .SourceType(SteganographyType.Text)
                .Source(new System.IO.FileInfo("sample/dictionary.tr.json"))
                .MergeType(SteganographyType.Text)
                .Content(@"
Şu tarlaya bi şinik kekere mekere ekmişler.
Bu tarlaya da bi şinik kekere mekere ekmişler.
Şu tarlaya ekilen bir şinik kekere mekereye dadanan boz ala boz başlıklı pis porsuk,
bu tarlaya ekilen bir şinik kekere mekereye dadanan boz ala boz başlıklı pis porsuğa demiş ki;
'ben bu tarlaya ekilen bir şinik kekere mekereye dadanan boz ala boz başlıklı pis porsuğum' demiş.
Öteki tarlaya ekilen bir şinik kekere mekereye dadanan boz ala boz başlıklı pis porsukta;
ben de; 'bu tarlaya ekilen bir şinik kekere mekereye dadanan boz ala boz başlıklı pis porsuğum' demiş.")
                .Merge(new System.IO.FileInfo("sample/merged/dictionary.tr.txt"));

            // Test Condination
            Assert.IsInstanceOfType(actual, typeof(CryptoText));

            CryptoText ct = (CryptoText)actual;

            System.Console.WriteLine(ct.String);
        }
    }
}