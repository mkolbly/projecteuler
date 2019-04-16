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
