using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01
{
    /// <summary>
    /// https://projecteuler.net/problem=1
    /// 
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum 
    /// of these multiples is 23.  Find the sum of all the multiples of 3 or 5 below 1000.
    /// 
    /// Answer: 233168
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            NaturalNumbersList list1 = new NaturalNumbersList(999, 3, 5);

            long sum = list1.SumOfMultiples;  // 233168

        }


    }
}

