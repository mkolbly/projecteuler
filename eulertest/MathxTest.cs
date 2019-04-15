using System;
using System.Linq;
using euler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eulertest
{
    [TestClass]
    public class MathxTest
    {
        


        [TestMethod]
        public void TestNthPrime()
        {
            Assert.AreEqual(13, Mathx.NthPrime(6));
        }

        [TestMethod]
        public void TestSumOfSquares()
        {
            Assert.AreEqual(385, Mathx.SumOfSquares(10));
        }


        [TestMethod]
        public void TestSquareOfSums()
        {
            Assert.AreEqual(3025, Mathx.SquareOfSums(10));
        }


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

        [TestMethod]
        public void TestPrime()
        {
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
    }
}
