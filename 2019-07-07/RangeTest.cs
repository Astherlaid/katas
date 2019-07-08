using Microsoft.VisualStudio.TestTools.UnitTesting;
using RangeKata2;

namespace RangeKataTest
{
    [TestClass]
    public class RangeTest
    {
        public Range Range { get; } = new Range();

        [TestMethod]
        public void IsValidateRange_TwoElements_True()
        {
            var data = "[2,3]";

            var isValidRange = new Range().IsValidRange(data);

            Assert.IsTrue(isValidRange);
        }

        [TestMethod]
        public void IsValidateRange_OneElement_False()
        {
            var data = "[3]";

            var isValidRange = Range.IsValidRange(data);

            Assert.IsTrue(!isValidRange);
        }

        [TestMethod]
        public void CheckIfClosedOrOpenedRange_Closed()
        {
            var data = "[1,2]";
            var wanted = RangeType.Closed;

            var result = Range.CheckRangeType(data);

            Assert.AreEqual(wanted, result);
        }

        [TestMethod]
        public void CheckIfClosedOrOpenedRange_HalfClosed()
        {
            var data = "(1,2]";
            var wanted = RangeType.HalfClosed;

            var result = Range.CheckRangeType(data);

            Assert.AreEqual(wanted, result);
        }
    }
}
