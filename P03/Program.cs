﻿using EulerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03
{
    /// <summary>
    /// Euler Problem 3
    /// 
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    ///
    /// What is the largest prime factor of the number 600851475143 
    /// 
    /// Answer: 6857
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            long testNum = 600851475143;

            long largestPrimeFactor = Mathx.LargestPrimeFactor(testNum);

            Console.WriteLine("Largest prime factor of {0} is {1}", testNum, largestPrimeFactor);
        }
    }
}
