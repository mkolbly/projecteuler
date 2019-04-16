using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

/// <summary>
/// Euler problems lib
/// 
/// Utilities to assist in solving Euler problems - https://projecteuler.net/
/// </summary>
namespace EulerLib
{
    /// <summary>
    /// Miscellaneous mathematics functions 
    /// </summary>
    public static class Mathx
    {
        /// <summary>
        /// Finds the sum of even valued Fibonacci numbers <= max
        /// </summary>
        /// <param name="max">Max Fibonacci number to be added</param>
        /// <returns>Sum of even valued Fibonacci numbers <= max</returns>
        public static BigInteger SumOfEvenFibonacci(BigInteger max)
        {
            if (max < 0)
                throw new ArgumentException("max must be > 0", "max");

            BigInteger a = 0;         // Fibonacci number 1       
            BigInteger b = 1;         // Fibonacci number 2
            BigInteger tmp = a + b;
            BigInteger sum = 0;

            // While our fibonacci number sequence is <= max
            while (a <= max)
            {
                if (a % 2 == 0)
                    sum += a;

                tmp = a + b;
                a = b;
                b = tmp;
            }

            return sum;
        }


        /// <summary>
        /// Finds the sum of multiples of natural numbers less <= max  
        /// </summary>
        /// <remarks>
        /// Function to solve Euler problem #1:
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
        /// The sum of these multiples is 23.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </remarks>
        /// <param name="max">Max value of a list of natural numbers</param>
        /// <param name="multiples">Array of numbers that our natural number list must be a multiple of</param>
        /// <returns></returns>
        public static long SumOfMultiples(long max, params long[] multiples)
        {
            if (max < 0)
                throw new ArgumentException("max must be a positive number", "max");

            if (multiples == null)
                throw new ArgumentException("multiples cannot be null", "multiples");

            if (multiples.LongLength < 1)
                throw new ArgumentException("multiples must contain at least one value", "multiples");

            foreach (long m in multiples)
            {
                if (m > max)
                    throw new ArgumentException("multiples cannot contain a number > max", "multiples");
            }

            long sum = 0;

            for (long i = 0; i <= max; i++)
            {
                foreach (long m in multiples)
                {
                    if (i % m == 0)
                    {
                        sum += i;
                        break;
                    }
                }
            }

            return sum;
        }

        /// <summary>
        /// Cache for long prime numbers for IsPrime(long)
        /// </summary>
        private static HashSet<long> LongPrimes = new HashSet<long>();

        /// <summary>
        /// Test if a given number is a prime
        /// </summary>
        /// <remarks>
        /// We only need to test odd numbers up to the square root of num.  Since we are
        /// computationally intensive, we'll store primes in a cache - LongPrimes
        /// </remarks>
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
                if (Mathx.LongPrimes.Contains(num))
                    return true;

                long numSqrt = (int)Math.Floor(Math.Sqrt(num));

                for (long i = 3; i <= numSqrt; i += 2)
                    if (num % i == 0)
                        return false;
            }

            Mathx.LongPrimes.Add(num);

            return true;
        }

        /// <summary>
        /// Finds the largest prime factor of num
        /// </summary>
        /// <param name="num">Number to find the largest prime factor for</param>
        /// <returns>Largest prime factor of num or 0 if none found</returns>
        public static long LargestPrimeFactor(long num)
        {
            if (num <= 1)
            {
                return 0;
            }
            else if (num == 2)
            {
                return 2;
            }
            else
            {
                long largest = 0;

                long sqrtNum = (long)Math.Ceiling(Math.Sqrt((double)num));

                // Check all odd numbers if they're a factor -and- they're a prime number
                for (long i = 3; i <= sqrtNum; i += 2)
                {
                    if ((num % i == 0) && Mathx.IsPrime(i))
                        largest = i;
                }

                // Check if num itself is a prime number (by definition, it's already a factor of itself)
                if (Mathx.IsPrime(num))
                    largest = num;

                return largest;
            }
        }
    }
}