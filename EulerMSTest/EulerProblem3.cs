using EulerLib;
using System.Numerics;

namespace EulerMSTest
{
    /// <summary>
    /// Euler Problem 3
    /// 
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    ///
    /// What is the largest prime factor of the number 600851475143 
    /// 
    /// Answer: 6857
    /// </summary>
    [TestClass]
    [TestCategory("Euler")]
    public class EulerProblem3
    {
        [TestMethod]
        public void SolveProblem3()
        {
            long testNum = 600851475143;

            long largestPrimeFactor = Mathx.LargestPrimeFactor(testNum);

            Console.WriteLine($"Largest prime factor of {testNum} is {largestPrimeFactor}");

            Assert.AreEqual(6857, largestPrimeFactor);
        }
    }
}