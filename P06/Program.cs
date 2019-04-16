using EulerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace P06
{
    /// <summary>
    /// 
    /// 
    /// The sum of the squares of the first ten natural numbers is,
    /// 1^2 + 2^2 + ... + 10^2 = 385
    ///
    /// The square of the sum of the first ten natural numbers is,
    ///(1 + 2 + ... + 10)^2 = 552 = 3025
    ///
    /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum 
    /// is 3025 − 385 = 2640.
    ///
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    ///
    /// Answer: 25164150
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger sum = Mathx.SquareOfSums(100) - Mathx.SumOfSquares(100);

            Console.WriteLine("Difference between the sum of the squares and the square of the sum of the first hundred natural numbers is {0}", sum);

        }
    }
}
