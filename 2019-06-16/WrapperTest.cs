using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordWrapKata2;

namespace WordWrapKata2Test
{
    [TestClass]
    public class WraperTest
    {
        [TestMethod]
        public void WrapText_EmptyString_Null()
        {
            var data = "";
            int columns = 1;
            string wanted = null;

            var wrapper = new Wrapper();

            var result = wrapper.WrapText(data, columns);

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void WrapText_CeroColumns_Null()
        {
            var data = "Hi";
            int columns = 0;
            string wanted = null;

            var wrapper = new Wrapper();

            var result = wrapper.WrapText(data, columns);

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void WrapText_TenCharsFiveColumns_TwoLines()
        {
            var data = "012345678901234567890123456789";
            var columns = 5;
            var wanted = "01234\n56789\n01234\n56789\n01234\n56789";
            var wrapper = new Wrapper();

            var result = wrapper.WrapText(data, columns);

            Assert.AreEqual(wanted, result);
        }
    }
}
