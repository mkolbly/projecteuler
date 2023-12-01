using EulerLib;

namespace EulerMSTest
{
    /// <summary>
    /// Euler problem 4 - https://projecteuler.net/problem=4
    /// 
    /// A palindromic number reads the same both ways.The largest palindrome made from the product of two 
    /// 2-digit numbers is 9009 = 91 × 99.
    ///
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// 
    /// Answer: 906609
    /// </summary>
    [TestClass]
    [TestCategory("Euler")]
    public class EulerProblem4
    {
        [TestMethod]
        public void SolveProblem4()
        {
            int largest = 0;

            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    int product = i * j;

                    if (Mathx.IsNumericPalindrome(product) && (product > largest))
                    {
                        largest = product;
                    }
                }
            }

            Console.WriteLine($"Largest palindrome made from the product of two 3-digit numbers is {largest}");

            Assert.AreEqual(906609, largest);
        }
    }
}