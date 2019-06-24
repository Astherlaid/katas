using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorKata;

namespace StringCalculatorKataTest
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void SumNumbers_EmptyString_Zero()
        {
            var data = "";
            var wanted = "0";
            var calculator = new StringCalculator();

            var result = calculator.SumNumbers(data);

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void SumNumbers_OneNumberInString_Number()
        {
            var data = "1";
            var wanted = "1";
            var calculator = new StringCalculator();

            var result = calculator.SumNumbers(data);

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void SumNumbers_TwoNumbersInString_SumOfNumbers()
        {
            var data = "1,2";
            var wanted = "3";
            var calculator = new StringCalculator();

            var result = calculator.SumNumbers(data);

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void SumNumbers_TwoArgsOfTwoNumbers_SumOfTwoPairs()
        {
            var data = "1,2";
            var data2 = "3,4";
            var wanted = "3, 7";
            var calculator = new StringCalculator();

            var result = calculator.SumNumbers(data, data2);

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void SumNumbers_ThreeNumbersWithCommaAndnewLineSeparators_SumOfNumbers()
        {
            var data = "1.1,2\n3";
            var wanted = "6.1";
            var calculator = new StringCalculator();

            var result = calculator.SumNumbers(data);

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void SumNumbers_CommaAtTheEnd_ErrorMessage()
        {
            var data = "1,2,";
            var wanted = "Number expected but EOF found.";
            var calculator = new StringCalculator();

            var result = calculator.SumNumbers(data);

            Assert.AreEqual(wanted, result);
        }
    }
}
