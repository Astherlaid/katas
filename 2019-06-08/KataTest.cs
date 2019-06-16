using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortKata;

namespace SortKataTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void DeleteSpaces_SendTwoWords_ConcatenedWords()
        {
            var data = "Casa roja";
            var wanted = "casaroja";

            var wordSorter = new WordSorter(data);
            var result = wordSorter.DeleteSpaces();

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void ReorderChars_SendTwoWords_ReorderConcatenatedWords()
        {
            var data = "When not studying nuclear physics, Bambi likes to play beach volleyball.";
            var wanted = "aaaaabbbbcccdeeeeeghhhiiiiklllllllmnnnnooopprsssstttuuvwyyyy";

            var wordSorter = new WordSorter(data);
            var result = wordSorter.ReorderChars();

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void ClearText_SendText_CleanText()
        {
            var data = "a11111112312321,.,/.,.//[;-bc";
            var wanted = "abc";

            var wordSorter = new WordSorter(data);
            wordSorter.ClearText();

            var result = wordSorter.GetText;

            Assert.AreEqual(wanted, result);
        }
    }
}
