using EulerLib;

namespace EulerMSTest
{
    /// <summary>
    /// Euler problem 5 - https://projecteuler.net/problem=5
    /// 
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    ///
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// 
    /// Answer: 232792560
    /// </summary>
    [TestClass]
    [TestCategory("Euler")]
    public class EulerProblem5
    {
        [TestMethod]
        public void SolveProblem5()
        {
            int min = 1;
            int max = 20;
            int smallestNumber = 0;

            for (int i = 1; (i < Int32.MaxValue) && (smallestNumber == 0); i++)
            {
                if (Mathx.IsEvenlyDivisible(i, min, max))
                {
                    smallestNumber = i;
                }
            }

            if (smallestNumber > 0)
            {
                Console.WriteLine($"Smallest positive number that is evenly divisible by all numbers from {min} to {max} is {smallestNumber}");
            }

            Assert.AreEqual(232792560, smallestNumber);
        }
    }
}