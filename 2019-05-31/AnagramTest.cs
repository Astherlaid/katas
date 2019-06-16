using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramKata;
using System.IO;

namespace AnagramTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_FileNotExists()
        {
            string path = "";

            Assert.ThrowsException<FileNotFoundException>(() => new Anagram(path));
        }

        [TestMethod]
        public void Check_FileExists()
        {
            string path = @"E:\Proyectos\Kata\Anagram\file.txt";

            var anagram = new Anagram(path);

            Assert.IsNotNull(anagram.AnagramFile);
        }

        [TestMethod]
        public void Check_CasaAnagrams()
        {
            string path = @"E:\Proyectos\Kata\Anagram\file.txt";

            string data = "casa";
            string result = "aacs";

            var anagram = new Anagram(path);
            string helper = anagram.OrderedWord(data);

            Assert.AreEqual(result, helper);
        }
    }
}
