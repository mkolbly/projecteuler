using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using euler;
using p01;

namespace eulertest
{
    [TestClass]
    public class P01Tests
    {
        /// <summary>
        /// Test some known quantities
        /// </summary>
        [TestMethod]
        public void Testp01()
        {
            NaturalNumbersList list1 = new NaturalNumbersList(9, 3, 5);

            Assert.AreEqual(23, list1.SumOfMultiples);

            NaturalNumbersList list2 = new NaturalNumbersList(999, 3, 5);

            Assert.AreEqual(233168, list2.SumOfMultiples);
        }

        /// <summary>
        /// multiples parameter cannot be null
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNull()
        {
            NaturalNumbersList list1 = new NaturalNumbersList(999, null);
        }

        /// <summary>
        /// multiples param cannot be missing
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMissingMultiples()
        {
            NaturalNumbersList list1 = new NaturalNumbersList(999);
        }

        /// <summary>
        /// Multiples cannot be larger than max
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMaxOutOfRange()
        {
            NaturalNumbersList list1 = new NaturalNumbersList(50, 100);
        }
    }
}
