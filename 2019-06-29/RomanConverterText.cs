using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsKata;

namespace RomanNumeralsKataTest
{
    [TestClass]
    public class RomanConverterTest
    {
        [TestMethod]
        public void ConvertNumber_NumberOne_I()
        {
            var data = 1;
            var wanted = "I";
            var converter = new RomanConverter();

            var result = converter.ConvertNumber(data);

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void ConvertNumber_NumberZero_Cero()
        {
            var data = 0;
            var wanted = "Cero";
            var converter = new RomanConverter();

            var result = converter.ConvertNumber(data);

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void ConvertNumber_Number23_XXIII()
        {
            var data = 23;
            var wanted = "XXIII";
            var converter = new RomanConverter();

            var result = converter.ConvertNumber(data);

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void ConvertNumber_Number35_XXXV()
        {
            var data = 23;
            var wanted = "XXIII";
            var converter = new RomanConverter();

            var result = converter.ConvertNumber(data);

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void ConvertNumber_Number2017_MMXVII()
        {
            var data = 2017;
            var wanted = "MMXVII";
            var converter = new RomanConverter();

            var result = converter.ConvertNumber(data);

            Assert.AreEqual(wanted, result);
        }
    }
}
