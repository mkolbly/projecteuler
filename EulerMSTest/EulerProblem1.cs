using EulerLib;

namespace EulerMSTest
{
    /// <summary>
    /// A Solution to Euler problem 1 - https://projecteuler.net/problem=1
    /// 
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum 
    /// of these multiples is 23.  Find the sum of all the multiples of 3 or 5 below 1000.
    /// 
    /// Answer: 233168
    /// </summary>
    [TestClass]
    [TestCategory("Euler")]
    public class EulerProblem1
    {
        [TestMethod]
        public void SolveProblem1()
        {
            long sum = Mathx.SumOfMultiples(999, 3, 5);    // 233168

            Console.WriteLine($"Sum of all multiples of 3 or 5 below 1000 is {sum}");

            Assert.AreEqual(233168, sum);
        }
    }
}