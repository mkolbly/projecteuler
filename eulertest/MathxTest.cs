﻿using System;
using System.Linq;
using euler;
using EulerLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eulertest
{
    [TestClass]
    public class MathxTest
    {
        


        [TestMethod]
        public void TestNthPrime()
        {
            Assert.AreEqual(13, Mathz.NthPrime(6));
        }

        [TestMethod]
        public void TestSumOfSquares()
        {
            Assert.AreEqual(385, Mathz.SumOfSquares(10));
        }


        [TestMethod]
        public void TestSquareOfSums()
        {
            Assert.AreEqual(3025, Mathz.SquareOfSums(10));
        }


        [TestMethod]
        public void TestPalindrome()
        {
            Assert.IsTrue(Mathz.IsNumericPalindrome(0));

            Assert.IsTrue(Mathz.IsNumericPalindrome(11));

            Assert.IsTrue(Mathz.IsNumericPalindrome(222));

            Assert.IsTrue(Mathz.IsNumericPalindrome(3333));

            Assert.IsTrue(Mathz.IsNumericPalindrome(9009));

            Assert.IsTrue(Mathz.IsNumericPalindrome(909));

            Assert.IsFalse(Mathz.IsNumericPalindrome(12));

            Assert.IsFalse(Mathz.IsNumericPalindrome(122));
        }

        /// <summary>
        /// Test for prime numbers
        /// </summary>
        [TestMethod]
        public void TestPrime()
        {
            Assert.IsFalse(Mathx.IsPrime(-99));
            Assert.IsFalse(Mathx.IsPrime(-1));
            Assert.IsFalse(Mathx.IsPrime(0));
            Assert.IsFalse(Mathx.IsPrime(1));

            Assert.IsTrue(Mathx.IsPrime(2));
            Assert.IsTrue(Mathx.IsPrime(3));
            Assert.IsTrue(Mathx.IsPrime(5));
            Assert.IsTrue(Mathx.IsPrime(7));
            Assert.IsTrue(Mathx.IsPrime(13));
            Assert.IsTrue(Mathx.IsPrime(29));

            Assert.IsTrue(Mathx.IsPrime(2));
            Assert.IsTrue(Mathx.IsPrime(3));
            Assert.IsTrue(Mathx.IsPrime(5));
            Assert.IsTrue(Mathx.IsPrime(7));
            Assert.IsTrue(Mathx.IsPrime(13));
            Assert.IsTrue(Mathx.IsPrime(29));

    
        }

        /// <summary>
        /// Test for Mathx.LargestPrimeFactor(long)
        /// </summary>
        [TestMethod]
        public void TestLargestPrimeFactor()
        {
            Assert.AreEqual(0, Mathx.LargestPrimeFactor(-1));
            Assert.AreEqual(0, Mathx.LargestPrimeFactor(0));
            Assert.AreEqual(0, Mathx.LargestPrimeFactor(1));

            Assert.AreEqual(3, Mathx.LargestPrimeFactor(9));

            Assert.AreEqual(29, Mathx.LargestPrimeFactor(13195));

            Assert.AreEqual(6857, Mathx.LargestPrimeFactor(600851475143));
        }

        /// <summary>
        /// Test for Mathx.LargestPrimeFactor(long)
        /// </summary>
        /// <remarks>
        /// Largest prime factors of a prime should be that prime itself
        /// </remarks>
        [TestMethod]
        public void TestLargestPrimeFactorOfPrimes()
        {
            Assert.AreEqual(2, Mathx.LargestPrimeFactor(2));
            Assert.AreEqual(3, Mathx.LargestPrimeFactor(3));
            Assert.AreEqual(5, Mathx.LargestPrimeFactor(5));
            Assert.AreEqual(7, Mathx.LargestPrimeFactor(7));
            Assert.AreEqual(11, Mathx.LargestPrimeFactor(11));
            Assert.AreEqual(13, Mathx.LargestPrimeFactor(13));
            Assert.AreEqual(17, Mathx.LargestPrimeFactor(17));
            Assert.AreEqual(19, Mathx.LargestPrimeFactor(19));
            Assert.AreEqual(23, Mathx.LargestPrimeFactor(23));
            Assert.AreEqual(29, Mathx.LargestPrimeFactor(29));

        }


    }
}
