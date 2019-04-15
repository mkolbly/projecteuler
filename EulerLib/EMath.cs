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
    /// Euler math functions 
    /// </summary>
    public static class EMath
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





    }
}