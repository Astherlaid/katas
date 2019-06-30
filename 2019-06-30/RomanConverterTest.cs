using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsKata2;

namespace RomanNumeralsKataTest
{
    [TestClass]
    public class RomanConverterTest
    {
        [TestMethod]
        public void ConvertNumberToRomanNumeral_Zero_Zero()
        {
            var data = 0;
            var wanted = "Zero";
            var converter = new RomanConverter();

            var result = converter.ConvertNumberToRomanNumeral(data);

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void ConvertNumberToRomanNumeral_Ten_X()
        {
            var data = 10;
            var wanted = "X";
            var converter = new RomanConverter();

            var result = converter.ConvertNumberToRomanNumeral(data);

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void ConvertNumberToRomanNumeral_3028_MMMXXVIII()
        {
            var data = 3028;
            var wanted = "MMMXXVIII";
            var converter = new RomanConverter();

            var result = converter.ConvertNumberToRomanNumeral(data);

            Assert.AreEqual(wanted, result);
        }
    }
}
