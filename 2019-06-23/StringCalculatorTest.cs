using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator2;

namespace StringCalculatorKataTest
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void SumStringNumbers_EmptyString_Zero()
        {
            var data = "";
            var wanted = "0";
            var calculator = new StringCalculator();

            var result = calculator.SumStringNumbers(data);

            Assert.AreEqual(result, wanted);
        }

        [TestMethod]
        public void SumStringNumbers_OneNumber_Number()
        {
            var data = "1";
            var wanted = "1";
            var calculator = new StringCalculator();

            var result = calculator.SumStringNumbers(data);

            Assert.AreEqual(result, wanted);
        }

        [TestMethod]
        public void SumStringNumbers_TwoNumber_SumOfNumbers()
        {
            var data = "1,2";
            var wanted = "3";
            var calculator = new StringCalculator();

            var result = calculator.SumStringNumbers(data);

            Assert.AreEqual(result, wanted);
        }

        [TestMethod]
        public void SumStringNumbers_TwoNumberWithNewLineSeparator_SumOfNumbers()
        {
            var data = "1,2,3";
            var wanted = "6";
            var calculator = new StringCalculator();

            var result = calculator.SumStringNumbers(data);

            Assert.AreEqual(result, wanted);
        }

        [TestMethod]
        public void SumStringNumbers_EndsWithComma_ErrorMessage()
        {
            var data = "1,2,";
            var wanted = "Number expected but EOF found.";
            var calculator = new StringCalculator();

            var result = calculator.SumStringNumbers(data);

            Assert.AreEqual(result, wanted);
        }

        [TestMethod]
        public void SumStringNumbers_NegativeNumber_ErrorMessage()
        {
            var data = "1,-3,-4,-5";
            var wanted = "Negative not allowed : -3, -4, -5";
            var calculator = new StringCalculator();

            var result = calculator.SumStringNumbers(data);

            Assert.AreEqual(result, wanted);
        }
    }
}
