using System.Numerics;

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
        /// Get the greatest product of the adjacent digits of num
        /// </summary>
        /// <param name="num">Number in question (as a string)</param>
        /// <param name="numAdjacentDigits">How many adjacent digits to multiply</param>
        public static long GreatestProduct(string num, int numAdjacentDigits)
        {
            if (String.IsNullOrWhiteSpace(num))
            {
                return 0;
            }

            if (numAdjacentDigits > num.Length)
            {
                return 0;
            }

            long greatest = 0;

            for (int i = 0; i <= num.Length - numAdjacentDigits; i++)
            {
                long product = 1;

                for (int j = i; j < i + numAdjacentDigits; j++)
                {
                    product *= int.Parse(num[j].ToString());
                }

                if (product > greatest)
                {
                    greatest = product;
                }
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
        /// <returns>nth prime or -1 if we're out of bounds</returns>
        public static long NthPrime(int n)
        {
            int numPrimes = 0;
            long num = 2;

            while ((numPrimes < n) && (num < long.MaxValue))
            {
                if (Mathx.IsPrime(num))
                {
                    numPrimes++;
                }

                if (numPrimes == n)
                {
                    return num;
                }

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

            sum *= sum;

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
        /// Test for if num is evenly divisible by all integers from min to max
        /// </summary>
        /// <param name="num">Test number</param>
        /// <param name="min">Minimum integer to test for divisibility</param>
        /// <param name="max">Maximum integer to test for divisibility</param>
        /// <returns>true if num is evenly divisibil by all numbers from min to max</returns>
        public static bool IsEvenlyDivisible(int num, int min, int max)
        {
            for (int j = min; j <= max; j++)
            {
                if (num % j != 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Is the given number a palindrome
        /// </summary>
        /// <param name="num">number to test</param>
        /// <returns>true if num is a palindrome, else false</returns>
        public static bool IsNumericPalindrome(int num)
        {
            if (num < 0)
            {
                return false;
            }

            string stNum = num.ToString();

            for (int i = 0, j = stNum.Length - 1; i < j; i++, j--)
            {
                if (stNum[i] != stNum[j])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Finds the sum of even valued Fibonacci numbers <= max
        /// </summary>
        /// <param name="max">Max Fibonacci number to be added</param>
        /// <returns>Sum of even valued Fibonacci numbers <= max</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "Cleaner code")]
        public static BigInteger SumOfEvenFibonacci(BigInteger max)
        {
            if (max < 0)
            {
                throw new ArgumentException($"{nameof(max)} must be > 0", nameof(max));
            }

            BigInteger a = 0;         // Fibonacci number 1       
            BigInteger b = 1;         // Fibonacci number 2
            BigInteger tmp = a + b;
            BigInteger sum = 0;

            // While our fibonacci number sequence is <= max
            while (a <= max)
            {
                if (a % 2 == 0)
                {
                    sum += a;
                }

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
            {
                throw new ArgumentException($"{nameof(max)} must be a positive number", nameof(max));
            }

            if (multiples == null)
            {
                throw new ArgumentNullException(nameof(multiples), $"{nameof(multiples)} cannot be null");
            }

            if (multiples.LongLength < 1)
            {
                throw new ArgumentException($"{nameof(multiples)} must contain at least one value", nameof(multiples));
            }

            foreach (long m in multiples)
            {
                if (m > max)
                {
                    throw new ArgumentException($"{nameof(multiples)} cannot contain a number > {nameof(max)}", nameof(multiples));
                }
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
        private static readonly HashSet<long> LongPrimes = [];

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
                {
                    return true;
                }

                long numSqrt = (int)Math.Floor(Math.Sqrt(num));

                for (long i = 3; i <= numSqrt; i += 2)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
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
                    {
                        largest = i;
                    }
                }

                // Check if num itself is a prime number (by definition, it's already a factor of itself)
                if (Mathx.IsPrime(num))
                {
                    largest = num;
                }

                return largest;
            }
        }
    }
}