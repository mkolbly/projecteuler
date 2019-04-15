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
    
            Assert.AreEqual(23, EMath.SumOfMultiples(9, 3, 5));

            Assert.AreEqual(233168, EMath.SumOfMultiples(999, 3, 5));
        }

        /// <summary>
        /// multiples parameter cannot be null
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNull()
        {
            EMath.SumOfMultiples(999, null);
        }

        /// <summary>
        /// multiples param cannot be missing
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMissingMultiples()
        {
            EMath.SumOfMultiples(999, null);

        }

        /// <summary>
        /// Multiples cannot be larger than max
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMaxOutOfRange()
        {
            EMath.SumOfMultiples(50, 100);
            
        }
    }
}
