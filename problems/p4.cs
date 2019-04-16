﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler
{
    /// <summary>
    /// A palindromic number reads the same both ways.The largest palindrome made from the product of two 
    /// 2-digit numbers is 9009 = 91 × 99.
    ///
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// 
    /// Answer: 906609
    /// </summary>
    public static class p4
    {
        public static int GetLargest()
        {
            int largest = 0;

            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    int product = i * j;

                    if (Mathz.IsNumericPalindrome(product) && (product > largest))
                        largest = product;
                }

            }

            return largest;
        }

    }


  
}
