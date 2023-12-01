using EulerLib;

namespace EulerMSTest
{
    /// <summary>
    /// Euler problem 10 - https://projecteuler.net/problem=10
    /// 
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    ///
    /// Find the sum of all the primes below two million.
    /// 
    /// Answer: 142913828922
    /// </summary>
    [TestClass]
    [TestCategory("Euler")]
    public class EulerProblem10
    {
        [TestMethod]
        public void SolveProblem10()
        {
            long sum = 0;

            for (long i = 0; i < 2000000; i++)
            {
                if (Mathx.IsPrime(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Sum of all primes below two million is {sum}");

            Assert.AreEqual(142913828922, sum);
        }
    }
}