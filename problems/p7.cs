using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler
{


    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// 
    /// What is the 10001st prime number?
    /// 
    /// Answer: 104743
    /// </summary>
    public static class p7
    {
        public static void GetAnswer()
        {

            long answer = Mathz.NthPrime(10001);

        }

    }
}
