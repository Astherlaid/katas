using Microsoft.VisualStudio.TestTools.UnitTesting;
using RangeKata;
using System;

namespace RangeKataTest
{
    [TestClass]
    public class IntegerRangeContains
    {
        Range Range { get; set; }

        [TestMethod]
        public void EmptyRange_ArgumentNullException()
        {
            var range = "";

            Assert.ThrowsException<ArgumentNullException>(() => new Range(range));
        }

        [TestMethod]
        public void EmptyArgument_ArgumentNullException()
        {
            var range = "[1,2]";
            var data = "";

            Assert.ThrowsException<ArgumentNullException>(() => new Range(range).IntegerRangeContains(data));
        }

        [TestMethod]
        public void DataInRange_ArgumentNullException()
        {
            var range = "[1,2]";
            var data = "{1}";
            var wanted = true;

            var result = new Range(range).IntegerRangeContains(data);

            Assert.AreEqual(wanted, result);
        }
    }
}
