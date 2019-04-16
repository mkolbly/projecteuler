using System;
using System.Linq;
using euler;
using EulerLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eulertest
{
    [TestClass]
    public class MathxTests
    {
        /// <summary>
        /// Test for Mathx.GreatestProduct(string, int)
        /// </summary>
        [TestMethod]
        public void TestGreatestProduct()
        {
            string bigNumber =
              "73167176531330624919225119674426574742355349194934" +
              "96983520312774506326239578318016984801869478851843" +
              "85861560789112949495459501737958331952853208805511" +
              "12540698747158523863050715693290963295227443043557" +
              "66896648950445244523161731856403098711121722383113" +
              "62229893423380308135336276614282806444486645238749" +
              "30358907296290491560440772390713810515859307960866" +
              "70172427121883998797908792274921901699720888093776" +
              "65727333001053367881220235421809751254540594752243" +
              "52584907711670556013604839586446706324415722155397" +
              "53697817977846174064955149290862569321978468622482" +
              "83972241375657056057490261407972968652414535100474" +
              "82166370484403199890008895243450658541227588666881" +
              "16427171479924442928230863465674813919123162824586" +
              "17866458359124566529476545682848912883142607690042" +
              "24219022671055626321111109370544217506941658960408" +
              "07198403850962455444362981230987879927244284909188" +
              "84580156166097919133875499200524063689912560717606" +
              "05886116467109405077541002256983155200055935729725" +
              "71636269561882670428252483600823257530420752963450";

            Assert.AreEqual(1000, bigNumber.Length);

            long greatest = Mathx.GreatestProduct(bigNumber, 4);

            Assert.AreEqual(5832, greatest);

            long greatest2 = Mathx.GreatestProduct(bigNumber, 13);

            Assert.AreEqual(23514624000, greatest2);

        }

        /// <summary>
        /// Test for divisbility
        /// </summary>
        [TestMethod]
        public void TestDivibility()
        {
            Assert.IsFalse(Mathx.IsEvenlyDivisible(232792560 - 1, 1, 20));

            Assert.IsTrue(Mathx.IsEvenlyDivisible(232792560, 1, 20));


            for (int i = 1; i < 2520; i++)
            {
                Assert.IsFalse(Mathx.IsEvenlyDivisible(i, 1, 10));
            }

            Assert.IsTrue(Mathx.IsEvenlyDivisible(2520, 1, 10));   
        }

        /// <summary>
        /// Test for nth prime
        /// </summary>
        [TestMethod]
        public void TestNthPrime()
        {
            Assert.AreEqual(13, Mathx.NthPrime(6));

            Assert.AreEqual(104743, Mathx.NthPrime(10001));
        }

        /// <summary>
        /// Test for sum of squares
        /// </summary>
        [TestMethod]
        public void TestSumOfSquares()
        {
            Assert.AreEqual(385, Mathx.SumOfSquares(10));
        }

        /// <summary>
        /// Test for square of sums
        /// </summary>
        [TestMethod]
        public void TestSquareOfSums()
        {
            Assert.AreEqual(3025, Mathx.SquareOfSums(10));
        }


        /// <summary>
        /// Tests for if numbers are a palindome
        /// </summary>
        [TestMethod]
        public void TestPalindrome()
        {
            Assert.IsTrue(Mathx.IsNumericPalindrome(0));

            Assert.IsTrue(Mathx.IsNumericPalindrome(11));

            Assert.IsTrue(Mathx.IsNumericPalindrome(222));

            Assert.IsTrue(Mathx.IsNumericPalindrome(3333));

            Assert.IsTrue(Mathx.IsNumericPalindrome(9009));

            Assert.IsTrue(Mathx.IsNumericPalindrome(909));

            Assert.IsFalse(Mathx.IsNumericPalindrome(12));

            Assert.IsFalse(Mathx.IsNumericPalindrome(122));
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
