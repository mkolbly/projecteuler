using EulerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05
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
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 20;
            int smallestNumber = 0;

            for (int i = 1; (i < Int32.MaxValue) && (smallestNumber == 0); i++)
            {
                if (Mathx.IsEvenlyDivisible(i, min, max))
                    smallestNumber = i;
            }

            if (smallestNumber > 0)
            {
                Console.WriteLine("Smallest positive number that is evenly divisible by all numbers from {0} to {1} is {2}",
                    min, max, smallestNumber);
            }
        }
    }
}
