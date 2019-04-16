using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace euler
{
    public static class Mathz
    {

        /// <summary>
        /// Get the greatest product of the adjacent digits of num
        /// </summary>
        /// <param name="num">Number in question</param>
        /// <param name="numAdjacentDigits">How many adjacent digits to multiply</param>
        public static long GreatestProduct(string num, int numAdjacentDigits)
        {
            if (String.IsNullOrWhiteSpace(num))
                return 0;

            if (numAdjacentDigits > num.Length)
                return 0;

            long greatest = 0;

            for (int i = 0; i <= num.Length - numAdjacentDigits; i++)
            {
                long product = 1;

                for (int j = i; j < i + numAdjacentDigits; j++)
                {
                    product *= int.Parse(num[j].ToString());
                }

                if (product > greatest)
                    greatest = product;
            }

            return greatest;
        }



        /// <summary>
        /// Get the nth prime number
        /// </summary>
        /// <example>
        /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        /// </example>
        /// <param name="n">Sequence number of primes</param>
        /// <returns>nth prime</returns>
        public static long NthPrime(int n)
        {
            int numPrimes = 0;
            long num = 2;

            while (numPrimes < n)
            {
                if (Mathz.IsPrime(num))
                    numPrimes++;

                if (numPrimes == n)
                    return num;

                num++;
            }

            return -1;
        }

        /// <summary>
        /// Gets the square of the sum of the first n natural numbers
        /// </summary>
        /// <example>
        /// The square of the sum of the first ten natural numbers is:
        /// (1 + 2 + ... + 10)^2 = 55^2 = 3025
        /// </example>
        /// <param name="n">Number of natural numbers</param>
        /// <returns>Square of the sum of the first n natural numbers</returns>
        public static BigInteger SquareOfSums(BigInteger n)
        {
            BigInteger sum = 0;

            for (BigInteger i = 1; i <= n; i++)
            {
                sum += i;
            }

            sum = sum * sum;

            return sum;
        }

        /// <summary>
        /// Gets the sum of the first n squares of natural numbers
        /// </summary>
        /// <example>
        /// The sum of the first 10 squares of natural numbers = 1^2 + 2^2 + ... + 10^2 = 385
        /// </example>
        /// <param name="n">Number of natural numbers to get the sum of the squares for</param>
        /// <returns>Sum of squares of first n natural numbers</returns>
        public static BigInteger SumOfSquares(BigInteger n)
        {
            BigInteger sum = 0;

            for (BigInteger i = 1; i <= n; i++)
            {
                sum += (i * i);
            }

            return sum;
        }


        /// <summary>
        /// Retrieve the largest prime factor of testNum
        /// </summary>
        /// <param name="testNum">Test number</param>
        /// <returns>Largest number that is a factor of testNum and is also a prime number</returns>
        public static long LargestPrimeFactor(long testNum)
        {
            long largest = 0;

            long sqrtNum = (long)Math.Ceiling(Math.Sqrt((double)testNum));

            for (long i = 3; i < sqrtNum; i += 2)
            {
                if ((testNum % i == 0) && Mathz.IsPrime(i))
                    largest = i;
            }

            return largest;
        }

        private static HashSet<long> LongPrimes = new HashSet<long>();

        /// <summary>
        /// Test if a given number is a prime
        /// </summary>
        /// <param name="num">Test number</param>
        /// <returns>true if num is prime, else false</returns>
        public static bool IsPrime(long num)
        {
            if (num <= 1)
            {
                return false;
            }
            else if (num == 2)
            {
                return true;
            }
            else if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                if (Mathz.LongPrimes.Contains(num))
                    return true;

                long numSqrt = (int)Math.Floor(Math.Sqrt(num));

                for (long i = 3; i <= numSqrt; i += 2)
                    if (num % i == 0)
                        return false;
            }

            Mathz.LongPrimes.Add(num);

            return true;
        }


       
    }
}
