using EulerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10
{
    /// <summary>
    /// Euler problem 10
    /// 
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    ///
    /// Find the sum of all the primes below two million.
    /// 
    /// Answer: 142913828922
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;

            for (long i = 0; i < 2000000; i++)
            {
                if (Mathx.IsPrime(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine("Sum of all primes below two million is {0}", sum);
        }
    }
}
