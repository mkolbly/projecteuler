using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    ///
    /// What is the largest prime factor of the number 600851475143 
    /// 
    /// Answer: 6857
    /// </summary>
    public static class p3
    {

        public static long GetLargestPrimeFactor()
        {
            long testNum = 600851475143;

            long largest = 0;

            long sqrtNum = (long)Math.Ceiling(Math.Sqrt((double)testNum));

            for (long i = 3; i < sqrtNum; i+= 2)
            {
                if ((testNum % i == 0) && Mathx.IsPrime(i))
                    largest = i;
            }

            return largest;
        }



    }
}
