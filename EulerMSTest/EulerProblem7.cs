using EulerLib;
using System.Numerics;

namespace EulerMSTest
{
    /// <summary>
    /// Euler problem 7 - https://projecteuler.net/problem=7
    /// 
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// 
    /// What is the 10001st prime number?
    /// 
    /// Answer: 104743
    /// </summary>
    [TestClass]
    [TestCategory("Euler")]
    public class EulerProblem7
    {
        [TestMethod]
        public void SolveProblem7()
        {
            long nthprime = Mathx.NthPrime(10001);

            Console.WriteLine($"The 10001st prime number is {nthprime}");

            Assert.AreEqual(104743, nthprime);
        }
    }
}