using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordWrapKata;

namespace WordWrapKataTest
{
    [TestClass]
    public class WrapperTest
    {
        [TestMethod]
        public void ValidateBadArgument()
        {
            var data = "";
            var result = Wrapper.WrapText(data, 1);

            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void WrapText_TwoWordsTenColumns_CompleteData()
        {
            var data = "Rojo azul";
            int columns = 10;
            var wanted = "Rojo azul";

            string result = Wrapper.WrapText(data, columns);

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void WraperText_TenWordsFiveColumns_TwoLinesText()
        {
            var data = "Probando esto";
            int columns = 5;
            string wanted = "Proba\nndo e\nsto";

            string result = Wrapper.WrapText(data, columns);

            var a = "a";
            Assert.AreEqual(wanted, result);
        }
    }
}
