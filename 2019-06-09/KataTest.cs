using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortKata2;

namespace SortKataTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void ClearText_VariousWords_CleanText()
        {
            var data = "Casa roja y azul123";
            var wanted = "casarojayazul";

            var charSoter = new CharSorter(data);

            var result = charSoter.Text;

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void SortedText_VariousWords_SortedText()
        {
            var data = "Casa roja y azul123";
            var wanted = "aaaacjlorsuyz";

            var charSoter = new CharSorter(data);

            var result = charSoter.SortedText();

            Assert.AreEqual(wanted, result);
        }
    }
}
