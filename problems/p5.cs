using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace euler
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    ///
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// 
    /// Answer: 232792560
    /// </summary>
    public static class p5
    {

        public static int GetSmallest()
        {
            int i = 1;
            
            while (true)
            {
                //Console.WriteLine("Evaluating: " + i);

                if (p5.IsEvenlyDivisible(i))
                    return i;

                i++;
            }
        }

        private static bool IsEvenlyDivisible(int num)
        {
            for (int j = 1; j <= 20; j++)
            {
                if (num % j != 0)
                    return false;
            }

            return true;
        }
    }
}
