using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using euler;
using P01;
using EulerLib;

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
    
            Assert.AreEqual(23, Mathx.SumOfMultiples(9, 3, 5));

            Assert.AreEqual(233168, Mathx.SumOfMultiples(999, 3, 5));
        }

        /// <summary>
        /// multiples parameter cannot be null
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNull()
        {
            Mathx.SumOfMultiples(999, null);
        }

        /// <summary>
        /// multiples param cannot be missing
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMissingMultiples()
        {
            Mathx.SumOfMultiples(999, null);

        }

        /// <summary>
        /// Multiples cannot be larger than max
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMaxOutOfRange()
        {
            Mathx.SumOfMultiples(50, 100);
            
        }
    }
}
