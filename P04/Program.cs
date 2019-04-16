using EulerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04
{
    class Program
    {
        /// <summary>
        /// Euler problem 4 - https://projecteuler.net/problem=4
        /// 
        /// A palindromic number reads the same both ways.The largest palindrome made from the product of two 
        /// 2-digit numbers is 9009 = 91 × 99.
        ///
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// 
        /// Answer: 906609
        /// </summary>
        static void Main(string[] args)
        {
            int largest = 0;

            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    int product = i * j;

                    if (Mathx.IsNumericPalindrome(product) && (product > largest))
                        largest = product;
                }
            }

            Console.WriteLine("Largest palindrome made from the product of two 3-digit numbers is {0}", largest);
        }
    }
}
