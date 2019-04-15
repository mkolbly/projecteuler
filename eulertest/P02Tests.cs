using System;
using System.Numerics;
using EulerLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using problems;

namespace eulertest
{
    [TestClass]
    public class P02Tests
    {
        /// <summary>
        /// Some tests of the sum of even-numbered fibonacci terms
        /// 
        /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        /// </summary>
        [TestMethod]
        public void TestSummation()
        {
            BigInteger sum = EMath.SumOfEvenFibonacci(4000000 - 1);

            Assert.AreEqual(4613732, sum);

            Assert.AreEqual(10, EMath.SumOfEvenFibonacci(10));

            Assert.AreEqual(44, EMath.SumOfEvenFibonacci(100));

            Assert.AreEqual(2, EMath.SumOfEvenFibonacci(2));

            Assert.AreEqual(0, EMath.SumOfEvenFibonacci(1));

            Assert.AreEqual(0, EMath.SumOfEvenFibonacci(0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidArg()
        {
            EMath.SumOfEvenFibonacci(-1);
        }
    }
}
