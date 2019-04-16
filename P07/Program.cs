using EulerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07
{
    /// <summary>
    /// Euler problem 7
    /// 
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// 
    /// What is the 10001st prime number?
    /// 
    /// Answer: 104743
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            long nthprime = Mathx.NthPrime(10001);

            Console.WriteLine("The 10001st prime number is {0}", nthprime);
        }
    }
}
